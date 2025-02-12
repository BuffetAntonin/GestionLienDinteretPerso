using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBO
{
    public class Nature
    {
        private int id;
        private string libelle;

        public Nature(int id)
        {
            this.id = id;
        }

        public Nature(string libelle)
        {
            this.libelle = libelle;
        }

        public Nature(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
