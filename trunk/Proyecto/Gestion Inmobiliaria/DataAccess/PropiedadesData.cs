using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.DA
{
    public class PropiedadesData
    {

        #region Metodos Recuerar VENTAS

        public IDataReader RecuperarPropiedadesVentaPorDireccion(string Calle, int Numero)
        { 
        
            return AccesoDatos.RecuperarDatos(
                    "PropiedadesVentas_RecuperarPorDireccion",
                    new object[] { Calle, Numero },
                    new string[] { "@Calle", "@Numero" });
        }

        public IDataReader RecuperarPropiedadesVentas(int IdEstadoPropiedad, int IdTipoPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                    "PropiedadesVentas_RecuperarPorEstadoYtipo",
                    new object[] { IdEstadoPropiedad, IdTipoPropiedad },
                    new string[] { "@IdEstadoPropiedad", "@IdTipoPropiedad" });
        }

        public IDataReader RecuperarPropiedadesVentasPorEstado(int IdEstadoPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                    "PropiedadesVentas_RecuperarPorEstado",
                    new object[] { IdEstadoPropiedad },
                    new string[] { "@IdEstadoPropiedad" });
        }

        public IDataReader RecuperarPropiedadesVentasPorTipo(int IdTipoPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                    "PropiedadesVentas_RecuperarPorTipo",
                    new object[] { IdTipoPropiedad},
                    new string[] { "@IdTipoPropiedad" });
        }
        public IDataReader RecuperarPropiedadesVentas()
        {
            return AccesoDatos.RecuperarDatos(
                "PropiedadesVentas_RecuperarTodas",
                new object[] { },
                new string[] { });
        }

        #endregion

        #region Metodos recuperar Alquileres

        public IDataReader RecuperarPropiedadesAlquileresPorDireccion(string Calle, int Numero)
        {

            return AccesoDatos.RecuperarDatos(
                    "PropiedadesAlquileres_RecuperarPorDireccion",
                    new object[] { Calle, Numero },
                    new string[] { "@Calle", "@Numero" });
        }

        public IDataReader RecuperarPropiedadesAlquileres(int IdEstadoPropiedad, int IdTipoPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                    "PropiedadesAlquileres_RecuperarPorEstadoYtipo",
                    new object[] { IdEstadoPropiedad, IdTipoPropiedad },
                    new string[] { "@IdEstadoPropiedad", "@IdTipoPropiedad" });
        }

        public IDataReader RecuperarPropiedadesAlquileresPorEstado(int IdEstadoPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                    "PropiedadesAlquileres_RecuperarPorEstado",
                    new object[] { IdEstadoPropiedad },
                    new string[] { "@IdEstadoPropiedad" });
        }

        public IDataReader RecuperarPropiedadesAlquileresPorTipo(int IdTipoPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                    "PropiedadesAlquileres_RecuperarPorTipo",
                    new object[] { IdTipoPropiedad },
                    new string[] { "@IdTipoPropiedad" });
        }
        public IDataReader RecuperarPropiedadesAlquileres()
        {
            return AccesoDatos.RecuperarDatos(
                "PropiedadesAlquileres_RecuperarTodas",
                new object[] { },
                new string[] { });
        }


        
        #endregion


        public IDataReader RecuperarEstadoPropiedad(string ClasePropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                "EstadosPropiedad_RecuperarPorClase",
                new object[] { ClasePropiedad },
                new string[] { "@Clase" });
        }



        #region GRABAR Y ACTUALIZAR PROPIEDADES


        public bool InsertarPropiedadesEnAlquiler(int IdPropiedad)
        {
            return AccesoDatos.ActualizarRegistro("Propiedades_CrearAlquiler", new object[] { IdPropiedad }, new string[] { "@IdPropiedad" });
        }

        public bool InsertarPropiedadesEnVenta(int IdPropiedad)
        {
            return AccesoDatos.ActualizarRegistro("Propiedades_CrearVenta", new object[] { IdPropiedad }, new string[] { "@IdPropiedad" });
        }

        public bool ActualizarPropiedad(int IdPropiedad, decimal CantidadAmbientes, int IdTipoPropiedad, int IdEstadoPropiedad, int IdEnumEstado, int IdCliente,
                int IdPais, int IdProvincia, int IdLocalidad, int IdBarrio, string Calle, int Numero, string Depto, string Piso, string CodigoPostal, string EntreCalle1, string EntreCalle2,
                decimal ValorMercado, int ValorMercadoIdMoneda, decimal ValorPublicacion, int ValorPublicacionIdMoneda, bool EsOtraInmobiliaria,
                decimal MetrosCubiertos, decimal MetrosSemicubiertos, decimal MetrosLibres, decimal Metros, decimal Fondo, decimal Frente, string Orientacion, int CantidadBanos, int CantidadCocheras,
                int CantidadDormitorios, int CantidadPlantas, int IdDisposicion, bool EsAptoProfesional, int CantidadPisos, int DeptosPorPiso, int CantidadAscensores,
                int CantidadAscensoresServicio, int IdTipoZona, string fos, string fot, string zonificacion, decimal mestrosConstruibles)
        {

            object id = null;
            if (IdCliente == 0)
                id = DBNull.Value;
            else
                id = IdCliente;

            return AccesoDatos.ActualizarRegistro(
                    "Propiedades_Actualizar",
                    new object[] { IdPropiedad, CantidadAmbientes,  IdTipoPropiedad,  IdEstadoPropiedad,  IdEnumEstado,  id,
                 IdPais,  IdProvincia,  IdLocalidad,  IdBarrio,  Calle,  Numero,  Depto,  Piso,  CodigoPostal,  EntreCalle1,  EntreCalle2,
                 ValorMercado,  ValorMercadoIdMoneda,  ValorPublicacion,  ValorPublicacionIdMoneda,  EsOtraInmobiliaria,
                 MetrosCubiertos,  MetrosSemicubiertos,  MetrosLibres,  Metros,  Fondo,  Frente,  Orientacion,  CantidadBanos,  CantidadCocheras,
                 CantidadDormitorios,  CantidadPlantas,  IdDisposicion,  EsAptoProfesional,  CantidadPisos,  DeptosPorPiso,  CantidadAscensores,
                 CantidadAscensoresServicio,  IdTipoZona,  fos,  fot, zonificacion,  mestrosConstruibles },
                    new string[] { "@IdPropiedad", "@CantidadAmbientes","@IdTipoPropiedad","@IdEstadoPropiedad","@EnumEstado","@IdCliente",
                        "@IdPais","@IdProvincia","@IdLocalidad","@IdBarrio","@Calle","@Numero","@Depto","@Piso","@CodigoPostal","@CalleEntre1","@CalleEntre2",
                        "@ValorMercadoImporte","@ValorMercadoIdMoneda","@ValorPublicacionImporte","@ValorPublicacionIdMoneda","@EsOtraInmobiliaria",
                        "@MetrosCubiertos","@MetrosSemicubiertos","@MetrosLibres","@Metros","@Fondo","@Frente","@Orientacion","@CantidadBaños","@CantidadCocheras",
			            "@CantidadDormitorios","@CantidadPlantas","@Disposicion","@EsAptoProfesional","@CantidadPisos","@DepartamentosPorPiso","@CantidadAscensores",
			            "@CantidadAscensoresServicio","@TipoZona","@Fos","@Fot","@Zonificacion","@MetrosConstruibles"});
        }

        public int InsertarPropiedades(decimal CantidadAmbientes, int IdTipoPropiedad, int IdEstadoPropiedad, int IdEnumEstado, int IdCliente,
                int IdPais, int IdProvincia, int IdLocalidad, int IdBarrio, string Calle, int Numero, string Depto, string Piso, string CodigoPostal, string EntreCalle1, string EntreCalle2,
                decimal ValorMercado, int ValorMercadoIdMoneda, decimal ValorPublicacion, int ValorPublicacionIdMoneda, bool EsOtraInmobiliaria,
                decimal MetrosCubiertos, decimal MetrosSemicubiertos, decimal MetrosLibres, decimal Metros, decimal Fondo, decimal Frente, string Orientacion, int CantidadBanos, int CantidadCocheras,
                int CantidadDormitorios, int CantidadPlantas, int IdDisposicion, bool EsAptoProfesional, int CantidadPisos, int DeptosPorPiso, int CantidadAscensores,
                int CantidadAscensoresServicio, int IdTipoZona, string fos, string fot,string zonificacion, decimal mestrosConstruibles)
        {


            object id = null;
            if (IdCliente == 0)
                id = DBNull.Value;
            else
                id = IdCliente;

            return AccesoDatos.InsertarRegistro(
                "Propiedades_Crear",
                new object[] {  CantidadAmbientes,  IdTipoPropiedad,  IdEstadoPropiedad,  IdEnumEstado,  id,
                 IdPais,  IdProvincia,  IdLocalidad,  IdBarrio,  Calle,  Numero,  Depto,  Piso,  CodigoPostal,  EntreCalle1,  EntreCalle2,
                 ValorMercado,  ValorMercadoIdMoneda,  ValorPublicacion,  ValorPublicacionIdMoneda,  EsOtraInmobiliaria,
                 MetrosCubiertos,  MetrosSemicubiertos,  MetrosLibres,  Metros,  Fondo,  Frente,  Orientacion,  CantidadBanos,  CantidadCocheras,
                 CantidadDormitorios,  CantidadPlantas,  IdDisposicion,  EsAptoProfesional,  CantidadPisos,  DeptosPorPiso,  CantidadAscensores,
                 CantidadAscensoresServicio,  IdTipoZona,  fos,  fot, zonificacion,  mestrosConstruibles },
                new string[] { "@CantidadAmbientes","@IdTipoPropiedad","@IdEstadoPropiedad","@EnumEstado","@IdCliente",
                        "@IdPais","@IdProvincia","@IdLocalidad","@IdBarrio","@Calle","@Numero","@Depto","@Piso","@CodigoPostal","@CalleEntre1","@CalleEntre2",
                        "@ValorMercadoImporte","@ValorMercadoIdMoneda","@ValorPublicacionImporte","@ValorPublicacionIdMoneda","@EsOtraInmobiliaria",
                        "@MetrosCubiertos","@MetrosSemicubiertos","@MetrosLibres","@Metros","@Fondo","@Frente","@Orientacion","@CantidadBaños","@CantidadCocheras",
			            "@CantidadDormitorios","@CantidadPlantas","@Disposicion","@EsAptoProfesional","@CantidadPisos","@DepartamentosPorPiso","@CantidadAscensores",
			            "@CantidadAscensoresServicio","@TipoZona","@Fos","@Fot","@Zonificacion","@MetrosConstruibles"});

        }


        #endregion

        #region MEDIDAS DE AMBIENTES . PROPIEDADES

        public IDataReader RecuperarTiposDePiso()
        {

            return AccesoDatos.RecuperarDatos(
                "TiposDePiso_RecuperarTodos",
                new object[] { },
                new string[] { });
        }

        public IDataReader RecuperarMedidasAmbientesPorPropiedad(int IdPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                "MedidasAmbientes_RecuperarPorPropiedad",
                new object[] { IdPropiedad },
                new string[] { "@IdPropiedad" });
        }


        public bool EliminarMedidaAmbiente(int IdMedidaAmbiente)
        {
            return AccesoDatos.EliminarRegistro("Propiedades_MedidadasAmbiente_Eliminar",
                new object[] { IdMedidaAmbiente },
                new string[] { "@IdMedida" });
        }

        public int GuardarMedidaAmbiente(decimal Ancho, decimal Largo, string Ambiente, int IdTipoPiso, int IdPropiedad)
        {
            return AccesoDatos.InsertarRegistro(
                "Propiedades_MedidadasAmbiente_Insertar",
                new object[] { Ancho, Largo, Ambiente, IdTipoPiso, IdPropiedad },
                new string[] { "@Ancho", "@Largo", "@Ambiente", "@IdTipoPiso", "@IdPropiedad" });
        }

        #endregion


        #region GALERIA DE FOTOS


        public IDataReader RecuperarGaleria(int idPropiedad)
        {
            return AccesoDatos.RecuperarDatos("Propiedades_RecuperarGaleria", new object[] { idPropiedad }, new string[] { "@IdPropiedad" });
        
        }

        public bool FotoEliminar(int idFoto)
        {
            return AccesoDatos.EliminarRegistro("Propiedades_EliminarFoto", new object[] { idFoto }, new string[] { "@IdFoto" });
        }


        public int FotoGuardar(int IdPropiedad, bool EsFachada, string Descripcion, byte[] Foto)
        {
            return AccesoDatos.InsertarRegistro(
                "Propiedades_GuardarFoto",
                new object[] { IdPropiedad, EsFachada, Descripcion, Foto },
                new string[] { "@IdPropiedad", "@EsFachada", "@Descripcion", "@Foto" });
        }



        #endregion



    }
}
