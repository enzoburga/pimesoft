using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Ubicaciones
{
    public class Provincia
    {

        public Provincia() { }

        private int idProvincia;
        private string nombre;
        private int idPais;
        private bool esDefault;

        public int IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }
       

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

        public int IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }
        
        

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


    public class Provincias : List<Provincia>
    {

        public void RecuperarTodas()
        {
            Clear();
            using (System.Data.IDataReader dr = new DA.UbicacionesData().RecuperarProvincias())
            {
                Provincia p;
                while (dr.Read())
                {
                    p = new Provincia();
                    p.IdPais = dr.GetInt32(dr.GetOrdinal("IdPais"));
                    p.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    p.EsDefault = dr.GetBoolean(dr.GetOrdinal("Default"));
                    p.IdProvincia = dr.GetInt32(dr.GetOrdinal("IdProvincia"));
                    Add(p);
                }

            }
        }

        

        public Provincia GetDefault
        {
            get
            {
                foreach (Provincia b in this)
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
