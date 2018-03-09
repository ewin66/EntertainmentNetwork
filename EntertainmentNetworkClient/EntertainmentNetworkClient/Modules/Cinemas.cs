using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.BL.ViewModels;
using EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetworkClient.Modules
{
    public partial class Cinemas : BaseModule
    {
        IViewModel<ICity> citiesView;
        IViewModel<ICinema> cinemasView;

        public Cinemas(IViewsManager viewsManager)
        {
            InitializeComponent();
            this.citiesView = viewsManager.CitiesView.Value;
            
            if (!this.citiesView.IsDataLoaded)
            {
                this.citiesView.LoadData(x => true);                
            }

            viewsManager.CitiesBindingSource.CurrentChanged += CitiesBindingSource_CurrentChanged;

            this.lookUpEditCities.Properties.DataSource = viewsManager.CitiesBindingSource;
            this.lookUpEditCities.DataBindings.Add(
                new Binding("EditValue", viewsManager.CitiesBindingSource, "CitId", true, DataSourceUpdateMode.OnPropertyChanged));

            this.cinemasView = viewsManager.CinemasView.Value;
            this.cinemasView.LoadData(this.FilterCinemas);
            this.gridCinemas.DataSource = viewsManager.CinemasBindingSource;
        }

        private bool FilterCinemas(ICinema cinema)
        {
            return this.citiesView.Selected != null && cinema.CityId == this.citiesView.Selected.CitId;
        }

        private void CitiesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.cinemasView.LoadData(this.FilterCinemas);
        }

        private void WindowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e)
        {
            var button = e.Button as WindowsUIButton;
            if (button != null)
            {
                if (button.Caption == Properties.Resources.ButtonSave)
                {
                    this.cinemasView.AddUpdateCommand.Execute(null);
                }
                else if (button.Caption == Properties.Resources.ButtonDelete)
                {
                    this.cinemasView.RemoveCommand.Execute(null);
                }
                else if (button.Caption == Properties.Resources.ButtonAddNew)
                {
                    this.layoutViewCinemas.AddNewRow();
                }
                else
                {
                    this.cinemasView.LoadData(this.FilterCinemas);
                }
            }
        }

        private void LayoutView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var view = sender as ColumnView;
            if (view != null)
            {
                view.SetRowCellValue(e.RowHandle, this.colCityId, this.lookUpEditCities.EditValue);
            }
        }

        private void LookUpEditCities_EditValueChanged(object sender, EventArgs e)
        {
            var lookup = sender as LookUpEdit;
            if (lookup != null)
            {
                int index = lookup.Properties.GetDataSourceRowIndex(lookup.Properties.ValueMember, lookup.EditValue);
                ((BindingSource)lookup.Properties.DataSource).Position = index;
            }
        }
    }
}
