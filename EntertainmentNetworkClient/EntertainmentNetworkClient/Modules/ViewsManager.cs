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
            this.HallsView = new Lazy<IViewModel<IHall>>(() => new HallsViewModel(ServiceManager.HallService.Value));
            this.FloorsView = new Lazy<IViewModel<IFloor>>(() => new FloorsViewModel(ServiceManager.FloorService.Value));
        }

        public Lazy<IViewModel<ICity>> CitiesView { get; private set; }
        public Lazy<IViewModel<ICinema>> CinemasView { get; private set; }
        public Lazy<IViewModel<IHall>> HallsView { get; private set; }
        public Lazy<IViewModel<IFloor>> FloorsView { get; private set; }

        public BindingSource CitiesBindingSource 
        {
            get 
            {
                this.SetDataSource(this.citiesBindingSource, this.CityViewBindingSource, true);
                return this.citiesBindingSource;
            }
        }

        public BindingSource CityViewBindingSource
        {
            get
            {
                this.SetDataSource(this.citiesViewBindingSource, this.CitiesView.Value);
                return this.citiesViewBindingSource;
            }
        }

        public BindingSource CinemasBindingSource
        {
            get
            {
                this.SetDataSource(this.cinemasBindingSource, this.CinemaViewBindingSource, true);
                return this.cinemasBindingSource;
            }
        }

        public BindingSource CinemaViewBindingSource
        {
            get
            {
                this.SetDataSource(this.cinemaViewBindingSource, this.CinemasView.Value);
                return this.cinemaViewBindingSource;
            }
        }

        public BindingSource HallsBindingSource
        {
            get
            {
                this.SetDataSource(this.hallsbindingSource, this.HallViewBindingSource, true);
                return this.hallsbindingSource;
            }
        }

        public BindingSource HallViewBindingSource
        {
            get
            {
                this.SetDataSource(this.hallViewbindingSource, this.HallsView.Value);
                return this.hallViewbindingSource;
            }
        }

        public BindingSource FloorsBindingSource
        {
            get
            {
                this.SetDataSource(this.floorsBindingSource, this.FloorViewBindingSource, true);
                return this.floorsBindingSource;
            }
        }

        public BindingSource FloorViewBindingSource
        {
            get
            {
                this.SetDataSource(this.floorViewBindingSource, this.FloorsView.Value);
                return this.floorViewBindingSource;
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

        public void HallsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var bindingSource = sender as BindingSource;
            if (bindingSource != null)
            {
                this.HallsView.Value.Selected = bindingSource.Current as IHall;
            }
        }

        public void FloorsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var bindingSource = sender as BindingSource;
            if (bindingSource != null)
            {
                this.FloorsView.Value.Selected = bindingSource.Current as IFloor;
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

        private void HallsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Hall();
        }

        private void FloorsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Floor();
        }

        /// <summary>
        /// Sets dataSource for source
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dataSource"></param>
        private void SetDataSource(BindingSource source, object dataSource, bool isSetDataMember = false)
        {
            if (source.DataSource == null)
            {
                source.DataSource = dataSource;
                source.DataMember = isSetDataMember ? modelsDatamember : String.Empty;
            }
        }

        private const string modelsDatamember = "Models";
    }
}
