using System;
using System.Windows.Forms;
using EntertainmentNetwork.BL.ViewModels;
using EntertainmentNetwork.DAL;
using DevExpress.XtraBars.Docking2010;
using EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.Models;
using EntertainmentNetwork.BL.Interfaces;

namespace EntertainmentNetworkClient.Modules
{
    public partial class Cities : BaseModule
    {
        public Cities(IViewsManager viewsManager)
        {
            InitializeComponent();
            this.citiesView = viewsManager.CitiesView.Value;
            this.citiesView.LoadData(x => true);
            this.gridCities.DataSource = viewsManager.CitiesBindingSource;
        }

        private void WindowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e)
        {
            var button = e.Button as WindowsUIButton;
            if (button != null)
            {
                if (button.Caption == Properties.Resources.ButtonSave)
                {
                    this.citiesView.AddUpdateCommand.Execute(null);                    
                }
                else if (button.Caption == Properties.Resources.ButtonDelete)
                {
                    this.citiesView.RemoveCommand.Execute(null);
                }
                else
                {
                    this.citiesView.LoadData(x => true);
                }
            }
        }

         private IViewModel<ICity> citiesView;
    }
}
