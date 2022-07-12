namespace BussinessInfo
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.importGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.exportGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.calendarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.tasksItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navbarImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.navbarImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.schedulerSplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTTDNTinhThanh = new System.Windows.Forms.TabPage();
            this.gridControlTinhThanh = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSoThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChiCongTy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NganhNgheTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.popupControlContainer2 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.buttonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.someLabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.someLabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.iHelp = new DevExpress.XtraBars.BarButtonItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.txtStatus1 = new DevExpress.XtraBars.BarStaticItem();
            this.txtStatus2 = new DevExpress.XtraBars.BarStaticItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.editAppointmentQueryItem1 = new DevExpress.XtraScheduler.UI.EditAppointmentQueryItem();
            this.editOccurrenceUICommandItem1 = new DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem();
            this.editSeriesUICommandItem1 = new DevExpress.XtraScheduler.UI.EditSeriesUICommandItem();
            this.deleteAppointmentsItem1 = new DevExpress.XtraScheduler.UI.DeleteAppointmentsItem();
            this.deleteOccurrenceItem1 = new DevExpress.XtraScheduler.UI.DeleteOccurrenceItem();
            this.deleteSeriesItem1 = new DevExpress.XtraScheduler.UI.DeleteSeriesItem();
            this.splitAppointmentItem1 = new DevExpress.XtraScheduler.UI.SplitAppointmentItem();
            this.changeAppointmentStatusItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem();
            this.changeAppointmentLabelItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem();
            this.toggleRecurrenceItem1 = new DevExpress.XtraScheduler.UI.ToggleRecurrenceItem();
            this.changeAppointmentReminderItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem();
            this.repositoryItemDuration1 = new DevExpress.XtraScheduler.UI.RepositoryItemDuration();
            this.switchToDayViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToDayViewItem();
            this.switchToWorkWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem();
            this.switchToWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWeekViewItem();
            this.switchToFullWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem();
            this.switchToMonthViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToMonthViewItem();
            this.switchToTimelineViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem();
            this.switchToGanttViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToGanttViewItem();
            this.switchTimeScalesItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesItem();
            this.changeScaleWidthItem1 = new DevExpress.XtraScheduler.UI.ChangeScaleWidthItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.switchTimeScalesCaptionItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem();
            this.switchCompressWeekendItem1 = new DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem();
            this.switchShowWorkTimeOnlyItem1 = new DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem();
            this.switchCellsAutoHeightItem1 = new DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem();
            this.changeSnapToCellsUIItem1 = new DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem();
            this.newAppointmentItem1 = new DevExpress.XtraScheduler.UI.NewAppointmentItem();
            this.newRecurringAppointmentItem1 = new DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem();
            this.navigateViewBackwardItem1 = new DevExpress.XtraScheduler.UI.NavigateViewBackwardItem();
            this.navigateViewForwardItem1 = new DevExpress.XtraScheduler.UI.NavigateViewForwardItem();
            this.gotoTodayItem1 = new DevExpress.XtraScheduler.UI.GotoTodayItem();
            this.viewZoomInItem1 = new DevExpress.XtraScheduler.UI.ViewZoomInItem();
            this.viewZoomOutItem1 = new DevExpress.XtraScheduler.UI.ViewZoomOutItem();
            this.groupByNoneItem1 = new DevExpress.XtraScheduler.UI.GroupByNoneItem();
            this.groupByDateItem1 = new DevExpress.XtraScheduler.UI.GroupByDateItem();
            this.groupByResourceItem1 = new DevExpress.XtraScheduler.UI.GroupByResourceItem();
            this.barKiemTra = new DevExpress.XtraBars.BarButtonItem();
            this.barDongBo = new DevExpress.XtraBars.BarButtonItem();
            this.barXuatExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barIn = new DevExpress.XtraBars.BarButtonItem();
            this.txtStatus3 = new DevExpress.XtraBars.BarStaticItem();
            this.txtStatus4 = new DevExpress.XtraBars.BarStaticItem();
            this.btnDongBoNgoaiLe = new DevExpress.XtraBars.BarButtonItem();
            this.txtMaSoThue = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.fillterMST = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.fillterTag = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.fillterTinhThanh = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.fillterQuanHuyen = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.fillterNganhNghe = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.fillterThuePhaiNop = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnFind = new DevExpress.XtraBars.BarButtonItem();
            this.dongBoTinh = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.dongBoQuan = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox6 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.dongBoBtn = new DevExpress.XtraBars.BarButtonItem();
            this.dongBoXuatExcelBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageSkins = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.skinsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.helpRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.helpRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit9 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridTinhThanh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSolrID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalDoanhNghiep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabTTDNDuLieu = new System.Windows.Forms.TabPage();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.gridData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSoThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.schedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.schedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl)).BeginInit();
            this.schedulerSplitContainerControl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTTDNTinhThanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTinhThanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).BeginInit();
            this.popupControlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTinhThanh)).BeginInit();
            this.tabTTDNDuLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 231);
            this.splitContainerControl.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(9);
            this.splitContainerControl.Panel1.Controls.Add(this.navBarControl);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.schedulerSplitContainerControl);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1650, 756);
            this.splitContainerControl.SplitterPosition = 247;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.importGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.importGroup,
            this.exportGroup});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.calendarItem,
            this.tasksItem});
            this.navBarControl.LargeImages = this.navbarImageCollectionLarge;
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Margin = new System.Windows.Forms.Padding(4);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 247;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(247, 738);
            this.navBarControl.SmallImages = this.navbarImageCollection;
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 1;
            this.navBarControl.Text = "navBarControl1";
            // 
            // importGroup
            // 
            this.importGroup.Caption = "Nhập dữ liệu";
            this.importGroup.Expanded = true;
            this.importGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("importGroup.ImageOptions.LargeImage")));
            this.importGroup.ImageOptions.LargeImageIndex = 0;
            this.importGroup.Name = "importGroup";
            // 
            // exportGroup
            // 
            this.exportGroup.Caption = "Khai thác";
            this.exportGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("exportGroup.ImageOptions.LargeImage")));
            this.exportGroup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.calendarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.tasksItem)});
            this.exportGroup.Name = "exportGroup";
            // 
            // calendarItem
            // 
            this.calendarItem.Caption = "Calendar";
            this.calendarItem.ImageOptions.SmallImageIndex = 4;
            this.calendarItem.Name = "calendarItem";
            // 
            // tasksItem
            // 
            this.tasksItem.Caption = "Tasks";
            this.tasksItem.ImageOptions.SmallImageIndex = 5;
            this.tasksItem.Name = "tasksItem";
            this.tasksItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.TasksItem_LinkClicked);
            // 
            // navbarImageCollectionLarge
            // 
            this.navbarImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.navbarImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollectionLarge.ImageStream")));
            this.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_32x32.png");
            this.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_32x32.png");
            // 
            // navbarImageCollection
            // 
            this.navbarImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("navbarImageCollection.ImageStream")));
            this.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png");
            this.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png");
            // 
            // schedulerSplitContainerControl
            // 
            this.schedulerSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.schedulerSplitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerSplitContainerControl.Margin = new System.Windows.Forms.Padding(4);
            this.schedulerSplitContainerControl.Name = "schedulerSplitContainerControl";
            this.schedulerSplitContainerControl.Panel1.Controls.Add(this.tabControl1);
            this.schedulerSplitContainerControl.Panel1.Text = "Panel1";
            this.schedulerSplitContainerControl.Panel2.Text = "Panel2";
            this.schedulerSplitContainerControl.Size = new System.Drawing.Size(1370, 738);
            this.schedulerSplitContainerControl.SplitterPosition = 0;
            this.schedulerSplitContainerControl.TabIndex = 2;
            this.schedulerSplitContainerControl.Text = "splitContainerControl1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTTDNTinhThanh);
            this.tabControl1.Controls.Add(this.tabTTDNDuLieu);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1355, 738);
            this.tabControl1.TabIndex = 1;
            // 
            // tabTTDNTinhThanh
            // 
            this.tabTTDNTinhThanh.Controls.Add(this.gridControlTinhThanh);
            this.tabTTDNTinhThanh.Location = new System.Drawing.Point(4, 28);
            this.tabTTDNTinhThanh.Margin = new System.Windows.Forms.Padding(4);
            this.tabTTDNTinhThanh.Name = "tabTTDNTinhThanh";
            this.tabTTDNTinhThanh.Padding = new System.Windows.Forms.Padding(4);
            this.tabTTDNTinhThanh.Size = new System.Drawing.Size(1347, 706);
            this.tabTTDNTinhThanh.TabIndex = 0;
            this.tabTTDNTinhThanh.Text = "Chọn tỉnh thành";
            this.tabTTDNTinhThanh.UseVisualStyleBackColor = true;
            // 
            // gridControlTinhThanh
            // 
            this.gridControlTinhThanh.DataMember = "DMDiaBan";
            this.gridControlTinhThanh.DataSource = this.sqlDataSource2;
            this.gridControlTinhThanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTinhThanh.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlTinhThanh.Location = new System.Drawing.Point(4, 4);
            this.gridControlTinhThanh.MainView = this.gridDanhSach;
            this.gridControlTinhThanh.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlTinhThanh.MenuManager = this.ribbonControl;
            this.gridControlTinhThanh.Name = "gridControlTinhThanh";
            this.gridControlTinhThanh.Size = new System.Drawing.Size(1339, 698);
            this.gridControlTinhThanh.TabIndex = 0;
            this.gridControlTinhThanh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDanhSach,
            this.gridTinhThanh});
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "DefaultConnection";
            this.sqlDataSource2.Name = "sqlDataSource2";
            columnExpression1.ColumnName = "ID";
            table1.Name = "DMDiaBan";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Title";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "SolrID";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "TotalDoanhNghiep";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.FilterString = "[DMDiaBan.Type] = 1";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "DMDiaBan";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // gridDanhSach
            // 
            this.gridDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSoThue,
            this.Title,
            this.DiaChiCongTy,
            this.NganhNgheTitle});
            this.gridDanhSach.DetailHeight = 512;
            this.gridDanhSach.FixedLineWidth = 3;
            this.gridDanhSach.GridControl = this.gridControlTinhThanh;
            this.gridDanhSach.IndicatorWidth = 75;
            this.gridDanhSach.Name = "gridDanhSach";
            this.gridDanhSach.OptionsSelection.MultiSelect = true;
            this.gridDanhSach.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridDanhSach.OptionsView.ShowGroupPanel = false;
            this.gridDanhSach.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.GridDanhSach_CustomDrawRowIndicator);
            // 
            // MaSoThue
            // 
            this.MaSoThue.Caption = "Mã số thuế";
            this.MaSoThue.FieldName = "MaSoThue";
            this.MaSoThue.MinWidth = 30;
            this.MaSoThue.Name = "MaSoThue";
            this.MaSoThue.Visible = true;
            this.MaSoThue.VisibleIndex = 1;
            this.MaSoThue.Width = 112;
            // 
            // Title
            // 
            this.Title.Caption = "Tên";
            this.Title.FieldName = "Title";
            this.Title.MinWidth = 30;
            this.Title.Name = "Title";
            this.Title.Visible = true;
            this.Title.VisibleIndex = 2;
            this.Title.Width = 112;
            // 
            // DiaChiCongTy
            // 
            this.DiaChiCongTy.Caption = "Địa chỉ";
            this.DiaChiCongTy.FieldName = "DiaChiCongTy";
            this.DiaChiCongTy.MinWidth = 30;
            this.DiaChiCongTy.Name = "DiaChiCongTy";
            this.DiaChiCongTy.Visible = true;
            this.DiaChiCongTy.VisibleIndex = 4;
            this.DiaChiCongTy.Width = 112;
            // 
            // NganhNgheTitle
            // 
            this.NganhNgheTitle.Caption = "Lĩnh vực hoạt động";
            this.NganhNgheTitle.FieldName = "NganhNgheTitle";
            this.NganhNgheTitle.MinWidth = 30;
            this.NganhNgheTitle.Name = "NganhNgheTitle";
            this.NganhNgheTitle.Visible = true;
            this.NganhNgheTitle.VisibleIndex = 3;
            this.NganhNgheTitle.Width = 112;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.appMenu;
            this.ribbonControl.ApplicationButtonText = null;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Images = this.ribbonImageCollection;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.SearchEditItem,
            this.ribbonControl.ExpandCollapseItem,
            this.iExit,
            this.iHelp,
            this.iAbout,
            this.txtStatus1,
            this.txtStatus2,
            this.rgbiSkins,
            this.editAppointmentQueryItem1,
            this.editOccurrenceUICommandItem1,
            this.editSeriesUICommandItem1,
            this.deleteAppointmentsItem1,
            this.deleteOccurrenceItem1,
            this.deleteSeriesItem1,
            this.splitAppointmentItem1,
            this.changeAppointmentStatusItem1,
            this.changeAppointmentLabelItem1,
            this.toggleRecurrenceItem1,
            this.changeAppointmentReminderItem1,
            this.switchToDayViewItem1,
            this.switchToWorkWeekViewItem1,
            this.switchToWeekViewItem1,
            this.switchToFullWeekViewItem1,
            this.switchToMonthViewItem1,
            this.switchToTimelineViewItem1,
            this.switchToGanttViewItem1,
            this.switchTimeScalesItem1,
            this.changeScaleWidthItem1,
            this.switchTimeScalesCaptionItem1,
            this.switchCompressWeekendItem1,
            this.switchShowWorkTimeOnlyItem1,
            this.switchCellsAutoHeightItem1,
            this.changeSnapToCellsUIItem1,
            this.newAppointmentItem1,
            this.newRecurringAppointmentItem1,
            this.navigateViewBackwardItem1,
            this.navigateViewForwardItem1,
            this.gotoTodayItem1,
            this.viewZoomInItem1,
            this.viewZoomOutItem1,
            this.groupByNoneItem1,
            this.groupByDateItem1,
            this.groupByResourceItem1,
            this.barKiemTra,
            this.barDongBo,
            this.barXuatExcel,
            this.barIn,
            this.txtStatus3,
            this.txtStatus4,
            this.btnDongBoNgoaiLe,
            this.txtMaSoThue,
            this.fillterMST,
            this.fillterTag,
            this.fillterTinhThanh,
            this.fillterQuanHuyen,
            this.fillterNganhNghe,
            this.fillterThuePhaiNop,
            this.btnFind,
            this.dongBoTinh,
            this.dongBoQuan,
            this.dongBoBtn,
            this.dongBoXuatExcelBtn});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl.MaxItemId = 129;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.iAbout);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPageSkins,
            this.helpRibbonPage});
            this.ribbonControl.QuickToolbarItemLinks.Add(this.iHelp);
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDuration1,
            this.repositoryItemSpinEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemTextEdit1,
            this.repositoryItemFontEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemTextEdit5,
            this.repositoryItemTextEdit6,
            this.repositoryItemTextEdit7,
            this.repositoryItemTextEdit8,
            this.repositoryItemTextEdit9,
            this.repositoryItemComboBox3,
            this.repositoryItemComboBox4,
            this.repositoryItemComboBox5,
            this.repositoryItemComboBox6});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.Size = new System.Drawing.Size(1650, 231);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // appMenu
            // 
            this.appMenu.BottomPaneControlContainer = this.popupControlContainer2;
            this.appMenu.ItemLinks.Add(this.iExit);
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribbonControl;
            this.appMenu.RightPaneControlContainer = this.popupControlContainer1;
            this.appMenu.ShowRightPane = true;
            // 
            // popupControlContainer2
            // 
            this.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer2.Appearance.Options.UseBackColor = true;
            this.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer2.Controls.Add(this.buttonEdit);
            this.popupControlContainer2.Location = new System.Drawing.Point(357, 422);
            this.popupControlContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.popupControlContainer2.Name = "popupControlContainer2";
            this.popupControlContainer2.Ribbon = this.ribbonControl;
            this.popupControlContainer2.Size = new System.Drawing.Size(177, 41);
            this.popupControlContainer2.TabIndex = 3;
            this.popupControlContainer2.Visible = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.EditValue = "Some Text";
            this.buttonEdit.Location = new System.Drawing.Point(4, 7);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.MenuManager = this.ribbonControl;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit.Size = new System.Drawing.Size(150, 28);
            this.buttonEdit.TabIndex = 0;
            // 
            // iExit
            // 
            this.iExit.Caption = "Exit";
            this.iExit.Description = "Closes this program after prompting you to save unsaved data.";
            this.iExit.Hint = "Closes this program after prompting you to save unsaved data";
            this.iExit.Id = 20;
            this.iExit.ImageOptions.ImageIndex = 6;
            this.iExit.ImageOptions.LargeImageIndex = 6;
            this.iExit.Name = "iExit";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer1.Appearance.Options.UseBackColor = true;
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.someLabelControl2);
            this.popupControlContainer1.Controls.Add(this.someLabelControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(166, 288);
            this.popupControlContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Ribbon = this.ribbonControl;
            this.popupControlContainer1.Size = new System.Drawing.Size(114, 102);
            this.popupControlContainer1.TabIndex = 2;
            this.popupControlContainer1.Visible = false;
            // 
            // someLabelControl2
            // 
            this.someLabelControl2.Location = new System.Drawing.Point(4, 83);
            this.someLabelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.someLabelControl2.Name = "someLabelControl2";
            this.someLabelControl2.Size = new System.Drawing.Size(74, 19);
            this.someLabelControl2.TabIndex = 0;
            this.someLabelControl2.Text = "Some Info";
            // 
            // someLabelControl1
            // 
            this.someLabelControl1.Location = new System.Drawing.Point(4, 4);
            this.someLabelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.someLabelControl1.Name = "someLabelControl1";
            this.someLabelControl1.Size = new System.Drawing.Size(74, 19);
            this.someLabelControl1.TabIndex = 0;
            this.someLabelControl1.Text = "Some Info";
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_Exit_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Content_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Info_16x16.png");
            // 
            // iHelp
            // 
            this.iHelp.Caption = "Hướng dẫn";
            this.iHelp.Description = "Start the program help system.";
            this.iHelp.Hint = "Start the program help system";
            this.iHelp.Id = 22;
            this.iHelp.ImageOptions.ImageIndex = 7;
            this.iHelp.ImageOptions.LargeImageIndex = 7;
            this.iHelp.Name = "iHelp";
            // 
            // iAbout
            // 
            this.iAbout.Caption = "Giới thiệu";
            this.iAbout.Description = "Displays general program information.";
            this.iAbout.Hint = "Displays general program information";
            this.iAbout.Id = 24;
            this.iAbout.ImageOptions.ImageIndex = 8;
            this.iAbout.ImageOptions.LargeImageIndex = 8;
            this.iAbout.Name = "iAbout";
            // 
            // txtStatus1
            // 
            this.txtStatus1.Id = 31;
            this.txtStatus1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtStatus1.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtStatus1.ItemAppearance.Normal.Options.UseFont = true;
            this.txtStatus1.ItemAppearance.Normal.Options.UseForeColor = true;
            this.txtStatus1.Name = "txtStatus1";
            // 
            // txtStatus2
            // 
            this.txtStatus2.Id = 32;
            this.txtStatus2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtStatus2.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtStatus2.ItemAppearance.Normal.Options.UseFont = true;
            this.txtStatus2.ItemAppearance.Normal.Options.UseForeColor = true;
            this.txtStatus2.Name = "txtStatus2";
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            // 
            // 
            // 
            this.rgbiSkins.Gallery.AllowHoverImages = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.ColumnCount = 4;
            this.rgbiSkins.Gallery.FixedHoverImageSize = false;
            this.rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
            this.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.rgbiSkins.Gallery.RowCount = 4;
            this.rgbiSkins.Id = 60;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // editAppointmentQueryItem1
            // 
            this.editAppointmentQueryItem1.Caption = "&Open";
            this.editAppointmentQueryItem1.Enabled = false;
            this.editAppointmentQueryItem1.Id = 62;
            this.editAppointmentQueryItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.editOccurrenceUICommandItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.editSeriesUICommandItem1)});
            this.editAppointmentQueryItem1.Name = "editAppointmentQueryItem1";
            this.editAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // editOccurrenceUICommandItem1
            // 
            this.editOccurrenceUICommandItem1.Caption = "Open Occurrence";
            this.editOccurrenceUICommandItem1.Enabled = false;
            this.editOccurrenceUICommandItem1.Id = 63;
            this.editOccurrenceUICommandItem1.Name = "editOccurrenceUICommandItem1";
            // 
            // editSeriesUICommandItem1
            // 
            this.editSeriesUICommandItem1.Caption = "Open Series";
            this.editSeriesUICommandItem1.Enabled = false;
            this.editSeriesUICommandItem1.Id = 64;
            this.editSeriesUICommandItem1.Name = "editSeriesUICommandItem1";
            // 
            // deleteAppointmentsItem1
            // 
            this.deleteAppointmentsItem1.Caption = "&Delete";
            this.deleteAppointmentsItem1.Enabled = false;
            this.deleteAppointmentsItem1.Id = 65;
            this.deleteAppointmentsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteOccurrenceItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteSeriesItem1)});
            this.deleteAppointmentsItem1.Name = "deleteAppointmentsItem1";
            this.deleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // deleteOccurrenceItem1
            // 
            this.deleteOccurrenceItem1.Caption = "Delete Occurrence";
            this.deleteOccurrenceItem1.Enabled = false;
            this.deleteOccurrenceItem1.Id = 66;
            this.deleteOccurrenceItem1.Name = "deleteOccurrenceItem1";
            // 
            // deleteSeriesItem1
            // 
            this.deleteSeriesItem1.Caption = "Delete Series";
            this.deleteSeriesItem1.Enabled = false;
            this.deleteSeriesItem1.Id = 67;
            this.deleteSeriesItem1.Name = "deleteSeriesItem1";
            // 
            // splitAppointmentItem1
            // 
            this.splitAppointmentItem1.Caption = "Split";
            this.splitAppointmentItem1.Enabled = false;
            this.splitAppointmentItem1.Id = 68;
            this.splitAppointmentItem1.Name = "splitAppointmentItem1";
            // 
            // changeAppointmentStatusItem1
            // 
            this.changeAppointmentStatusItem1.Caption = "&Show Time As";
            this.changeAppointmentStatusItem1.Enabled = false;
            this.changeAppointmentStatusItem1.Id = 69;
            this.changeAppointmentStatusItem1.Name = "changeAppointmentStatusItem1";
            // 
            // changeAppointmentLabelItem1
            // 
            this.changeAppointmentLabelItem1.Caption = "&Label As";
            this.changeAppointmentLabelItem1.Enabled = false;
            this.changeAppointmentLabelItem1.Id = 70;
            this.changeAppointmentLabelItem1.Name = "changeAppointmentLabelItem1";
            // 
            // toggleRecurrenceItem1
            // 
            this.toggleRecurrenceItem1.Caption = "Recurrence";
            this.toggleRecurrenceItem1.Enabled = false;
            this.toggleRecurrenceItem1.Id = 71;
            this.toggleRecurrenceItem1.Name = "toggleRecurrenceItem1";
            // 
            // changeAppointmentReminderItem1
            // 
            this.changeAppointmentReminderItem1.Caption = "Reminder";
            this.changeAppointmentReminderItem1.Edit = this.repositoryItemDuration1;
            this.changeAppointmentReminderItem1.Enabled = false;
            this.changeAppointmentReminderItem1.Id = 72;
            this.changeAppointmentReminderItem1.Name = "changeAppointmentReminderItem1";
            // 
            // repositoryItemDuration1
            // 
            this.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDuration1.AutoComplete = false;
            this.repositoryItemDuration1.AutoHeight = false;
            this.repositoryItemDuration1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDuration1.DisabledStateText = null;
            this.repositoryItemDuration1.Name = "repositoryItemDuration1";
            this.repositoryItemDuration1.ShowEmptyItem = true;
            this.repositoryItemDuration1.ValidateOnEnterKey = true;
            // 
            // switchToDayViewItem1
            // 
            this.switchToDayViewItem1.Caption = "&Day View";
            this.switchToDayViewItem1.Enabled = false;
            this.switchToDayViewItem1.Id = 73;
            this.switchToDayViewItem1.Name = "switchToDayViewItem1";
            // 
            // switchToWorkWeekViewItem1
            // 
            this.switchToWorkWeekViewItem1.Caption = "Wo&rk Week View";
            this.switchToWorkWeekViewItem1.Enabled = false;
            this.switchToWorkWeekViewItem1.Id = 74;
            this.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1";
            // 
            // switchToWeekViewItem1
            // 
            this.switchToWeekViewItem1.Caption = "&Week View";
            this.switchToWeekViewItem1.Enabled = false;
            this.switchToWeekViewItem1.Id = 75;
            this.switchToWeekViewItem1.Name = "switchToWeekViewItem1";
            // 
            // switchToFullWeekViewItem1
            // 
            this.switchToFullWeekViewItem1.Caption = "&Full Week View";
            this.switchToFullWeekViewItem1.Enabled = false;
            this.switchToFullWeekViewItem1.Id = 76;
            this.switchToFullWeekViewItem1.Name = "switchToFullWeekViewItem1";
            // 
            // switchToMonthViewItem1
            // 
            this.switchToMonthViewItem1.Caption = "&Month View";
            this.switchToMonthViewItem1.Enabled = false;
            this.switchToMonthViewItem1.Id = 77;
            this.switchToMonthViewItem1.Name = "switchToMonthViewItem1";
            // 
            // switchToTimelineViewItem1
            // 
            this.switchToTimelineViewItem1.Caption = "&Timeline View";
            this.switchToTimelineViewItem1.Enabled = false;
            this.switchToTimelineViewItem1.Id = 78;
            this.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1";
            // 
            // switchToGanttViewItem1
            // 
            this.switchToGanttViewItem1.Caption = "&Gantt View";
            this.switchToGanttViewItem1.Enabled = false;
            this.switchToGanttViewItem1.Id = 79;
            this.switchToGanttViewItem1.Name = "switchToGanttViewItem1";
            // 
            // switchTimeScalesItem1
            // 
            this.switchTimeScalesItem1.Caption = "&Time Scales";
            this.switchTimeScalesItem1.Enabled = false;
            this.switchTimeScalesItem1.Id = 80;
            this.switchTimeScalesItem1.Name = "switchTimeScalesItem1";
            // 
            // changeScaleWidthItem1
            // 
            this.changeScaleWidthItem1.Caption = "Scale Width";
            this.changeScaleWidthItem1.Edit = this.repositoryItemSpinEdit1;
            this.changeScaleWidthItem1.Enabled = false;
            this.changeScaleWidthItem1.Id = 81;
            this.changeScaleWidthItem1.Name = "changeScaleWidthItem1";
            this.changeScaleWidthItem1.UseCommandCaption = true;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // switchTimeScalesCaptionItem1
            // 
            this.switchTimeScalesCaptionItem1.Caption = "Time Scale &Captions";
            this.switchTimeScalesCaptionItem1.Enabled = false;
            this.switchTimeScalesCaptionItem1.Id = 82;
            this.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1";
            // 
            // switchCompressWeekendItem1
            // 
            this.switchCompressWeekendItem1.Caption = "Compress Weekend";
            this.switchCompressWeekendItem1.Enabled = false;
            this.switchCompressWeekendItem1.Id = 83;
            this.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1";
            // 
            // switchShowWorkTimeOnlyItem1
            // 
            this.switchShowWorkTimeOnlyItem1.Caption = "Working Hours";
            this.switchShowWorkTimeOnlyItem1.Enabled = false;
            this.switchShowWorkTimeOnlyItem1.Id = 84;
            this.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1";
            // 
            // switchCellsAutoHeightItem1
            // 
            this.switchCellsAutoHeightItem1.Caption = "Cell Auto Height";
            this.switchCellsAutoHeightItem1.Enabled = false;
            this.switchCellsAutoHeightItem1.Id = 85;
            this.switchCellsAutoHeightItem1.Name = "switchCellsAutoHeightItem1";
            // 
            // changeSnapToCellsUIItem1
            // 
            this.changeSnapToCellsUIItem1.Caption = "Snap to Cells";
            this.changeSnapToCellsUIItem1.Enabled = false;
            this.changeSnapToCellsUIItem1.Id = 86;
            this.changeSnapToCellsUIItem1.Name = "changeSnapToCellsUIItem1";
            // 
            // newAppointmentItem1
            // 
            this.newAppointmentItem1.Caption = "New App&ointment";
            this.newAppointmentItem1.Enabled = false;
            this.newAppointmentItem1.Id = 87;
            this.newAppointmentItem1.Name = "newAppointmentItem1";
            // 
            // newRecurringAppointmentItem1
            // 
            this.newRecurringAppointmentItem1.Caption = "New Recurring &Appointment";
            this.newRecurringAppointmentItem1.Enabled = false;
            this.newRecurringAppointmentItem1.Id = 88;
            this.newRecurringAppointmentItem1.Name = "newRecurringAppointmentItem1";
            // 
            // navigateViewBackwardItem1
            // 
            this.navigateViewBackwardItem1.Caption = "Backward";
            this.navigateViewBackwardItem1.Enabled = false;
            this.navigateViewBackwardItem1.Id = 89;
            this.navigateViewBackwardItem1.Name = "navigateViewBackwardItem1";
            // 
            // navigateViewForwardItem1
            // 
            this.navigateViewForwardItem1.Caption = "Forward";
            this.navigateViewForwardItem1.Enabled = false;
            this.navigateViewForwardItem1.Id = 90;
            this.navigateViewForwardItem1.Name = "navigateViewForwardItem1";
            // 
            // gotoTodayItem1
            // 
            this.gotoTodayItem1.Caption = "Go to &Today";
            this.gotoTodayItem1.Enabled = false;
            this.gotoTodayItem1.Id = 91;
            this.gotoTodayItem1.Name = "gotoTodayItem1";
            // 
            // viewZoomInItem1
            // 
            this.viewZoomInItem1.Caption = "Zoom In";
            this.viewZoomInItem1.Enabled = false;
            this.viewZoomInItem1.Id = 92;
            this.viewZoomInItem1.Name = "viewZoomInItem1";
            // 
            // viewZoomOutItem1
            // 
            this.viewZoomOutItem1.Caption = "Zoom Out";
            this.viewZoomOutItem1.Enabled = false;
            this.viewZoomOutItem1.Id = 93;
            this.viewZoomOutItem1.Name = "viewZoomOutItem1";
            // 
            // groupByNoneItem1
            // 
            this.groupByNoneItem1.Caption = "&Group by None";
            this.groupByNoneItem1.Enabled = false;
            this.groupByNoneItem1.Id = 94;
            this.groupByNoneItem1.Name = "groupByNoneItem1";
            // 
            // groupByDateItem1
            // 
            this.groupByDateItem1.Caption = "&Group by Date";
            this.groupByDateItem1.Enabled = false;
            this.groupByDateItem1.Id = 95;
            this.groupByDateItem1.Name = "groupByDateItem1";
            // 
            // groupByResourceItem1
            // 
            this.groupByResourceItem1.Caption = "&Group by Resource";
            this.groupByResourceItem1.Enabled = false;
            this.groupByResourceItem1.Id = 96;
            this.groupByResourceItem1.Name = "groupByResourceItem1";
            // 
            // barKiemTra
            // 
            this.barKiemTra.Caption = "Kiểm tra ngay";
            this.barKiemTra.Id = 102;
            this.barKiemTra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barKiemTra.ImageOptions.Image")));
            this.barKiemTra.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barKiemTra.ImageOptions.LargeImage")));
            this.barKiemTra.Name = "barKiemTra";
            this.barKiemTra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKiemTra_ItemClick);
            // 
            // barDongBo
            // 
            this.barDongBo.Caption = "Đồng bộ ngay";
            this.barDongBo.Id = 103;
            this.barDongBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barDongBo.ImageOptions.Image")));
            this.barDongBo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barDongBo.ImageOptions.LargeImage")));
            this.barDongBo.Name = "barDongBo";
            this.barDongBo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarDongBo_ItemClick);
            // 
            // barXuatExcel
            // 
            this.barXuatExcel.Caption = "Xuất excel";
            this.barXuatExcel.Id = 104;
            this.barXuatExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barXuatExcel.ImageOptions.Image")));
            this.barXuatExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barXuatExcel.ImageOptions.LargeImage")));
            this.barXuatExcel.Name = "barXuatExcel";
            this.barXuatExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barXuatExcel_ItemClick);
            // 
            // barIn
            // 
            this.barIn.Caption = "In";
            this.barIn.Id = 105;
            this.barIn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barIn.ImageOptions.Image")));
            this.barIn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barIn.ImageOptions.LargeImage")));
            this.barIn.Name = "barIn";
            // 
            // txtStatus3
            // 
            this.txtStatus3.Id = 111;
            this.txtStatus3.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtStatus3.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtStatus3.ItemAppearance.Normal.Options.UseFont = true;
            this.txtStatus3.ItemAppearance.Normal.Options.UseForeColor = true;
            this.txtStatus3.Name = "txtStatus3";
            // 
            // txtStatus4
            // 
            this.txtStatus4.Id = 112;
            this.txtStatus4.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtStatus4.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Purple;
            this.txtStatus4.ItemAppearance.Normal.Options.UseFont = true;
            this.txtStatus4.ItemAppearance.Normal.Options.UseForeColor = true;
            this.txtStatus4.Name = "txtStatus4";
            // 
            // btnDongBoNgoaiLe
            // 
            this.btnDongBoNgoaiLe.Caption = "Đồng bộ";
            this.btnDongBoNgoaiLe.Id = 113;
            this.btnDongBoNgoaiLe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBoNgoaiLe.ImageOptions.Image")));
            this.btnDongBoNgoaiLe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDongBoNgoaiLe.ImageOptions.LargeImage")));
            this.btnDongBoNgoaiLe.Name = "btnDongBoNgoaiLe";
            this.btnDongBoNgoaiLe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDongBoNgoaiLe_ItemClick);
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.Caption = "Mã số thuế";
            this.txtMaSoThue.Edit = this.repositoryItemTextEdit2;
            this.txtMaSoThue.EditWidth = 100;
            this.txtMaSoThue.Id = 114;
            this.txtMaSoThue.Name = "txtMaSoThue";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // fillterMST
            // 
            this.fillterMST.Caption = "Mã số thuế";
            this.fillterMST.Edit = this.repositoryItemTextEdit1;
            this.fillterMST.EditHeight = 30;
            this.fillterMST.EditWidth = 100;
            this.fillterMST.Id = 115;
            this.fillterMST.Name = "fillterMST";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // fillterTag
            // 
            this.fillterTag.Caption = "Tag";
            this.fillterTag.Edit = this.repositoryItemTextEdit4;
            this.fillterTag.EditHeight = 30;
            this.fillterTag.EditWidth = 135;
            this.fillterTag.Id = 116;
            this.fillterTag.Name = "fillterTag";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // fillterTinhThanh
            // 
            this.fillterTinhThanh.Caption = "Tỉnh thành";
            this.fillterTinhThanh.Edit = this.repositoryItemComboBox1;
            this.fillterTinhThanh.EditHeight = 30;
            this.fillterTinhThanh.EditWidth = 102;
            this.fillterTinhThanh.Id = 117;
            this.fillterTinhThanh.Name = "fillterTinhThanh";
            this.fillterTinhThanh.EditValueChanged += new System.EventHandler(this.FillterTinhThanh_EditValueChanged);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // fillterQuanHuyen
            // 
            this.fillterQuanHuyen.Caption = "Quận huyện";
            this.fillterQuanHuyen.Edit = this.repositoryItemComboBox2;
            this.fillterQuanHuyen.EditHeight = 30;
            this.fillterQuanHuyen.EditWidth = 94;
            this.fillterQuanHuyen.Id = 118;
            this.fillterQuanHuyen.Name = "fillterQuanHuyen";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // fillterNganhNghe
            // 
            this.fillterNganhNghe.Caption = "Ngành nghề";
            this.fillterNganhNghe.Edit = this.repositoryItemComboBox3;
            this.fillterNganhNghe.EditHeight = 30;
            this.fillterNganhNghe.EditWidth = 210;
            this.fillterNganhNghe.Id = 119;
            this.fillterNganhNghe.Name = "fillterNganhNghe";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // fillterThuePhaiNop
            // 
            this.fillterThuePhaiNop.Caption = "Thuế phải nộp";
            this.fillterThuePhaiNop.Edit = this.repositoryItemComboBox4;
            this.fillterThuePhaiNop.EditHeight = 30;
            this.fillterThuePhaiNop.EditWidth = 200;
            this.fillterThuePhaiNop.Id = 120;
            this.fillterThuePhaiNop.Name = "fillterThuePhaiNop";
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            // 
            // btnFind
            // 
            this.btnFind.Caption = "Tìm kiếm";
            this.btnFind.Id = 121;
            this.btnFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.ImageOptions.Image")));
            this.btnFind.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFind.ImageOptions.LargeImage")));
            this.btnFind.Name = "btnFind";
            this.btnFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnFind_ItemClick);
            // 
            // dongBoTinh
            // 
            this.dongBoTinh.Caption = "Tỉnh ";
            this.dongBoTinh.Edit = this.repositoryItemComboBox5;
            this.dongBoTinh.EditWidth = 150;
            this.dongBoTinh.Id = 125;
            this.dongBoTinh.Name = "dongBoTinh";
            this.dongBoTinh.EditValueChanged += new System.EventHandler(this.DongBoTinh_EditValueChanged);
            // 
            // repositoryItemComboBox5
            // 
            this.repositoryItemComboBox5.AutoHeight = false;
            this.repositoryItemComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox5.Name = "repositoryItemComboBox5";
            // 
            // dongBoQuan
            // 
            this.dongBoQuan.Caption = "Quận";
            this.dongBoQuan.Edit = this.repositoryItemComboBox6;
            this.dongBoQuan.EditWidth = 148;
            this.dongBoQuan.Id = 126;
            this.dongBoQuan.Name = "dongBoQuan";
            // 
            // repositoryItemComboBox6
            // 
            this.repositoryItemComboBox6.AutoHeight = false;
            this.repositoryItemComboBox6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox6.Name = "repositoryItemComboBox6";
            // 
            // dongBoBtn
            // 
            this.dongBoBtn.Caption = "Đồng bộ";
            this.dongBoBtn.Id = 127;
            this.dongBoBtn.ImageOptions.ImageUri.Uri = "Apply";
            this.dongBoBtn.Name = "dongBoBtn";
            this.dongBoBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.dongBoBtn_ItemClick);
            // 
            // dongBoXuatExcelBtn
            // 
            this.dongBoXuatExcelBtn.Caption = "Xuất Excel";
            this.dongBoXuatExcelBtn.Id = 128;
            this.dongBoXuatExcelBtn.ImageOptions.ImageUri.Uri = "PrintDialog";
            this.dongBoXuatExcelBtn.Name = "dongBoXuatExcelBtn";
            this.dongBoXuatExcelBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DongBoXuatExcelBtn_ItemClick);
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Info_32x32.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barKiemTra);
            this.ribbonPageGroup1.ItemLinks.Add(this.barDongBo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Xử lý";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDongBoNgoaiLe);
            this.ribbonPageGroup3.ItemLinks.Add(this.txtMaSoThue);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Đồng bộ ngoại lệ";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.dongBoTinh);
            this.ribbonPageGroup5.ItemLinks.Add(this.dongBoQuan);
            this.ribbonPageGroup5.ItemLinks.Add(this.dongBoBtn);
            this.ribbonPageGroup5.ItemLinks.Add(this.dongBoXuatExcelBtn);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Lấy danh sách theo quận huyện";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Lọc, xuất";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barXuatExcel);
            this.ribbonPageGroup2.ItemLinks.Add(this.barIn);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Xuất dữ liệu";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.fillterMST);
            this.ribbonPageGroup4.ItemLinks.Add(this.fillterTag);
            this.ribbonPageGroup4.ItemLinks.Add(this.fillterTinhThanh);
            this.ribbonPageGroup4.ItemLinks.Add(this.fillterQuanHuyen);
            this.ribbonPageGroup4.ItemLinks.Add(this.fillterNganhNghe);
            this.ribbonPageGroup4.ItemLinks.Add(this.fillterThuePhaiNop);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnFind);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Lọc dữ liệu";
            // 
            // ribbonPageSkins
            // 
            this.ribbonPageSkins.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.skinsRibbonPageGroup});
            this.ribbonPageSkins.Name = "ribbonPageSkins";
            this.ribbonPageSkins.Text = "Giao diện";
            // 
            // skinsRibbonPageGroup
            // 
            this.skinsRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.skinsRibbonPageGroup.ItemLinks.Add(this.rgbiSkins);
            this.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup";
            this.skinsRibbonPageGroup.Text = "Chọn giao diện";
            // 
            // helpRibbonPage
            // 
            this.helpRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.helpRibbonPageGroup});
            this.helpRibbonPage.Name = "helpRibbonPage";
            this.helpRibbonPage.Text = "Trợ giúp";
            // 
            // helpRibbonPageGroup
            // 
            this.helpRibbonPageGroup.ItemLinks.Add(this.iHelp);
            this.helpRibbonPageGroup.ItemLinks.Add(this.iAbout);
            this.helpRibbonPageGroup.Name = "helpRibbonPageGroup";
            this.helpRibbonPageGroup.Text = "Trợ giúp";
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            // 
            // repositoryItemTextEdit6
            // 
            this.repositoryItemTextEdit6.AutoHeight = false;
            this.repositoryItemTextEdit6.Name = "repositoryItemTextEdit6";
            // 
            // repositoryItemTextEdit7
            // 
            this.repositoryItemTextEdit7.AutoHeight = false;
            this.repositoryItemTextEdit7.Name = "repositoryItemTextEdit7";
            // 
            // repositoryItemTextEdit8
            // 
            this.repositoryItemTextEdit8.AutoHeight = false;
            this.repositoryItemTextEdit8.Name = "repositoryItemTextEdit8";
            // 
            // repositoryItemTextEdit9
            // 
            this.repositoryItemTextEdit9.AutoHeight = false;
            this.repositoryItemTextEdit9.Name = "repositoryItemTextEdit9";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.txtStatus1);
            this.ribbonStatusBar.ItemLinks.Add(this.txtStatus2);
            this.ribbonStatusBar.ItemLinks.Add(this.txtStatus3);
            this.ribbonStatusBar.ItemLinks.Add(this.txtStatus4);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 987);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1650, 36);
            // 
            // gridTinhThanh
            // 
            this.gridTinhThanh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTitle,
            this.colSolrID,
            this.colTotalDoanhNghiep});
            this.gridTinhThanh.DetailHeight = 512;
            this.gridTinhThanh.FixedLineWidth = 3;
            this.gridTinhThanh.GridControl = this.gridControlTinhThanh;
            this.gridTinhThanh.Name = "gridTinhThanh";
            this.gridTinhThanh.OptionsSelection.MultiSelect = true;
            this.gridTinhThanh.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridTinhThanh.OptionsView.ShowGroupPanel = false;
            this.gridTinhThanh.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 30;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            this.colID.Width = 64;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Tên tỉnh thành";
            this.colTitle.FieldName = "Title";
            this.colTitle.MinWidth = 30;
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 2;
            this.colTitle.Width = 379;
            // 
            // colSolrID
            // 
            this.colSolrID.Caption = "Địa chỉ";
            this.colSolrID.FieldName = "SolrID";
            this.colSolrID.MinWidth = 30;
            this.colSolrID.Name = "colSolrID";
            this.colSolrID.Visible = true;
            this.colSolrID.VisibleIndex = 3;
            this.colSolrID.Width = 379;
            // 
            // colTotalDoanhNghiep
            // 
            this.colTotalDoanhNghiep.Caption = "Tổng doanh nghiệp";
            this.colTotalDoanhNghiep.FieldName = "TotalDoanhNghiep";
            this.colTotalDoanhNghiep.MinWidth = 30;
            this.colTotalDoanhNghiep.Name = "colTotalDoanhNghiep";
            this.colTotalDoanhNghiep.Visible = true;
            this.colTotalDoanhNghiep.VisibleIndex = 4;
            this.colTotalDoanhNghiep.Width = 385;
            // 
            // tabTTDNDuLieu
            // 
            this.tabTTDNDuLieu.Controls.Add(this.gridControlData);
            this.tabTTDNDuLieu.Location = new System.Drawing.Point(4, 28);
            this.tabTTDNDuLieu.Margin = new System.Windows.Forms.Padding(4);
            this.tabTTDNDuLieu.Name = "tabTTDNDuLieu";
            this.tabTTDNDuLieu.Padding = new System.Windows.Forms.Padding(4);
            this.tabTTDNDuLieu.Size = new System.Drawing.Size(1347, 706);
            this.tabTTDNDuLieu.TabIndex = 1;
            this.tabTTDNDuLieu.Text = "Dữ liệu";
            this.tabTTDNDuLieu.UseVisualStyleBackColor = true;
            // 
            // gridControlData
            // 
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlData.Location = new System.Drawing.Point(4, 4);
            this.gridControlData.MainView = this.gridData;
            this.gridControlData.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlData.MenuManager = this.ribbonControl;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.Size = new System.Drawing.Size(1339, 698);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridData});
            // 
            // gridData
            // 
            this.gridData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.colMaSoThue,
            this.Ten});
            this.gridData.DetailHeight = 512;
            this.gridData.FixedLineWidth = 3;
            this.gridData.GridControl = this.gridControlData;
            this.gridData.Name = "gridData";
            this.gridData.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "ID";
            this.Id.FieldName = "Id";
            this.Id.MinWidth = 30;
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 112;
            // 
            // colMaSoThue
            // 
            this.colMaSoThue.Caption = "Mã số thuế";
            this.colMaSoThue.FieldName = "MaSoThue";
            this.colMaSoThue.MinWidth = 30;
            this.colMaSoThue.Name = "colMaSoThue";
            this.colMaSoThue.Visible = true;
            this.colMaSoThue.VisibleIndex = 1;
            this.colMaSoThue.Width = 112;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên doanh nghiệp";
            this.Ten.FieldName = "Title";
            this.Ten.MinWidth = 30;
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 2;
            this.Ten.Width = 112;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "yaiba\\sqlserver.Bussiness.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = null;
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // schedulerBarController1
            // 
            this.schedulerBarController1.BarItems.Add(this.editAppointmentQueryItem1);
            this.schedulerBarController1.BarItems.Add(this.editOccurrenceUICommandItem1);
            this.schedulerBarController1.BarItems.Add(this.editSeriesUICommandItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteAppointmentsItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteOccurrenceItem1);
            this.schedulerBarController1.BarItems.Add(this.deleteSeriesItem1);
            this.schedulerBarController1.BarItems.Add(this.splitAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentStatusItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentLabelItem1);
            this.schedulerBarController1.BarItems.Add(this.toggleRecurrenceItem1);
            this.schedulerBarController1.BarItems.Add(this.changeAppointmentReminderItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToDayViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToWorkWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToFullWeekViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToMonthViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToTimelineViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchToGanttViewItem1);
            this.schedulerBarController1.BarItems.Add(this.switchTimeScalesItem1);
            this.schedulerBarController1.BarItems.Add(this.changeScaleWidthItem1);
            this.schedulerBarController1.BarItems.Add(this.switchTimeScalesCaptionItem1);
            this.schedulerBarController1.BarItems.Add(this.switchCompressWeekendItem1);
            this.schedulerBarController1.BarItems.Add(this.switchShowWorkTimeOnlyItem1);
            this.schedulerBarController1.BarItems.Add(this.switchCellsAutoHeightItem1);
            this.schedulerBarController1.BarItems.Add(this.changeSnapToCellsUIItem1);
            this.schedulerBarController1.BarItems.Add(this.newAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.newRecurringAppointmentItem1);
            this.schedulerBarController1.BarItems.Add(this.navigateViewBackwardItem1);
            this.schedulerBarController1.BarItems.Add(this.navigateViewForwardItem1);
            this.schedulerBarController1.BarItems.Add(this.gotoTodayItem1);
            this.schedulerBarController1.BarItems.Add(this.viewZoomInItem1);
            this.schedulerBarController1.BarItems.Add(this.viewZoomOutItem1);
            this.schedulerBarController1.BarItems.Add(this.groupByNoneItem1);
            this.schedulerBarController1.BarItems.Add(this.groupByDateItem1);
            this.schedulerBarController1.BarItems.Add(this.groupByResourceItem1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 32;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "Tỉnh thành";
            this.barEditItem2.Edit = this.repositoryItemComboBox1;
            this.barEditItem2.EditHeight = 30;
            this.barEditItem2.EditWidth = 102;
            this.barEditItem2.Id = 117;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 1023);
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.popupControlContainer2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmMain.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl)).EndInit();
            this.schedulerSplitContainerControl.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabTTDNTinhThanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTinhThanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer2)).EndInit();
            this.popupControlContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            this.popupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDuration1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTinhThanh)).EndInit();
            this.tabTTDNDuLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarButtonItem iHelp;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        public DevExpress.XtraBars.BarStaticItem txtStatus1;
        public DevExpress.XtraBars.BarStaticItem txtStatus2;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage helpRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup helpRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraEditors.LabelControl someLabelControl2;
        private DevExpress.XtraEditors.LabelControl someLabelControl1;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup importGroup;
        private DevExpress.XtraNavBar.NavBarGroup exportGroup;
        private DevExpress.XtraNavBar.NavBarItem calendarItem;
        private DevExpress.XtraNavBar.NavBarItem tasksItem;
        private DevExpress.Utils.ImageCollection navbarImageCollection;
        private DevExpress.Utils.ImageCollection navbarImageCollectionLarge;
        private DevExpress.XtraEditors.SplitContainerControl schedulerSplitContainerControl;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage;
        private DevExpress.XtraScheduler.UI.EditAppointmentQueryItem editAppointmentQueryItem1;
        private DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem editOccurrenceUICommandItem1;
        private DevExpress.XtraScheduler.UI.EditSeriesUICommandItem editSeriesUICommandItem1;
        private DevExpress.XtraScheduler.UI.DeleteAppointmentsItem deleteAppointmentsItem1;
        private DevExpress.XtraScheduler.UI.DeleteOccurrenceItem deleteOccurrenceItem1;
        private DevExpress.XtraScheduler.UI.DeleteSeriesItem deleteSeriesItem1;
        private DevExpress.XtraScheduler.UI.SplitAppointmentItem splitAppointmentItem1;
        private DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem changeAppointmentStatusItem1;
        private DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem changeAppointmentLabelItem1;
        private DevExpress.XtraScheduler.UI.ToggleRecurrenceItem toggleRecurrenceItem1;
        private DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem changeAppointmentReminderItem1;
        private DevExpress.XtraScheduler.UI.RepositoryItemDuration repositoryItemDuration1;
        private DevExpress.XtraScheduler.UI.SwitchToDayViewItem switchToDayViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem switchToWorkWeekViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToWeekViewItem switchToWeekViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem switchToFullWeekViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToMonthViewItem switchToMonthViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem switchToTimelineViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchToGanttViewItem switchToGanttViewItem1;
        private DevExpress.XtraScheduler.UI.SwitchTimeScalesItem switchTimeScalesItem1;
        private DevExpress.XtraScheduler.UI.ChangeScaleWidthItem changeScaleWidthItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem switchTimeScalesCaptionItem1;
        private DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem switchCompressWeekendItem1;
        private DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem switchShowWorkTimeOnlyItem1;
        private DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem switchCellsAutoHeightItem1;
        private DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem changeSnapToCellsUIItem1;
        private DevExpress.XtraScheduler.UI.NewAppointmentItem newAppointmentItem1;
        private DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem newRecurringAppointmentItem1;
        private DevExpress.XtraScheduler.UI.NavigateViewBackwardItem navigateViewBackwardItem1;
        private DevExpress.XtraScheduler.UI.NavigateViewForwardItem navigateViewForwardItem1;
        private DevExpress.XtraScheduler.UI.GotoTodayItem gotoTodayItem1;
        private DevExpress.XtraScheduler.UI.ViewZoomInItem viewZoomInItem1;
        private DevExpress.XtraScheduler.UI.ViewZoomOutItem viewZoomOutItem1;
        private DevExpress.XtraScheduler.UI.GroupByNoneItem groupByNoneItem1;
        private DevExpress.XtraScheduler.UI.GroupByDateItem groupByDateItem1;
        private DevExpress.XtraScheduler.UI.GroupByResourceItem groupByResourceItem1;
        private DevExpress.XtraScheduler.UI.SchedulerBarController schedulerBarController1;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridData;
        private DevExpress.XtraBars.BarButtonItem barKiemTra;
        private DevExpress.XtraBars.BarButtonItem barDongBo;
        private DevExpress.XtraBars.BarButtonItem barXuatExcel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        public DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTTDNTinhThanh;
        private DevExpress.XtraGrid.GridControl gridControlTinhThanh;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTinhThanh;
        private System.Windows.Forms.TabPage tabTTDNDuLieu;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colSolrID;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDoanhNghiep;
        public DevExpress.XtraBars.BarStaticItem txtStatus3;
        private DevExpress.XtraBars.BarStaticItem txtStatus4;
        private DevExpress.XtraBars.BarButtonItem btnDongBoNgoaiLe;
        private DevExpress.XtraBars.BarEditItem txtMaSoThue;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSoThue;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraBars.BarEditItem fillterMST;
        private DevExpress.XtraBars.BarEditItem fillterTag;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraBars.BarEditItem fillterTinhThanh;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.XtraBars.BarEditItem fillterQuanHuyen;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit6;
        private DevExpress.XtraBars.BarEditItem fillterNganhNghe;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit7;
        private DevExpress.XtraBars.BarEditItem fillterThuePhaiNop;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit8;
        private DevExpress.XtraBars.BarButtonItem btnFind;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit9;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
        private DevExpress.XtraBars.BarEditItem dongBoTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraBars.BarEditItem dongBoQuan;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox6;
        private DevExpress.XtraBars.BarButtonItem dongBoBtn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn MaSoThue;
        private DevExpress.XtraGrid.Columns.GridColumn Title;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChiCongTy;
        private DevExpress.XtraGrid.Columns.GridColumn NganhNgheTitle;
        private DevExpress.XtraBars.BarButtonItem dongBoXuatExcelBtn;
    }
}
