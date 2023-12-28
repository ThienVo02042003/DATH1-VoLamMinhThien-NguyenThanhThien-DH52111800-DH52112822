using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danh_Ba_Dien_Thoai
{
    public partial class FrmChooseNumber : Form
    {
        public string SelectedPhoneNumber { get; private set; }
        public FrmChooseNumber(string phoneNumber1, string phoneNumber2)
        {
            InitializeComponent();
            // Hiển thị số điện thoại để người dùng có thể chọn
            lblPhoneNumber1.Text = phoneNumber1;
            lblPhoneNumber2.Text = phoneNumber2;
        }
        private void FrmChooseNumber_Load(object sender, EventArgs e)
        {

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Lựa chọn số điện thoại và đóng form
            SelectedPhoneNumber = rbSDT1.Checked ? lblPhoneNumber1.Text : lblPhoneNumber2.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

    }     
}
