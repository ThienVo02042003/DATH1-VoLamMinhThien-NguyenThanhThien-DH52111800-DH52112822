using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Danh_Ba_Dien_Thoai
{
    public partial class FrmAddform : Form
    {
       List<DanhBa> ds;
        public FrmAddform()
        {
            InitializeComponent();
        }
        //ĐÓng form
        private void button3_Click(object sender, EventArgs e)
        {
            //ĐÓng form
            Close();
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
        private void button1_Click(object sender, EventArgs e)
        {       //Lấy thôn tin từ input
            string sdt = txtSDT.Text;
            if (!checkSDT(sdt))
            {
                MessageBox.Show("Nhập lỗi, Hãy nhập số!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            string sdt1 = txtSDT1.Text;
            if (!checkSDT(sdt1))
            {
                MessageBox.Show("Nhập lỗi, Hãy nhập số!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            string hoten = txtName.Text;
            string email = txtEmail.Text;
            string diachi = txtDiaChi.Text;         
            string gt = radNam.Checked == true ? "Nam" : "Nu";
            DanhBa db = new DanhBa(hoten, sdt, sdt1, email, diachi, gt);
            try
            {
                List<DanhBa> dic =new List<DanhBa>();
                //dọc dữ liệu từ file
                FileStream fs = new FileStream("QLDB.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dic = bf.Deserialize(fs) as List<DanhBa>;
                fs.Close(); 
                //Đọc dữ liệu từ file chặn
                List<DanhBa> temp=new List<DanhBa>();
                FileStream fb = new FileStream("QLDBChan.txt", FileMode.Open);
                BinaryFormatter bfb = new BinaryFormatter();
                temp = bfb.Deserialize(fb) as List<DanhBa>;
                fb.Close();
                //Kiểm tra xem đối tượng muốn thêm đã có trong danh sách chưa
                foreach (DanhBa k in dic)
                {
                    //Nếu có thì không thêm
                    if (sdt == k.SoDienThoai)
                    {
                        MessageBox.Show("Số Điện Thoại 1 đã tồn tại hoặc đã bị chặn","Lỗi!", MessageBoxButtons.OK);
                        return;
                    }    
                       
                }
                foreach (DanhBa k in dic)
                {
                    //Nếu có thì không thêm
                    if (sdt == k.SoDienThoai1)
                    {
                        MessageBox.Show("Số Điện Thoại 1 đã tồn tại hoặc đã bị chặn", "Lỗi!", MessageBoxButtons.OK);
                        return;
                    }

                }
                //Kiểm tra xem đối tượng muốn thêm đã có trong danh sách hay chưa
                foreach (DanhBa k in temp)
                {
                    //Nếu có thì không thêm
                    if (sdt == k.SoDienThoai)
                    {
                        MessageBox.Show("Số Điện Thoại 1 đã tồn tại hoặc đã bị chặn", "Lỗi!", MessageBoxButtons.OK);
                        return;
                    }

                }
                //
                foreach (DanhBa k in dic)
                {
                    //Nếu có thì không thêm
                    if (sdt1 == k.SoDienThoai1)
                    {
                        MessageBox.Show("Số Điện Thoại 2 đã tồn tại hoặc đã bị chặn", "Lỗi!", MessageBoxButtons.OK);
                        return;
                    }
                }
                foreach (DanhBa k in dic)
                {
                    //Nếu có thì không thêm
                    if (sdt1 == k.SoDienThoai)
                    {
                        MessageBox.Show("Số Điện Thoại 2 đã tồn tại hoặc đã bị chặn", "Lỗi!", MessageBoxButtons.OK);
                        return;
                    }
                }
                foreach (DanhBa k in temp)
                {
                    //Nếu có thì không thêm
                    if (sdt1 == k.SoDienThoai)
                    {
                        MessageBox.Show("Số Điện Thoại 2 đã tồn tại hoặc đã bị chặn", "Lỗi!", MessageBoxButtons.OK);
                        return;
                    }

                }
                //Nếu chưa có thì tiến hành thêm và xóa input form
                ds.Add(db);
                txtDiaChi.Text="";
                txtName.Text = "";
                txtSDT.Text = "";
                txtSDT1.Text = "";
                txtEmail.Text = "";
                txtName.Focus();                          
            }
            catch
            {
               
            }
            try
            {
                //Sau khi thêm xong tiến hành ghi dữ liệu vào file
                //Ghi dữ liệu vào file
                FileStream fs = new FileStream("QLDB.txt", FileMode.OpenOrCreate);
                
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ds);
                fs.Close();
                Close();
            }
            catch
            {
                MessageBox.Show("Không Thể Lưu");
            }
        }
        private void FrmAddform_Load(object sender, EventArgs e)
        {
            ds = new List<DanhBa>();
            radNam.Checked = true;
            txtName.Focus();
        }
    }
}
