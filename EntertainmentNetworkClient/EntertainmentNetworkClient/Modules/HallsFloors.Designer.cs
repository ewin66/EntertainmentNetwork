namespace EntertainmentNetworkClient.Modules
{
    partial class HallsFloors
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemCinema = new DevExpress.XtraLayout.LayoutControlItem();
            this.lookUpEditCinemas = new DevExpress.XtraEditors.LookUpEdit();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridFloors = new DevExpress.XtraGrid.GridControl();
            this.gridViewFloors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFloorId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHallId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFloorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridHalls = new DevExpress.XtraGrid.GridControl();
            this.gridHallsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCinemaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHalId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHalName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHalSitscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.layoutControlGroupFloors = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupHalls = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCinemas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFloors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFloors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHallsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupFloors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupHalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
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
            this.labelControl.Text = "Halls and Floors";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.ExpandButtonVisible = true;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemCinema,
            this.layoutControlGroupFloors,
            this.layoutControlGroupHalls,
            this.splitterItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 510);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemCinema
            // 
            this.layoutControlItemCinema.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItemCinema.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItemCinema.Control = this.lookUpEditCinemas;
            this.layoutControlItemCinema.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemCinema.Name = "layoutControlItemCinema";
            this.layoutControlItemCinema.Size = new System.Drawing.Size(780, 28);
            this.layoutControlItemCinema.Text = "Cinema:";
            this.layoutControlItemCinema.TextSize = new System.Drawing.Size(53, 18);
            // 
            // lookUpEditCinemas
            // 
            this.lookUpEditCinemas.Location = new System.Drawing.Point(68, 12);
            this.lookUpEditCinemas.Name = "lookUpEditCinemas";
            this.lookUpEditCinemas.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lookUpEditCinemas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lookUpEditCinemas.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEditCinemas.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditCinemas.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditCinemas.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpEditCinemas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lookUpEditCinemas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCinemas.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CinName", "Cin Name", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CinId", "Cin Id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CinAddress", "Cin Address", 86, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CinIcon", "Cin Icon", 63, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CityId", "City Id", 53, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)});
            this.lookUpEditCinemas.Properties.DisplayMember = "CinName";
            this.lookUpEditCinemas.Properties.ValueMember = "CinId";
            this.lookUpEditCinemas.Size = new System.Drawing.Size(720, 24);
            this.lookUpEditCinemas.StyleController = this.dataLayoutControl1;
            this.lookUpEditCinemas.TabIndex = 7;
            this.lookUpEditCinemas.EditValueChanged += new System.EventHandler(this.LookUpEditCinemas_EditValueChanged);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.gridFloors);
            this.dataLayoutControl1.Controls.Add(this.lookUpEditCinemas);
            this.dataLayoutControl1.Controls.Add(this.gridHalls);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(771, 311, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 510);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // gridFloors
            // 
            this.gridFloors.DataMember = null;
            this.gridFloors.Location = new System.Drawing.Point(16, 257);
            this.gridFloors.MainView = this.gridViewFloors;
            this.gridFloors.Name = "gridFloors";
            this.gridFloors.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4});
            this.gridFloors.Size = new System.Drawing.Size(768, 237);
            this.gridFloors.TabIndex = 8;
            this.gridFloors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFloors});
            this.gridFloors.Click += new System.EventHandler(this.layoutControlGroupFloors_Click);
            // 
            // gridViewFloors
            // 
            this.gridViewFloors.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridViewFloors.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewFloors.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridViewFloors.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewFloors.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewFloors.Appearance.Row.Options.UseFont = true;
            this.gridViewFloors.Appearance.SelectedRow.BackColor = System.Drawing.Color.White;
            this.gridViewFloors.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewFloors.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridViewFloors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFloorId,
            this.colHallId,
            this.colFloorName});
            this.gridViewFloors.GridControl = this.gridFloors;
            this.gridViewFloors.Name = "gridViewFloors";
            this.gridViewFloors.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewFloors.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewFloors.OptionsView.ShowGroupPanel = false;
            this.gridViewFloors.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.FloorsView_InitNewRow);
            this.gridViewFloors.GotFocus += new System.EventHandler(this.layoutControlGroupFloors_Click);
            // 
            // colFloorId
            // 
            this.colFloorId.FieldName = "FloorId";
            this.colFloorId.Name = "colFloorId";
            this.colFloorId.OptionsColumn.ReadOnly = true;
            this.colFloorId.Visible = true;
            this.colFloorId.VisibleIndex = 0;
            // 
            // colHallId
            // 
            this.colHallId.FieldName = "HallId";
            this.colHallId.Name = "colHallId";
            // 
            // colFloorName
            // 
            this.colFloorName.FieldName = "FloorName";
            this.colFloorName.Name = "colFloorName";
            this.colFloorName.Visible = true;
            this.colFloorName.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // gridHalls
            // 
            gridLevelNode1.RelationName = "Sits";
            this.gridHalls.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridHalls.Location = new System.Drawing.Point(16, 68);
            this.gridHalls.MainView = this.gridHallsView;
            this.gridHalls.Name = "gridHalls";
            this.gridHalls.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gridHalls.Size = new System.Drawing.Size(768, 148);
            this.gridHalls.TabIndex = 5;
            this.gridHalls.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridHallsView});
            this.gridHalls.Click += new System.EventHandler(this.layoutControlGroupHalls_Click);
            // 
            // gridHallsView
            // 
            this.gridHallsView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridHallsView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridHallsView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridHallsView.Appearance.OddRow.Options.UseBackColor = true;
            this.gridHallsView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridHallsView.Appearance.Row.Options.UseFont = true;
            this.gridHallsView.Appearance.SelectedRow.BackColor = System.Drawing.Color.White;
            this.gridHallsView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridHallsView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridHallsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCinemaId,
            this.colHalId,
            this.colHalName,
            this.colHalSitscount});
            this.gridHallsView.GridControl = this.gridHalls;
            this.gridHallsView.Name = "gridHallsView";
            this.gridHallsView.OptionsView.EnableAppearanceOddRow = true;
            this.gridHallsView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridHallsView.OptionsView.ShowGroupPanel = false;
            this.gridHallsView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.HallsView_InitNewRow);
            this.gridHallsView.GotFocus += new System.EventHandler(this.layoutControlGroupHalls_Click);
            // 
            // colCinemaId
            // 
            this.colCinemaId.FieldName = "CinemaId";
            this.colCinemaId.Name = "colCinemaId";
            // 
            // colHalId
            // 
            this.colHalId.FieldName = "HalId";
            this.colHalId.Name = "colHalId";
            this.colHalId.OptionsColumn.ReadOnly = true;
            this.colHalId.Visible = true;
            this.colHalId.VisibleIndex = 0;
            // 
            // colHalName
            // 
            this.colHalName.FieldName = "HalName";
            this.colHalName.Name = "colHalName";
            this.colHalName.Visible = true;
            this.colHalName.VisibleIndex = 1;
            // 
            // colHalSitscount
            // 
            this.colHalSitscount.FieldName = "HalSitscount";
            this.colHalSitscount.Name = "colHalSitscount";
            this.colHalSitscount.Visible = true;
            this.colHalSitscount.VisibleIndex = 2;
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
            // layoutControlGroupFloors
            // 
            this.layoutControlGroupFloors.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.layoutControlGroupFloors.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroupFloors.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Floors", "", DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", true, -1, false, null, true, false, true, null, null, -1)});
            this.layoutControlGroupFloors.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted;
            this.layoutControlGroupFloors.ExpandButtonVisible = true;
            this.layoutControlGroupFloors.ExpandOnDoubleClick = true;
            this.layoutControlGroupFloors.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroupFloors.Location = new System.Drawing.Point(0, 217);
            this.layoutControlGroupFloors.Name = "layoutControlGroupFloors";
            this.layoutControlGroupFloors.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlGroupFloors.Size = new System.Drawing.Size(780, 273);
            this.layoutControlGroupFloors.TextVisible = false;
            this.layoutControlGroupFloors.Click += new System.EventHandler(this.layoutControlGroupFloors_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridFloors;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(772, 241);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroupHalls
            // 
            this.layoutControlGroupHalls.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.layoutControlGroupHalls.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroupHalls.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Halls", "", DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", true, -1, false, null, true, false, true, null, null, -1)});
            this.layoutControlGroupHalls.ExpandButtonVisible = true;
            this.layoutControlGroupHalls.ExpandOnDoubleClick = true;
            this.layoutControlGroupHalls.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroupHalls.Location = new System.Drawing.Point(0, 28);
            this.layoutControlGroupHalls.Name = "layoutControlGroupHalls";
            this.layoutControlGroupHalls.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlGroupHalls.Size = new System.Drawing.Size(780, 184);
            this.layoutControlGroupHalls.TextVisible = false;
            this.layoutControlGroupHalls.Click += new System.EventHandler(this.layoutControlGroupHalls_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridHalls;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(772, 152);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 212);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(780, 5);
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
            // HallsFloors
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.Name = "HallsFloors";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCinemas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFloors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFloors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHallsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupFloors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupHalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraGrid.GridControl gridHalls;
        private DevExpress.XtraGrid.Views.Grid.GridView gridHallsView;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCinema;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCinemas;
        private DevExpress.XtraGrid.Columns.GridColumn colCinemaId;
        private DevExpress.XtraGrid.Columns.GridColumn colHalId;
        private DevExpress.XtraGrid.Columns.GridColumn colHalName;
        private DevExpress.XtraGrid.Columns.GridColumn colHalSitscount;
        private DevExpress.XtraGrid.GridControl gridFloors;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFloors;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupFloors;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupHalls;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colFloorId;
        private DevExpress.XtraGrid.Columns.GridColumn colHallId;
        private DevExpress.XtraGrid.Columns.GridColumn colFloorName;
    }
}
