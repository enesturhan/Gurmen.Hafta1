using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    /// <summary>
    /// Örneğin elimize vehicle(araç) classımız olsun Bu class birden çok taşıt türü alabilir örneğin motor,araba,uçak,kamyon,tren,tramvay gibi ve bunların yaktığı yakıt türleri de birbirinden farklı olucaktır.
    /// Ve bunun gibi birden fazla özellik bizim base sınıfımızdan türetildiği zaman sonsuz sayıda kombinason içerecektir.Bu yüzden soyut nesneleri kullanarak(interface,abstract) birbirleri ile yakın ilişkili sınıfları, birbirinden bağımsız olarak geliştirme yaparak bunları farklı hiyarerşilere bölmeliyiz.
    ///Burada bir ıfuel interfacemiz yardımı ile diesel ve gazoline sınıflarımıza implemente ettik.    Sonrasında abstract olarak motorbike sınıfımızı olusturduk burada ıfuel interfacesi ile köprü görevinde kullandık ve birbirine bağlamış olduk.
    ///Sonrasında ise 2 adet motor class olusturarak bunları base constructura yönlendirmiş olduk.
    /// </summary>
    internal class BestSample
    {


        public interface IFuelType
        {

            public string FuelType();

        }

        public class DieselFuel : IFuelType
        {
            public string FuelType()
            {
                return "Diesel";
            }
        }
        public class GazolineFuel : IFuelType
        {
            public string FuelType()
            {
                return "Gazoline";
            }
        }

        public abstract class Motorbike
        {
            private readonly IFuelType _fuelType;

           

            public string bikeName { get; set; }
            public Motorbike(IFuelType fuelType,string BikeName)
            {
                _fuelType = fuelType;
                bikeName = BikeName;

            }
          
            public void Drive()
            {
                Console.WriteLine("Bu araç yakıtı" +" "+_fuelType.FuelType()+" "+"ismi ise" +" "+bikeName);
            }
          
        }

        public class StreetMotorBike : Motorbike
        {
            public StreetMotorBike(IFuelType fuelType, string bikeName) : base(fuelType, bikeName)
            {

            }

         
        }
        public class RacingMotorBike : Motorbike
        {
            public RacingMotorBike(IFuelType fuelType, string bikeName) : base(fuelType, bikeName)
            {
            }

        
        }

        class BridgeDesignPattern
        {
            static void Main(string[] args)
            {
                StreetMotorBike streetMotor = new StreetMotorBike(new DieselFuel(), "Sokak Motoru");
                streetMotor.Drive();
                RacingMotorBike racingMotorBike = new RacingMotorBike(new GazolineFuel(), "Yarış Motoru");
                racingMotorBike.Drive();
            }   
        }
    }

        
} 
