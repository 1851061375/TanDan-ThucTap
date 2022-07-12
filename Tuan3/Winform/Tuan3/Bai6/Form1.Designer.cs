
namespace Bai6
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbShowIcon = new System.Windows.Forms.TextBox();
            this.tbBackground = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFormStyle = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 86);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbFormStyle);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbBackground);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbShowIcon);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 400);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show icon";
            // 
            // tbShowIcon
            // 
            this.tbShowIcon.Location = new System.Drawing.Point(129, 43);
            this.tbShowIcon.Name = "tbShowIcon";
            this.tbShowIcon.Size = new System.Drawing.Size(256, 26);
            this.tbShowIcon.TabIndex = 1;
            // 
            // tbBackground
            // 
            this.tbBackground.Location = new System.Drawing.Point(129, 110);
            this.tbBackground.Name = "tbBackground";
            this.tbBackground.Size = new System.Drawing.Size(256, 26);
            this.tbBackground.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Background";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Form style";
            // 
            // cbFormStyle
            // 
            this.cbFormStyle.FormattingEnabled = true;
            this.cbFormStyle.Items.AddRange(new object[] {
            "Sizable",
            "FixedToolWindow"});
            this.cbFormStyle.Location = new System.Drawing.Point(129, 177);
            this.cbFormStyle.Name = "cbFormStyle";
            this.cbFormStyle.Size = new System.Drawing.Size(256, 28);
            this.cbFormStyle.TabIndex = 5;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(529, 27);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(106, 41);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fMain";
            this.ShowIcon = false;
            this.Text = "Lưu cấu hình";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbFormStyle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBackground;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbShowIcon;
        private System.Windows.Forms.Label label1;
    }
}

