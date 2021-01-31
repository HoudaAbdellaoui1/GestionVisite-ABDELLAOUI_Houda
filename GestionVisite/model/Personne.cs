using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVisite.model
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public Geometry Position { get; set; }

        public Personne()
        {

        }
        public Personne(int id, string nom, double x, double y)
        {
            this.Id = id;
            this.Nom = nom;
            this.Position = new Geometry(x, y);
        }
        public Personne(string txtId, string txtNom, string txtX, string txtY)
        {
            this.Id = int.Parse(txtId);
            this.Nom = txtNom;
            this.Position = new Geometry(txtX, txtY);
        }

    }
}
