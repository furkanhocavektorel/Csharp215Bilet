using BiletApp.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletApp.controller
{
    internal class AdminController
    {
        IBaseService baseService;
        public AdminController()
        {
            baseService = new AdminService();
        }
        public void Kaydet(string mail, string password, string ad, string soyad, string tc)
        {
            baseService.Kaydet(mail, password, ad, soyad, tc,3);
            baseService.farklıKaydet(mail, password, ad, soyad, tc, 3);

        }
    }
}
