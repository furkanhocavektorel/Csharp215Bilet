using BiletApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletApp.service
{
    internal interface IYoneticiService
    {
        // create-delete-update-read -> CRUD ISlemleri
   
        List<Yönetici> TümYöneticileriGetir();

        Yönetici IdyeGöreGetir(int id);
        Yönetici MaileGöreGetir(string mail);
      
    }
}
