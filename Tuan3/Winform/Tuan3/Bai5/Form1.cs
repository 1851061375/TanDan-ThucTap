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

namespace Bai5
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private bool taoFileTXT()
        {
            bool success = false;
            string fileName = "default.txt";
            fileName = tbTenFile.Text + ".txt";
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(tbNoiDung.Text);
                    success = true;
                }
            }
            else
            {
                // File.WriteAllText("FILENAME.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(tbNoiDung.Text);
                    success = true;
                }
            }
            return success;
        }

        private void btLuu_Click(object sender, EventArgs e)
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
