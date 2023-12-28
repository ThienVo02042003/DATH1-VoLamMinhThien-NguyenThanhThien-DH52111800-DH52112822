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
    public partial class FrmBlockList : Form
    {
        List<DanhBa> ds = new List<DanhBa>();
        int indexClick = -1;
        public FrmBlockList()
        {
            InitializeComponent();
        }
        private void hienThi()
        {
            //Lấy dư liệu từ ds hiển thị ra list view
            //dgvData.DataSource = Ten.getName(ds);
            dgvData.DataSource = SDT.getSDT(ds);
        }
        private void FrmBlockList_Load(object sender, EventArgs e)
        {
            ds = new List<DanhBa>();
            //Đọc dữ liệu từ file
            try
            {
                FileStream fs = new FileStream("QLDBChan.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();

                ds = bf.Deserialize(fs) as List<DanhBa>;
                fs.Close();
                hienThi();
            }
            catch { MessageBox.Show("Không Thể Load"); }
        }
        private void BtnBoChan_Click(object sender, EventArgs e)
        {
            if (indexClick != -1)
            {
                //Kiểm tra xem người dùng có click vào dòng không
                //Nếu đã click thì xóa dòng đó
                ds.RemoveAt(indexClick);
                indexClick = -1;
                hienThi();              
            }
        }
        private void FrmBlockList_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Lưu danh sách chặn vào file QLDBChan.txt
                FileStream fs = new FileStream("QLDBChan.txt", FileMode.OpenOrCreate);

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ds);
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Không Thể Lưu");
            }
        }
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
            {
                indexClick = e.RowIndex;
            }
        }
    }
}
