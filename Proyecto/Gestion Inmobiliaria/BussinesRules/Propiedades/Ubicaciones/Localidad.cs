using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Ubicaciones
{
    public class Localidad
    {
        public Localidad()
        { }

        private int idLocalidad;

        public int IdLocalidad
        {
            get { return idLocalidad; }
            set { idLocalidad = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int idProvincia;

        public int IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
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

    public class Localidades : List<Localidad>
    {
        public void RecuperarTodas()
        {
            Clear();
            using (System.Data.IDataReader dr = new DA.UbicacionesData().RecuperarLocalidades())
            {
                Localidad l;
                while (dr.Read())
                {
                    l = new Localidad();
                    l.IdLocalidad = dr.GetInt32(dr.GetOrdinal("IdLocalidad"));
                    l.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    l.EsDefault = dr.GetBoolean(dr.GetOrdinal("Default"));
                    l.IdProvincia = dr.GetInt32(dr.GetOrdinal("IdProvincia"));
                    Add(l);
                }

            }
        }


        public Localidad GetDefault
        {
            get
            {
                foreach (Localidad b in this)
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
