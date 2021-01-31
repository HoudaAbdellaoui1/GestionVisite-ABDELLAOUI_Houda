using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVisite.model
{
    public class DB
    {
        public List<Personne> Clients { get; set; }

        public DB()
        {
            Clients = new List<Personne>();
            Clients.Add(new Personne(1, "Ali"     , 10, 5));
            Clients.Add(new Personne(2, "Omar"    , 8, -3));
            Clients.Add(new Personne(3, "Rachida" , 5, 2));
            Clients.Add(new Personne(4, "Karima"  , 1, 8));
            Clients.Add(new Personne(5, "Allal"   , 0, 3));
        }

        public Personne FindById(int id)
        {
            return Clients.Where(c => c.Id == id).FirstOrDefault();
        } 

    }
}

