using System.Data.SqlClient;

namespace WebApplication15.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Region { get; set; }
        public DateTime? BirthDate { get; set; }
    }

    public class NorthwindDb
    {
        private string _connectionString;

        public NorthwindDb(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Employee> GetAll()
        {
            //int? x = null;

            //if(x == null)
            //{

            //}

            //DateTime? foo;

            //foo.Value.


            var connection = new SqlConnection(_connectionString);
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Employees";
            connection.Open();
            var reader = cmd.ExecuteReader();
            var employees = new List<Employee>();
            while (reader.Read())
            {
                employees.Add(new()
                {
                    Id = (int)reader["EmployeeId"],
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    Region = reader.GetOrNull<string>("Region"),
                    BirthDate = reader.GetOrNull<DateTime?>("BirthDate")
                });
            }

            return employees;
        }
    }
}
