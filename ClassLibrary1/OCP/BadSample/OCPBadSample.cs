using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.BadSample
{
    internal class OCPBadSample
    {

        //Kod gelişime acık degisime kapalı olmalıdır.
        //Yeni bir kod eklediğimizde kodu revize etmememiz gerekir sadece uygulamamız gerekmektedir.


        //Burada aynı method icerisinde düzeltme yapıyorsak kodumuzda bu ocp ters bir olaydır. Burda her işlem ayrı ayrı methodlarda calısma yapılmalıdır. interface veya abstract sınıflar ile calısmak işimizi kolaylaştıracaktır.


        public enum OrderType
        {

            Eft= 0,
            Havale=1,
            Nakit=2,
        }

        public class Order
        {
            //private degiskenler _ ile tanımlamamız gerekir.
            private readonly OrderType _orderType;
            
            public Order(OrderType orderType)
            {
                _orderType = orderType;
            }

            //Değişikliği hep aynı method içerisinde yapıyoruz.Bu o yüzden open closed prensibine aykırıdır.
            public void OnProcess()
            {
                switch (_orderType)
                {
                    case OrderType.Eft:
                        break;

                     //Eft

                    case OrderType.Havale:
                        break;

                    //Havale

                    case OrderType.Nakit:
                        break;

                    //Nakit
                }
            }
        }
    }
}
