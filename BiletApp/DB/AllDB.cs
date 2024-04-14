using BiletApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletApp.DB
{
    internal class AllDB
    {
        public static List<Musteri> MusteriDB;

        public AllDB()
        {
            MusteriDB = new List<Musteri>();
        }
    }
}
