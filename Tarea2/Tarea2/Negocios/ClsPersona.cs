using System;
using System.Collections.Generic;
using System.Text;
using Tarea2.Entidades;

namespace Tarea2.Negocios
{
    public class ClsPersona
    {
        public int contarPalabra(Palabra palabra)
        {
            return palabra.palabra.Length;
        }
    }
}
