using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.BestSample
{
    internal class OCPBestSample
    {
        /// <summary>
        /// Burada öncelikle interfaceları ayrı acarak bunları ayrı ayrı sınıflara implemente ettik bu yüzden hem single responsibiltye uymuş olduk  ve open closed prensibi ile her yeni değişiklikte değiştirme yapmadan açık bir şekilde uygulamış olduk.
        /// 
        /// </summary>

        public interface IPurchaseOrder
        {
            void OnProcess();

        }
        public interface ITurkeyPurchaseOrder:IPurchaseOrder
        {
            void Check();

        }
        public class TurkeyPurchaseOrder : ITurkeyPurchaseOrder
        {
            public void Check()
            {
                throw new NotImplementedException();
            }

            public void OnProcess()
            {
                throw new NotImplementedException();
            }
        }

        public class EtfPurchaseOrder : IPurchaseOrder
        {
            public void OnProcess()
            {
                throw new NotImplementedException();
            }
        }

        public class PurchaseOrderManager : IPurchaseOrder
        {
            
            private readonly IPurchaseOrder _purchaseOrder;


            //Dependency Injection  (Constructor Injection)
            public PurchaseOrderManager(IPurchaseOrder purchaseOrder)
            {
                _purchaseOrder = purchaseOrder;
            }


            public void OnProcess()
            {
                _purchaseOrder.OnProcess();
            }
        }

    }
}
