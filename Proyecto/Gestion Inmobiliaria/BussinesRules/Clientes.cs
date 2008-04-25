using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.BR
{
    public class Clientes : List<Cliente>
    {
        public void RecuperarPropietarios(string nombre)
        {
            GI.DA.ClientesData cd = new GI.DA.ClientesData();
            using (IDataReader dr = cd.RecuperarPropietarios(nombre))
            {
                while (dr.Read())
                {
                    this.Add(GetPropietario(dr));
                }
            }
        }

        public void RecuperarPropietarios()
        {
            GI.DA.ClientesData cd = new GI.DA.ClientesData();
            using (IDataReader dr = cd.RecuperarPropietarios())
            {
                while (dr.Read())
                {
                    this.Add(GetPropietario(dr));
                }
            }
        }

        private Cliente GetPropietario(IDataReader dr)
        {
            Propietario p = new Propietario();
            p.llenar(dr);
            return p;
        }
    }
}
