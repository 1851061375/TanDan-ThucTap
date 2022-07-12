
namespace Demo
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barCbSelectWeb = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barCbStartPage = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barCbEndPage = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barBtnGetData = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barCbSelectWeb,
            this.barCbStartPage,
            this.barCbEndPage,
            this.barBtnGetData,
            this.barBtnExcel,
            this.barBtnSave,
            this.barEditItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3,
            this.repositoryItemComboBox4});
            this.ribbonControl1.Size = new System.Drawing.Size(1449, 231);
            // 
            // barCbSelectWeb
            // 
            this.barCbSelectWeb.Caption = "Chọn trang web";
            this.barCbSelectWeb.Edit = this.repositoryItemComboBox1;
            this.barCbSelectWeb.EditWidth = 200;
            this.barCbSelectWeb.Id = 1;
            this.barCbSelectWeb.Name = "barCbSelectWeb";
            this.barCbSelectWeb.EditValueChanged += new System.EventHandler(this.barCbSelectWeb_EditValueChanged);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barCbStartPage
            // 
            this.barCbStartPage.Caption = "Trang bắt đầu ";
            this.barCbStartPage.Edit = this.repositoryItemComboBox2;
            this.barCbStartPage.EditWidth = 80;
            this.barCbStartPage.Id = 2;
            this.barCbStartPage.Name = "barCbStartPage";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            this.repositoryItemComboBox2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barCbEndPage
            // 
            this.barCbEndPage.Caption = "Trang kết thúc";
            this.barCbEndPage.Edit = this.repositoryItemComboBox3;
            this.barCbEndPage.EditWidth = 80;
            this.barCbEndPage.Id = 3;
            this.barCbEndPage.Name = "barCbEndPage";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            this.repositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barBtnGetData
            // 
            this.barBtnGetData.Caption = "Lấy dữ liệu";
            this.barBtnGetData.Id = 4;
            this.barBtnGetData.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnGetData.ImageOptions.Image")));
            this.barBtnGetData.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnGetData.ImageOptions.LargeImage")));
            this.barBtnGetData.Name = "barBtnGetData";
            this.barBtnGetData.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnGetData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGetData_ItemClick);
            // 
            // barBtnExcel
            // 
            this.barBtnExcel.Caption = "Xuất excel";
            this.barBtnExcel.Id = 5;
            this.barBtnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnExcel.ImageOptions.Image")));
            this.barBtnExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnExcel.ImageOptions.LargeImage")));
            this.barBtnExcel.Name = "barBtnExcel";
            // 
            // barBtnSave
            // 
            this.barBtnSave.Caption = "Lưu";
            this.barBtnSave.Id = 6;
            this.barBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSave.ImageOptions.Image")));
            this.barBtnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSave.ImageOptions.LargeImage")));
            this.barBtnSave.Name = "barBtnSave";
            this.barBtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSave_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemComboBox4;
            this.barEditItem1.Id = 8;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barCbSelectWeb);
            this.ribbonPageGroup1.ItemLinks.Add(this.barCbStartPage, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barCbEndPage);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnGetData, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnExcel, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSave, true);
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 463);
            this.panel1.TabIndex = 1;
            // 
            // tbResult
            // 
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResult.Location = new System.Drawing.Point(0, 0);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(1449, 463);
            this.tbResult.TabIndex = 0;
            this.tbResult.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarEditItem barCbSelectWeb;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem barCbStartPage;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraBars.BarEditItem barCbEndPage;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraBars.BarButtonItem barBtnGetData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox tbResult;
        private DevExpress.XtraBars.BarButtonItem barBtnExcel;
        private DevExpress.XtraBars.BarButtonItem barBtnSave;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

