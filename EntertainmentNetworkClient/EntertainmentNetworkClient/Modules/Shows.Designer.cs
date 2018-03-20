namespace EntertainmentNetworkClient.Modules
{
    partial class Shows
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
            this.gridShows = new DevExpress.XtraGrid.GridControl();
            this.layoutViewShows = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colShwId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colShwName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colShwDesc = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colShwPerformer = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colShwIcon = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemCinemaIcon = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewField_colShwId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colShwDesc = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colShwPerformer = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colShwIcon = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colShwName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewShows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCinemaIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colShwId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colShwDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colShwPerformer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colShwIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colShwName)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.gridShows);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 510);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // gridShows
            // 
            this.gridShows.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridShows.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridShows.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridShows.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridShows.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridShows.Location = new System.Drawing.Point(12, 12);
            this.gridShows.MainView = this.layoutViewShows;
            this.gridShows.Name = "gridShows";
            this.gridShows.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCinemaIcon});
            this.gridShows.Size = new System.Drawing.Size(776, 486);
            this.gridShows.TabIndex = 6;
            this.gridShows.UseEmbeddedNavigator = true;
            this.gridShows.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutViewShows});
            // 
            // layoutViewShows
            // 
            this.layoutViewShows.Appearance.FieldEditingValue.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.layoutViewShows.Appearance.FieldEditingValue.Options.UseFont = true;
            this.layoutViewShows.Appearance.FieldValue.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.layoutViewShows.Appearance.FieldValue.Options.UseFont = true;
            this.layoutViewShows.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.layoutViewShows.CardMinSize = new System.Drawing.Size(534, 465);
            this.layoutViewShows.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colShwId,
            this.colShwName,
            this.colShwDesc,
            this.colShwPerformer,
            this.colShwIcon});
            this.layoutViewShows.GridControl = this.gridShows;
            this.layoutViewShows.Name = "layoutViewShows";
            this.layoutViewShows.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.layoutViewShows.OptionsBehavior.AllowExpandCollapse = false;
            this.layoutViewShows.OptionsBehavior.AutoFocusNewCard = true;
            this.layoutViewShows.OptionsCarouselMode.Radius = 1000;
            this.layoutViewShows.OptionsCustomization.AllowFilter = false;
            this.layoutViewShows.OptionsCustomization.AllowSort = false;
            this.layoutViewShows.OptionsItemText.TextToControlDistance = 0;
            this.layoutViewShows.OptionsView.ShowHeaderPanel = false;
            this.layoutViewShows.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.layoutViewShows.TemplateCard = this.layoutViewCard1;
            // 
            // colShwId
            // 
            this.colShwId.FieldName = "ShwId";
            this.colShwId.LayoutViewField = this.layoutViewField_colShwId;
            this.colShwId.Name = "colShwId";
            this.colShwId.OptionsColumn.ReadOnly = true;
            // 
            // colShwName
            // 
            this.colShwName.FieldName = "ShwName";
            this.colShwName.LayoutViewField = this.layoutViewField_colShwName;
            this.colShwName.Name = "colShwName";
            // 
            // colShwDesc
            // 
            this.colShwDesc.FieldName = "ShwDesc";
            this.colShwDesc.LayoutViewField = this.layoutViewField_colShwDesc;
            this.colShwDesc.Name = "colShwDesc";
            // 
            // colShwPerformer
            // 
            this.colShwPerformer.FieldName = "ShwPerformer";
            this.colShwPerformer.LayoutViewField = this.layoutViewField_colShwPerformer;
            this.colShwPerformer.Name = "colShwPerformer";
            // 
            // colShwIcon
            // 
            this.colShwIcon.FieldName = "ShwIcon";
            this.colShwIcon.LayoutViewField = this.layoutViewField_colShwIcon;
            this.colShwIcon.Name = "colShwIcon";
            // 
            // repositoryItemCinemaIcon
            // 
            this.repositoryItemCinemaIcon.Name = "repositoryItemCinemaIcon";
            this.repositoryItemCinemaIcon.NullText = "Click right mouse button for loading image, then click \"Load\"";
            this.repositoryItemCinemaIcon.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.repositoryItemCinemaIcon.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 510);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridShows;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 490);
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
            this.labelControl.Text = "Shows";
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
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colShwId,
            this.layoutViewField_colShwDesc,
            this.layoutViewField_colShwPerformer,
            this.layoutViewField_colShwIcon,
            this.layoutViewField_colShwName});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 0;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // layoutViewField_colShwId
            // 
            this.layoutViewField_colShwId.EditorPreferredWidth = 105;
            this.layoutViewField_colShwId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colShwId.Name = "layoutViewField_colShwId";
            this.layoutViewField_colShwId.Size = new System.Drawing.Size(117, 45);
            this.layoutViewField_colShwId.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_colShwId.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colShwId.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutViewField_colShwDesc
            // 
            this.layoutViewField_colShwDesc.EditorPreferredWidth = 516;
            this.layoutViewField_colShwDesc.Location = new System.Drawing.Point(0, 45);
            this.layoutViewField_colShwDesc.Name = "layoutViewField_colShwDesc";
            this.layoutViewField_colShwDesc.Size = new System.Drawing.Size(528, 45);
            this.layoutViewField_colShwDesc.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_colShwDesc.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colShwDesc.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutViewField_colShwPerformer
            // 
            this.layoutViewField_colShwPerformer.EditorPreferredWidth = 516;
            this.layoutViewField_colShwPerformer.Location = new System.Drawing.Point(0, 90);
            this.layoutViewField_colShwPerformer.Name = "layoutViewField_colShwPerformer";
            this.layoutViewField_colShwPerformer.Size = new System.Drawing.Size(528, 45);
            this.layoutViewField_colShwPerformer.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_colShwPerformer.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colShwPerformer.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutViewField_colShwIcon
            // 
            this.layoutViewField_colShwIcon.EditorPreferredWidth = 516;
            this.layoutViewField_colShwIcon.Location = new System.Drawing.Point(0, 135);
            this.layoutViewField_colShwIcon.Name = "layoutViewField_colShwIcon";
            this.layoutViewField_colShwIcon.Size = new System.Drawing.Size(528, 306);
            this.layoutViewField_colShwIcon.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_colShwIcon.StartNewLine = true;
            this.layoutViewField_colShwIcon.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colShwIcon.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutViewField_colShwName
            // 
            this.layoutViewField_colShwName.EditorPreferredWidth = 399;
            this.layoutViewField_colShwName.Location = new System.Drawing.Point(117, 0);
            this.layoutViewField_colShwName.Name = "layoutViewField_colShwName";
            this.layoutViewField_colShwName.Size = new System.Drawing.Size(411, 45);
            this.layoutViewField_colShwName.Spacing = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutViewField_colShwName.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_colShwName.TextSize = new System.Drawing.Size(75, 13);
            // 
            // Shows
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.Name = "Shows";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridShows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewShows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCinemaIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colShwId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colShwDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colShwPerformer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colShwIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colShwName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridShows;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutViewShows;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colShwId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colShwName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colShwDesc;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colShwPerformer;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colShwIcon;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemCinemaIcon;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colShwId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colShwName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colShwDesc;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colShwPerformer;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colShwIcon;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}
