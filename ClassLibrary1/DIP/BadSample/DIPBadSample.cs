using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.BadSample
{
    //Dependency inversion =bağımlılıkların terse çevrilmesi prensibi

    //Her yazdığım sınıf için gelip buraya yeni bir instance almam gerekiyor
    //ÜST VE alt seviye sınıfların birbirleri ile bağımlılıkları sıkı sıkıya değil(tight couple) 

    //Lose couple olmalıdır.

    //Buradaki yanlış örnekte bir üst sınıf alt sınıfı instance alıyor ve ramde yer kaplıyor . Bu yüzden temizleme işini garbage collectore bırakmış oluyoruz.
    //Bu aslında yanlış bir kullanımdır.
    internal class DIPBadSample
    {



        public class Product
        {

            private readonly ProductStockService _productStockService;

            private readonly ProductTypeService _productTypeService;

            public Product()
            {
                _productStockService = new ProductStockService();
                _productTypeService = new ProductTypeService();
            }

        }
    }















    public class ProductStockService
    {

    }
    public class ProductTypeService
    {

    }
}
