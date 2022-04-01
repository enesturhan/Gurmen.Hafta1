using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FacadeDesignPattern.BestSample;

namespace FacadeDesignPattern
{
    /// <summary>
    /// Bir sistemde parçaları olusturan classları istemciden soyutlayarak kullanımı daha kolaylastırmak için kullanılan tasarım kalıbıdır.
    /// Katmanlar arası bağımlılıgı azaltmak icin kullanılır. Soyutlamayı saglar ve kullanıcıya bir arayüz sunar.
    
    /// birden fazla classı tek bir classta cagırarak karmaşıklıgı önlemek ve bize tek elden hizmet sunar.
    /// Burada bir agile yönetim sürecinde projeye atılan kullanıcıların durumlarını uygunluklarını en sonda facede classı ile kontrol sağlamıs olduk.
    /// </summary>
    internal class BestSample
    {

        public class User
        {
            public string UserName { get; set; }

            public string Email { get; set; }

            public string FirstName { get; set; }
            public string LastName { get; set; }


        }

        class Project
        {
            public bool IsAssign(User email)
            {
                
                if (email == null)
                {
                    return false;
                }
                return true;
            }
        }

        class Contributor
        {
            public bool IsContributor(User user)
            {
                if(user.Email != null)
                {
                    return true;
                }
                return false;
            }

        }

        class Sprint
        {
            public string SprintName { get; set; }
            public int SprintCount { get; set; }
            public int GetSprint(int count)
            {
                if (string.IsNullOrEmpty(SprintName))
                {
                    throw new Exception("isim giriniz");
                }
                if (SprintCount > 4)
                {
                    return 4;
                }
                return 2;

            }


        }

        /// <summary>
        /// Facede sınıfında istenilen kısımları organize ederek tek bir sınıf yardımıyla bize sunar.
        /// </summary>
        class Facede
        {
            private readonly Contributor _contributor;
            private readonly Sprint _sprint;
            private readonly Project _project;

            public Facede(Contributor contributor,Sprint sprint,Project project)
            {
                _contributor = contributor;
                _sprint = sprint;
                _project = project;
            }
            
            public bool IsAssignable(User user)
            {
                if (_sprint.SprintCount > 4)
                {
                    return false;
                }
                if (_contributor.IsContributor(user) != false)
                {
                    return false;
                }
                var value =_project.IsAssign(user);
                if (value)
                {
                    return false;
                }

                return true;
                Console.WriteLine("Kisi projeye atanabilir");
            }
          

        }



    }
}
