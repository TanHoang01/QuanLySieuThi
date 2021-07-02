using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLySieuThi.DTO;
using System.Windows.Forms;
namespace QuanLySieuThi.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public string CheckLogin(string usename, string password)
        {
            string query = "SELECT * FROM dbo.Account WHERE UserName = N'" + usename + "' AND PassWord = N'" + password + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                Account account = new Account(result.Rows[0]);
                return account.Type;
            }
            return "0";
        }

        public void AddAccount(Account acconut)
        {
            try
            {
                string query = "INSERT INTO Account VALUES ( @UserName , @DisplayName , @PassWord , @TYPE )";
                int a = DataProvider.Instance.ExecuteNonQuery(query, new object[] { acconut.UserName, acconut.DisplayName, acconut.PassWord, acconut.Type });

                if (a == 0)
                {
                    MessageBox.Show("Tài Khoản Đã Tồn Tại!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm Tài Khoản Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Tài Khoản Đã Tồn Tại!", "Thông Báo", MessageBoxButtons.OK);
            }

        }

        public void UpdateAccount(string a, string b, string c, string d)
        {
            try
            {
                string query = "UPDATE Account SET UserName = N'" + c + "',PassWord = N'" + d + "' WHERE UserName =  N'" + a + "' AND PassWord = N'" + b + "'";
                int kq = DataProvider.Instance.ExecuteNonQuery(query);
                if (kq == 0)
                {
                    MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Đúng!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập Nhật Tài Khoản Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Đúng!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        public DataTable Load()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account");
            return data;
        }

        public void DeleteAccount(string s1, string s2, string s3)
        {
            try
            {
                string query = "DELETE FROM Account WHERE UserName = N'" + s1 + "' AND Displayname = N'" + s2 + "' AND PassWord = N'" + s3 + "'";
                int a = DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch
            {
                MessageBox.Show("Xóa Tài khoản lỗi");
            }
            finally
            {
                MessageBox.Show("Xóa thành công");
            }
        }

    }
}
