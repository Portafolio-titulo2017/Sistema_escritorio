﻿using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionEscritorio
{
    class Tipo
    {
        public int idTipo { get; set; }
      
        public string descripcion { get; set; }

        public string nombre { get; set; }
        public Tipo()
        {

        }

        public Tipo(int idTipo, string descripcion,string nombre)
        {
            this.idTipo = idTipo;
    
            this.descripcion = descripcion;
            this.nombre = nombre;
        }
    }


}
