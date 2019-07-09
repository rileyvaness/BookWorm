using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BookWorm.Models
{
    public class BookGenreViewModel
    {
        public List<bookworm> Books { get; set; }
        public SelectList Genres { get; set; }
        public string BookGenre { get; set; }
        public string SearchString { get; set; }
    }
}
