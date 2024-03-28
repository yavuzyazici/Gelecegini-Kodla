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
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi {  get; set; }
        public string Tur { get; set; }
        public string Durum { get; set; }
        public string OkunmaTarihi { get; set; }
        public string ISBN { get; set; }

    }
}
