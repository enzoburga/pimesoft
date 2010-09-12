using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Ubicaciones
{
    [Serializable]
    public class Pais
    {
        public Pais()
        { }

        private int idPais;

        public int IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private bool esDefault;

        public bool EsDefault
        {
            get { return esDefault; }
            set { esDefault = value; }
        }

        public override string ToString()
        {
            return Nombre.ToString();
        }




    }

    public class Paises : List<Pais>
    {




        public void RecuperarTodos()
        {
            Clear();
            using (System.Data.IDataReader dr = new DA.UbicacionesData().RecuperarPaises())
            {
                Pais p;
                while (dr.Read())
                {
                    p = new Pais();
                    p.IdPais = dr.GetInt32(dr.GetOrdinal("IdPais"));
                    p.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    p.EsDefault = dr.GetBoolean(dr.GetOrdinal("Default"));
                    Add(p);
                }
            
            }

        }
        public Pais GetDefault
        {
            get
            {
                foreach (Pais b in this)
                {
                    if (b.EsDefault)
                        return b;
                }
                if (this.Count > 0)
                    return this[0];
                return null;
            }
        }


    }
}
