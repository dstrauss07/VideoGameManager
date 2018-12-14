using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.VideoGameLibrary
{
    public class Game
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public string Platform { get; set; }
        public string Genre { get; set; }

        public string GetFullName()
        {
            return $"{Year} {Title} {Platform} {Genre}";
        }
    }


}
