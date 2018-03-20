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
using DevExpress.XtraBars.Docking2010;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.DAL.Models.Interfaces;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using EntertainmentNetworkClient.Properties;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace EntertainmentNetworkClient.Modules
{
    public partial class Seats : BaseModule
    {
        public Seats(IViewsManager viewsManager)
        {
            InitializeComponent();
            this.viewsManager = viewsManager;
            this.mainDocumentManager = viewsManager.MainDocumentManager;
            this.seatsView = viewsManager.SeatsView.Value;
            this.seatsView.SeatsMapGenerated += SeatsView_SeatsMapGenerated;
            this.floorsView = viewsManager.FloorsView.Value;

            if (!this.floorsView.IsDataLoaded)
            {
                this.floorsView.LoadData(x => true); //TODO: filter is temporary
            }

            this.lookUpEditFloors.Properties.DataSource = viewsManager.FloorsBindingSource;
            this.lookUpEditFloors.DataBindings.Add(
                new Binding("EditValue", viewsManager.FloorsBindingSource, "FloorId", true, DataSourceUpdateMode.OnPropertyChanged));

            viewsManager.FloorsBindingSource.CurrentChanged += FloorsBindingSource_CurrentChanged;
            viewsManager.SeatsBindingSource.CurrentChanged += SeatsBindingSource_CurrentChanged;
            this.seatsView.LoadData(this.FilterSeats);
        }

        private void SeatsView_SeatsMapGenerated(object sender, EventArgs e)
        {
            this.gridViewSeats.Columns.Clear();
            this.gridSeats.DataSource = null;
            this.gridSeats.DataSource = this.viewsManager.SeatsBindingSource;
            foreach (GridColumn column in this.gridViewSeats.Columns)
            {
                column.View.CustomColumnDisplayText += ColumView_CustomColumnDisplayText;
            }
        }

        private void SeatsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var bindingSource = sender as BindingSource;
            if (bindingSource != null)
            {
                this.seatsView.Selected = this.gridViewSeats.GetFocusedValue() as ISeat;
            }
        }

        private bool IsInCell(GridView view, EventArgs e)
        {    
            bool isInCell = false;
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            if (view != null && ea != null)
            {
                GridHitInfo info = view.CalcHitInfo(ea.Location);
                isInCell = info.InRowCell;
            }

            return isInCell;
        }

        private void GridViewSeats_Click(object sender, EventArgs e)
        {
            GridView view = sender as GridView;

            if (this.IsInCell(view, e))
            {
                ISeat seat = this.gridViewSeats.GetFocusedValue() as ISeat;
                if (seat != null)
                {
                    seat.IsActive = !seat.IsActive;
                }

                view.InvalidateRowCell(view.FocusedRowHandle, view.FocusedColumn);
            }            
        }

        private void GridViewSeats_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;

            if (this.IsInCell(view, e))
            {
                WindowsUIView uiView = this.mainDocumentManager.View as WindowsUIView;
                if (uiView != null)
                {
                    var flSeats = uiView.ContentContainers.FirstOrDefault(x => x.Name == Resources.FlyoutSeats);
                    if (flSeats != null)
                    {
                        uiView.ActivateContainer(flSeats);
                    }
                }
            }
        }

        private void GridViewSeats_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            e.Appearance.BackColor = Color.White;

            foreach (var item in this.seatsView.Models.Where(x => !x.IsActive))
            {
                if (item.Equals(e.CellValue))
                {
                    e.Appearance.BackColor = Color.Gray;
                }
            }
        }

        private void ColumView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            ISeat seat = e.Value as ISeat;
            if (seat != null)
            {
                e.DisplayText = seat.SeatNum.ToString();
            }
        }

        private bool FilterSeats(ISeat seat)
        {
            return this.floorsView.Selected != null && seat.FloorId == this.floorsView.Selected.Id;
        }

        private void FloorsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.seatsView.LoadData(this.FilterSeats);
        }

        private void LookUpEditFloors_EditValueChanged(object sender, EventArgs e)
        {
            var lookup = sender as LookUpEdit;
            if (lookup != null)
            {
                int index = lookup.Properties.GetDataSourceRowIndex(lookup.Properties.ValueMember, lookup.EditValue);
                ((BindingSource)lookup.Properties.DataSource).Position = index;
            }
        }

        private void WindowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e)
        {
            var button = e.Button as WindowsUIButton;
            if (button != null)
            {
                if (button.Caption == Resources.ButtonGenerate)
                {
                    this.seatsView.GenerateCommand.Execute(
                        Tuple.Create(this.floorsView.Selected.Id, Convert.ToInt32(this.spinEditRows.EditValue), Convert.ToInt32(this.spinEditColumns.EditValue)));
                }
                else if (button.Caption == Resources.ButtonSave)
                {
                    this.seatsView.AddUpdateCommand.Execute(null);
                }
                else
                {
                   this.seatsView.LoadData(this.FilterSeats);
                }
            }
        }

        private ISeatViewModel seatsView;
        private IViewModel<IFloor> floorsView;
        private IViewsManager viewsManager;
        private DocumentManager mainDocumentManager;
    }
}
