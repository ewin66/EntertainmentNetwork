﻿using System;
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

namespace EntertainmentNetworkClient.Modules
{
    public partial class Seats : BaseModule
    {
        public Seats(IViewsManager viewsManager)
        {
            InitializeComponent();
        }
    }
}
