using Controle_Soler_Jean_Michel.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Soler_Jean_Michel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContextBDD())
            {
                var r1 = db.Jeux.Select(o => new { o.Nom, o.Souhait });
                /*foreach (var item in r1)
                {
                    Console.WriteLine(item.Nom);
                    Console.WriteLine(item.Souhait);
                }*/

                //var r2 = db.Clients.Select(o => new { o.ClientID, o.Jeux.Nom});
                /*foreach (var item in r2)
                {
                    Console.WriteLine(item.ClientID);
                    Console.WriteLine(item.Nom);
                }*/
            }
        }
    }
}
