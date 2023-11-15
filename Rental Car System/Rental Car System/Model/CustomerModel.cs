using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Car_System.Model
{
    internal class CustomerModel
    {
        public int id { get; set; }
        public string avatar { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime dob { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public CustomerModel() { }
        public CustomerModel(int id) 
        {
            this.id = id;
        }
        public CustomerModel(int id, string avatar, string name, string email, string phone, DateTime dob, string gender, string address)
        {
            this.id = id;
            this.avatar = avatar;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.dob = dob;
            this.gender = gender;
            this.address = address;
        }
        public CustomerModel(string avatar, string name, string email, string phone, DateTime dob, string gender, string address)
        {
            this.avatar = avatar;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.dob = dob;
            this.gender = gender;
            this.address = address;
        }
        public void InsertCustomer(SqlConnection connection)
        {
            String query = "INSERT INTO Customer (Avatar, Name, Email, PhoneNumber, Dob, Gender, Address) " +
                "VALUES (@Avatar, @Name, @Email, @PhoneNumber, @Dob, @Gender, @Address)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Avatar", avatar);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PhoneNumber", phone);
                command.Parameters.AddWithValue("@Dob", dob);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Address", address);

                command.ExecuteNonQuery();
            }
        }
        public static DataTable GetDataToLoadDataGridView(SqlConnection connection) {
            String query = "SELECT Id, Name, Email, PhoneNumber FROM Customer";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    return data;
                }
            }
        }
        public static CustomerModel findCustomerById(SqlConnection connection, int id) 
        {
            String query = "SELECT * FROM Customer WHERE Id = @id";
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                CustomerModel customer = new CustomerModel();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string avatar = reader["Avatar"].ToString();
                    string name = reader["Name"].ToString();
                    string email = reader["Email"].ToString();
                    string phone = reader["PhoneNumber"].ToString();
                    DateTime dob = Convert.ToDateTime(reader["Dob"]);
                    string gender = reader["Gender"].ToString();
                    string address = reader["address"].ToString();

                    customer = new CustomerModel(id, avatar, name, email, phone, dob, gender, address);
                }
                reader.Close();
                return customer;
            }
        }
        public void updateCustomer(SqlConnection connection)
        {
            string query = "UPDATE Customer SET Avatar = @Avatar, Name = @Name, Email = @Email, " +
                           "PhoneNumber = @Phone, Dob = @Dob, Gender = @Gender, Address = @Address WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Avatar", avatar);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Dob", dob);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Address", address);

                command.ExecuteNonQuery();
            }
        }
        public void deleteCustomer(SqlConnection connection)
        {
            string query = "DELETE FROM Customer WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public static CustomerModel FindCustomerByPhoneNumber(SqlConnection connection, string phoneNumber)
        {
            string query = "SELECT * FROM Customer WHERE PhoneNumber = @PhoneNumber";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                SqlDataReader reader = command.ExecuteReader();
                CustomerModel customer = null;

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    string avatar = reader["Avatar"].ToString();
                    string name = reader["Name"].ToString();
                    string email = reader["Email"].ToString();
                    string phone = reader["PhoneNumber"].ToString();
                    DateTime dob = Convert.ToDateTime(reader["Dob"]);
                    string gender = reader["Gender"].ToString();
                    string address = reader["Address"].ToString();

                    customer = new CustomerModel(id, avatar, name, email, phone, dob, gender, address);
                }

                reader.Close();
                return customer;
            }
        }
    }
}
