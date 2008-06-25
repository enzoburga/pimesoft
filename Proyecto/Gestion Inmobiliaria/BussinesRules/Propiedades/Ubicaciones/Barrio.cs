using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Ubicaciones
{

    [Serializable]
    public class Barrio
    {
        public Barrio()
        { 
        
        }

        private int idBarrio;

        public int IdBarrio
        {
            get { return idBarrio; }
            set { idBarrio = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int idLocalidad;

        public int IdLocalidad
        {
            get { return idLocalidad; }
            set { idLocalidad = value; }
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


    public class Barrios : List<Barrio>
    {

        public void RecuperarTodos()
        {
            Clear();
            using (System.Data.IDataReader dr = new DA.UbicacionesData().RecuperarBarrios())
            {
                Barrio b;
                while (dr.Read())
                {
                    b = new Barrio();
                    b.IdLocalidad = dr.GetInt32(dr.GetOrdinal("IdLocalidad"));
                    b.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    b.EsDefault = dr.GetBoolean(dr.GetOrdinal("Default"));
                    b.IdBarrio = dr.GetInt32(dr.GetOrdinal("IdBarrio"));
                    Add(b);
                }

            }
        }






        public Barrio GetDefault
        {
            get
            {
                foreach (Barrio b in this)
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
