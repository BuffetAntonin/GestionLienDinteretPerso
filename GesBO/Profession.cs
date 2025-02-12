using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBO
{
    public class Profession
    {
        private int? id;
        private string libelle;

        public Profession(int id)
        {
            this.id = id;
        }

        public Profession(string libelle)
        {
            this.libelle = libelle;
        }

        public Profession(int? id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int? Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
