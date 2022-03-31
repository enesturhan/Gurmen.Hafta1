using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.BadSample
{

    /// <summary>
    /// Burada bizim prensipimize ters düşen nokta product ile order arasında yönetimsel ilişki olmamaasına ragmen bir classa birden fazla sorumluluk yüklüyoruz.
    /// BUda zaten bizim prensibimize ters düşüyor.Product,order ve user yükünü tek bir classa yüklüyoruz buda ilerde herhangi bir sıkıntı olduğunda birden fazla nesnenin birbiri içine girmesi demektir.
    /// Sonrasında projede bir hata durumunda kolay düzeltilebilecek olan bir hatayı çok daha zor düzeltilebilir hale getirmiş olacağız.
    /// </summary>
    internal class SRPBadSample
    {


        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }

        }
        public class Order
        {
            public string CustomerName { get; set; }
            public string ShippingAdress { get; set; }

        }

        public void AddProduct()
        {

        }
        public void AddOrder()
        {

        }
        public void AddUser()
        {

        }
    }
}
