using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Rental_Car_System.Model
{
    internal class ReservationModel
    {
        public int id { get; set; }
        public DateTime hireDate { get; set; }
        public DateTime returnDate { get; set; }
        public string features { get; set; }
        public int totalPrices { get; set; }
        public int idUser{ get; set; }
        public int idCustomer { get; set; }
        public int idCar { get; set; }
        public ReservationModel() { }
        public ReservationModel(int id)
        {
            this.id = id;
        }
        public ReservationModel(DateTime hireDate, DateTime returnDate, string features, int totalPrices, int idUser, int idCustomer, int idCar)
        {
            this.hireDate = hireDate;
            this.returnDate = returnDate;
            this.features = features;
            this.totalPrices = totalPrices;
            this.idUser = idUser;
            this.idCustomer = idCustomer;
            this.idCar = idCar;
        }
        public ReservationModel(int id, DateTime hireDate, DateTime returnDate, string features, int totalPrices, int idUser, int idCustomer, int idCar)
        {
            this.id = id;
            this.hireDate = hireDate;
            this.returnDate = returnDate;
            this.features = features;
            this.totalPrices = totalPrices;
            this.idUser = idUser;
            this.idCustomer = idCustomer;
            this.idCar = idCar;
        }
        public void InsertReservation(SqlConnection connection)
        {
            String query = "INSERT INTO Reservation (hiredate, returnDate, features, totalPrices, idUser, idCustomer, idCar) " +
                "VALUES (@hiredate, @returnDate, @features, @totalPrices, @idUser, @idCustomer, @idCar)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@hiredate", hireDate);
                command.Parameters.AddWithValue("@returnDate", returnDate);
                command.Parameters.AddWithValue("@features", features);
                command.Parameters.AddWithValue("@totalPrices", totalPrices);
                command.Parameters.AddWithValue("@idUser", idUser);
                command.Parameters.AddWithValue("@idCustomer", idCustomer);
                command.Parameters.AddWithValue("@idCar", idCar);

                command.ExecuteNonQuery();
            }
        }

        public static DataTable GetDataToLoadDataGridView(SqlConnection connection)
        {
            String query = "SELECT Reservation.Id, Customer.Name as CustomerName, Customer.PhoneNumber, Car.Name as CarName, Reservation.TotalPrices " +
                "FROM Reservation " +
                "JOIN Customer ON Reservation.IdCustomer = Customer.Id " +
                "JOIN Car ON Reservation.IdCar = Car.Id";
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
        public static DataTable GetDataToLoadDGVSchedule(SqlConnection connection, int customerId)
        {
            string query = @"SELECT r.Id, c.Name as CarName, r.HireDate, r.ReturnDate, r.TotalPrices
                                     FROM Reservation r
                                     INNER JOIN Car c ON r.IdCar = c.Id
                                     WHERE r.IdCustomer = @CustomerId";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CustomerId", customerId);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    return data;
                }
            }
        }
        public static ReservationModel findReservationById(SqlConnection connection, int id)
        {
            String query = "SELECT * FROM Reservation WHERE Id = @id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                ReservationModel reservationModel = new ReservationModel();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    reservationModel.id = Convert.ToInt32(reader["Id"]);
                    reservationModel.hireDate = Convert.ToDateTime(reader["HireDate"]);
                    reservationModel.returnDate = Convert.ToDateTime(reader["ReturnDate"]);
                    reservationModel.features = reader["Features"].ToString();
                    reservationModel.totalPrices = Convert.ToInt32(reader["TotalPrices"]);
                    reservationModel.idUser = Convert.ToInt32(reader["IdUser"]);
                    reservationModel.idCustomer = Convert.ToInt32(reader["IdCustomer"]);
                    reservationModel.idCar = Convert.ToInt32(reader["IdCar"]);

                }
                reader.Close();
                return reservationModel;
            }
        }
        public void updateReservation(SqlConnection connection)
        {
            string query = "UPDATE Reservation SET HireDate = @HireDate, ReturnDate = @ReturnDate, " +
                           "Features = @Features, TotalPrices = @TotalPrices, IdUser = @IdUser, " +
                           "IdCustomer = @IdCustomer, IdCar = @IdCar WHERE Id = @Id";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@HireDate", hireDate);
                command.Parameters.AddWithValue("@ReturnDate", returnDate);
                command.Parameters.AddWithValue("@Features", features);
                command.Parameters.AddWithValue("@TotalPrices", totalPrices);
                command.Parameters.AddWithValue("@IdUser", idUser);
                command.Parameters.AddWithValue("@IdCustomer", idCustomer);
                command.Parameters.AddWithValue("@IdCar", idCar);

                command.ExecuteNonQuery();
            }
        }

        public void deleteReservation(SqlConnection connection)
        {
            string query = "DELETE FROM Reservation WHERE Id = @Id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
