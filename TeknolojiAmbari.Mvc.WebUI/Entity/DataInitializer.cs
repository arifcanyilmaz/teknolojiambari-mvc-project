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
                new Category(){Name = "Kamera",Description="Kamera Ürünleri"},
                new Category(){Name = "Bilgisayar",Description="Bilgisayar Ürünleri"},
                new Category(){Name = "Elektronik",Description="Elektronik Ürünleri"},
                new Category(){Name = "Telefon",Description="Telefon Ürünleri"},
                new Category(){Name = "Beyaz Eşya",Description="Beyaz Eşya Ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            List<Product> urunler = new List<Product>()
            {
                new Product(){Name="MSI Mini Tower Oyuncu Kasası" , Description = "İnanılmaz işlemci gücü ve yeni nesil ekran kartı teknolojiyle muazzam oyun deneyimi yaşayın." , Price = 1499 , Stock = 500 , IsApproved = true , CategoryId = 1 , IsHome = true},
                new Product(){Name="COOLER MASTER MASTERBOX Oyuncu Kasası" , Description = "İnanılmaz işlemci gücü ve yeni nesil ekran kartı teknolojiyle muazzam oyun deneyimi yaşayın." , Price = 1599 , Stock = 500 , IsApproved = true , CategoryId = 1, IsHome = true},
                new Product(){Name="RAMPAGE REDSKY 80 Plus Bronze Oyuncu Kasası " , Description = "İnanılmaz işlemci gücü ve yeni nesil ekran kartı teknolojiyle muazzam oyun deneyimi yaşayın." , Price = 1199 , Stock = 500 , IsApproved = false , CategoryId = 1 , IsHome = true},
                new Product(){Name="THERMALTAKE RGB Fanlı Oyuncu Kasası" , Description = "İnanılmaz işlemci gücü ve yeni nesil ekran kartı teknolojiyle muazzam oyun deneyimi yaşayın." , Price = 1399 , Stock = 500 , IsApproved = true , CategoryId = 1},
                new Product(){Name="FRISBY 80PLUS MidT ATX Oyuncu Kasası" , Description = "İnanılmaz işlemci gücü ve yeni nesil ekran kartı teknolojiyle muazzam oyun deneyimi yaşayın." , Price = 999 , Stock = 500 , IsApproved = false , CategoryId = 1},

                new Product(){Name="PHILIPS 50 Inc 126 CM 4K TV " , Description = "Dev ekranı ve yeni renk paletiyle eşsiz film deneyimi." , Price = 1200 , Stock = 1200  , IsApproved = true , CategoryId = 2 , IsHome = true},
                new Product(){Name="SONY 55X89J 55inc 139 cm 4K TV " , Description = "Dev ekranı ve yeni renk paletiyle eşsiz film deneyimi" , Price = 1699 , Stock = 0 , IsApproved = false , CategoryId = 2},
                new Product(){Name="ONVO OV32F700 32inc 82 cm Frameless HD TV" , Description = "Dev ekranı ve yeni renk paletiyle eşsiz film deneyimi" , Price = 800 , Stock = 600 , IsApproved = true, CategoryId = 2 , IsHome = true},
                new Product(){Name="VESTEL 70U9600 70inc 178 cm 4K UHD Smart TV" , Description = "Dev ekranı ve yeni renk paletiyle eşsiz film deneyimi" , Price = 1900 , Stock = 500 , IsApproved = true , CategoryId = 2},

                new Product(){Name="Apple iPhone 8 128GB" , Description = "Yeni tasarım, büyük depolama alanı ve güçlü işlemcisiyle sınıfında 1 numara." , Price = 350 , Stock = 1200 , IsApproved = true  , CategoryId = 3 , IsHome = true},
                new Product(){Name="Apple iPhone 14 128GB" , Description = "Yeni tasarım, büyük depolama alanı ve güçlü işlemcisiyle sınıfında 1 numara." , Price = 899 , Stock = 0 , IsApproved = false , CategoryId = 3},
                new Product(){Name="Xiaomi Redmi Note 10 Pro " , Description = "Yeni tasarım, büyük depolama alanı ve güçlü işlemcisiyle sınıfında 1 numara." , Price = 200 , Stock = 600 , IsApproved = true , CategoryId = 3 , IsHome = true},
                new Product(){Name="Xiaomi Redmi 10T Pro" , Description = "Yeni tasarım, büyük depolama alanı ve güçlü işlemcisiyle sınıfında 1 numara." , Price = 679 , Stock = 500 , IsApproved = true , CategoryId = 3}
        
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