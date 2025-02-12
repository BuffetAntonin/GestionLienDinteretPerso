using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBO
{
    public class Etatblissement
    {
        private int? id;
        private string libelle;

        public Etatblissement()
        {
        }
        public Etatblissement(int id)
        {
            this.id = id;
        }

        public Etatblissement(string libelle)
        {
            this.libelle = libelle;
        }

        public Etatblissement(int? id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int? Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
