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
using DevExpress.Utils.Menu;
using DevExpress.XtraScheduler;
using DevExpress.Utils;
using System.Reflection;
using DevExpress.Utils.Controls;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraScheduler.Localization;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraEditors.Native;
using DevExpress.Utils.Internal;
using DevExpress.XtraScheduler.Internal;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using EntertainmentNetworkClient.Properties;

namespace EntertainmentNetworkClient.Modules
{
    public partial class SchedulerAppointmentForm : BaseModule
    {
        public SchedulerAppointmentForm(IViewsManager viewsManager)
        {
            this.ViewManager = viewsManager;

            if (!this.ViewManager.HallsView.Value.IsDataLoaded)
            {
                this.ViewManager.HallsView.Value.LoadData(x => true);                
            }
        }

        public void Initialize(SchedulerControl control, Appointment apt)
        {
            this.Controller = new AppointmentFormController(control, apt);
            InitializeComponent();

            this.lookUpEditHalls.Properties.DataSource = this.ViewManager.HallsBindingSource;
            this.lookUpEditHalls.DataBindings.Add(
                new Binding("EditValue", this.ViewManager.HallsBindingSource, "HalId", true, DataSourceUpdateMode.OnPropertyChanged));

            this.Control = control;
            this.Storage = control.Storage;
            this.edtResource.SchedulerControl = control;
            this.edtResource.Storage = this.Storage;

            SubscribeControllerEvents(Controller);
            BindControllerToControls();
        }

        #region Properties

        public bool ReadOnly
        {
            get { return Controller != null && Controller.ReadOnly; }
            set
            {
                if (Controller.ReadOnly == value)
                    return;
                Controller.ReadOnly = value;
            }
        }

        public IDXMenuManager MenuManager { get; set; }

        protected internal AppointmentFormController Controller { get; set; }

        protected internal SchedulerControl Control { get; set; }
       
        protected internal ISchedulerStorage Storage { get; set; }
        
        protected internal bool IsNewAppointment 
        { 
            get 
            {
                return this.Controller != null ? this.Controller.IsNewAppointment : true;
            } 
        }
        
        protected decimal EditAppointmentHallId 
        {
            get
            {
                return this.Controller.EditedAppointmentCopy.CustomFields[Resources.FieldNameHallId] == null 
                    ? -1
                    : (decimal)this.Controller.EditedAppointmentCopy.CustomFields[Resources.FieldNameHallId];
            }
            set
            {
                this.Controller.EditedAppointmentCopy.CustomFields[Resources.FieldNameHallId] = value;
            }
        }

        private IViewsManager ViewManager { get; set; }

        private decimal HallId { get; set; }

        #endregion

        public virtual void LoadFormData()
        {
            this.HallId = this.EditAppointmentHallId;
            this.lookUpEditHalls.EditValue = this.HallId;            
        }

        public virtual void SaveFormData()
        {
            this.EditAppointmentHallId = (decimal)this.lookUpEditHalls.EditValue;
        }

        public virtual bool IsAppointmentChanged()
        {
            return this.HallId != this.EditAppointmentHallId
                || this.Controller.IsAppointmentChanged();
        }

        public virtual void SetMenuManager(IDXMenuManager menuManager)
        {
            MenuManagerUtils.SetMenuManager(Controls, menuManager);
            this.MenuManager = menuManager;
        }

        protected virtual void BindControllerToControls()
        {
            BindProperties(this.textEditScheduleName, "Text", "Subject");
            BindProperties(this.memoEditSchedulerDescription, "Text", "Description");
            BindProperties(this.edtStartDate, "EditValue", "DisplayStartDate");
            BindProperties(this.edtStartDate, "Enabled", "IsDateTimeEditable");
            BindProperties(this.edtStartTime, "EditValue", "DisplayStartTime");
            BindProperties(this.edtStartTime, "Visible", "IsTimeVisible");
            BindProperties(this.edtStartTime, "Enabled", "IsTimeVisible");
            BindProperties(this.edtEndDate, "EditValue", "DisplayEndDate", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndDate, "Enabled", "IsDateTimeEditable", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndTime, "EditValue", "DisplayEndTime", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndTime, "Visible", "IsTimeVisible", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndTime, "Enabled", "IsTimeVisible", DataSourceUpdateMode.Never);
            BindProperties(this.chkAllDay, "Checked", "AllDay");
            BindProperties(this.chkAllDay, "Enabled", "IsDateTimeEditable");
            BindProperties(this.edtResource, "ResourceId", "ResourceId");
            BindProperties(this.edtResource, "Enabled", "CanEditResource");
            BindToBoolPropertyAndInvert(this.edtResource, "Visible", "ResourceSharing");
        }

        protected virtual void ObjectToStringConverter(object o, ConvertEventArgs e)
        {
            e.Value = e.Value.ToString();
        }

        protected virtual void BindProperties(Control target, string targetProperty, string sourceProperty)
        {
            BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged);
        }

        protected virtual void BindProperties(Control target, string targetProperty, string sourceProperty, DataSourceUpdateMode updateMode)
        {
            target.DataBindings.Add(targetProperty, Controller, sourceProperty, true, updateMode);
        }

        protected virtual void BindProperties(Control target, string targetProperty, string sourceProperty, ConvertEventHandler objectToStringConverter)
        {
            Binding binding = new Binding(targetProperty, Controller, sourceProperty, true);
            binding.Format += objectToStringConverter;
            target.DataBindings.Add(binding);
        }

