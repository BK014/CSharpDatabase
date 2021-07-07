using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using RentalService.Models;

namespace RentalService
{
    public class DAO
    {
        // Gets the connection of the database from the connection string.
        private SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=VBMOVIESFULLDATA.MDF;Integrated Security=True");
            return con;
        }

        // the function executes the query and returns the reader from the database.
        private SqlDataReader ExecuteQuery(string sqlCommand, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(sqlCommand, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        // The function executes the non query component like - Insert or update or delete.
        private void ExecuteNonQuery(string sqlCommand, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(sqlCommand, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // The function gets all the customers.
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            SqlConnection conn = GetConnection();
            SqlDataReader reader = ExecuteQuery("Select * from Customer", conn);

            while (reader.Read())
            {
                Customer customer = new Customer
                {
                    Address = reader["Address"].ToString(),
                    CustID = Convert.ToInt32(reader["CustID"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Phone = reader["Phone"].ToString(),
                };
                customers.Add(customer);
            }

            return customers;
        }


        // The function adds the customer.
        public void AddCustomer(Customer customer)
        {
            SqlConnection conn = GetConnection();
            ExecuteNonQuery(String.Format("insert into customer(FirstName, LastName, Address, Phone) values('{0}','{1}','{2}','{3}')",customer.FirstName,customer.LastName,customer.Address,customer.Phone), conn);
        }

        // The function updates the customer.
        public void UpdateCustomer(Customer customer)
        {
            SqlConnection conn = GetConnection();
            ExecuteNonQuery(String.Format("update customer set Firstname='{0}', LastName='{1}', Address='{2}', Phone='{3}' where CustID={4}", customer.FirstName, customer.LastName, customer.Address, customer.Phone,customer.CustID), conn);
        }

        // The function deletes the customer
        public void DeleteCustomer(int customerId)
        {
            SqlConnection conn = GetConnection();
            ExecuteNonQuery(String.Format("delete from customer where CustID={0}",customerId), conn);
        }

        // The function gets all the movies
        public List<Movies> GetAllMovies()
        {
            List<Movies> movies = new List<Movies>();
            SqlConnection conn = GetConnection();
            SqlDataReader reader = ExecuteQuery("Select * from Movies", conn);

            while (reader.Read())
            {
                Movies movie = new Movies
                {
                    Copies = reader["Copies"].ToString(),
                    MovieId = Convert.ToInt32(reader["MovieId"]),
                    Rating = reader["Rating"].ToString(),
                    Title = reader["Title"].ToString(),
                    Year = reader["Year"].ToString(),
                    Rental_Cost = Convert.ToDecimal(reader["Rental_Cost"]==DBNull.Value ? 0: reader["Rental_Cost"]),
                    Plot = reader["Plot"].ToString(),
                    Genre = reader["Genre"].ToString(),
                };
                movies.Add(movie);
            }

            return movies;
        }


        // The function adds a movie to the table
        public void AddMovie(Movies movie)
        {
            SqlConnection conn = GetConnection();

            // condition to check the rental cost for the movie
            int year = Convert.ToInt32(movie.Year);
            if (year > 5)
                movie.Rental_Cost = (decimal?)2.00;
            else
                movie.Rental_Cost = (decimal?)5.00;

            movie.Plot = movie.Plot.Replace("'", "''");

            ExecuteNonQuery(String.Format("insert into movies(Rating, Title, Year, Rental_Cost, Copies, Plot, Genre) values('{0}','{1}','{2}',{3},'{4}','{5}','{6}')",movie.Rating,movie.Title,movie.Year,movie.Rental_Cost,movie.Copies,movie.Plot,movie.Genre), conn);
        }

        // The function updates the movie.
        public void UpdateMovie(Movies movie)
        {
            SqlConnection conn = GetConnection();

            // condition to check the rental cost for the movie
            int year = Convert.ToInt32(movie.Year);
            if (year > 5)
                movie.Rental_Cost = (decimal?)2.00;
            else
                movie.Rental_Cost = (decimal?)5.00;
            movie.Plot = movie.Plot.Replace("'", "''");
            ExecuteNonQuery(String.Format("update movies set Rating='{0}', Title='{1}', Year='{2}', Rental_Cost={3}, Copies='{4}', Plot='{5}',Genre='{6}' where MovieId={7}", movie.Rating, movie.Title, movie.Year, movie.Rental_Cost, movie.Copies, movie.Plot, movie.Genre,movie.MovieId), conn);
        }


        // Deletes a movie from table
        public void DeleteMovie(int movieId)
        {
            SqlConnection conn = GetConnection();

            ExecuteNonQuery(String.Format("delete from movies where MovieId={0}", movieId), conn);
        }

        // The function gets all the rented movies that are there in the table
        public List<RentedMovies> GetAllRentedMovies()
        {
            List<RentedMovies> rentedmovies = new List<RentedMovies>();
            SqlConnection conn = GetConnection();

            // the query uses inner join to join more than two tables.
            SqlDataReader reader = ExecuteQuery("Select * from RentedMovies rm inner join customer c on c.CustID = rm.CustIDFK inner join movies m on m.MovieId=rm.MovieIDFK", conn);

            while (reader.Read())
            {
                RentedMovies rentedmovie = new RentedMovies
                {
                    RMID = Convert.ToInt32(reader["RMID"]),
                    MovieIDFK = Convert.ToInt32(reader["MovieIDFK"]),
                    CustIDFK = Convert.ToInt32(reader["CustIDFK"]),
                    DateRented = Convert.ToDateTime(reader["DateRented"]),
                    DateReturned = reader["DateReturned"] == DBNull.Value?(DateTime?)null:(DateTime?)reader["DateReturned"],
                    Address = reader["Address"].ToString(),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Title = reader["Title"].ToString(),
                    Rental_Cost = Convert.ToDecimal(reader["Rental_Cost"] == DBNull.Value ? 0 : reader["Rental_Cost"]),
                };
                rentedmovies.Add(rentedmovie);
            }

            return rentedmovies;
        }


        // Gets all the movies that are out. This function uses a view to return the data
        public List<RentedMovies> GetAllOutMovies()
        {
            List<RentedMovies> rentedmovies = new List<RentedMovies>();
            SqlConnection conn = GetConnection();
            SqlDataReader reader = ExecuteQuery("Select * from MoviesOut", conn);

            while (reader.Read())
            {
                RentedMovies rentedmovie = new RentedMovies
                {
                    RMID = Convert.ToInt32(reader["RMID"]),
                    DateRented = Convert.ToDateTime(reader["DateRented"]),
                    DateReturned = reader["DateReturned"] == DBNull.Value ? (DateTime?)null : (DateTime?)reader["DateReturned"],
                    Address = reader["Address"].ToString(),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Title = reader["Title"].ToString(),
                    Rental_Cost = Convert.ToDecimal(reader["Rental_Cost"] == DBNull.Value ? 0 : reader["Rental_Cost"]),
                };
                rentedmovies.Add(rentedmovie);
            }

            return rentedmovies;
        }

        // The function issues a movie to the customer
        public void IssueMovie(RentedMovies rentedMovies)
        {
            SqlConnection conn = GetConnection();
            ExecuteNonQuery(String.Format("insert into RentedMovies(CustIDFK, MovieIDFK, DateRented) values({0},{1},'{2}')", rentedMovies.CustIDFK,rentedMovies.MovieIDFK,rentedMovies.DateRented), conn);
        }

        // This uses stored Procedure
        // This function returns a movie from the user.
        public void ReturnMovie(RentedMovies rentedMovies)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ReturnMovie";
            cmd.Connection = conn;

            SqlParameter param1 = new SqlParameter();
            param1.SqlDbType = SqlDbType.Int;
            param1.ParameterName = "@RMID";
            param1.Value = rentedMovies.RMID;

            SqlParameter param2 = new SqlParameter();
            param2.SqlDbType = SqlDbType.DateTime;
            param2.ParameterName = "@DateReturned";
            param2.Value = rentedMovies.DateReturned;

            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // Gets the list of the customers that have borrowed movies in descending order of their total rentals.
        public List<Customer> GetCustomersBorrowingMoreMovies()
        {
            List<Customer> customers = new List<Customer>();
            SqlConnection conn = GetConnection();
            SqlDataReader reader = ExecuteQuery("select * from CUSTOMER_BORROWING_MORE_MOVIES", conn);

            while (reader.Read())
            {
                Customer customer = new Customer
                {
                    Address = reader["Address"].ToString(),
                    CustID = Convert.ToInt32(reader["CustID"]),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Phone = reader["Phone"].ToString(),
                };
                customers.Add(customer);
            }
            return customers;
        }

        // Gets the list of the movies that have been borrowed most by the customers.
        public List<Movies> GetMostBorrowedMovies()
        {
            List<Movies> movies = new List<Movies>();
            SqlConnection conn = GetConnection();
            SqlDataReader reader = ExecuteQuery("select * from MostBorrowedMovies", conn);

            while (reader.Read())
            {
                Movies movie = new Movies
                {
                    Copies = reader["Copies"].ToString(),
                    MovieId = Convert.ToInt32(reader["MovieId"]),
                    Rating = reader["Rating"].ToString(),
                    Title = reader["Title"].ToString(),
                    Year = reader["Year"].ToString(),
                    Rental_Cost = Convert.ToDecimal(reader["Rental_Cost"] == DBNull.Value ? 0 : reader["Rental_Cost"]),
                    Plot = reader["Plot"].ToString(),
                    Genre = reader["Genre"].ToString(),
                };
                movies.Add(movie);
            }

            return movies;
        }
    }
}
