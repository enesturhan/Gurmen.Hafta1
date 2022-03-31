using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.BestSample
{

    /// <summary>
    /// Bir sınıfın değişebilmesi için sadece tek bir sebebi olmalıdır. Bu prensipte bütün sorumlulukları birbirinden ayırıyoruz.
    /// Bizim için böyle yapmak kodun okunabilirligini ,test edilmesini ve  kodun kalitesini artırmaktadır.
    /// Burada verebileceğimiz en mantıklı örnek çok amaçlı bir çakı bize kesme,tornavida,törpü vb   bir çok işi yapmamızı tek bir alet üzerinde yapmamızı sağlar ama bize ne kadar sağlıklı sonuçlar verebilir.
    /// Buradaki örnekte sadece uçuş ile ilgili bilgileri tutuyoruz. Mesela user ile alakalı bir işlemi burada yapmıyoruz.
    
    /// Burada önemli olan konudan birisi ise bu prensip aslında DDD(Domain Driven Design) yaklaşımıyla biraz ters düşüyor gibi gözüküyor
    /// .Ama aslında öyle değil. Çünkü biz ddd ile geliştirme yaparken aggregate mantığı ile geliştirme yapıyoruz
    /// .Böylelikle mesela bir ürünümüzün categorysi yoksa ürünün kendiside olamaz bu yüzden bunlar arasında bir aggregate mantıgı bulunmaktadır .Burada category nesnesi aggregate root olmaktadır.
    /// </summary>
    internal class SRPBestSample
    {

        public interface IFlight
        {

        }

        public void AddFlight()
        {

        }
        public void DeleteFlight()
        {

        }

        public class FlightPriceDto
        {
            public string Type { get; set; }
            public decimal Price { get; set; }

        }

        public class FlightDetailDto
        {
            public string From { get; set; }
            public string To { get; set; }

            public string ArrivalTime { get; set; }
            public string DepartureTime { get; set; }
            public string FlightNumber { get; set; }


        }

        public class FlightPlaningDto
        {
            public string StatusText { get; set; }

            public string Id { get; set; }
            public string ConnectionType { get; set; } // aktermalı veya aktarmasız
            public string ArrivalTime { get; set; }
            public string DepartureTime { get; set; }
            public string From { get; set; }
            public string To { get; set; }

            public string TravelTime { get; set; }



            public List<FlightPriceDto> Prices = new List<FlightPriceDto>();

            public List<FlightDetailDto> Flights { get; set; } = new List<FlightDetailDto>();

        }
    }
}
