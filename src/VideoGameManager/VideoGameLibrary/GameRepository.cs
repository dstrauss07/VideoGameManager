using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.VideoGameLibrary
{
    public class GameRepository
    {
        private static List<Game> _games = new List<Game>();
        private static int nextId = 0;

        public List<Game> ListAll()
        {
            return _games;
        }
        
        public Game GetById(int id)
        {
            return _games.Find(b => b.Id == id);
        }

        public void Add(Game newGame)
        {
            newGame.Id = nextId++;
            _games.Add(newGame);
        }
        
        public void Edit(Game editGame)
        {
            var origGame = GetById(editGame.Id);

            origGame.Year = editGame.Year;
            origGame.Title = editGame.Title;
            origGame.Platform = editGame.Platform;
            origGame.Genre = editGame.Genre;
        }

        public void Delete(int id)
        {
            var gameToDelete = GetById(id);
            _games.Remove(gameToDelete);
        }
    }
}
