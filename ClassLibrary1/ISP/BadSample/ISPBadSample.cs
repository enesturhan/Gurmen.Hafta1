using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.BadSample
{

    /// <summary>
    /// Interface segration
    /// Bir interfacenin değişmesi için tek bir sebep olmalıdır.
    /// </summary>
    /// 
    //Buradaki örnekte temel hata interfacelere fazla sorumluluk yüklüyoruz. Bir interfacenin içindeki member bir classta kullanılırken diğerlerinde kullanılmayabilir.
    //O yüzden interfacelerin sorumluluğumu azaltmamız gerekmektedir.
    internal class ISPBadSample
    {

        public interface ISignuture
        {
            string Key { get; set; }
            string HS256 { get; set; }

            string Encoded();
            string Decoded();

        }

        public class Jwt : ISignuture
        {
            public string Key { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string HS256 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public string Decoded()
            {
                throw new NotImplementedException();
            }

            public string Encoded()
            {
                throw new NotImplementedException();
            }
        }

        public class SendEmail : ISignuture
        {
            public string Key { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string HS256 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public string Decoded()
            {
                throw new NotImplementedException();
            }

            public string Encoded()
            {
                throw new NotImplementedException();
            }
        }
    }
}
