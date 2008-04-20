using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Propiedades : List<Propiedad>
    {
        TiposPropiedadFlyweightFactory tiposPropiedadFact;
        EstadoPropiedadFlyweigthFactory estadosPropFactory;

        public Propiedades()
        { 
        
        }

        public void RecuperarPropiedadesVentasTodas()
        {
            tiposPropiedadFact = new TiposPropiedadFlyweightFactory();
            estadosPropFactory = new EstadoPropiedadFlyweigthFactory(typeof(GI.BR.Propiedades.Venta));

            using (IDataReader dr = new GI.DA.PropiedadesData().RecuperarPropiedadesVentasTodas())
            {
                cargarColeccionVentas(dr);
            }
        
        }







        private void cargarColeccionVentas(IDataReader dr)
        {
            Clear();

            Venta Propiedad;
            while (dr.Read())
            {
                Propiedad = new Venta();
                CargarPropiedad(Propiedad, dr);
                Add(Propiedad);
            }
        }


        private void CargarPropiedad(GI.BR.Propiedades.Propiedad p, IDataReader dr)
        {
            

            p.IdPropiedad = dr.GetInt32(dr.GetOrdinal("IdPropiedad"));
            p.CantidadAmbientes = dr.GetDecimal(dr.GetOrdinal("CantidadAmbientes"));
            p.Codigo = dr.GetString(dr.GetOrdinal("Codigo"));
            p.TipoPropiedad = tiposPropiedadFact.GetTipoPropiedad(dr.GetInt32(dr.GetOrdinal("IdTipoPropiedad")));
            p.Estado = estadosPropFactory.GetEstado(dr.GetInt32(dr.GetOrdinal("IdEstadoPropiedad")));
            p.EnumEstado = (Estado)dr.GetInt32(dr.GetOrdinal("EnumEstadoProp"));
            p.Propietario = new Propietario();
            p.Propietario.IdCliente = dr.GetInt32(dr.GetOrdinal("IdPropietario"));





            //Calle
            //NumeroPostal
            //Depto
            //Piso
            //CodigoPostal
            //CalleEntre1
            //CalleEntre2
            //ValorMercadoImporte
            //ValorMercadoMoneda
            //ValorPublicacionImporte
            //ValorPublicacionMoneda
            //Observaciones
            //EsOtraInmobiliaria
            //MetrosCubiertos
            //MetrosSemicubiertos
            //MetrosLibres
            //TerrenoMetros
            //TerrenoFondo
            //TerrenosFrente
            //Orientacion
            //CantidadBanos
            //CantidadCocheras
            //CantidadDomritorios
            //CantidadPlantas
            //IdDepartamentoDisposicion
            //EsAptoProfesional
            //DeptoCantidadPisos
            //DeptoDepartamentosPorPiso
            //CantidadAscensores
            //CantidadAscensoresServicio
            //IdTipoZona
            //Fos
            //Fot
            //Zonificacion
            //MetrosContruibles

            //IdPais
            //IdProvincia
            //IdLocalidad
            //IdBarrio



        }




    }
}
