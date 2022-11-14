using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKyTucXa.Controller;
using QLKyTucXa.Models;
using QLKyTucXa.View;

namespace QLKyTucXa
{
    public partial class Login : Form
    {
        private long  id_NguoiDung;
        
        public Login()
        {
            InitializeComponent();
        }

        public long Id_NguoiDung { get => id_NguoiDung; set => id_NguoiDung = value; }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;
            
            if (login(userName, passWord))
            {
                NguoiDungDTO user = NguoiDungDAO.GetUserByUsername(userName);
                this.Id_NguoiDung = user.ID_NguoiDung;

                // Change user connect to database
                //DatabaseConnection.ChangeConnection(true, "_" + user.Ssn, passWord);

                if (user.LoaiNguoiDung.Equals("ADMIN") && user.TrangThai == true)
                {
                    AdminDTO admin = AdminDAO.GetAdminById(id_NguoiDung);
                    Admin frmAdmin = new Admin();
                    this.Hide();
                    frmAdmin.ShowDialog();
                    txtPassword.Text = "";
                }
                else if (user.LoaiNguoiDung.Equals("EMPLOYEE") && user.TrangThai == true)
                {
                    NhanVienDTO employee = NhanVienDAO.GetEmployeeById(id_NguoiDung);
                    Employee frmEmployee = new Employee();
                    this.Hide();
                    frmEmployee.ShowDialog();
                    txtPassword.Text = "";
                }
                else if (user.TrangThai == true)
                {
                    SinhVienDTO student = SinhVienDAO.GetStudentById(Id_NguoiDung);
                    Student frmStudent = new Student();
                    this.Hide();
                    frmStudent.ShowDialog();
                    txtPassword.Text = "";
                }
                return;
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool login(string username, string password)
        {
            return NguoiDungDAO.Login(username, password);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.UseSystemPasswordChar == true)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
