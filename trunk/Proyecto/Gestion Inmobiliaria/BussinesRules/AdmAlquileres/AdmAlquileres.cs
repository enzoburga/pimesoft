using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.BR.AdmAlquileres
{
    public class AdmAlquileres: List<AdmAlquiler>
    {

        public void RecuperarAdmAlquileresPorDireccion(string Calle, int Numero)
        {
            using (IDataReader dr = new GI.DA.AdmAlquileresData().RecuperarAdmAlquileresPorDireccion(Calle, Numero))
            {
                GI.BR.AdmAlquileres.AdmAlquiler adm;
                while (dr.Read())
                {
                    adm = new AdmAlquiler();
                    adm.fill(dr);
                    this.Add(adm);
                }
            }
        }

        public void RecuperarAdmAlquileresTodos()
        {
            using (IDataReader dr = new GI.DA.AdmAlquileresData().RecuperarAdmAlquileresTodos())
            {
                GI.BR.AdmAlquileres.AdmAlquiler adm;
                while (dr.Read())
                {
                    adm = new AdmAlquiler();
                    adm.fill(dr);
                    this.Add(adm);
                }
            }
        }

        public void RecuperarAdmAlquileres(GI.BR.Propiedades.EstadoPropiedad Estado, GI.BR.Propiedades.TipoPropiedad Tipo)
        {
            using (IDataReader dr = new GI.DA.AdmAlquileresData().RecuperarAdmAlquileres(Estado.IdEstadoPropiedad, Tipo.IdTipoPropiedad))
            {
                GI.BR.AdmAlquileres.AdmAlquiler adm;
                while (dr.Read())
                {
                    adm = new AdmAlquiler();
                    adm.fill(dr);
                    this.Add(adm);
                }
            }
        }

        public void RecuperarAdmAlquileres(GI.BR.Propiedades.EstadoPropiedad Estado)
        {
            using (IDataReader dr = new GI.DA.AdmAlquileresData().RecuperarAdmAlquileresPorEstado(Estado.IdEstadoPropiedad))
            {
                GI.BR.AdmAlquileres.AdmAlquiler adm;
                while (dr.Read())
                {
                    adm = new AdmAlquiler();
                    adm.fill(dr);
                    this.Add(adm);
                }
            }
        }

        public void RecuperarAdmAlquileres(GI.BR.Propiedades.TipoPropiedad Tipo)
        {
            using (IDataReader dr = new GI.DA.AdmAlquileresData().RecuperarAdmAlquileresPorTipo(Tipo.IdTipoPropiedad))
            {
                GI.BR.AdmAlquileres.AdmAlquiler adm;
                while (dr.Read())
                {
                    adm = new AdmAlquiler();
                    adm.fill(dr);
                    this.Add(adm);
                }
            }
        }

        public void RecuperarAdmAlquileresPorCodigoPropiedad(string Codigo)
        {
            using (IDataReader dr = new GI.DA.AdmAlquileresData().RecuperarAdmAlquileresPorCodigoPropiedad(Codigo))
            {
                GI.BR.AdmAlquileres.AdmAlquiler adm;
                while (dr.Read())
                {
                    adm = new AdmAlquiler();
                    adm.fill(dr);
                    this.Add(adm);
                }
            }
        }

        public void RecuperarAdmAlquileresPorNombreInquilino(string Nombres)
        {
            using (IDataReader dr = new GI.DA.AdmAlquileresData().RecuperarAdmAlquileresPorNombreInquilino(Nombres))
            {
                GI.BR.AdmAlquileres.AdmAlquiler adm;
                while (dr.Read())
                {
                    adm = new AdmAlquiler();
                    adm.fill(dr);
                    this.Add(adm);
                }
            }
        }
    }
}
