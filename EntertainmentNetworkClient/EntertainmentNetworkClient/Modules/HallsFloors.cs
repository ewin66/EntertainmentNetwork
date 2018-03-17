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
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using EntertainmentNetwork.BL.ViewModels;
using EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.BL.Interfaces;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace EntertainmentNetworkClient.Modules
{
    public partial class HallsFloors : BaseModule
    {
        public HallsFloors(IViewsManager viewsManager)
        {
            InitializeComponent();

            this.cinemasView = viewsManager.CinemasView.Value;

            if (!this.cinemasView.IsDataLoaded)
            {
                this.cinemasView.LoadData(x => true);
            }

            viewsManager.CinemasBindingSource.CurrentChanged += CinemasBindingSource_CurrentChanged;
            viewsManager.HallsBindingSource.CurrentChanged += HallsBindingSource_CurrentChanged;

            this.lookUpEditCinemas.Properties.DataSource = viewsManager.CinemasBindingSource;
            this.lookUpEditCinemas.DataBindings.Add(
                new Binding("EditValue", viewsManager.CinemasBindingSource, "CinId", true, DataSourceUpdateMode.OnPropertyChanged));

            this.hallsView = viewsManager.HallsView.Value;
            this.hallsView.LoadData(this.FilterHalls);

            this.floorsView = viewsManager.FloorsView.Value;
            this.floorsView.LoadData(this.FilterFloors);

            this.gridHalls.DataSource = viewsManager.HallsBindingSource;
            this.gridFloors.DataSource = viewsManager.FloorsBindingSource;
        }

        private bool FilterHalls(IHall hall)
        {
            return this.cinemasView.Selected != null && hall.CinemaId == this.cinemasView.Selected.CinId;
        }

        private bool FilterFloors(IFloor floor)
        {
            return this.hallsView.Selected != null && floor.HallId == this.hallsView.Selected.HalId;
        }

        private void CinemasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.hallsView.LoadData(this.FilterHalls);
        }

        private void HallsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.floorsView.LoadData(this.FilterFloors);
        }

        private void WindowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e)
        {
            var button = e.Button as WindowsUIButton;
            if (button != null)
            {
                if (button.Caption == Properties.Resources.ButtonSave)
                {
                    this.hallsView.AddUpdateCommand.Execute(null);
                    this.floorsView.AddUpdateCommand.Execute(null);
                }
                else if (button.Caption == Properties.Resources.ButtonDelete)
                {
                    if (this.layoutControlGroupHalls.AllowBorderColorBlending)
                    {
                        this.hallsView.RemoveCommand.Execute(null);
                    }

                    if (this.layoutControlGroupFloors.AllowBorderColorBlending)
                    {
                        this.floorsView.RemoveCommand.Execute(null);
                    }
                }
                else
                {
                    this.hallsView.LoadData(this.FilterHalls);
                    this.floorsView.LoadData(this.FilterFloors);
                }
            }
        }

        private void HallsView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var view = sender as ColumnView;
            if (view != null)
            {
                view.SetRowCellValue(e.RowHandle, this.colCinemaId, this.lookUpEditCinemas.EditValue);
            }
        }

        private void FloorsView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            var view = sender as ColumnView;
            if (view != null)
            {
                view.SetRowCellValue(e.RowHandle, this.colHallId, this.hallsView.Selected.HalId);
            }
        }

        private void LookUpEditCinemas_EditValueChanged(object sender, EventArgs e)
        {
            var lookup = sender as LookUpEdit;
            if (lookup != null)
            {
                int index = lookup.Properties.GetDataSourceRowIndex(lookup.Properties.ValueMember, lookup.EditValue);
                ((BindingSource)lookup.Properties.DataSource).Position = index;
            }
        }

        private void layoutControlGroupHalls_Click(object sender, EventArgs e)
        {
            this.layoutControlGroupHalls.AllowBorderColorBlending = true;
            this.layoutControlGroupFloors.AllowBorderColorBlending = false;
        }

        private void layoutControlGroupFloors_Click(object sender, EventArgs e)
        {
            this.layoutControlGroupHalls.AllowBorderColorBlending = false;
            this.layoutControlGroupFloors.AllowBorderColorBlending = true;
        }

        private IViewModel<IHall> hallsView;
        private IViewModel<ICinema> cinemasView;
        private IViewModel<IFloor> floorsView;
    }
}
