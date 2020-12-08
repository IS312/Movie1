
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie1.DataBaseOperations
{
    public class RentalMovie
    {
        // Add Movie
        public bool RentMovie(string CustId, string MovieId, string IssueDate, string ReturnDate)
        {
            SqlCommand cmd = Connection.StartConnection().CreateCommand();
            cmd.CommandText = "RentMovieSP"; // stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MovieID", MovieId);
            cmd.Parameters.AddWithValue("@CustID", CustId);
            cmd.Parameters.AddWithValue("@RentDate", IssueDate);
            cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
            
            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }

        // Get All RentedData
        public DataTable GetAllRentedData()
        {
            SqlCommand cmd = Connection.StartConnection().CreateCommand();
            
            cmd.CommandText = "RentedMovieSP";  // stored procedure
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }

       

        //RentedMovies
        public DataTable GetRentedMoviesDDL()
        {
            SqlCommand cmd = Connection.StartConnection().CreateCommand();
            
            cmd.CommandText = "select rm.MovieID, Title from RentedMovies rm join mymovies mv on rm.movieid= mv.movieid where rentedDate is not null group by Title, rm.MovieID";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }


        // Return Movie
        public bool ReturnMovie(int MovieID, int CustId)
        {
            SqlCommand cmd = Connection.StartConnection().CreateCommand();
            cmd.CommandText = "ReturnMovieSP"; // stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@movieID", MovieID);
            cmd.Parameters.AddWithValue("@CustID", CustId);

            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }


        //Customers who borrows most movies
        public DataTable BorrowMostMovies()
        {
            SqlCommand cmd = Connection.StartConnection().CreateCommand();
            cmd.CommandText = "BorrowMostMoviesSP"; // store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }

        //Most popular movies
        public DataTable PopularMovies()
        {
            SqlCommand cmd = Connection.StartConnection().CreateCommand();
            cmd.CommandText = "MostPopularMoviesSP"; // store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }

        
    }
}
