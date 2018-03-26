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
using DevExpress.XtraBars.Docking2010;
using EntertainmentNetwork.DAL.Models;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.BL.ViewModels;
using EntertainmentNetwork.DAL;
using EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetworkClient.Properties;

namespace EntertainmentNetworkClient.Modules
{
    public partial class ViewsManager : DevExpress.XtraEditors.XtraUserControl, IViewsManager
    {
        public ViewsManager(DocumentManager documentManager)
        {
            InitializeComponent();
            this.MainDocumentManager = documentManager;
            this.CitiesView = new Lazy<IViewModel<ICity>>(() => new CitiesViewModel(ServiceManager.CityService.Value));
            this.CinemasView = new Lazy<IViewModel<ICinema>>(() => new CinemasViewModel(ServiceManager.CinemaService.Value));
            this.HallsView = new Lazy<IViewModel<IHall>>(() => new HallsViewModel(ServiceManager.HallService.Value));
            this.FloorsView = new Lazy<IViewModel<IFloor>>(() => new FloorsViewModel(ServiceManager.FloorService.Value));
            this.SeatsView = new Lazy<ISeatViewModel>(() => new SeatsViewModel(ServiceManager.SeatService.Value));
            this.ShowsView = new Lazy<IViewModel<IShow>>(() => new BaseViewModel<IBaseService<IShow>, IShow>(ServiceManager.ShowService.Value));
            this.SchedulerView = new Lazy<IViewModel<IScheduler>>(() => new SchedulerViewModel(ServiceManager.SchedulerService.Value));
        }

        public DocumentManager MainDocumentManager { get; private set; }
        public Lazy<IViewModel<ICity>> CitiesView { get; private set; }
        public Lazy<IViewModel<ICinema>> CinemasView { get; private set; }
        public Lazy<IViewModel<IHall>> HallsView { get; private set; }
        public Lazy<IViewModel<IFloor>> FloorsView { get; private set; }
        public Lazy<ISeatViewModel> SeatsView { get; private set; }
        public Lazy<IViewModel<IShow>> ShowsView { get; private set; }
        public Lazy<IViewModel<IScheduler>> SchedulerView { get; private set; }

        public BindingSource CitiesBindingSource 
        {
            get 
            {
                this.SetDataSource(this.citiesBindingSource, this.CityViewBindingSource, Resources.ModelsDataMember);
                return this.citiesBindingSource;
            }
        }

        public BindingSource CityViewBindingSource
        {
            get
            {
                this.SetDataSource(this.citiesViewBindingSource, this.CitiesView.Value, String.Empty);
                return this.citiesViewBindingSource;
            }
        }

        public BindingSource CinemasBindingSource
        {
            get
            {
                this.SetDataSource(this.cinemasBindingSource, this.CinemaViewBindingSource, Resources.ModelsDataMember);
                return this.cinemasBindingSource;
            }
        }

        public BindingSource CinemaViewBindingSource
        {
            get
            {
                this.SetDataSource(this.cinemaViewBindingSource, this.CinemasView.Value, String.Empty);
                return this.cinemaViewBindingSource;
            }
        }

        public BindingSource HallsBindingSource
        {
            get
            {
                this.SetDataSource(this.hallsbindingSource, this.HallViewBindingSource, Resources.ModelsDataMember);
                return this.hallsbindingSource;
            }
        }

        public BindingSource HallViewBindingSource
        {
            get
            {
                this.SetDataSource(this.hallViewbindingSource, this.HallsView.Value, String.Empty);
                return this.hallViewbindingSource;
            }
        }

        public BindingSource FloorsBindingSource
        {
            get
            {
                this.SetDataSource(this.floorsBindingSource, this.FloorViewBindingSource, Resources.ModelsDataMember);
                return this.floorsBindingSource;
            }
        }

        public BindingSource FloorViewBindingSource
        {
            get
            {
                this.SetDataSource(this.floorViewBindingSource, this.FloorsView.Value, String.Empty);
                return this.floorViewBindingSource;
            }
        }

        public BindingSource SeatsBindingSource
        {
            get
            {
                this.SetDataSource(this.seatsBindingSource, this.SeatViewBindingSource, Resources.SeatsModelDataMember);
                return this.seatsBindingSource;
            }
        }

        public BindingSource SeatViewBindingSource
        {
            get
            {
                this.SetDataSource(this.seatViewBindingSource, this.SeatsView.Value, String.Empty);
                return this.seatViewBindingSource;
            }
        }

        public BindingSource ShowsBindingSource
        {
            get
            {
                this.SetDataSource(this.showsBindingSource, this.ShowViewBindingSource, Resources.ModelsDataMember);
                return this.showsBindingSource;
            }
        }

        public BindingSource ShowViewBindingSource
        {
            get
            {
                this.SetDataSource(this.showViewBindingSource, this.ShowsView.Value, String.Empty);
                return this.showViewBindingSource;
            }
        }

        public BindingSource SchedulersBindingSource
        {
            get
            {
                this.SetDataSource(this.schedulersBindingSource, this.SchedulerViewBindingSource, Resources.ModelsDataMember);
                return this.schedulersBindingSource;
            }
        }

        public BindingSource SchedulerViewBindingSource
        {
            get
            {
                this.SetDataSource(this.schedulerViewBindingSource, this.SchedulerView.Value, String.Empty);
                return this.schedulerViewBindingSource;
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

        private void ShowsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var bindingSource = sender as BindingSource;
            if (bindingSource != null)
            {
                this.ShowsView.Value.Selected = bindingSource.Current as IShow;
            }
        }

        private void SchedulersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var bindingSource = sender as BindingSource;
            if (bindingSource != null)
            {
                this.SchedulerView.Value.Selected = bindingSource.Current as IScheduler;
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

        private void ShowsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Show();
        }

        private void SchedulersBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Scheduler();
        }

        /// <summary>
        /// Sets dataSource for source
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dataSource"></param>
        private void SetDataSource(BindingSource source, object dataSource, string dataMember)
        {
            if (source.DataSource == null)
            {
                source.DataSource = dataSource;
                source.DataMember = String.IsNullOrWhiteSpace(dataMember) ? String.Empty : dataMember;
            }
        }
    }
}
