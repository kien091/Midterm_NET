using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Car_System.Model
{
    internal class UserModel
    {
        public int id { get; set; }
        public string avatar { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string role { get; set; }
        public UserModel() { }
        public UserModel(int id, string avatar, string username, string password, string email, string phoneNumber, string role)
        {
            this.id = id;
            this.avatar = avatar;
            this.username = username;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.role = role;
        }

        public void InsertUser(SqlConnection connection)
        {
            string query = "INSERT INTO User (Avatar, UserName, Password, Email, PhoneNumber, Role) " +
                "VALUES (@Avatar, @UserName, @Password, @Email, @PhoneNumber, @Role)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Avatar", avatar);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Role", role);

                command.ExecuteNonQuery();
            }
        }
    }
}
