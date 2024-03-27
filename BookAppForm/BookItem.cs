using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class BookItem
    {
        public BookItem() 
        {

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Location { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }

    }
}
