using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Code_First
{
    public class Page
    {
        public Guid Id { get; set; }//gauname unikalu string kiekviena karta, jis pravartus duombazeje
        public int Number { get; set; }
        public string Content { get; set; }

        [ForeignKey("Book")]//turi sutapti su navproperty pavadinimu
        public Guid BookId { get; set; }//Foreign KEy - kokiai knygai priklauso
        //navigation property
        public Book Book { get; set; }//leis naviguot tarp knygos ir puslaipo, is puslapio i knyga.


        public Page(int number, string content)
        {
            Id = Guid.NewGuid();//generuojam nauja visada
            Number = number;
            Content = content;
        }

        public Page(Guid id)
        {
            Id = id;
        }
    }
}
