using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletApp.service
{
    internal interface IBaseService
    {
        void Kaydet(string mail, string password, string ad, string soyad,string tc, int id);
        void IdyeGöreSilme(int id);
        void IdyeGöreGüncelle(int id);
        void farklıKaydet(string mail, string password, string ad, string soyad, string tc, int id);
    }
}
