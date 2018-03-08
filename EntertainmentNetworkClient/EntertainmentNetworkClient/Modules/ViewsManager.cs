using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EntertainmentNetwork.DAL.Models;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.BL.ViewModels;
using EntertainmentNetwork.DAL;
using EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetworkClient.Modules
{
    public partial class ViewsManager : DevExpress.XtraEditors.XtraUserControl, IViewsManager
    {
        public ViewsManager()
        {
            InitializeComponent();
            this.CitiesView = new Lazy<IViewModel<ICity>>(() => new CitiesViewModel(ServiceManager.CityService.Value));
            this.CinemasView = new Lazy<IViewModel<ICinema>>(() => new CinemasViewModel(ServiceManager.CinemaService.Value));
        }

        public Lazy<IViewModel<ICity>> CitiesView { get; private set; }
        public Lazy<IViewModel<ICinema>> CinemasView { get; private set; }
       
        public BindingSource CitiesBindingSource 
        {
            get 
            {
                if (this.citiesBindingSource.DataSource == null)
                {
                    this.citiesBindingSource.DataSource = this.CityViewBindingSource;
                    this.citiesBindingSource.DataMember = modelsDatamember;
                }

                return this.citiesBindingSource;
            }
        }

        public BindingSource CityViewBindingSource
        {
            get
            {
                if (this.citiesViewBindingSource.DataSource == null)
                {
                    this.citiesViewBindingSource.DataSource = this.CitiesView.Value;
                }

                return this.citiesViewBindingSource;
            }
        }

        public BindingSource CinemasBindingSource
        {
            get
            {
                if (this.cinemasBindingSource.DataSource == null)
                {
                    this.cinemasBindingSource.DataSource = this.CinemaViewBindingSource;
                    this.cinemasBindingSource.DataMember = modelsDatamember;
                }

                return this.cinemasBindingSource;
            }
        }

        public BindingSource CinemaViewBindingSource
        {
            get
            {
                if (this.cinemaViewBindingSource.DataSource == null)
                {
                    this.cinemaViewBindingSource.DataSource = this.CinemasView.Value;
                }

                return this.cinemaViewBindingSource;
            }
        }

        public void CitiesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var bindingSource = sender as BindingSource;
            if (bindingSource != null)
            {
                this.CitiesView.Value.Selected = bindingSource.Current as ICity;
            }
        }

        public void CinemasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var bindingSource = sender as BindingSource;
            if (bindingSource != null)
            {
                this.CinemasView.Value.Selected = bindingSource.Current as ICinema;
            }
        }

        private void CitiesBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new City();
        }

        private void CinemasBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Cinema();
        }

        private const string modelsDatamember = "Models";
    }
}
