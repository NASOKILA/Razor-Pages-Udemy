using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookList_RazorPages.Model
{
    public class Book
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public string ISPN { get; set; }
        
        public double Price { get; set; }

        public int Avaliability { get; set; }
    }
}
