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
    public class CitiesViewModel : BaseNotifyPropertyChanged, IViewModel<ICity>
    {
        public CitiesViewModel(ICityService dataService)
        {
            this.cityService = dataService;
            this.citiesViewCollection = new BindingList<ICity>();
            this.addUpdateCommand = new AddUpdateCommand<ICity>(this);
            this.removeCommand = new RemoveCommand<ICity>(this);
        }

        public BindingList<ICity> Models 
        { 
            get 
            {
                return this.citiesViewCollection; 
            } 
        }

        public bool IsDataLoaded { get; private set; }
        public ICity Selected { get; set; }

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
            foreach (var item in this.Models.Where(x => x.IsNew))
            {
                await this.cityService.AddCity(item);
                var task = await this.cityService.FindByName(item.CitName);
                var added = task.FirstOrDefault(x => x.CitCountry == item.CitCountry);
                item.Update(added);
            }

            foreach (var item in this.Models.Where(x => x.IsChanged && !x.IsNew))
            {
                this.GetCity(item.CitId).Update(item);
                await this.cityService.MergeCity(item);
            }
        }

        public async Task LoadData(Func<ICity, bool> filter)
        {
            this.citiesViewCollection.ListChanged -= CitiesViewCollection_ListChanged;      
            this.citiesViewCollection.Clear();
            var task = await this.cityService.GetCities();
            
            foreach (ICity item in task.Where(filter))
            {
                this.citiesViewCollection.Add(item);
            }

            this.IsDataLoaded = true;
            this.citiesViewCollection.ListChanged += CitiesViewCollection_ListChanged;
        }

        public async Task Remove()
        {
            await this.cityService.RemoveCity(this.Selected.CitId);
            this.Models.Remove(this.Selected);
        }

        private ICity GetCity(decimal cityId)
        {
            return this.Models.FirstOrDefault(x => x.CitId == cityId);
        }

        private void CitiesViewCollection_ListChanged(object sender, ListChangedEventArgs e)
        {
            var changedList = sender as BindingList<ICity>;
            if (changedList != null && e.ListChangedType != ListChangedType.ItemDeleted)
            {
                changedList[e.NewIndex].IsChanged = true;
            } 
        }

        private readonly ICommand addUpdateCommand;
        private readonly ICommand removeCommand;
        private BindingList<ICity> citiesViewCollection;
        private ICityService cityService;
        public const string SELECTED_CITY_PROPERRTY_NAME = "SelectedCity";
    }
}
