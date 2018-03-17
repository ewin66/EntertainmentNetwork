using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using EntertainmentNetwork.BL.Commands;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.DAL;
using EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.BL.ViewModels
{
    public class HallsViewModel : BaseNotifyPropertyChanged, IViewModel<IHall>
    {
        public HallsViewModel(IHallService dataService)
        {
            this.hallService = dataService;
            this.hallsViewCollection = new BindingList<IHall>();
            this.addUpdateCommand = new AddUpdateCommand<IHall>(this);
            this.removeCommand = new RemoveCommand<IHall>(this);
        }

        public BindingList<IHall> Models 
        { 
            get 
            {
                return this.hallsViewCollection; 
            } 
        }

        public bool IsDataLoaded { get; private set; }
        public IHall Selected { get; set; }

        public ICommand AddUpdateCommand
        {
            get
            {
                return this.addUpdateCommand;
            }
        }

        public ICommand RemoveCommand
        {
            get
            {
                return this.removeCommand;
            }
        }

        public async Task AddUpdate()
        {
            foreach (var item in this.Models.Where(x => x.IsNew || x.IsChanged))
            {
                var hall = await this.hallService.MergeHall(item);
                item.Update(hall);
            }
        }

        public async Task LoadData(Func<IHall, bool> filter)
        {
            this.hallsViewCollection.ListChanged -= CitiesViewCollection_ListChanged;      
            this.hallsViewCollection.Clear();
            var task = await this.hallService.GetHalls();

            foreach (IHall item in task.Where(filter))
            {
                this.hallsViewCollection.Add(item);
            }

            this.IsDataLoaded = true;
            this.hallsViewCollection.ListChanged += CitiesViewCollection_ListChanged;
        }

        public async Task Remove()
        {
            await this.hallService.RemoveHall(this.Selected.HalId);
            this.Models.Remove(this.Selected);
        }

        private IHall GetHall(decimal hallId)
        {
            return this.Models.FirstOrDefault(x => x.HalId == hallId);
        }

        private void CitiesViewCollection_ListChanged(object sender, ListChangedEventArgs e)
        {
            var changedList = sender as BindingList<IHall>;
            if (changedList != null && e.ListChangedType != ListChangedType.ItemDeleted)
            {
                changedList[e.NewIndex].IsChanged = true;
            } 
        }

        private readonly ICommand addUpdateCommand;
        private readonly ICommand removeCommand;
        private BindingList<IHall> hallsViewCollection;
        private IHallService hallService;
        public const string SELECTED_CITY_PROPERRTY_NAME = "SelectedHall";
    }
}
