

namespace Bai2
{
    partial class fMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.cbEnd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbPicture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(584, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 211);
            this.panel2.TabIndex = 1;
            // 
            // pbPicture
            // 
            this.pbPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPicture.Location = new System.Drawing.Point(0, 0);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(367, 211);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 0;
            this.pbPicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nmCount);
            this.panel1.Controls.Add(this.cbEnd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbStart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 211);
            this.panel1.TabIndex = 0;
            // 
            // btSearch
            // 
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Location = new System.Drawing.Point(455, 154);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(102, 40);
            this.btSearch.TabIndex = 8;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số vé";
            // 
            // nmCount
            // 
            this.nmCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nmCount.Location = new System.Drawing.Point(105, 129);
            this.nmCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(56, 30);
            this.nmCount.TabIndex = 6;
            this.nmCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbEnd
            // 
            this.cbEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEnd.FormattingEnabled = true;
            this.cbEnd.Location = new System.Drawing.Point(398, 21);
            this.cbEnd.Name = "cbEnd";
            this.cbEnd.Size = new System.Drawing.Size(159, 31);
            this.cbEnd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm đến";
            // 
            // dtDate
            // 
            this.dtDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(105, 75);
            this.dtDate.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtDate.MinDate = new System.DateTime(2021, 11, 21, 21, 33, 16, 94);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(159, 30);
            this.dtDate.TabIndex = 3;
            this.dtDate.Value = new System.DateTime(2021, 11, 21, 21, 33, 16, 94);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày đi";
            // 
            // cbStart
            // 
            this.cbStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Location = new System.Drawing.Point(105, 21);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(159, 31);
            this.cbStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm đi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbResult);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(954, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // lbResult
            // 
            this.lbResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 23;
            this.lbResult.Location = new System.Drawing.Point(3, 26);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(948, 263);
            this.lbResult.TabIndex = 0;
            this.lbResult.SelectedIndexChanged += new System.EventHandler(this.lbResult_SelectedIndexChanged);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(954, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM CHUYẾN BAY";
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmCount;
        private System.Windows.Forms.ComboBox cbEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.PictureBox pbPicture;
    }
}

