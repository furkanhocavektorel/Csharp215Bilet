using BiletApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletApp.service
{
    internal interface IMusteriService
    {

        List<Musteri> TümMusterileriGetir();
        Musteri TCYeGöreGetir(string tc);
        Musteri IdYeGöreGetir(int id);

        void TCyeGöreSil(string tc);
        void TCyeGöreGüncelle(string tc);
        Musteri AdyeGöreGetir(string ad,int id);

        Musteri MaileGöreGetir(string mail);
        
    }
}
