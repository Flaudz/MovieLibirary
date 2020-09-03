using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibirary.Classes
{
    class MiddleClass
    {
        MovieInfo movieInfo = new MovieInfo();



        List<Movie> movies = new List<Movie>();

        public MiddleClass()
        {

        }

        public List<Movie> Movies { get => movies; set => movies = value; }

        public void changeMovie()
        {
            Movies = movieInfo.GetMovies();
        }
    }
}
