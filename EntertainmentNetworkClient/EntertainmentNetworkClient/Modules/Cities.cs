using System;
using System.Windows.Forms;
using EntertainmentNetwork.BL.ViewModels;
using EntertainmentNetwork.DAL;
using DevExpress.XtraBars.Docking2010;
using EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.Models;

namespace EntertainmentNetworkClient.Modules
{
    public partial class Cities : BaseModule
    {
        CitiesViewModel citiesView;

        public Cities()
        {
            InitializeComponent();
            this.citiesView = new CitiesViewModel(ServiceManager.CityService.Value);
            this.citiesView.LoadData();
            citiesViewBindingSource.DataSource = citiesView;            
        }

        public void BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var bindingSource = sender as BindingSource;
            if (bindingSource != null)
            {
                citiesView.SelectedCity = bindingSource.Current as City;
            }
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
                    this.citiesView.LoadData();
                }
            }
        }

        private void EnableUIButtons(bool enable)
        {
            (this.windowsUIButtonPanelMain.Buttons[Properties.Resources.ButtonSave] as WindowsUIButton).Enabled = enable;
            (this.windowsUIButtonPanelMain.Buttons[Properties.Resources.ButtonRefresh] as WindowsUIButton).Enabled = enable;
        }
    }
}
