namespace EntertainmentNetworkClient
{
    partial class EntertainmentNetworkMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.hubGroup = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup(this.components);
            this.docCities = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.docCinemas = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.docHallsFloors = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.docSeats = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.docShows = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.docScheduler = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.LoginFlyout = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.docLoginPage = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.flyoutSeats = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.seatPopupDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.flyoutSchedulerAppointmentForm = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.docSchedulerAppointmentForm = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.baseModuleDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.viewsManagerDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hubGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docCinemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docHallsFloors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docShows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFlyout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLoginPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatPopupDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutSchedulerAppointmentForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSchedulerAppointmentForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseModuleDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewsManagerDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.windowsUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.BackgroundImageLayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.BottomLeft;
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.hubGroup,
            this.LoginFlyout,
            this.flyoutSeats,
            this.flyoutSchedulerAppointmentForm});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.docCities,
            this.docLoginPage,
            this.docCinemas,
            this.docHallsFloors,
            this.docSeats,
            this.baseModuleDocument,
            this.seatPopupDocument,
            this.viewsManagerDocument,
            this.docShows,
            this.docScheduler,
            this.docSchedulerAppointmentForm});
            this.windowsUIView1.UseSplashScreen = DevExpress.Utils.DefaultBoolean.False;
            // 
            // hubGroup
            // 
            this.hubGroup.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.docCities,
            this.docCinemas,
            this.docHallsFloors,
            this.docSeats,
            this.docShows,
            this.docScheduler});
            this.hubGroup.Name = "hubGroup";
            this.hubGroup.Parent = this.LoginFlyout;
            this.hubGroup.Properties.AllowHtmlDrawHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.hubGroup.Properties.HeaderOffset = -12;
            this.hubGroup.Properties.HeaderStyle = DevExpress.XtraBars.Docking2010.Views.WindowsUI.HeaderStyle.Tile;
            this.hubGroup.Properties.Margin = new System.Windows.Forms.Padding(-8, -56, 10, 30);
            this.hubGroup.Properties.TileSize = 140;
            // 
            // docCities
            // 
            this.docCities.Caption = "Cities";
            this.docCities.ControlName = "Cities";
            this.docCities.ControlTypeName = "EntertainmentNetworkClient.Modules.Cities";
            this.docCities.Header = "Cities";
            // 
            // docCinemas
            // 
            this.docCinemas.Caption = "Cinemas";
            this.docCinemas.ControlName = "Cinemas";
            this.docCinemas.ControlTypeName = "EntertainmentNetworkClient.Modules.Cinemas";
            this.docCinemas.Header = "Cinemas";
            // 
            // docHallsFloors
            // 
            this.docHallsFloors.Caption = "Halls & Floors";
            this.docHallsFloors.ControlName = "HallsFloors";
            this.docHallsFloors.ControlTypeName = "EntertainmentNetworkClient.Modules.HallsFloors";
            // 
            // docSeats
            // 
            this.docSeats.Caption = "Seats";
            this.docSeats.ControlName = "Seats";
            this.docSeats.ControlTypeName = "EntertainmentNetworkClient.Modules.Seats";
            // 
            // docShows
            // 
            this.docShows.Caption = "Shows";
            this.docShows.ControlName = "Shows";
            this.docShows.ControlTypeName = "EntertainmentNetworkClient.Modules.Shows";
            // 
            // docScheduler
            // 
            this.docScheduler.Caption = "Scheduler";
            this.docScheduler.ControlName = "Schedulers";
            this.docScheduler.ControlTypeName = "EntertainmentNetworkClient.Modules.Schedulers";
            // 
            // LoginFlyout
            // 
            this.LoginFlyout.Document = this.docLoginPage;
            this.LoginFlyout.Name = "LoginFlyout";
            // 
            // docLoginPage
            // 
            this.docLoginPage.Caption = "Login Page";
            this.docLoginPage.ControlName = "LoginForm";
            this.docLoginPage.ControlTypeName = "EntertainmentNetworkClient.Modules.LoginForm";
            // 
            // flyoutSeats
            // 
            this.flyoutSeats.Document = this.seatPopupDocument;
            this.flyoutSeats.FlyoutButtons = System.Windows.Forms.MessageBoxButtons.OKCancel;
            this.flyoutSeats.Name = "flyoutSeats";
            // 
            // seatPopupDocument
            // 
            this.seatPopupDocument.Caption = "SeatPopup";
            this.seatPopupDocument.ControlName = "SeatPopup";
            this.seatPopupDocument.ControlTypeName = "EntertainmentNetworkClient.Modules.SeatPopup";
            // 
            // flyoutSchedulerAppointmentForm
            // 
            this.flyoutSchedulerAppointmentForm.Document = this.docSchedulerAppointmentForm;
            this.flyoutSchedulerAppointmentForm.FlyoutButtons = System.Windows.Forms.MessageBoxButtons.OKCancel;
            this.flyoutSchedulerAppointmentForm.Name = "flyoutSchedulerAppointmentForm";
            // 
            // docSchedulerAppointmentForm
            // 
            this.docSchedulerAppointmentForm.Caption = "SchedulerAppointmentForm";
            this.docSchedulerAppointmentForm.ControlName = "SchedulerAppointmentForm";
            this.docSchedulerAppointmentForm.ControlTypeName = "EntertainmentNetworkClient.Modules.SchedulerAppointmentForm";
            // 
            // baseModuleDocument
            // 
            this.baseModuleDocument.Caption = "BaseModule";
            this.baseModuleDocument.ControlName = "BaseModule";
            this.baseModuleDocument.ControlTypeName = "EntertainmentNetworkClient.Modules.BaseModule";
            // 
            // viewsManagerDocument
            // 
            this.viewsManagerDocument.Caption = "ViewsManager";
            this.viewsManagerDocument.ControlName = "ViewsManager";
            this.viewsManagerDocument.ControlTypeName = "EntertainmentNetworkClient.Modules.ViewsManager";
            // 
            // EntertainmentNetworkMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 674);
            this.Name = "EntertainmentNetworkMainForm";
            this.Text = "EntertainmentNetwork";
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hubGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docCinemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docHallsFloors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docShows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFlyout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLoginPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatPopupDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutSchedulerAppointmentForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSchedulerAppointmentForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseModuleDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewsManagerDocument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docCities;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup hubGroup;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout LoginFlyout;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docLoginPage;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docCinemas;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docHallsFloors;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docSeats;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout flyoutSeats;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document seatPopupDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document baseModuleDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document viewsManagerDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docShows;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docScheduler;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docSchedulerAppointmentForm;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout flyoutSchedulerAppointmentForm;




    }
}

