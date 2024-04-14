

using BiletApp.DB;
using BiletApp.entity;

namespace BiletApp.context
{
    internal class MusteriContext
    {
        
        public void MusteriKaydet(string mail, string password, string ad, string soyad)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Mail = mail;
            musteri.Sifre = password;
            musteri.Ad = ad;
            musteri.Soyad = soyad;
            AllDB.MusteriDB.Add(musteri);
        }

        public List<Musteri> MusterileriGetir()
        {
            List<Musteri> listMusteri = new List<Musteri>();

            foreach (Musteri m in AllDB.MusteriDB)
            {
                listMusteri.Add(m);
            }
            return listMusteri;
        }

        public Musteri MaileGöreGetir(string mail)
        {
            foreach (Musteri m in AllDB.MusteriDB)
            {
                if (m.Mail.Equals(mail))
                {
                    return m;
                }

            }

            return null;
        }
    }
}
