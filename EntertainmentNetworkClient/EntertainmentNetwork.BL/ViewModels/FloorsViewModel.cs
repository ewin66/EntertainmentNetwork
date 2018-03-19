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
    public class FloorsViewModel : BaseNotifyPropertyChanged, IViewModel<IFloor>
    {
        public FloorsViewModel(IFloorService dataService)
        {
            this.floorService = dataService;
            this.floorsViewCollection = new BindingList<IFloor>();
            this.addUpdateCommand = new AddUpdateCommand<IFloor>(this);
            this.removeCommand = new RemoveCommand<IFloor>(this);
        }

        public BindingList<IFloor> Models 
        { 
            get 
            {
                return this.floorsViewCollection; 
            } 
        }

        public bool IsDataLoaded { get; private set; }
        public IFloor Selected { get; set; }

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
                var floor = await this.floorService.MergeFloor(item);
                item.Update(floor);
            }
        }

        public async Task LoadData(Func<IFloor, bool> filter)
        {
            this.floorsViewCollection.ListChanged -= HallsViewCollection_ListChanged;      
            this.floorsViewCollection.Clear();
            var task = await this.floorService.GetFloors();

            foreach (IFloor item in task.Where(filter))
            {
                this.floorsViewCollection.Add(item);
            }

            this.IsDataLoaded = true;
            this.floorsViewCollection.ListChanged += HallsViewCollection_ListChanged;
        }

        public async Task Remove()
        {
            await this.floorService.RemoveFloor(this.Selected.FloorId);
            this.Models.Remove(this.Selected);
        }

        private IFloor GetHall(decimal floorId)
        {
            return this.Models.FirstOrDefault(x => x.FloorId == floorId);
        }

        private void HallsViewCollection_ListChanged(object sender, ListChangedEventArgs e)
        {
            var changedList = sender as BindingList<IFloor>;
            if (changedList != null && e.ListChangedType != ListChangedType.ItemDeleted)
            {
                changedList[e.NewIndex].IsChanged = true;
            } 
        }

        private readonly ICommand addUpdateCommand;
        private readonly ICommand removeCommand;
        private BindingList<IFloor> floorsViewCollection;
        private IFloorService floorService;
        public const string SELECTED_FLOOR_PROPERRTY_NAME = "SelectedFloor";
    }
}
