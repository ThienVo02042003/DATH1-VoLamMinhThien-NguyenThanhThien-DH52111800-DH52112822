using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Danh_Ba_Dien_Thoai
{
    public partial class FrmDetail : Form
    {
        List<DanhBa> detail;
        public FrmDetail()
        {
            InitializeComponent();
        }

        private void FrmDetail_Load(object sender, EventArgs e)
        {
            detail = new List<DanhBa>();
            //Đọc dữ liệu từ file
            try
            {

                FileStream fs = new FileStream("QLDB.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();

                //Lấy dữ liệu từ file cho vào detail
                detail = bf.Deserialize(fs) as List<DanhBa>;
                fs.Close();
                //gán giá trị in put bằng thông tin vừa lấy được từ file
                txtName.Text = detail[0].HoVaTen;
                txtSDT.Text = detail[0].SoDienThoai;
                txtSDT1.Text = detail[0].SoDienThoai1;
                txtEmail.Text = detail[0].Email;
                txtDiaChi.Text = detail[0].DiaChi;
                if (detail[0].GT == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;

            }
            catch { MessageBox.Show("Không Thể Load"); }
        }
        private bool checkSDT(string a)
        {

            foreach (char c in a)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Lấy thông tin ở input và cập nhật cho detail
            detail[0].HoVaTen = txtName.Text;
            detail[0].SoDienThoai = txtSDT.Text;
            if (!checkSDT(txtSDT1.Text))
            {
                MessageBox.Show("Nhập lỗi, Hãy nhập số!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            try
            {
                //dọc dữ liệu từ file QLDB
                List<DanhBa> dic = new List<DanhBa>();
                FileStream fs = new FileStream("QLDB.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dic = bf.Deserialize(fs) as List<DanhBa>;
                fs.Close();
                //Đọc dữ liệu từ file chặn
                List<DanhBa> temp = new List<DanhBa>();
                FileStream fb = new FileStream("QLDBChan.txt", FileMode.Open);
                BinaryFormatter bfb = new BinaryFormatter();
                temp = bfb.Deserialize(fb) as List<DanhBa>;
                fb.Close();                                      
            }
            catch { }       
                    detail[0].SoDienThoai1 = txtSDT1.Text;
                    detail[0].Email = txtEmail.Text;
                    detail[0].DiaChi = txtDiaChi.Text;
                    detail[0].GT = radNam.Checked == true ? "Nam" : "Nu";
                    try
                    {
                        //Ghi dữ liệu vào file
                        FileStream fs = new FileStream("QLDB.txt", FileMode.OpenOrCreate);
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, detail);
                        fs.Close();
                        Close();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể cập nhật");
                    }

        }
    }
}
    

