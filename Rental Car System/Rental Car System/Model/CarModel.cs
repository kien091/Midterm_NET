using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Rental_Car_System.Model
{
    internal class CarModel
    {
		public int id { get; set; }
		public string name { get; set; }
		public string image { get; set; }
		public string brand { get; set; }
        public string model { get; set; }
        public string type { get; set; }
		public string fuel { get; set; }
        public int hireprice { get; set; }
        public bool status { get; set; }

        public CarModel() { }
        public CarModel(int id)
        {
            this.id = id;
        }
        public CarModel(string name, string image, string brand, string model, string type, string fuel, int hireprice, bool status)
        {
            this.name = name;
            this.image = image;
            this.brand = brand;
            this.model = model;
            this.type = type;
            this.fuel = fuel;
            this.hireprice = hireprice;
            this.status = status;
        }
        public CarModel(int id, string name, string image, string brand, string model, string type, string fuel, int hireprice, bool status)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.brand = brand;
            this.model = model;
            this.type = type;
            this.fuel = fuel;
            this.hireprice = hireprice;
            this.status = status;
        }

        public void InsertCar(SqlConnection connection)
        {
            string query = "INSERT INTO Car (Name, Image, Brand, Model, Type, Fuel, HirePrice, Status) " +
                "VALUES (@name, @image, @brand, @model, @type, @fuel, @hireprice, @status)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@image", image);
                command.Parameters.AddWithValue("@brand", brand);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@fuel", fuel);
                command.Parameters.AddWithValue("@hireprice", hireprice);
                command.Parameters.AddWithValue("@status", status);

                command.ExecuteNonQuery();
            }
        }
        public static DataTable GetDataToLoadDataGridView(SqlConnection connection)
        {
            String query = "SELECT Id, Name, Brand, Model, Type FROM Car";
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
        public static DataTable GetDataToLoadDGVReservation(SqlConnection connection)
        {
            String query = "SELECT Id, Name, Brand, Model, Type, Fuel FROM Car WHERE Status = 0";
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
        public static CarModel findCarById(SqlConnection connection, int id)
        {
            String query = "SELECT * FROM Car WHERE Id = @id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                CarModel car = new CarModel();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    car.id = id;
                    car.name = reader["Name"].ToString();
                    car.image = reader["Image"].ToString();
                    car.brand = reader["Brand"].ToString();
                    car.model = reader["Model"].ToString();
                    car.type = reader["Type"].ToString();
                    car.fuel = reader["Fuel"].ToString();
                    car.hireprice = Convert.ToInt32(reader["HirePrice"]);
                    car.status = Convert.ToBoolean(reader["Status"]);
                }
                reader.Close();
                return car;
            }
        }
        public void updateCar(SqlConnection connection)
        {
            string query = "UPDATE Car SET Name = @Name, Image = @Image, Brand = @Brand, Model = @Model, " +
                           "Type = @Type, Fuel = @Fuel, HirePrice = @HirePrice, Status = @Status WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Image", image);
                command.Parameters.AddWithValue("@Brand", brand);
                command.Parameters.AddWithValue("@Model", model);
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@Fuel", fuel);
                command.Parameters.AddWithValue("@HirePrice", hireprice);
                command.Parameters.AddWithValue("@Status", status ? 1:0);

                command.ExecuteNonQuery();
            }
        }
        public void deleteCar(SqlConnection connection)
        {
            string query = "DELETE FROM Car WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        public static List<string> GetCarTypes(SqlConnection connection)
        {
            string query = "SELECT DISTINCT Type FROM Car";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<string> carTypes = new List<string>();

                    while (reader.Read())
                    {
                        string type = reader["Type"].ToString();
                        carTypes.Add(type);
                    }

                    return carTypes;
                }
            }
        }
    }
}
