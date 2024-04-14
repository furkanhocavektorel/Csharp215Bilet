using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletApp.entity
{
    internal class Musteri:BaseEntity
    {
       
        public int Yas { get; set; }
        public Cinsiyet.Sec Cinsiyet { get; set; }

        public Musteri()
        {

        }
        // dolu conts

    }
}
