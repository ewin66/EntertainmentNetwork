using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraScheduler;
using EntertainmentNetwork.BL.ViewModels;
using EntertainmentNetworkClient.Properties;

namespace EntertainmentNetworkClient.Modules
{
    public partial class Schedulers : BaseModule
    {
        public Schedulers(IViewsManager viewsManager)
        {
            InitializeComponent();
            this.ViewsManager = viewsManager;
            this.MainDocumentManager = viewsManager.MainDocumentManager;
            WindowsUIView uiView = this.MainDocumentManager.View as WindowsUIView;
            uiView.QueryControl += View_QueryControl;
            uiView.ControlReleasing += View_ControlReleasing;

            this.ViewsManager.ShowsView.Value.LoadData(x => true);
            this.ViewsManager.SchedulerView.Value.LoadData(x => true);

            this.schedulerStorage.Resources.DataSource = this.ViewsManager.ShowsBindingSource;
            this.schedulerStorage.Appointments.DataSource = this.ViewsManager.SchedulersBindingSource;
        }

        private IViewsManager ViewsManager { get; set; }
        private DocumentManager MainDocumentManager { get; set; }
        private AppointmentFormEventArgs CurrentAppointmentArgs { get; set; }
        private SchedulerAppointmentForm CurrentAppointmentForm { get; set; }

        void View_QueryControl(object sender, QueryControlEventArgs e)
        {
            this.CurrentAppointmentForm = e.Control as SchedulerAppointmentForm;
            if (this.CurrentAppointmentForm != null)
            {
                this.CurrentAppointmentForm.Initialize(this.schedulerControl, this.CurrentAppointmentArgs.Appointment);
            }
        }

        void View_ControlReleasing(object sender, ControlReleasingEventArgs e)
        {
            if (e.Document.Control is SchedulerAppointmentForm)
            {
                e.KeepControl = false;
            }
        }

        private void WindowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e)
        {
            var button = e.Button as WindowsUIButton;
            if (button != null)
            {
                this.ViewsManager.ShowsView.Value.LoadData(x => true);
                this.ViewsManager.SchedulerView.Value.LoadData(x => true);
            }
        }

        private void SchedulerStorage_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            foreach (var appointment in e.Objects.OfType<Appointment>())
            {
                this.ViewsManager.SchedulerView.Value.RemoveCommand.Execute(appointment.Id);
            }
        }

        private void SchedulerStorage_AppointmentsInsertUpdate(object sender, PersistentObjectsEventArgs e)
        {
            this.ViewsManager.SchedulerView.Value.AddUpdateCommand.Execute(null);
        }

        private void SchedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            this.CurrentAppointmentArgs = e;
            WindowsUIView uiView = this.MainDocumentManager.View as WindowsUIView;
            if (uiView != null)
            {
                Flyout flyout = uiView.ContentContainers.FirstOrDefault(x => x.Name == Resources.FlyoutSchedulerAppointmentForm) as Flyout;
                if (flyout != null)
                {
                    FlyoutAction action = new FlyoutAction();
                    action.Commands.Add(new FlyoutCommand
                    {
                        Result = DialogResult.Abort,
                        Text = Resources.ButtonDelete
                    });
                    flyout.Action = action;
                    uiView.FlyoutHidden += View_FlyoutHidden;
                    uiView.ActivateContainer(flyout);
                    e.Handled = true;
                }              
            }           
        }

        void View_FlyoutHidden(object sender, FlyoutResultEventArgs e)
        {
            if (e.Result == DialogResult.OK)
            {
                this.CurrentAppointmentForm.OnOkButton();
            }
            else if (e.Result == DialogResult.Abort)
            {
                this.CurrentAppointmentForm.OnDeleteButton();
            }

            WindowsUIView uiView = sender as WindowsUIView;
            if (uiView != null)
            {
                uiView.FlyoutHidden -= this.View_FlyoutHidden;
            }
        }
    }
}
