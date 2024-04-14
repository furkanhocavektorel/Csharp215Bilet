using BiletApp.controller;
using BiletApp.DB;
using BiletApp.entity;
using BiletApp.service;

namespace BiletApp
{
    internal class Program
    {
       // Main MEtodu = Front- WEb Sayfası
        static void Main(string[] args)
        {
            AllDB allDB= new AllDB();
            IAdminController = new AdminController();
            MusteriController musteriController = new MusteriController();
            string sonuc=musteriController.Kaydet("furkan@gmail.com", "123", "furkan", "türkmen");

            Console.WriteLine(sonuc);
         
        }


    }
}