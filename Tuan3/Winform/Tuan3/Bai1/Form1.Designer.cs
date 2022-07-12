
namespace Bai1
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
            this.components = new System.ComponentModel.Container();
            this.labelTitleInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btSubmit = new System.Windows.Forms.Button();
            this.cbConfirm = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.rbNo3 = new System.Windows.Forms.RadioButton();
            this.rbYes3 = new System.Windows.Forms.RadioButton();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.rbNo2 = new System.Windows.Forms.RadioButton();
            this.rbYes2 = new System.Windows.Forms.RadioButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rbNo1 = new System.Windows.Forms.RadioButton();
            this.rbYes1 = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ePAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitleInfo
            // 
            this.labelTitleInfo.AutoSize = true;
            this.labelTitleInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleInfo.Location = new System.Drawing.Point(35, 24);
            this.labelTitleInfo.Name = "labelTitleInfo";
            this.labelTitleInfo.Size = new System.Drawing.Size(214, 29);
            this.labelTitleInfo.TabIndex = 0;
            this.labelTitleInfo.Text = "Thông tin liên lạc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Địa chỉ nơi ở hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(236, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "(*)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.SystemColors.Window;
            this.tbAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(40, 104);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(590, 30);
            this.tbAddress.TabIndex = 3;
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddress_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(165, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "(*)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.SystemColors.Window;
            this.tbPhone.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(40, 197);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(590, 30);
            this.tbPhone.TabIndex = 6;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(595, 58);
            this.label5.TabIndex = 7;
            this.label5.Text = "Trong vòng 14 ngày qua anh/chị có thấy xuất hiện \n triệu chứng nào sau đây không";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.btSubmit);
            this.panelMain.Controls.Add(this.cbConfirm);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.tbPhone);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.tbAddress);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.labelTitleInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(696, 624);
            this.panelMain.TabIndex = 0;
            // 
            // btSubmit
            // 
            this.btSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSubmit.Enabled = false;
            this.btSubmit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.Location = new System.Drawing.Point(522, 564);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(108, 36);
            this.btSubmit.TabIndex = 10;
            this.btSubmit.Text = "Gửi";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // cbConfirm
            // 
            this.cbConfirm.AutoSize = true;
            this.cbConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbConfirm.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConfirm.Location = new System.Drawing.Point(40, 542);
            this.cbConfirm.Name = "cbConfirm";
            this.cbConfirm.Size = new System.Drawing.Size(391, 27);
            this.cbConfirm.TabIndex = 9;
            this.cbConfirm.Text = "Cam kết thông tin là hoàn toàn chính xác";
            this.cbConfirm.UseVisualStyleBackColor = true;
            this.cbConfirm.CheckedChanged += new System.EventHandler(this.cbConfirm_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(40, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 192);
            this.panel1.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel14);
            this.panel5.Controls.Add(this.panel13);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(590, 50);
            this.panel5.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.rbNo3);
            this.panel14.Controls.Add(this.rbYes3);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(209, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(381, 50);
            this.panel14.TabIndex = 3;
            // 
            // rbNo3
            // 
            this.rbNo3.AutoSize = true;
            this.rbNo3.Checked = true;
            this.rbNo3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNo3.Location = new System.Drawing.Point(273, 12);
            this.rbNo3.Name = "rbNo3";
            this.rbNo3.Size = new System.Drawing.Size(21, 20);
            this.rbNo3.TabIndex = 3;
            this.rbNo3.TabStop = true;
            this.rbNo3.UseVisualStyleBackColor = true;
            // 
            // rbYes3
            // 
            this.rbYes3.AutoSize = true;
            this.rbYes3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbYes3.Location = new System.Drawing.Point(88, 14);
            this.rbYes3.Name = "rbYes3";
            this.rbYes3.Size = new System.Drawing.Size(21, 20);
            this.rbYes3.TabIndex = 0;
            this.rbYes3.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label11);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(209, 50);
            this.panel13.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Khó thở";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(590, 47);
            this.panel4.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.rbNo2);
            this.panel12.Controls.Add(this.rbYes2);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(209, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(381, 47);
            this.panel12.TabIndex = 2;
            // 
            // rbNo2
            // 
            this.rbNo2.AutoSize = true;
            this.rbNo2.Checked = true;
            this.rbNo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNo2.Location = new System.Drawing.Point(273, 12);
            this.rbNo2.Name = "rbNo2";
            this.rbNo2.Size = new System.Drawing.Size(21, 20);
            this.rbNo2.TabIndex = 3;
            this.rbNo2.TabStop = true;
            this.rbNo2.UseVisualStyleBackColor = true;
            // 
            // rbYes2
            // 
            this.rbYes2.AutoSize = true;
            this.rbYes2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbYes2.Location = new System.Drawing.Point(88, 14);
            this.rbYes2.Name = "rbYes2";
            this.rbYes2.Size = new System.Drawing.Size(21, 20);
            this.rbYes2.TabIndex = 0;
            this.rbYes2.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label10);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(209, 47);
            this.panel11.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "Ho";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 48);
            this.panel3.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.rbNo1);
            this.panel10.Controls.Add(this.rbYes1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(209, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(381, 48);
            this.panel10.TabIndex = 1;
            // 
            // rbNo1
            // 
            this.rbNo1.AutoSize = true;
            this.rbNo1.Checked = true;
            this.rbNo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNo1.Location = new System.Drawing.Point(273, 12);
            this.rbNo1.Name = "rbNo1";
            this.rbNo1.Size = new System.Drawing.Size(21, 20);
            this.rbNo1.TabIndex = 3;
            this.rbNo1.TabStop = true;
            this.rbNo1.UseVisualStyleBackColor = true;
            // 
            // rbYes1
            // 
            this.rbYes1.AutoSize = true;
            this.rbYes1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbYes1.Location = new System.Drawing.Point(88, 14);
            this.rbYes1.Name = "rbYes1";
            this.rbYes1.Size = new System.Drawing.Size(21, 20);
            this.rbYes1.TabIndex = 0;
            this.rbYes1.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label9);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(209, 48);
            this.panel9.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sốt";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 45);
            this.panel2.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label8);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(409, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(181, 45);
            this.panel8.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Không";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(209, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 45);
            this.panel7.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Có";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(209, 45);
            this.panel6.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Triệu chứng";
            // 
            // ePAddress
            // 
            this.ePAddress.ContainerControl = this;
            // 
            // ePPhone
            // 
            this.ePPhone.ContainerControl = this;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 624);
            this.Controls.Add(this.panelMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHIẾU KHAI THÔNG TIN";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitleInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.RadioButton rbNo3;
        private System.Windows.Forms.RadioButton rbYes3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.RadioButton rbNo2;
        private System.Windows.Forms.RadioButton rbYes2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton rbNo1;
        private System.Windows.Forms.RadioButton rbYes1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbConfirm;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.ErrorProvider ePAddress;
        private System.Windows.Forms.ErrorProvider ePPhone;
    }
}

