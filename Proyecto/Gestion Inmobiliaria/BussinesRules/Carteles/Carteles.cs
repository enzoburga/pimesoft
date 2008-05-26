using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Carteles
{
    public class Carteles:List<Cartel>
    {
        public void RecuperarCartelesTodos()
        {
            using (System.Data.IDataReader dr = new DA.CartelesData().RecuperarTodos())
            {
                this.Clear();
                GI.BR.Carteles.Cartel c;
                while (dr.Read())
                {
                    c = new Cartel();
                    c.fill(dr);
                    this.Add(c);                
                }
            }
        }
    }
}
