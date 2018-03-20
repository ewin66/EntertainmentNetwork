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
    public partial class Shows : BaseModule
    {
        public Shows(IViewsManager viewsManager)
        {
            InitializeComponent();
            this.showView = viewsManager.ShowsView.Value;
            this.showView.LoadData(x => true);
            this.gridShows.DataSource = viewsManager.ShowsBindingSource;
        }
     
        private void WindowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e)
        {
            var button = e.Button as WindowsUIButton;
            if (button != null)
            {
                if (button.Caption == Properties.Resources.ButtonSave)
                {
                    this.showView.AddUpdateCommand.Execute(null);
                }
                else if (button.Caption == Properties.Resources.ButtonDelete)
                {
                    this.showView.RemoveCommand.Execute(null);
                }
                else if (button.Caption == Properties.Resources.ButtonAddNew)
                {
                    this.layoutViewShows.AddNewRow();
                }
                else
                {
                    this.showView.LoadData(x => true);
                }
            }
        }

        private IViewModel<IShow> showView;
    }
}
