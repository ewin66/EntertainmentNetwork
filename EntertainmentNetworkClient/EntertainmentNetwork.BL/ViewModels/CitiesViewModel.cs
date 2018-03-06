using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EntertainmentNetwork.BL.Commands;
using EntertainmentNetwork.BL.Interfaces;
//using EntertainmentNetwork.BL.Models;
using EntertainmentNetwork.DAL.Models;
using EntertainmentNetwork.DAL.Models.Interfaces;
using System.ComponentModel;

namespace EntertainmentNetwork.BL.ViewModels
{
    public class CitiesViewModel : EntertainmentNetwork.DAL.BaseNotifyPropertyChanged, ICitiesViewModel
    {
        public CitiesViewModel(ICityService dataService)
        {
            this.cityService = dataService;
            this.citiesViewCollection = new BindingList<City>();
            this.addUpdateCommand = new AddUpdateCommand(this);
            this.removeCommand = new RemoveCommand(this);
        }

        public BindingList<City> Cities 
        { 
            get 
            {
                return this.citiesViewCollection; 
            } 
        }

        public ICity SelectedCity { get; set; }

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

        public void AddUpdateCity()
        {
            foreach (var item in this.Cities.Where(x => x.IsNew))
            {
                this.cityService.AddCity(item);
                var added = this.cityService.FindByName(item.CitName).FirstOrDefault(x => x.CitCountry == item.CitCountry);
                item.Update(added);
            }

            foreach (var item in this.Cities.Where(x => x.IsChanged && !x.IsNew))
            {
                this.GetCity(item.CitId).Update(item);
                this.cityService.MergeCity(item);
            }
        }

        public void LoadData()
        {
            this.citiesViewCollection.ListChanged -= CitiesViewCollection_ListChanged;      
            this.citiesViewCollection.Clear();
            foreach (var item in this.cityService.GetCities())
            {
                this.citiesViewCollection.Add(item);
            }
            
            this.citiesViewCollection.ListChanged += CitiesViewCollection_ListChanged;
        }

        public void RemoveCity()
        {
            this.cityService.RemoveCity(this.SelectedCity.CitId);
            this.Cities.Remove((City)this.SelectedCity);
        }

        private ICity GetCity(decimal cityId)
        {
            return this.Cities.FirstOrDefault(x => x.CitId == cityId);
        }

        private void CitiesViewCollection_ListChanged(object sender, ListChangedEventArgs e)
        {
            var changedList = sender as BindingList<City>;
            if (changedList != null && e.ListChangedType != ListChangedType.ItemDeleted)
            {
                changedList[e.NewIndex].IsChanged = true;
            } 
        }


        private readonly ICommand addUpdateCommand;
        private readonly ICommand removeCommand;
        private BindingList<City> citiesViewCollection;
        private ICityService cityService;

        public const string SELECTED_CITY_PROPERRTY_NAME = "SelectedCity";
    }
}
