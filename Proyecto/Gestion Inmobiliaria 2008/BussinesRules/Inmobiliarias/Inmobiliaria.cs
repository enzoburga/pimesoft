using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR
{

    public class Inmobiliaria
    {
        public Inmobiliaria()
        { }

        #region Miembros

        private int idInmobiliaria;
        private string nombre;
        private Propiedades.Direccion direccion;
        private string telefono;
        private string fax;
        private string url;
        private string personaResponsable;



        #endregion

        #region Propiedades

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public int IdInmobiliaria
        {
            get { return idInmobiliaria; }
            set { idInmobiliaria = value; }
        }

        public string PersonaResponsable
        {
            get { return personaResponsable; }
            set { personaResponsable = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public Propiedades.Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        
        #endregion

        #region Metodos

        public override string ToString()
        {
            return Nombre;
        }

        public virtual bool Actualizar()
        {
            return new DA.InmobiliariasData().ActualizarInmobiliaria(
                Nombre,
                Direccion.Calle,
                Direccion.CodigoPostal,
                Direccion.Depto,
                Direccion.Numero,
                Direccion.Piso,
                Fax,
                Telefono,
                Url);


        }

        public static Inmobiliaria GetInmobiliaria()
        {
            Inmobiliaria i = new Inmobiliaria();

            i.Nombre = "Nombre Inmobiliaria";
            i.Direccion = new GI.BR.Propiedades.Direccion();
            i.Direccion.Calle = "";
            i.Direccion.CodigoPostal = "";
            i.Direccion.Numero = 0;
            i.Fax = "";
            i.IdInmobiliaria = 0;
            i.Telefono = "";
            i.Url = "http://";

            using (System.Data.IDataReader dr = new DA.InmobiliariasData().RecuperarDatosInmobiliaria())
            {
                if (dr.Read())
                {
                    i.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    i.Direccion.Calle = dr.GetString(dr.GetOrdinal("Calle"));
                    i.Direccion.CodigoPostal = dr.GetString(dr.GetOrdinal("CodigoPostal"));
                    i.Direccion.Depto = dr.GetString(dr.GetOrdinal("Depto"));
                    i.Direccion.Numero = dr.GetInt32(dr.GetOrdinal("Numero"));
                    i.Direccion.Piso = dr.GetString(dr.GetOrdinal("Piso"));
                    i.Fax = dr.GetString(dr.GetOrdinal("Fax"));
                    i.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));
                    i.Url = dr.GetString(dr.GetOrdinal("DireccionWeb"));

                }
            }



            return i;
        }

        #endregion



    }
}
