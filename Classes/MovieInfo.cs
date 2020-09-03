using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MovieLibirary.Classes
{
    class MovieInfo
    {
        private string connectionString = "Data Source=CV-BB-5992;Initial Catalog=MovieInfo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private DataSet Execute(string query)
        {
            DataSet resultSet = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(query, new SqlConnection(connectionString))))
            {
                adapter.Fill(resultSet);
            }
            return resultSet;
        }

        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>();
            string allMoviesQuery = "SELECT * FROM Movies";

            // Executer queryen og gemmer den i en variable
            DataSet resultSet = Execute(allMoviesQuery);

            // Får den første table af data sættet og gemmer i en variable
            DataTable moviesTable = resultSet.Tables[0];

            // Laver et nyt object som jeg gemmer i movies listen og returner listen
            foreach (DataRow movieRow in moviesTable.Rows)
            {
                int id = (int)movieRow["id"];
                string name = (string)movieRow["name"];
                string urlString = (string)movieRow["posterurl"];

                Movie movie = new Movie();
                movie.Id = id;
                movie.Name = name;
                movie.Url = urlString;
                movies.Add(movie);
            }
            return movies;
        }
    }
}
