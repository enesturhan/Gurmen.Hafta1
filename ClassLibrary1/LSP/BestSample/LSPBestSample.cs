using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.BestSample
{


    //Düzgün örnekte bizim base classımıza sadece 2 classta ortak olması gereken memberleri yazıyoruz.

    //Ekstra eklenecek kısımları sınıfımızın içine kendi gerekli olan propertileri verebiliriz veya gerekli olan methodları yazabilirizç

    //Burada 2 classtada ortak olan alan ve çevre hesaplama methodlarıdır. Base classımıza uzunluk değeri veremiyoruz. Çünkü circle sınıfı bu uzunluğu kullanamıyor. Bu yüzden ikisindede ortak olan memberleri yazıyoruz.

    internal class LSPBestSample
    {
        


        public abstract class Shape
        {
            public abstract double GetArea();
            public abstract double GetPerimeter();


        }

        public class Rectangle : Shape
        {
            public double Height { get; set; }

            public override double GetArea() {

                return Height * Height;
            }
            public override double GetPerimeter()
            {
                return 4 * Height;
            }

        }
        public class Circle : Shape
        {
            public double Radius { get; set; }
            public override double GetArea()
            {
                return 3.14 * Radius * Radius;
            }

            public override double GetPerimeter()
            {
                return 2 * (3.14) * Radius;
            }
        }
    }
}
