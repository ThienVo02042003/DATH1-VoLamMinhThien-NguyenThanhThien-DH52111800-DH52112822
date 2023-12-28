using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Danh_Ba_Dien_Thoai
{
    public partial class FrmQLDB : Form
    {
        private List<DanhBa> blockedContacts = new List<DanhBa>();
        //biến lưu vị trí khi click vào listview
        int indexClick = -1;
        List<DanhBa> ds=new List<DanhBa>();

        public MailMessage MailMessage { get; private set; }

        public FrmQLDB()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Gọi form thêm thông tin
            FrmAddform form = new FrmAddform();
            form.ShowDialog();
            button1_Click(sender, e);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //Hiển thị dialog khi thoát
            DialogResult res=MessageBox.Show("Bạn muốn thoát!","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(res==DialogResult.Yes)
            {
                Close();
            }    
        }
        private void hienThi()
        {
            //Lấy dư liệu từ ds hiển thị ra list view
            dgvData.DataSource=Ten.getName(ds);
        }
        private void FrmQLDB_Load(object sender, EventArgs e)
        {
            ds = new List<DanhBa>();
           
           
            //Đọc dữ liệu từ file
            try
            {
                FileStream fs = new FileStream("QLDB.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();

                ds = bf.Deserialize(fs) as List<DanhBa>;
                fs.Close();
                hienThi();
            }
            catch { MessageBox.Show("Không Thể Load"); }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            try
            {
                //Lấy thông tin vừa thêm được ở frm thêm và gán vào lst
                bool flag = true;
                List<DanhBa> lst = new List<DanhBa>();
                FileStream fs = new FileStream("QLDB.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();

                lst = bf.Deserialize(fs) as List<DanhBa>;
                fs.Close();
                //Kiểm tra xem thông tin lấy được đã có trong danh sách hay chưa
                foreach(DanhBa key in lst)
                {
                   foreach(DanhBa value in ds)
                    {
                        if (value.SoDienThoai == key.SoDienThoai)
                        {
                            flag=false;
                        }
                    }    
                }
                //Nếu chưa có thì tiến hành thêm vào ds
                if (flag)
                {
                    ds.Add(lst[0]);
                    
                }
                hienThi();
            }
            catch { }
            try
            {
                //Lấy thôg tin sau khi cập nhật xong cho detail
                List<DanhBa> detail = new List<DanhBa>();
                FileStream fs = new FileStream("QLDB.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                detail = bf.Deserialize(fs) as List<DanhBa>;
                fs.Close();
                //Thay đổi thông tin cũ trong danh sách thành thông tin mới
                foreach (DanhBa db in ds)
                {
                    if (db.SoDienThoai == detail[0].SoDienThoai)
                    {
                        db.HoVaTen = detail[0].HoVaTen;                      
                        db.SoDienThoai1 = detail[0].SoDienThoai1;
                        db.Email = detail[0].Email;
                        db.DiaChi = detail[0].DiaChi;
                        db.GT=detail[0].GT;

                    }
                }
                //Hiển thị thông tin mới ra view
                hienThi();
            }
            catch
            {

            }
            try
            {
                FileStream fs = new FileStream("QLDB.txt", FileMode.OpenOrCreate);

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ds);
                fs.Close();
            }
            catch { }
        }
        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //double click vào danh sách
        {
            //Lấy chỉ mục khi click vào row
            int index = dgvData.Rows[e.RowIndex].Index;
            try
            {
                //Tạo 1 danh sách ảo với phần tử là phần được đc click  và lưu vào file
                List<DanhBa> detail = new List<DanhBa>();
                detail.Add(ds[index]);
                //Ghi dữ liệu vào file
                FileStream fs = new FileStream("QLDB.txt", FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, detail);
                fs.Close();
                //Gọi form thông tin chi tiết
                FrmDetail frm = new FrmDetail();
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Không Thể Lưu");
            }
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(indexClick!=-1)
            {
               //Kiểm tra xem người dùng có click vào dòng không
               //Nếu đã click thì xóa dòng đó
                ds.RemoveAt(indexClick);
                FileStream fs = new FileStream("QLDB.txt", FileMode.OpenOrCreate);

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ds);
                fs.Close();
                indexClick = -1;
                hienThi();
            }
        }
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvData.Rows.Count)
            {
                indexClick = e.RowIndex;
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //Gọi form search
            FrmSearch frm = new FrmSearch(); //become a search form
            frm.ShowDialog();
        }

        private void FrmQLDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Lưu dữ liệu vào file
                FileStream fs = new FileStream("QLDB.txt", FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ds);
                fs.Close(); 
            }
            catch
            {
                MessageBox.Show("Khong the luu");
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BtnChan_Click(object sender, EventArgs e)
        {         
            if (indexClick != -1)
            {
                DanhBa selectedContact = ds[indexClick];

                using (FrmChooseNumber frmChonSoChan = new FrmChooseNumber(selectedContact.SoDienThoai, selectedContact.SoDienThoai1))
                {
                    DialogResult result = frmChonSoChan.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // Lấy số điện thoại được chọn từ FrmChooseNumber
                        string selectedPhoneNumber = frmChonSoChan.SelectedPhoneNumber;

                        // Tạo DanhBa mới với số điện thoại được chọn và thêm vào blockedContacts
                        DanhBa blockedContactToAdd = new DanhBa(selectedContact.HoVaTen, selectedPhoneNumber, selectedContact.SelectedPhoneNumber, selectedContact.Email, selectedContact.DiaChi, selectedContact.GT);
                        blockedContacts.Add(blockedContactToAdd);
                        // Xóa dòng đó khỏi danh sách chính
                        //ds.RemoveAt(indexClick);
                        indexClick = -1;
                        hienThi();

                        // Lưu danh sách blockedContacts vào QLDBChan.txt
                        SaveBlockedContactsToFile();
                    }
                }
            }

        }
        private void SaveBlockedContactsToFile()
        {
            try
            {
                FileStream fs = new FileStream("QLDBChan.txt", FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, blockedContacts);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể lưu danh sách chặn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBlock_Click(object sender, EventArgs e)
        {
            FrmBlockList frm = new FrmBlockList();
            frm.ShowDialog();
        }

        private void btnGuiMail_Click(object sender, EventArgs e)
        {
            if (indexClick != -1)
            {
                ds = new List<DanhBa>();


                //Đọc dữ liệu từ file
                try
                {
                    FileStream fs = new FileStream("QLDB.txt", FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();

                    ds = bf.Deserialize(fs) as List<DanhBa>;
                    fs.Close();
                    hienThi();
                }
                catch { }
                string formMail = "kidokidokido1111@gmail.com"; 
                string formPassword = "wnta phqq alpe pqen";

                MailMessage message = new MailMessage();
                message.From = new MailAddress(formMail);
                message.Subject = "Thông tin số điện thoại";
                message.To.Add(new MailAddress("volamminhthien090@gmail.com"));
                                                                               
                DanhBa selectedContact = ds[indexClick];

                // Thêm thông tin vào nội dung email
                message.Body = $"<html><body>" +
                               $"<h3>Thông tin số điện thoại:</h3>" +
                               $"<p>Họ và tên: {selectedContact.HoVaTen}</p>" +
                               $"<p>Số điện thoại: {selectedContact.SoDienThoai}</p>" +
                               $"<p>Số điện thoại 2: {selectedContact.SoDienThoai1}</p>" +
                               $"<p>Email: {selectedContact.Email}</p>" +
                               $"<p>Địa chỉ: {selectedContact.DiaChi}</p>" +
                               $"<p>Giới tính: {selectedContact.GT}</p>" +
                               $"</body></html>";
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(formMail, formPassword),
                    EnableSsl = true
                };

                try
                {
                    smtpClient.Send(message);
                    MessageBox.Show("Gửi Thành Công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gửi Thất Bại: {ex.Message}");
                }
            }
        }
    }
}
