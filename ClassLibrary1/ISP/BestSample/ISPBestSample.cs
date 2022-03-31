using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.BestSample
{

    /// <summary>
    /// Burada bütün interfacelerimizi görevlerine göre ayırdık böylelikle onları sadece o yeteneği kazanmak isteyen sınıflar impemente edecek.
    /// Böylelikle her interfacenin sorumluluğu kendi üzerine olmuş olucak 
    /// </summary>
    internal class ISPBestSample
    {

        public interface IEncoded
        {
            string Encoded();
        }
        public interface IDecoded
        {
            string Decoded();

        }
        public interface IHS256
        {
            string HS256();
        }


        public interface JwtSignutare : IEncoded, IDecoded, IHS256
        {

        }

        public class Jwt : JwtSignutare
        {
            public string Decoded()
            {
                throw new NotImplementedException();
            }

            public string Encoded()
            {
                throw new NotImplementedException();
            }

            public string HS256()
            {
                throw new NotImplementedException();
            }
        }
        /// <summary>
        /// Burada sifreleme olarak başka bir şifreleme kullanmak isteyebilirim.
        /// O yüzden hs256 algoritması yerine başka bir algoritmayı interfaceyi implemente ederek kullanabilirim.
        /// 
        /// </summary>
        public class Password : IEncoded, IDecoded
        {
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
