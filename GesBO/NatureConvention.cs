﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesLienBO
{
    public class NatureConvention
    {
        private int id;
        private string libelle;

        public NatureConvention(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
