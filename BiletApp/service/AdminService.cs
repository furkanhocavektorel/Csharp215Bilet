using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletApp.service
{
    internal class AdminService : IBaseService
    {
        YöneticiService yöneticiService;
        MusteriService musteriService;
        public AdminService()
        {
            yöneticiService = new YöneticiService();
            musteriService = new MusteriService();
        }
        public void farklıKaydet(string mail, string password, string ad, string soyad, string tc, int id)
        {
           //sakdjgasgdafsgddıyuwg7ıuyefkfgs
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
    }
}
