using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.VideoGameLibrary
{
    class Rpg : Game
    {
        public string Setting { get; set; }

        public string GetFullNameRPG()
        {
            return $"{Year} {Title} {Platform} {Genre} {Setting}";
        }
    }
}