        protected virtual void BindToBoolPropertyAndInvert(Control target, string targetProperty, string sourceProperty)
        {
            target.DataBindings.Add(new BoolInvertBinding(targetProperty, Controller, sourceProperty));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Controller == null)
                return;
            this.DataBindings.Add("Text", Controller, "Caption");
            this.SubscribeControlsEvents();
            this.LoadFormData();
        }

        void SubscribeControllerEvents(AppointmentFormController controller)
        {
            if (controller != null)
            {
                controller.PropertyChanged += OnControllerPropertyChanged;
            }
        }

        void OnControllerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ReadOnly")
            {
                UpdateReadonly();
            }
        }

        protected virtual void UpdateReadonly()
        {
            if (this.Controller != null)
            {
                IList<Control> controls = GetAllControls(this);
                foreach (Control control in controls)
                {
                    BaseEdit editor = control as BaseEdit;
                    if (editor != null)
                    {
                        editor.ReadOnly = Controller.ReadOnly;
                    }
                }
            }
        }

        List<Control> GetAllControls(Control rootControl)
        {
            List<Control> result = new List<Control>();
            foreach (Control control in rootControl.Controls)
            {
                result.Add(control);
                IList<Control> childControls = GetAllControls(control);
                result.AddRange(childControls);
            }
            return result;
        }

        protected internal virtual void SubscribeControlsEvents()
        {
            this.edtEndDate.Validating += new CancelEventHandler(OnEdtEndDateValidating);
            this.edtEndDate.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtEndDateInvalidValue);
            this.edtEndTime.Validating += new CancelEventHandler(OnEdtEndTimeValidating);
            this.edtEndTime.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtEndTimeInvalidValue);
            this.edtStartDate.Validating += new CancelEventHandler(OnEdtStartDateValidating);
            this.edtStartDate.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtStartDateInvalidValue);
            this.edtStartTime.Validating += new CancelEventHandler(OnEdtStartTimeValidating);
            this.edtStartTime.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtStartTimeInvalidValue);
        }

        protected internal virtual void UnsubscribeControlsEvents()
        {
            this.edtEndDate.Validating -= new CancelEventHandler(OnEdtEndDateValidating);
            this.edtEndDate.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtEndDateInvalidValue);
            this.edtEndTime.Validating -= new CancelEventHandler(OnEdtEndTimeValidating);
            this.edtEndTime.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtEndTimeInvalidValue);
            this.edtStartDate.Validating -= new CancelEventHandler(OnEdtStartDateValidating);
            this.edtStartDate.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtStartDateInvalidValue);
            this.edtStartTime.Validating -= new CancelEventHandler(OnEdtStartTimeValidating);
            this.edtStartTime.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtStartTimeInvalidValue);
        }

        protected internal virtual void OnEdtStartTimeInvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }

        protected internal virtual void OnEdtStartTimeValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Controller.ValidateLimitInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay);
        }

        protected internal virtual void OnEdtStartDateInvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }

        protected internal virtual void OnEdtStartDateValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Controller.ValidateLimitInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay);
        }

        protected internal virtual void OnEdtEndDateValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !IsValidInterval();
            if (!e.Cancel)
            {
                this.edtEndDate.DataBindings["EditValue"].WriteValue();
            }
        }

        protected internal virtual void OnEdtEndDateInvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            if (!AppointmentFormControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay))
            {
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate);
            }
            else
            {
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
            }
        }

        protected internal virtual void OnEdtEndTimeValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !IsValidInterval();
            if (!e.Cancel)
            {
                this.edtEndTime.DataBindings["EditValue"].WriteValue();
            }
        }

        protected internal virtual void OnEdtEndTimeInvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            if (!AppointmentFormControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay))
            {
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate);
            }
            else
            {
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
            }
        }

        protected internal virtual bool IsValidInterval()
        {
            return AppointmentFormControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay) 
                && Controller.ValidateLimitInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay);
        }

        protected internal virtual void OnOkButton()
        {
            this.SaveFormData();

            if (!ValidateDateAndTime())
                return;

            if (!this.Controller.IsConflictResolved())
            {
                ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_Conflict), this.Controller.GetMessageBoxCaption(SchedulerStringId.Msg_Conflict), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.IsAppointmentChanged() || this.Controller.IsNewAppointment)
            {
                this.Controller.ApplyChanges();
            }
        }

        private bool ValidateDateAndTime()
        {
            this.edtEndDate.DoValidate();
            this.edtEndTime.DoValidate();
            this.edtStartDate.DoValidate();
            this.edtStartTime.DoValidate();

            return String.IsNullOrEmpty(this.edtEndTime.ErrorText) && String.IsNullOrEmpty(this.edtEndDate.ErrorText) && String.IsNullOrEmpty(this.edtStartDate.ErrorText) && String.IsNullOrEmpty(this.edtStartTime.ErrorText);
        }

        protected internal virtual DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return XtraMessageBox.Show(this, text, caption, buttons, icon);
        }

        protected internal virtual void OnDeleteButton()
        {
            if (IsNewAppointment)
                return;

            Controller.DeleteAppointment();
        }

        private void LookUpEditHalls_EditValueChanged(object sender, EventArgs e)
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
