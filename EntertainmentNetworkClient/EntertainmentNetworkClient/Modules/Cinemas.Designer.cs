namespace EntertainmentNetworkClient.Modules
{
    partial class Cinemas
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridCinemas = new DevExpress.XtraGrid.GridControl();
            this.layoutViewCinemas = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colCinId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCinId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCinName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCinName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCinAddress = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCinAddress = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCinIcon = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemCinemaIcon = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewField_colCinIcon = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colCityId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colCityId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCinemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCinemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCinId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCinName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCinAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCinemaIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCinIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCityId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.gridCinemas);
            this.dataLayoutControl1.Controls.Add(this.comboBoxCities);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 510);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // gridCinemas
            // 
            this.gridCinemas.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridCinemas.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridCinemas.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridCinemas.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridCinemas.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridCinemas.Location = new System.Drawing.Point(12, 42);
            this.gridCinemas.MainView = this.layoutViewCinemas;
            this.gridCinemas.Name = "gridCinemas";
            this.gridCinemas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCinemaIcon});
            this.gridCinemas.Size = new System.Drawing.Size(776, 456);
            this.gridCinemas.TabIndex = 5;
            this.gridCinemas.UseEmbeddedNavigator = true;
            this.gridCinemas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutViewCinemas});
            // 
            // layoutViewCinemas
            // 
            this.layoutViewCinemas.Appearance.FieldEditingValue.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.layoutViewCinemas.Appearance.FieldEditingValue.Options.UseFont = true;
            this.layoutViewCinemas.Appearance.FieldValue.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.layoutViewCinemas.Appearance.FieldValue.Options.UseFont = true;
            this.layoutViewCinemas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.layoutViewCinemas.CardMinSize = new System.Drawing.Size(556, 432);
            this.layoutViewCinemas.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colCinId,
            this.colCinName,
            this.colCinAddress,
            this.colCinIcon,
            this.colCityId});
            this.layoutViewCinemas.GridControl = this.gridCinemas;
            this.layoutViewCinemas.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colCityId});
            this.layoutViewCinemas.Name = "layoutViewCinemas";
            this.layoutViewCinemas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.layoutViewCinemas.OptionsBehavior.AllowExpandCollapse = false;
            this.layoutViewCinemas.OptionsBehavior.AutoFocusNewCard = true;
            this.layoutViewCinemas.OptionsCustomization.AllowFilter = false;
            this.layoutViewCinemas.OptionsCustomization.AllowSort = false;
            this.layoutViewCinemas.OptionsItemText.TextToControlDistance = 3;
            this.layoutViewCinemas.OptionsView.ShowHeaderPanel = false;
            this.layoutViewCinemas.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.layoutViewCinemas.TemplateCard = this.layoutViewCard1;
            this.layoutViewCinemas.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.LayoutView_InitNewRow);
            // 
            // colCinId
            // 
            this.colCinId.FieldName = "CinId";
            this.colCinId.LayoutViewField = this.layoutViewField_colCinId;
            this.colCinId.Name = "colCinId";
            this.colCinId.OptionsColumn.AllowEdit = false;
            this.colCinId.OptionsColumn.ReadOnly = true;
            // 
            // layoutViewField_colCinId
            // 
            this.layoutViewField_colCinId.EditorPreferredWidth = 70;
            this.layoutViewField_colCinId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colCinId.Name = "layoutViewField_colCinId";
            this.layoutViewField_colCinId.Size = new System.Drawing.Size(103, 42);
            this.layoutViewField_colCinId.Spacing = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colCinId.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colCinId.TextSize = new System.Drawing.Size(61, 13);
            // 
            // colCinName
            // 
            this.colCinName.FieldName = "CinName";
            this.colCinName.LayoutViewField = this.layoutViewField_colCinName;
            this.colCinName.Name = "colCinName";
            // 
            // layoutViewField_colCinName
            // 
            this.layoutViewField_colCinName.EditorPreferredWidth = 468;
            this.layoutViewField_colCinName.Location = new System.Drawing.Point(103, 0);
            this.layoutViewField_colCinName.Name = "layoutViewField_colCinName";
            this.layoutViewField_colCinName.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutViewField_colCinName.Size = new System.Drawing.Size(474, 42);
            this.layoutViewField_colCinName.Spacing = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colCinName.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colCinName.TextSize = new System.Drawing.Size(61, 13);
            // 
            // colCinAddress
            // 
            this.colCinAddress.FieldName = "CinAddress";
            this.colCinAddress.LayoutViewField = this.layoutViewField_colCinAddress;
            this.colCinAddress.Name = "colCinAddress";
            // 
            // layoutViewField_colCinAddress
            // 
            this.layoutViewField_colCinAddress.EditorPreferredWidth = 544;
            this.layoutViewField_colCinAddress.Location = new System.Drawing.Point(0, 42);
            this.layoutViewField_colCinAddress.Name = "layoutViewField_colCinAddress";
            this.layoutViewField_colCinAddress.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutViewField_colCinAddress.Size = new System.Drawing.Size(577, 42);
            this.layoutViewField_colCinAddress.Spacing = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colCinAddress.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colCinAddress.TextSize = new System.Drawing.Size(61, 13);
            // 
            // colCinIcon
            // 
            this.colCinIcon.ColumnEdit = this.repositoryItemCinemaIcon;
            this.colCinIcon.FieldName = "CinIcon";
            this.colCinIcon.LayoutViewField = this.layoutViewField_colCinIcon;
            this.colCinIcon.Name = "colCinIcon";
            // 
            // repositoryItemCinemaIcon
            // 
            this.repositoryItemCinemaIcon.Name = "repositoryItemCinemaIcon";
            this.repositoryItemCinemaIcon.NullText = "Click right mouse button for loading image, then click \"Load\"";
            this.repositoryItemCinemaIcon.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.repositoryItemCinemaIcon.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // layoutViewField_colCinIcon
            // 
            this.layoutViewField_colCinIcon.EditorPreferredWidth = 544;
            this.layoutViewField_colCinIcon.Location = new System.Drawing.Point(0, 84);
            this.layoutViewField_colCinIcon.Name = "layoutViewField_colCinIcon";
            this.layoutViewField_colCinIcon.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutViewField_colCinIcon.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutViewField_colCinIcon.Size = new System.Drawing.Size(577, 62);
            this.layoutViewField_colCinIcon.Spacing = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colCinIcon.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colCinIcon.TextSize = new System.Drawing.Size(61, 13);
            // 
            // colCityId
            // 
            this.colCityId.FieldName = "CityId";
            this.colCityId.LayoutViewField = this.layoutViewField_colCityId;
            this.colCityId.Name = "colCityId";
            // 
            // layoutViewField_colCityId
            // 
            this.layoutViewField_colCityId.EditorPreferredWidth = 20;
            this.layoutViewField_colCityId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colCityId.Name = "layoutViewField_colCityId";
            this.layoutViewField_colCityId.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutViewField_colCityId.Size = new System.Drawing.Size(536, 126);
            this.layoutViewField_colCityId.Spacing = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_colCityId.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colCityId.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colCinId,
            this.layoutViewField_colCinName,
            this.layoutViewField_colCinIcon,
            this.layoutViewField_colCinAddress});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.DisplayMember = "CitName";
            this.comboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCities.Font = new System.Drawing.Font("Tahoma", 11F);
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(776, 26);
            this.comboBoxCities.Sorted = true;
            this.comboBoxCities.TabIndex = 4;
            this.comboBoxCities.ValueMember = "CitName";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 510);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.comboBoxCities;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 7);
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 30);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridCinemas;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 460);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
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
            this.labelControl.Text = "Cinemas";
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
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Add New", null, "AddItem;Size32x32;GrayScaled"),
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
            // Cinemas
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.Name = "Cinemas";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCinemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCinemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCinId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCinName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCinAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCinemaIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCinIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCityId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridCinemas;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutViewCinemas;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCinId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCinName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCinAddress;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCinIcon;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCityId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCinId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCinName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCinAddress;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCinIcon;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCityId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemCinemaIcon;
    }
}
