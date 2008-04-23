using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR
{
    public class Propietario : Cliente
    {
        public override string ToString()
        {
            return this.Apellido + ", "+this.Nombres;
        }

    }
}
