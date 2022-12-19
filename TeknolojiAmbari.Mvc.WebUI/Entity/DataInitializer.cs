using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TeknolojiAmbari.Mvc.WebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name = "Bilgisayar",Description="Bilgisayar Ürünleri"},
                new Category(){Name = "Televizyon",Description="Televizyon Ürünleri"},
                new Category(){Name = "Telefon",Description="Telefon Ürünleri"},
                new Category(){Name = "Kamera",Description="Kamera Ürünleri"},
                new Category(){Name = "Beyaz Eşya",Description="Beyaz Eşya Ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){Name="MSI Mini Tower Oyuncu Kasası" , Description = "İnanılmaz işlemci gücü ve yeni nesil ekran kartı teknolojiyle muazzam oyun deneyimi yaşayın." , Price = 1499 , Stock = 500 , IsApproved = true , CategoryId = 1 , IsHome = true , Image = "1.jpg"},
                new Product(){Name="COOLER MASTER MASTERBOX Oyuncu Kasası" , Description = "İnanılmaz işlemci gücü ve yeni nesil ekran kartı teknolojiyle muazzam oyun deneyimi yaşayın." , Price = 1599 , Stock = 500 , IsApproved = true , CategoryId = 1, IsHome = true , Image = "2.jpg"},
                new Product(){Name="RAMPAGE REDSKY 80 Plus Bronze Oyuncu Kasası " , Description = "İnanılmaz işlemci gücü ve yeni nesil ekran kartı teknolojiyle muazzam oyun deneyimi yaşayın." , Price = 1199 , Stock = 500 , IsApproved = false , CategoryId = 1 , IsHome = true , Image = "3.jpg"},
                new Product(){Name="THERMALTAKE RGB Fanlı Oyuncu Kasası" , Description = "İnanılmaz işlemci gücü ve yeni nesil ekran kartı teknolojiyle muazzam oyun deneyimi yaşayın." , Price = 1399 , Stock = 500 , IsApproved = true , CategoryId = 1 ,IsHome = true , Image = "4.jpg"},
                new Product(){Name="FRISBY 80PLUS MidT ATX Oyuncu Kasası" , Description = "İnanılmaz işlemci gücü ve yeni nesil ekran kartı teknolojiyle muazzam oyun deneyimi yaşayın." , Price = 999 , Stock = 500 , IsApproved = false , CategoryId = 1 , IsHome = true,  Image = "5.jpg"},

                new Product(){Name="PHILIPS 50 Inc 126 CM 4K TV " , Description = "Dev ekranı ve yeni renk paletiyle eşsiz film deneyimi." , Price = 1200 , Stock = 1200  , IsApproved = true , CategoryId = 2 , IsHome = true , Image = "6.jpg"},
                new Product(){Name="SONY 55X89J 55inc 139 cm 4K TV " , Description = "Dev ekranı ve yeni renk paletiyle eşsiz film deneyimi" , Price = 1699 , Stock = 0 , IsApproved = false , CategoryId = 2 , Image = "7.jpg"},
                new Product(){Name="ONVO OV32F700 32inc 82 cm Frameless HD TV" , Description = "Dev ekranı ve yeni renk paletiyle eşsiz film deneyimi" , Price = 800 , Stock = 600 , IsApproved = true, CategoryId = 2 , IsHome = true , Image = "8.jpg"},
                new Product(){Name="VESTEL 70U9600 70inc 178 cm 4K UHD Smart TV" , Description = "Dev ekranı ve yeni renk paletiyle eşsiz film deneyimi" , Price = 1900 , Stock = 500 , IsApproved = true , CategoryId = 2 , Image = "9.jpg"},

                new Product(){Name="Apple iPhone 8 128GB" , Description = "Yeni tasarım, büyük depolama alanı ve güçlü işlemcisiyle sınıfında 1 numara." , Price = 350 , Stock = 1200 , IsApproved = true  , CategoryId = 3 , Image = "10.jpg"},
                new Product(){Name="Apple iPhone 14 128GB" , Description = "Yeni tasarım, büyük depolama alanı ve güçlü işlemcisiyle sınıfında 1 numara." , Price = 899 , Stock = 0 , IsApproved = true , CategoryId = 3 , IsHome = true , Image = "11.jpg"},
                new Product(){Name="Xiaomi Redmi Note 10 Pro " , Description = "Yeni tasarım, büyük depolama alanı ve güçlü işlemcisiyle sınıfında 1 numara." , Price = 200 , Stock = 600 , IsApproved = true , CategoryId = 3 , IsHome = true , Image = "12.jpg"},
                new Product(){Name="Xiaomi Redmi 10T Pro" , Description = "Yeni tasarım, büyük depolama alanı ve güçlü işlemcisiyle sınıfında 1 numara." , Price = 679 , Stock = 500 , IsApproved = true , CategoryId = 3 , Image = "13.jpg"},

                new Product(){Name="Canon Eos 1200D 18-55mm DC Profesyonel Kamera" , Description = "Ergonomik tasarımı ile çekiminizi oluşturmak artık sandığınızdan daha kolay." , Price = 525 , Stock = 1200 , IsApproved = true  , CategoryId = 4 , IsHome = true , Image = "14.jpg"},
                new Product(){Name="Nikon D3100 18-55mm DC Profesyonel Kamera" , Description = "Ergonomik tasarımı ile çekiminizi oluşturmak artık sandığınızdan daha kolay." , Price = 650 , Stock = 0 , IsApproved = false , CategoryId = 4 , Image = "15.jpg"},
                new Product(){Name="Sony HDR-CX405 Handycam Video Kamera" , Description = "Ergonomik tasarımı ile çekiminizi oluşturmak artık sandığınızdan daha kolay." , Price = 780 , Stock = 600 , IsApproved = true , CategoryId = 4 , IsHome = true , Image = "16.jpg"},
                new Product(){Name="Panasonic HC-V785 Eg-K Full Hd Video Kamera" , Description = "Ergonomik tasarımı ile çekiminizi oluşturmak artık sandığınızdan daha kolay." , Price = 460 , Stock = 500 , IsApproved = true , CategoryId = 4 , Image = "17.jpg"}

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}