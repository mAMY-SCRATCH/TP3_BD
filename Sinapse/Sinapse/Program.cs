using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sinapse.Model;
using Sinapse.Repository;

namespace Sinapse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SinapseContext context = new SinapseContext();
            SinapseInitializer init = new SinapseInitializer();

            Database.SetInitializer<SinapseContext>(init);

            init.InitializeDatabase(context);


            var emps = context.Employes
                .Where(employe => employe.Salaire > 100000)
                .Select(s => new { s.Prenom, s.Nom, s.NAS });

            foreach (var e in emps)
            {
                Console.WriteLine("{0} {1}, {2}",
                    e.Prenom,
                    e.Nom,
                    e.NAS);
            }
            
            Console.ReadLine();
        }
    }
}
