using Microsoft.EntityFrameworkCore;//DbContext klase
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Code_First
{
    public class BookContext : DbContext// ateina is EntityFramework
    {
        public DbSet<Page> Pages { get; set; }//duombazej bus lentele su tipu page, cia susikureme puslapiu kolekcija

        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//konfiguruojam kokiu budu susisieja su duombaze
        {                                                                           //reikia parodyti specifiskai kaip mes darome
                                                                                    //nes dontent kodas neamto ka mes darome
                                                                                    //base.OnConfiguring(optionsBuilder);default


            optionsBuilder.UseSqlServer($"Server=(localdb)\\mssqllocaldb;Database=EntityFrameworkCodeFirst;Trusted_Connection=True;");
            //serverio pavadinimas toks koks yra nurodytas per SQL
            //database - pavadinimas
            //kaip jungtis: kokiu useriu. autentifikacija.
        }
    }
}
