using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.BadSample
{

    //Liskov substition a göre kalıtım alınan sınıfın tüm memberları inherif alınan sınıflar tarafından kullanılmalıdır. 
    
    //Buradaki örnekte bizim base clasımızdaki height ve weight degerlerini triangle classında implemente ediyorum ama kullanmıyorum o yüzden içi boş şekilde kalıyor kullanmıyorum.

    //Aynı şekilde abstract yapmamızada gerek yok çünkü değiştirme yapmıyoruz. Yani aslında base clasımızda sadece diğer classlarımızda implemente ediceğim memberları yazmam gerekiyor.

    internal class LSPBadSample
    {

        public abstract class ShapeBase
        {
            public abstract double Height { get; set; }
            public abstract double Weight { get; set; }

        }

        public class Triangle : ShapeBase
        {
            public override double Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public override double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

        public class Square : ShapeBase
        {
            public override double Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public override double Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public double GetArea(double height,double weight)
            {

                return height * weight;

            }
        }


    }
}
