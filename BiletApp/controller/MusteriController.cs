using BiletApp.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletApp.controller
{
    internal class MusteriController
    {
        /*
        1_ interface'ler new 'lenemez
        2_ interfacelerin altında bulunan classlar ile iletişime direkt geçilmemeli
        3_ interfaceler aracılığı ile bağlantı sağlanmalı
        4_ özellikle service katmanı içi interfaceler gerekmektedir

         */
    
        IBaseService _IbaseService;
        IMusteriService _ImusteriService;
        public MusteriController()
        {
            _IbaseService = new MusteriService();
            _ImusteriService = new MusteriService();
        }

        public string Kaydet(string mail, string password, string ad, string soyad, string tc)
        {
            _IbaseService.Kaydet(mail, password, ad, soyad, tc,1);
            return "kayit basarili";
            _IbaseService.farklıKaydet
        }
    }
}
