using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using EntertainmentNetwork.BL.Commands;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.DAL;
using EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.BL.ViewModels
{
    public class CinemasViewModel : BaseNotifyPropertyChanged, IViewModel<ICinema>
    {
        public CinemasViewModel(ICinemaService dataService)
        {
            this.cinemaService = dataService;
            this.cinemasViewCollection = new BindingList<ICinema>();
            this.addUpdateCommand = new AddUpdateCommand<ICinema>(this);
            this.removeCommand = new RemoveCommand<ICinema>(this);
        }

        public BindingList<ICinema> Models 
        { 
            get 
            {
                return this.cinemasViewCollection; 
            } 
        }

        public bool IsDataLoaded { get; private set; }
        public ICinema Selected { get; set; }

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

        public void AddUpdate()
        {
            foreach (var item in this.Models.Where(x => x.IsNew))
            {
                this.cinemaService.AddCinema(item);
                var added = this.cinemaService.FindCinemaByName(item.CinName).FirstOrDefault(x => x.CityId == item.CityId);
                item.Update(added);
            }

            foreach (var item in this.Models.Where(x => x.IsChanged && !x.IsNew))
            {
                this.GetCinema(item.CinId).Update(item);
                this.cinemaService.MergeCinema(item);
            }
        }

        public void LoadData(Func<ICinema, bool> filter)
        {
            this.cinemasViewCollection.ListChanged -= CinemasViewCollection_ListChanged;      
            this.cinemasViewCollection.Clear();
            var cinemas = this.cinemaService.GetCinemas().Where(filter);

            foreach (ICinema item in cinemas)
            {
                this.cinemasViewCollection.Add(item);
            }

            this.IsDataLoaded = true;
            this.cinemasViewCollection.ListChanged += CinemasViewCollection_ListChanged;
        }

        public void Remove()
        {
            this.cinemaService.RemoveCinema(this.Selected.CinId);
            this.Models.Remove(this.Selected);
        }

        private ICinema GetCinema(decimal cinemaId)
        {
            return this.Models.FirstOrDefault(x => x.CinId == cinemaId);
        }

        private void CinemasViewCollection_ListChanged(object sender, ListChangedEventArgs e)
        {
            var changedList = sender as BindingList<ICinema>;
            if (changedList != null && e.ListChangedType != ListChangedType.ItemDeleted)
            {
                changedList[e.NewIndex].IsChanged = true;
            } 
        }

        private readonly ICommand addUpdateCommand;
        private readonly ICommand removeCommand;
        private BindingList<ICinema> cinemasViewCollection;
        private ICinemaService cinemaService;
        public const string SELECTED_CINEMA_PROPERRTY_NAME = "Selected";
    }
}
