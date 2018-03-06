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
            this.docHalls = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.docSits = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.LoginFlyout = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.docLoginPage = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.flyout1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hubGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docCinemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docHalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFlyout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLoginPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyout1)).BeginInit();
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
            this.flyout1,
            this.LoginFlyout});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.docCities,
            this.docLoginPage,
            this.docCinemas,
            this.docHalls,
            this.docSits});
            this.windowsUIView1.UseSplashScreen = DevExpress.Utils.DefaultBoolean.False;
            // 
            // hubGroup
            // 
            this.hubGroup.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.docCities,
            this.docCinemas,
            this.docHalls,
            this.docSits});
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
            // docHalls
            // 
            this.docHalls.Caption = "Halls";
            this.docHalls.ControlName = "Halls";
            this.docHalls.ControlTypeName = "EntertainmentNetworkClient.Modules.Halls";
            // 
            // docSits
            // 
            this.docSits.Caption = "Sits";
            this.docSits.ControlName = "Sits";
            this.docSits.ControlTypeName = "EntertainmentNetworkClient.Modules.Sits";
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
            // flyout1
            // 
            this.flyout1.Name = "flyout1";
            // 
            // EntertainmentNetworkMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 506);
            this.Name = "EntertainmentNetworkMainForm";
            this.Text = "EntertainmentNetwork";
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hubGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docCinemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docHalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFlyout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docLoginPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyout1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docCities;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TabbedGroup hubGroup;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout LoginFlyout;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout flyout1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docLoginPage;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docCinemas;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docHalls;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document docSits;




    }
}

