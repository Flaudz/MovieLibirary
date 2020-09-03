using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibirary.Classes
{
    public class Movie
    {
        private int id;
        private string name;
        private string url;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Url { get => url; set => url = value; }

        public Movie()
        {

        }

        public Movie(string name, string url)
        {

        }
    }
}
