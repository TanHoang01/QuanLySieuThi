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
    class AccountDAO : DataProvider
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

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            { 
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Account VALUES (@UserName,@DisplayName,@PassWord,@TYPE)", connection);
                    command.Parameters.AddWithValue("@UserName", acconut.UserName);
                    command.Parameters.AddWithValue("@DisplayName", acconut.DisplayName);
                    command.Parameters.AddWithValue("@PassWord", acconut.PassWord);
                    command.Parameters.AddWithValue("@TYPE", acconut.Type);
                    int a = command.ExecuteNonQuery();
                    connection.Close();
                    if (a == 0)
                    {
                        MessageBox.Show("Tài Khoản Đã Tồn Tạo!", "Thông Báo", MessageBoxButtons.OK);
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
            
        }
        public void UpdateAccount(string a, string b,string c,string d)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Account SET UserName = '" + c + "',PassWord = '" + d + "' WHERE UserName =  '" + a + "' AND PassWord = '" + b + "'", connection);
                    int e = command.ExecuteNonQuery();
                    connection.Close();
                    if (e == 0)
                    {
                        MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Đúng!", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Tài Khoản Admin Đã Được Cập Nhật!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
                catch
                {
                    MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Đúng!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }
        public DataTable Load()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account");
            return data;
        }
        public void DeleteAccount(string s1, string s2, string s3)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Account WHERE UserName = '" + s1 + "' AND Displayname = '" + s2 + "' And PassWord = '" + s3 + "'", connection);
                    command.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Xóa Tài khoản lỗi");
                }
                finally
                {
                    connection.Close();
                    MessageBox.Show("Xóa thành công");
                }
            }
        }
    }
}
