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

        public IDataReader RecuperarPropiedadesVentasSinOfrecer(int IdPedido)
        {
            return AccesoDatos.RecuperarDatos(
                "PropiedadesVentas_RecuperarTodasSinOfrecer",
                new object[] { IdPedido },
                new string[] { "@IdPedido" });
        }

     	
	public IDataReader RecuperarPropiedadesVentasOfrecidas(int IdPedido)
        {
            return AccesoDatos.RecuperarDatos(
                "PropiedadesVentas_RecuperarTodasOfrecidas",
                new object[] { IdPedido },
                new string[] { "@IdPedido" });
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

        public IDataReader RecuperarPropiedadesAlquileresSinOfrecer(int IdPedido)
        {
            return AccesoDatos.RecuperarDatos(
                "PropiedadesAlquileres_RecuperarTodasSinOfrecer",
                new object[] { IdPedido},
                new string[] { "@IdPedido" });
        }

     	public IDataReader RecuperarPropiedadesAlquileresOfrecidas(int IdPedido)
        {
            return AccesoDatos.RecuperarDatos(
                "PropiedadesAlquileres_RecuperarTodasOfrecidas",
                new object[] { IdPedido },
                new string[] { "@IdPedido" });
        }


        
        #endregion

        public IDataReader RecuperarPropiedadPorId(int IdPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                "Propiedad_RecuperarPorId",
                new object[] { IdPropiedad },
                new string[] { "@IdPropiedad" });
        }

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

        public bool ActualizarPropiedad(string observaciones, int IdPropiedad, decimal CantidadAmbientes, int IdTipoPropiedad, int IdEstadoPropiedad, int IdEnumEstado, int IdCliente,
                int IdPais, int IdProvincia, int IdLocalidad, int IdBarrio, string Calle, int Numero, string Depto, string Piso, string CodigoPostal, string EntreCalle1, string EntreCalle2,
                decimal ValorMercado, int ValorMercadoIdMoneda, decimal ValorPublicacion, int ValorPublicacionIdMoneda, bool EsOtraInmobiliaria,
                decimal MetrosCubiertos, decimal MetrosSemicubiertos, decimal MetrosLibres, decimal Metros, decimal Fondo, decimal Frente, string Orientacion, int CantidadBanos, int CantidadCocheras,
                int CantidadDormitorios, int CantidadPlantas, int IdDisposicion, bool EsAptoProfesional, int CantidadPisos, int DeptosPorPiso, int CantidadAscensores,
                int CantidadAscensoresServicio, int IdTipoZona, string fos, string fot, string zonificacion, decimal mestrosConstruibles, int Antiguedad,
                int IdInmobiliariaExterna, decimal ValorExpensas,
            bool Jardin, bool Patio, bool Piscina, bool Lavadero, bool Dependencia, bool Quincho, bool Parrilla, bool Balcon, bool Terraza, bool Playroom, bool Baulera, bool CuartoHerramientas, bool PublicarSinPrecio)
        {

            object id = null;
            if (IdCliente == 0)
                id = DBNull.Value;
            else
                id = IdCliente;

            object idinm = null;
            if (IdInmobiliariaExterna == 0)
                idinm = DBNull.Value;
            else
                idinm = IdInmobiliariaExterna;


            return AccesoDatos.ActualizarRegistro(
                    "Propiedades_Actualizar",
                    new object[] { observaciones, IdPropiedad, CantidadAmbientes,  IdTipoPropiedad,  IdEstadoPropiedad,  IdEnumEstado,  id,
                 IdPais,  IdProvincia,  IdLocalidad,  IdBarrio,  Calle,  Numero,  Depto,  Piso,  CodigoPostal,  EntreCalle1,  EntreCalle2,
                 ValorMercado,  ValorMercadoIdMoneda,  ValorPublicacion,  ValorPublicacionIdMoneda,  EsOtraInmobiliaria,
                 MetrosCubiertos,  MetrosSemicubiertos,  MetrosLibres,  Metros,  Fondo,  Frente,  Orientacion,  CantidadBanos,  CantidadCocheras,
                 CantidadDormitorios,  CantidadPlantas,  IdDisposicion,  EsAptoProfesional,  CantidadPisos,  DeptosPorPiso,  CantidadAscensores,
                 CantidadAscensoresServicio,  IdTipoZona,  fos,  fot, zonificacion,  mestrosConstruibles, Antiguedad, idinm, ValorExpensas ,
                    Jardin, Patio,Piscina ,Lavadero ,Dependencia ,Quincho ,Parrilla , Balcon , Terraza ,Playroom ,Baulera ,CuartoHerramientas, PublicarSinPrecio},
                    new string[] {"@Descripcion", "@IdPropiedad", "@CantidadAmbientes","@IdTipoPropiedad","@IdEstadoPropiedad","@EnumEstado","@IdCliente",
                        "@IdPais","@IdProvincia","@IdLocalidad","@IdBarrio","@Calle","@Numero","@Depto","@Piso","@CodigoPostal","@CalleEntre1","@CalleEntre2",
                        "@ValorMercadoImporte","@ValorMercadoIdMoneda","@ValorPublicacionImporte","@ValorPublicacionIdMoneda","@EsOtraInmobiliaria",
                        "@MetrosCubiertos","@MetrosSemicubiertos","@MetrosLibres","@Metros","@Fondo","@Frente","@Orientacion","@CantidadBa�os","@CantidadCocheras",
			            "@CantidadDormitorios","@CantidadPlantas","@Disposicion","@EsAptoProfesional","@CantidadPisos","@DepartamentosPorPiso","@CantidadAscensores",
			            "@CantidadAscensoresServicio","@TipoZona","@Fos","@Fot","@Zonificacion","@MetrosConstruibles", "@Antiguedad", "@IdInmobiliariaExterna", "@ValorExpensas",
                         "@Jardin" ,"@Patio" ,"@Piscina" ,"@Lavadero" , "@Dependencia" ,"@Quincho" ,"@Parrilla" ,"@Balcon" , "@Terraza" ,"@Playroom" ,"@Baulera" ,"@CuartoHerramientas", "@PublicarSinPrecio"   });
        }

        public bool InsertarPropiedades(int IdPropiedad, string Observaciones, decimal CantidadAmbientes, int IdTipoPropiedad, int IdEstadoPropiedad, int IdEnumEstado, int IdCliente,
                int IdPais, int IdProvincia, int IdLocalidad, int IdBarrio, string Calle, int Numero, string Depto, string Piso, string CodigoPostal, string EntreCalle1, string EntreCalle2,
                decimal ValorMercado, int ValorMercadoIdMoneda, decimal ValorPublicacion, int ValorPublicacionIdMoneda, bool EsOtraInmobiliaria,
                decimal MetrosCubiertos, decimal MetrosSemicubiertos, decimal MetrosLibres, decimal Metros, decimal Fondo, decimal Frente, string Orientacion, int CantidadBanos, int CantidadCocheras,
                int CantidadDormitorios, int CantidadPlantas, int IdDisposicion, bool EsAptoProfesional, int CantidadPisos, int DeptosPorPiso, int CantidadAscensores,
                int CantidadAscensoresServicio, int IdTipoZona, string fos, string fot, string zonificacion, decimal mestrosConstruibles, int Antiguedad,
                int IdInmobiliariaExterna, decimal ValorExpensas,
                bool Jardin, bool Patio, bool Piscina, bool Lavadero, bool Dependencia, bool Quincho, bool Parrilla, bool Balcon, bool Terraza, bool Playroom, bool Baulera, bool CuartoHerramientas,
                bool PublicarSinPrecio)
        {

            object idinm = null;
            if (IdInmobiliariaExterna == 0)
                idinm = DBNull.Value;
            else
                idinm = IdInmobiliariaExterna;

            object id = null;
            if (IdCliente == 0)
                id = DBNull.Value;
            else
                id = IdCliente;

            return AccesoDatos.ActualizarRegistro(
                "Propiedades_Crear",
                new object[] { IdPropiedad, Observaciones, CantidadAmbientes,  IdTipoPropiedad,  IdEstadoPropiedad,  IdEnumEstado,  id,
                 IdPais,  IdProvincia,  IdLocalidad,  IdBarrio,  Calle,  Numero,  Depto,  Piso,  CodigoPostal,  EntreCalle1,  EntreCalle2,
                 ValorMercado,  ValorMercadoIdMoneda,  ValorPublicacion,  ValorPublicacionIdMoneda,  EsOtraInmobiliaria,
                 MetrosCubiertos,  MetrosSemicubiertos,  MetrosLibres,  Metros,  Fondo,  Frente,  Orientacion,  CantidadBanos,  CantidadCocheras,
                 CantidadDormitorios,  CantidadPlantas,  IdDisposicion,  EsAptoProfesional,  CantidadPisos,  DeptosPorPiso,  CantidadAscensores,
                 CantidadAscensoresServicio,  IdTipoZona,  fos,  fot, zonificacion,  mestrosConstruibles, Antiguedad, idinm, ValorExpensas,
                 Jardin, Patio,Piscina ,Lavadero ,Dependencia ,Quincho ,Parrilla , Balcon , Terraza ,Playroom ,Baulera ,CuartoHerramientas, PublicarSinPrecio   },
                new string[] { "@IdPropiedad", "@Descripcion", "@CantidadAmbientes","@IdTipoPropiedad","@IdEstadoPropiedad","@EnumEstado","@IdCliente",
                        "@IdPais","@IdProvincia","@IdLocalidad","@IdBarrio","@Calle","@Numero","@Depto","@Piso","@CodigoPostal","@CalleEntre1","@CalleEntre2",
                        "@ValorMercadoImporte","@ValorMercadoIdMoneda","@ValorPublicacionImporte","@ValorPublicacionIdMoneda","@EsOtraInmobiliaria",
                        "@MetrosCubiertos","@MetrosSemicubiertos","@MetrosLibres","@Metros","@Fondo","@Frente","@Orientacion","@CantidadBa�os","@CantidadCocheras",
			            "@CantidadDormitorios","@CantidadPlantas","@Disposicion","@EsAptoProfesional","@CantidadPisos","@DepartamentosPorPiso","@CantidadAscensores",
			            "@CantidadAscensoresServicio","@TipoZona","@Fos","@Fot","@Zonificacion","@MetrosConstruibles", "@Antiguedad", "@IdInmobiliariaExterna", "@ValorExpensas",
                        "@Jardin" ,"@Patio" ,"@Piscina" ,"@Lavadero" , "@Dependencia" ,"@Quincho" ,"@Parrilla" ,"@Balcon" , "@Terraza" ,"@Playroom" ,"@Baulera" ,"@CuartoHerramientas", "@PublicarSinPrecio"});

        }



        public int RecuperarProxIdPropiedad()
        {
            int id = 1;
            
            using (IDataReader dr = AccesoDatos.RecuperarDatos("Propiedades_SelectProxId", new object[] { }, new string[] { }))
            {
                if (dr.Read())
                {
                    id = dr.IsDBNull(0) ? 1 : dr.GetInt32(0);
                }
            }


            return id;


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

        public int GuardarMedidaAmbiente(decimal Ancho, decimal Largo, string Ambiente, int IdTipoPiso, int IdPropiedad, int IdTipoAmbiente)
        {
            return AccesoDatos.InsertarRegistro(
                "Propiedades_MedidadasAmbiente_Insertar",
                new object[] { Ancho, Largo, Ambiente, IdTipoPiso, IdPropiedad, IdTipoAmbiente },
                new string[] { "@Ancho", "@Largo", "@Ambiente", "@IdTipoPiso", "@IdPropiedad", "@IdTipoAmbiente" });
        }

        #endregion


        #region GALERIA DE FOTOS

        public IDataReader RecuperarFoto(int IdFoto)
        {
            return AccesoDatos.RecuperarDatos("Propiedades_RecuperarFoto", new object[] { IdFoto }, new string[] { "@IdFoto" });
        
        }

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



        #region Notas


        public bool EliminarNota(int IdNota)
        { 
            return AccesoDatos.EliminarRegistro(
                "Propiedades_EliminarNota",
                new object[] { IdNota },
                new string[] { "@IdNota" });
        }

        public int CrearNota(int IdPropiedad, string Nota, DateTime Fecha)
        { 
            return AccesoDatos.InsertarRegistro(
                "Propiedades_InsertarNota",
                 new object[] { IdPropiedad, Nota, Fecha },
                new string[] { "@IdPropiedad", "@Nota", "@Fecha" });
        
        }

        public IDataReader RecuperarNotasPropiedad(int IdPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                "Propiedades_RecuperarNotas",
                new object[] { IdPropiedad },
                new string[] { "@IdPropiedad" });
        
        }

        #endregion


        #region Visitas


        public IDataReader RecuperarVisitas(int IdPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                "Propiedades_RecuperarVisitas",
                new object[] { IdPropiedad },
                new string[] { "@IdPropiedad" });
        
        }

        public int CrearVisita(	long TimpoAlarma,
	            DateTime FechaHora,
	            bool Realizada,
	            string Visita ,
	            string Telefono ,
	            string Comentario ,
	            bool ConAlarma ,
	            int IdPropiedad )
        {
            return AccesoDatos.InsertarRegistro(
                "Propiedades_GuardarVisita",
                 new object[] { TimpoAlarma, FechaHora, Realizada, Visita, Telefono, Comentario, ConAlarma, IdPropiedad },
                new string[] { "@TimpoAlarma", "@FechaHora", "@Realizada", "@Visita", "@Telefono", "@Comentario", "@ConAlarma", "@IdPropiedad" });

        
        }

        public bool ActualizarVisita(long TimpoAlarma,
                DateTime FechaHora,
                bool Realizada,
                string Visita,
                string Telefono,
                string Comentario,
                bool ConAlarma,
                int IdVisita)
        {
            return AccesoDatos.ActualizarRegistro(
         "Propiedades_ActualizarVisita",
          new object[] { TimpoAlarma, FechaHora, Realizada, Visita, Telefono, Comentario, ConAlarma, IdVisita },
         new string[] { "@TimpoAlarma", "@FechaHora", "@Realizada", "@Visita", "@Telefono", "@Comentario", "@ConAlarma", "@IdVisita" });

        
        
        }

        public bool EliminarVisita(int IdVisita)
        { 
            return AccesoDatos.EliminarRegistro(
                "Propiedades_EliminarVisita",
                new object[] { IdVisita },
                new string[] { "@IdVisita" });
        }


        #endregion



        #region Llamados

        public IDataReader RecuperarLlamados(int IdPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                 "Propiedades_RecuperarLlamados",
                 new object[] { IdPropiedad },
                 new string[] { "@IdPropiedad" });

        }

        public int CrearLlamado(
               DateTime FechaHora,
               string Contacto,
               string Telefono,
               string Comentarios,
               int IdPropiedad)
        {
            return AccesoDatos.InsertarRegistro(
                "Propiedades_CrearLlamado",
                 new object[] { FechaHora, Contacto, Telefono, Comentarios, IdPropiedad },
                new string[] { "@FechaHora", "@Contacto", "@Telefono", "@Comentarios", "@IdPropiedad" });


        }

        public bool EliminarLlamado(int IdLlamado)
        {
            return AccesoDatos.EliminarRegistro(
                "Propiedades_EliminarLlamado",
                new object[] { IdLlamado },
                new string[] { "@IdLlamado " });
        }

        public bool ActualizarLlamado(
       DateTime FechaHora,
       string Contacto,
       string Telefono,
       string Comentarios,
       int IdLlamado)
        {
            return AccesoDatos.ActualizarRegistro(
                "Propiedades_ActualizarLlamado",
                 new object[] { FechaHora, Contacto, Telefono, Comentarios, IdLlamado },
                new string[] { "@FechaHora", "@Contacto", "@Telefono", "@Comentarios", "@IdLlamado" });


        }

        #endregion


        #region Publicaciones


        public IDataReader RecuperarPublicaciones(int IdPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                  "Propiedades_RecuperarPublicaciones",
                  new object[] { IdPropiedad },
                  new string[] { "@IdPropiedad" });

        
        }

        public int CrearPublicacion(int IdPropiedad, string Medio, string Detalles, DateTime Fecha, int IdMoneda, decimal Importe)
        {
            return AccesoDatos.InsertarRegistro(
                "Propiedades_CrearPublicacion",
                new object[] { IdPropiedad, Medio, Detalles, Fecha, IdMoneda, Importe },
                new string[] { "@IdPropiedad", "@Medio", "@Detalles", "@Fecha", "@IdMoneda", "@Importe" });
        
        }


        public bool ActualizarPublicacion(int IdPublicacion, string Medio, string Detalles, DateTime Fecha, int IdMoneda, decimal Importe)
        {
            return AccesoDatos.ActualizarRegistro(
                "Propiedades_ActualizarPublicacion",
                new object[] { IdPublicacion, Medio, Detalles, Fecha, IdMoneda, Importe },
                new string[] { "@IdPublicacion", "@Medio", "@Detalles", "@Fecha", "@IdMoneda", "@Importe" });

        }


        public bool EliminarPublicacion(int IdPublicacion)
        {
            return AccesoDatos.EliminarRegistro(
                "Propiedades_EliminarPublicacion",
                new object[] { IdPublicacion },
                new string[] { "@IdPublicacion " });
        }
        #endregion


        #region Tasaciones

        public IDataReader RecuperarTasaciones(int IdPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                  "Propiedades_RecuperarTasaciones",
                  new object[] { IdPropiedad },
                  new string[] { "@IdPropiedad" });
        }

        public int CrearTasacion(int IdPropiedad, DateTime Fecha, decimal ValorReal, decimal ValorPublicacion, int IdMonedaReal, int IdMonedaPublicacion, string Detalles)
        {
            return AccesoDatos.InsertarRegistro(
                "Propiedades_CrearTasacion",
                new object[] { IdPropiedad, Fecha, ValorReal, ValorPublicacion, IdMonedaReal, IdMonedaPublicacion, Detalles },
                new string[] { "@IdPropiedad", "@Fecha", "@ImporteReal", "@ImportePublicacion", "@IdMonedaReal", "@IdMonedaPublicacion", "@Comentarios" });

        
        }

        public bool ActualizarTasacion(int IdTasacion, DateTime Fecha, decimal ValorReal, decimal ValorPublicacion, int IdMonedaReal, int IdMonedaPublicacion, string Detalles)
        {
            return AccesoDatos.ActualizarRegistro(
                    "Propiedades_ModificarTasacion",
                    new object[] { IdTasacion, Fecha, ValorReal, ValorPublicacion, IdMonedaReal, IdMonedaPublicacion, Detalles },
                    new string[] { "@IdTasacion", "@Fecha", "@ImporteReal", "@ImportePublicacion", "@IdMonedaReal", "@IdMonedaPublicacion", "@Comentarios" });

        }

        public bool EliminarTasacion(int IdTasacion)
        { 
            return AccesoDatos.EliminarRegistro(
                "Propiedades_EliminarTasacion",
                new object[] { IdTasacion },
                new string[] { "@IdTasacion " });

        }

        #endregion


        #region Tipos de Ambiente

        public IDataReader RecuperarTiposDeAmbiente()
        {
            return AccesoDatos.RecuperarDatos("Propiedades_TiposDeAmbiente_RecuperarTodos", new object[] { }, new string[] { });

        }


        #endregion



        public IDataReader RecuperarVentaPorId(int IdPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                "PropiedadesVentas_RecuperarPorId",
                new object[] { IdPropiedad },
                new string[] { "@IdPropiedad" });
        }

        public IDataReader RecuperarAlquilerPorId(int IdPropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                "PropiedadesAlquileres_RecuperarPorId",
                new object[] { IdPropiedad },
                new string[] { "@IdPropiedad" });
        }

        public bool EliminarAmbientes(int IdPropiedad)
        {
            return AccesoDatos.EliminarRegistro(
                "Propiedades_EliminarAmbientes",
                new object[] { IdPropiedad },
                new string[] { "@IdPropiedad" });
        }
    }
}
