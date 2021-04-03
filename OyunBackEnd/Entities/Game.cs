using System;
using System.Collections.Generic;
using System.Text;

namespace OyunBackEnd.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string NameOfTheGame { get; set; }
        public string Category { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
    }
}
