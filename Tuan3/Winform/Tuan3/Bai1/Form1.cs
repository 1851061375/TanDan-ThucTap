using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class fMain : Form
    {
        bool addressValidate = false;
        bool phoneValidate = false;
        public fMain()
        {
            InitializeComponent();
            
        }
        #region event
        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                addressValidate = false;
                tbAddress.Focus();
                ePAddress.SetError(tbAddress, "Đây là trường bắt buôc");
            }
            else
            {
                addressValidate = true;
                ePAddress.SetError(tbAddress, null);
            }
                
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                phoneValidate = false;
                tbPhone.Focus();
                ePPhone.SetError(tbPhone, "Đây là trường bắt buộc");
            }
            else if (!isNumber(tbPhone.Text) || tbPhone.Text.Length != 10)
            {
                phoneValidate = false;
                tbPhone.Focus();
                ePPhone.SetError(tbPhone, "Vui lòng nhập số điện thoại gồm 10 chữ số");
            }
            else
            {
                phoneValidate = true;
                ePPhone.SetError(tbPhone, null);
            }
        }

        private void cbConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConfirm.Checked && addressValidate && phoneValidate)
                btSubmit.Enabled = true;
            else
                btSubmit.Enabled = false;
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cảm ơn bạn đã gửi thông tin!", "Thông báo",
                                  MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                Application.Exit();
        }
        #endregion
        private bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (int.TryParse(s[i].ToString(), out int n)) return true;
            return false;
        }

        
    }
}
