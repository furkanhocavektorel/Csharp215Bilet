using BiletApp.context;
using BiletApp.DB;
using BiletApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletApp.service
{
    // bir metot veya bir class interface olmadan olmaz
    internal class MusteriService : IMusteriService,IBaseService
    {
        MusteriContext context;
        YöneticiService IyoneticiService;


        public MusteriService()
        {
            context=new MusteriContext();
            IyoneticiService = new YöneticiService();
        }


        public Musteri AdyeGöreGetir(string ad, int id)
        {
            return null;

        }

        public void farklıKaydet(string mail, string password, string ad, string soyad, string tc, int id)
        {
            //aljdgasyrdasuyyyydty
        }

        public Musteri IdYeGöreGetir(int id)
        {
            return null;

        }

        public void IdyeGöreGüncelle(int id)
        {
        }

        public void IdyeGöreSilme(int id)
        {
            throw new NotImplementedException();
        }

        public void Kaydet(string mail, string password, string ad, string soyad,string tc)
        {
           
            bool varMi = false;
            foreach(Musteri m in DB.AllDB.MusteriDB){
                if (m.Mail.Equals(mail))
                {
                    varMi = true;
                    Console.WriteLine("bu mail zaten kayitli");
                    return;
                }
            }

            context.MusteriKaydet(mail,password,ad,soyad);
        }

        public void Kaydet(string mail, string password, string ad, string soyad, string tc, int id)
        {
            throw new NotImplementedException();
        }

        public Musteri MaileGöreGetir(string mail)
        {
            return context.MaileGöreGetir(mail);
        }

        public Musteri TCYeGöreGetir(string tc)
        {
            return null;

        }

        public void TCyeGöreGüncelle(string tc)
        {
        }

        public void TCyeGöreSil(string tc)
        {
        }

        public List<Musteri> TümMusterileriGetir()
        {

            return context.MusterileriGetir();
        }
        
    }
}
