using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP.BestSample
{


    /// <summary>
    /// Kullandığımız sınıfları bir interface ile işaretliyoruz.Böylelikle ıproduct service den kalıtım alan bütün sınıflara tek bir seferde erişim sağlamış oluyoruz.
    /// Doğru kullanımda biz instance yönetiminide böylelikle  kendimiz ypaıyoruz. 
    /// 
    /// </summary>
    internal class DIPBestSample
    {

        public class Product:IProductService
        {

            private readonly IProductService _productService;

            public Product(IProductService productService)
            {
                _productService = productService;
             
            }

        }
    }


    public interface IProductService
    {

    }

    public class ProductStockService:IProductService
    {

    }
    public class ProductTypeService:IProductService
    {

    }
}
