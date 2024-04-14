
using BiletApp.entity;

namespace BiletApp.service
{
    internal class YöneticiService : IYoneticiService, IBaseService
    {
        public void farklıKaydet(string mail, string password, string ad, string soyad, string tc, int id)
        {
          // adfhsagfdasudasıugdasıoudga
        }

        public Yönetici IdyeGöreGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void IdyeGöreGüncelle(int id)
        {
            throw new NotImplementedException();
        }

        public void IdyeGöreSilme(int id)
        {
            throw new NotImplementedException();
        }

        public void Kaydet(string mail, string password, string ad, string soyad,string tc)
        {
            throw new NotImplementedException();
        }

        public void Kaydet(string mail, string password, string ad, string soyad, string tc, int id)
        {
            throw new NotImplementedException();
        }

        public Yönetici MaileGöreGetir(string mail)
        {
            throw new NotImplementedException();
        }

        public List<Yönetici> TümYöneticileriGetir()
        {
            throw new NotImplementedException();
        }
    }
}
