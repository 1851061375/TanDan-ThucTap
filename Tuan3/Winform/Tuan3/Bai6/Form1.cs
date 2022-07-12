using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class fMain : Form
    {
        string fileName = "default.txt";
        public fMain()
        {
            InitializeComponent();

            if (File.Exists(fileName))
            {
                //Read file
                string[] lines = File.ReadAllLines(fileName);

                this.ShowIcon = Convert.ToBoolean(lines[0]);
                Color myColor = ColorTranslator.FromHtml(lines[1]);
                this.BackColor = myColor;
                
                this.FormBorderStyle = (FormBorderStyle)Enum.Parse(typeof(FormBorderStyle), lines[2].ToString()); ;
            }

        }

        private bool taoFileTXT()
        {
            bool success = false;
            
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(tbShowIcon.Text);
                    sw.WriteLine(tbBackground.Text);
                    sw.WriteLine(cbFormStyle.Text);
                    success = true;
                }
            }
            else
            {
                File.WriteAllText(fileName, String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(tbShowIcon.Text);
                    sw.WriteLine(tbBackground.Text);
                    sw.WriteLine(cbFormStyle.Text);
                    success = true;
                }
            }
            return success;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (taoFileTXT())
            {
                DialogResult result = MessageBox.Show("Tạo file thành công!", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                    Application.Exit();
            }
            else
            {
                MessageBox.Show("Tạo file không thành công!", "Thông báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
