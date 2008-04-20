using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Propiedades : List<Propiedad>
    {

        #region Members
        TiposPropiedadFlyweightFactory tiposPropiedadFact;
        EstadoPropiedadFlyweigthFactory estadosPropFactory;
        Monedas.MonedasFlyweigthFactory monedasFactory;
        Ubicaciones.UbicacionFlyweightFactory ubicacionesFactory;

        #endregion
        
        public Propiedades()
        { 
        
        }

        public void RecuperarPropiedadesVentasTodas()
        {
            tiposPropiedadFact = new TiposPropiedadFlyweightFactory();
            estadosPropFactory = new EstadoPropiedadFlyweigthFactory(typeof(GI.BR.Propiedades.Venta));
            monedasFactory = new GI.BR.Monedas.MonedasFlyweigthFactory();
            ubicacionesFactory = new GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory();

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

            if (!dr.IsDBNull(dr.GetOrdinal("IdPropietario")))
            {
                p.Propietario = new Propietario();
                p.Propietario.IdCliente = dr.GetInt32(dr.GetOrdinal("IdPropietario"));
            }

            p.Direccion = new Direccion();
            p.Direccion.Calle = dr.GetString(dr.GetOrdinal("Calle"));
            p.Direccion.Numero = dr.GetInt32(dr.GetOrdinal("NumeroPostal"));
            p.Direccion.Depto = dr.GetString(dr.GetOrdinal("Depto"));
            p.Direccion.Piso = dr.GetString(dr.GetOrdinal("Piso"));
            p.Direccion.CodigoPostal = dr.GetString(dr.GetOrdinal("CodigoPostal"));
            p.Direccion.CalleEntre1 = dr.GetString(dr.GetOrdinal("CalleEntre1"));
            p.Direccion.CalleEntre2 = dr.GetString(dr.GetOrdinal("CalleEntre2"));

            p.ValorMercado = new Valor();
            p.ValorMercado.Importe = dr.GetDecimal(dr.GetOrdinal("ValorMercadoImporte"));
            p.ValorMercado.Moneda = monedasFactory.GetMoneda(dr.GetInt32(dr.GetOrdinal("ValorMercadoMoneda")));

            p.ValorPublicacion = new Valor();
            p.ValorPublicacion.Importe = dr.GetDecimal(dr.GetOrdinal("ValorPublicacionImporte"));
            p.ValorPublicacion.Moneda = monedasFactory.GetMoneda(dr.GetInt32(dr.GetOrdinal("ValorPublicacionMoneda")));

            p.Observaciones = dr.IsDBNull(dr.GetOrdinal("Observaciones")) ? "" : dr.GetString(dr.GetOrdinal("Observaciones"));
            p.EsOtraInmobiliaria = dr.IsDBNull(dr.GetOrdinal("EsOtraInmobiliaria")) ? false : dr.GetBoolean(dr.GetOrdinal("EsOtraInmobiliaria"));

            p.MedidasPropiedad = new MedidaPropiedad();
            p.MedidasPropiedad.MetrosCubiertos = dr.GetDecimal(dr.GetOrdinal("MetrosCubiertos"));
            p.MedidasPropiedad.MetrosLibres = dr.GetDecimal(dr.GetOrdinal("MetrosLibres"));
            p.MedidasPropiedad.MetrosSemicubiertos = dr.GetDecimal(dr.GetOrdinal("MetrosSemicubiertos"));

            p.MedidasTerreno = new MedidasTerreno();
            p.MedidasTerreno.Fondo = dr.GetDecimal(dr.GetOrdinal("TerrenoFondo"));
            p.MedidasTerreno.Frente = dr.GetDecimal(dr.GetOrdinal("TerrenosFrente"));
            p.MedidasTerreno.Metros = dr.GetDecimal(dr.GetOrdinal("TerrenoMetros"));
            p.Orientacion = dr.GetString(dr.GetOrdinal("Orientacion"));
            p.CantidadBaños = dr.GetInt32(dr.GetOrdinal("CantidadBanos"));
            p.CantidadCocheras = dr.GetInt32(dr.GetOrdinal("CantidadCocheras"));
            p.CantidadDormitorios = dr.GetInt32(dr.GetOrdinal("CantidadDomritorios"));
            p.CantidadPlantas = dr.GetInt32(dr.GetOrdinal("CantidadPlantas"));

            p.Disposicion = dr.IsDBNull(dr.GetOrdinal("IdDepartamentoDisposicion")) ? DepartamentoDisposicion.SinDefinir : (DepartamentoDisposicion)dr.GetInt32(dr.GetOrdinal("IdDepartamentoDisposicion"));
            p.EsAptoProfesional = dr.IsDBNull(dr.GetOrdinal("EsAptoProfesional")) ? false : dr.GetBoolean(dr.GetOrdinal("EsAptoProfesional"));
            p.CantidadPisos = dr.IsDBNull(dr.GetOrdinal("DeptoCantidadPisos")) ? 0 : dr.GetInt32(dr.GetOrdinal("DeptoCantidadPisos"));
            p.DepartamentosPorPiso = dr.IsDBNull(dr.GetOrdinal("DeptoDepartamentosPorPiso")) ? 0 : dr.GetInt32(dr.GetOrdinal("DeptoDepartamentosPorPiso"));
            p.CantidadAscensores = dr.IsDBNull(dr.GetOrdinal("CantidadAscensores")) ? 0 : dr.GetInt32(dr.GetOrdinal("CantidadAscensores"));
            p.CantidadAscensoresServicio = dr.IsDBNull(dr.GetOrdinal("CantidadAscensoresServicio")) ? 0 : dr.GetInt32(dr.GetOrdinal("CantidadAscensoresServicio"));


            p.TipoZona = dr.IsDBNull(dr.GetOrdinal("IdTipoZona")) ? TipoZona.SinDefinir : (TipoZona)dr.GetInt32(dr.GetOrdinal("IdTipoZona"));
            p.Fos = dr.IsDBNull(dr.GetOrdinal("Fos")) ? "" : dr.GetString(dr.GetOrdinal("Fos"));
            p.Fot = dr.IsDBNull(dr.GetOrdinal("Fot")) ? "" : dr.GetString(dr.GetOrdinal("Fot"));
            p.Zonificacion = dr.IsDBNull(dr.GetOrdinal("Zonificacion")) ? "" : dr.GetString(dr.GetOrdinal("Zonificacion"));
            p.MetrosConstruibles = dr.IsDBNull(dr.GetOrdinal("MetrosContruibles")) ? 0 : dr.GetInt32(dr.GetOrdinal("MetrosContruibles"));

            p.Ubicacion = new Ubicacion();
            p.Ubicacion.Barrio = ubicacionesFactory.GetBarrio(dr.GetInt32(dr.GetOrdinal("IdBarrio")));
            p.Ubicacion.Localidad = ubicacionesFactory.GetLocalidad(dr.GetInt32(dr.GetOrdinal("IdLocalidad")));
            p.Ubicacion.Pais = ubicacionesFactory.GetPais(dr.GetInt32(dr.GetOrdinal("IdPais")));
            p.Ubicacion.Provincia = ubicacionesFactory.GetProvincia(dr.GetInt32(dr.GetOrdinal("IdProvincia")));



        }




    }
}
