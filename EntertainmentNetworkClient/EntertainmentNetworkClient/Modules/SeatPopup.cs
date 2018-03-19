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

namespace EntertainmentNetworkClient.Modules
{
    public partial class SeatPopup : BaseModule
    {
        public SeatPopup(IViewsManager viewsManager)
        {
            InitializeComponent();
            ISeat seat = viewsManager.SeatsView.Value.Selected;

            this.textEditSeatNum.DataBindings.Add(
              new Binding("EditValue", seat, "SeatNum", true, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}
