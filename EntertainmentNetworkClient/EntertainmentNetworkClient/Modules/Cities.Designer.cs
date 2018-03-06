using EntertainmentNetwork.BL.ViewModels;

namespace EntertainmentNetworkClient.Modules
{
    partial class Cities
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
        ///
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridCities = new DevExpress.XtraGrid.GridControl();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridCitiesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCitId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCitCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutGridCities = new DevExpress.XtraLayout.LayoutControlItem();
            this.cityViewBindingSoure = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCitiesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutGridCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityViewBindingSoure)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.gridCities);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(675, 265, 542, 396);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 510);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // gridCities
            // 
            this.gridCities.DataSource = this.citiesBindingSource;
            this.gridCities.Location = new System.Drawing.Point(12, 12);
            this.gridCities.MainView = this.gridCitiesView;
            this.gridCities.Name = "gridCities";
            this.gridCities.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gridCities.Size = new System.Drawing.Size(776, 486);
            this.gridCities.TabIndex = 4;
            this.gridCities.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCitiesView});
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.AllowNew = true;
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.citiesViewBindingSource;
            this.citiesBindingSource.CurrentChanged += new System.EventHandler(this.BindingSource_CurrentChanged);
            // 
            // citiesViewBindingSource
            // 
            this.citiesViewBindingSource.DataSource = typeof(EntertainmentNetwork.BL.ViewModels.CitiesViewModel);
            // 
            // gridCitiesView
            // 
            this.gridCitiesView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridCitiesView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridCitiesView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridCitiesView.Appearance.OddRow.Options.UseBackColor = true;
            this.gridCitiesView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCitiesView.Appearance.Row.Options.UseFont = true;
            this.gridCitiesView.Appearance.SelectedRow.BackColor = System.Drawing.Color.White;
            this.gridCitiesView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridCitiesView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridCitiesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCitId,
            this.colCitName,
            this.colCitCountry});
            this.gridCitiesView.GridControl = this.gridCities;
            this.gridCitiesView.Name = "gridCitiesView";
            this.gridCitiesView.NewItemRowText = "new";
            this.gridCitiesView.OptionsView.EnableAppearanceOddRow = true;
            this.gridCitiesView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridCitiesView.OptionsView.ShowGroupPanel = false;
            this.gridCitiesView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // colCitId
            // 
            this.colCitId.FieldName = "CitId";
            this.colCitId.Name = "colCitId";
            this.colCitId.Visible = true;
            this.colCitId.VisibleIndex = 0;
            this.colCitId.Width = 128;
            // 
            // colCitName
            // 
            this.colCitName.FieldName = "CitName";
            this.colCitName.Name = "colCitName";
            this.colCitName.Visible = true;
            this.colCitName.VisibleIndex = 1;
            this.colCitName.Width = 307;
            // 
            // colCitCountry
            // 
            this.colCitCountry.FieldName = "CitCountry";
            this.colCitCountry.Name = "colCitCountry";
            this.colCitCountry.Visible = true;
            this.colCitCountry.VisibleIndex = 2;
            this.colCitCountry.Width = 325;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutGridCities});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 510);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutGridCities
            // 
            this.layoutGridCities.Control = this.gridCities;
            this.layoutGridCities.Location = new System.Drawing.Point(0, 0);
            this.layoutGridCities.Name = "layoutGridCities";
            this.layoutGridCities.Size = new System.Drawing.Size(780, 490);
            this.layoutGridCities.TextSize = new System.Drawing.Size(0, 0);
            this.layoutGridCities.TextVisible = false;
            // 
            // cityViewBindingSoure
            // 
            this.cityViewBindingSoure.DataSource = typeof(EntertainmentNetwork.DAL.Models.City);
            // 
            // labelControl
            // 
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Location = new System.Drawing.Point(0, 0);
            this.labelControl.Name = "labelControl";
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.labelControl.Size = new System.Drawing.Size(800, 30);
            this.labelControl.TabIndex = 1;
            this.labelControl.Text = "Cities";
            // 
            // windowsUIButtonPanelMain
            // 
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.windowsUIButtonPanelMain.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", null, "Save;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Refresh", null, "Reset;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", null, "Edit/Delete;Size32x32;GrayScaled")});
            this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelMain.Location = new System.Drawing.Point(0, 540);
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(60, 60);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Size = new System.Drawing.Size(800, 60);
            this.windowsUIButtonPanelMain.TabIndex = 3;
            this.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanelMain.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.WindowsUIButtonPanelMain_ButtonClick);
            // 
            // Cities
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.Name = "Cities";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCitiesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutGridCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityViewBindingSoure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridCities;
        private DevExpress.XtraLayout.LayoutControlItem layoutGridCities;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.BindingSource citiesViewBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCitiesView;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private System.Windows.Forms.BindingSource cityViewBindingSoure;
        private DevExpress.XtraGrid.Columns.GridColumn colCitId;
        private DevExpress.XtraGrid.Columns.GridColumn colCitName;
        private DevExpress.XtraGrid.Columns.GridColumn colCitCountry;
    }
}
