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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Danh_Ba_Dien_Thoai
{
    public partial class FrmSearch : Form
    {
        List<DanhBa> ds;
        public FrmSearch()
        {
            InitializeComponent();
             ds = new List<DanhBa>();
        }
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            //ĐỌc dữ liệu từ file gán vào ds 
           
            try
            {
                FileStream fs = new FileStream("QLDB.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                ds = bf.Deserialize(fs) as List<DanhBa>;
                fs.Close();
            }
            catch
            { 
                MessageBox.Show("Không thể load");
            }
        }
        private void Sort(object sender, EventArgs e)
        {
            PerformSearch();
        }
        private void PerformSearch()
        {   
            int flag = 0;
            List<DanhBa> temp = new List<DanhBa>();
            string input = txtInput.Text.ToLower();

            foreach (DanhBa danhBa in ds)
            {
                // Kiểm tra xem họ tên có trong danh sách hay không
                if (danhBa.HoVaTen.ToLower().Contains(input))
                {
                    foreach (DanhBa db in temp)
                    {
                        if (db.HoVaTen == danhBa.HoVaTen)
                        {
                            flag = 1;
                            break;
                        }
                    }

                    if (flag == 0)
                        temp.Add(danhBa);
                }

                // Kiểm tra số điện thoại có trong danh sách hay không
                if (danhBa.SoDienThoai.ToLower().Contains(input))
                {
                    foreach (DanhBa db in temp)
                    {
                        if (db.SoDienThoai == danhBa.SoDienThoai)
                        {
                            flag = 1;
                            break;
                        }
                    }

                    if (flag == 0)
                        temp.Add(danhBa);
                }
            }

            // Hiển thị danh sách ra DataGridView
            dgvData.DataSource = temp;
        }
    }
}
