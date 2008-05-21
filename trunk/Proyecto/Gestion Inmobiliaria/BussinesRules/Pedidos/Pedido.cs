using System;
using System.Collections.Generic;
using System.Text;
using GI.BR.Propiedades;

namespace GI.BR.Pedidos
{
    public class Pedido: ICloneable
    {


        public Pedido()
        {
            ubicacion = new Ubicacion();
        }


        #region Miembros

        private int idPedido;
        private GI.BR.Clientes.ClientePedido clientePedido;

        private Type estadoPropiedad;
        private TipoPropiedad tipoPropiedad;
        private CategoriaPropiedad categoria;
        private EstadoPropiedad estado;
        private Nullable<Estado> enumEstado;
        private Ambiente cantidadAmbientesInicial;
        private Ambiente cantidadAmbientesFinal;
        private Ubicacion ubicacion;
        private decimal valorInicial;
        private decimal valorFinal;
        private Monedas.Moneda moneda;
        private int metrosTerrenoInicial;
        private int metrosTerrenoFinal;
        private int metrosCubiertosInicial;
        private int metrosCubiertosFinal;

        private Nullable<DepartamentoDisposicion> disposicion;
        private Nullable<bool> esAptoProfesional;

        private Nullable<TipoZona> tipoZona;
        private int metrosConstruiblesInicial;
        private int metrosConstruiblesFinal;

        private bool activo;
        private string observaciones;
        private DateTime fechaAlta;

        #endregion

        #region Miembros Publicos

        public int IdPedido { get { return idPedido; } set { idPedido = value; } }

        public GI.BR.Clientes.ClientePedido ClientePedido { get { return clientePedido; } set { clientePedido = value; } }

        public Type EstadoPropiedad { get { return estadoPropiedad; } set { estadoPropiedad = value; } }

        public TipoPropiedad TipoPropiedad { get { return tipoPropiedad; } set { tipoPropiedad = value; } }

        public CategoriaPropiedad Categoria { get { return categoria; } set { categoria = value; } }

        public EstadoPropiedad Estado { get { return estado; } set { estado = value; } }

        public Nullable<Estado> EnumEstado
        {
            get { return enumEstado; }
            set
            {
                if (value.HasValue && value.Value == GI.BR.Propiedades.Estado.NoEspecifica)
                    enumEstado = null;
                else
                    enumEstado = value;
            }
        }

        public Ambiente CantidadAmbientesInicial { get { return cantidadAmbientesInicial; } set { cantidadAmbientesInicial = value; } }

        public Ambiente CantidadAmbientesFinal { get { return cantidadAmbientesFinal; } set { cantidadAmbientesFinal = value; } }

        public Ubicacion Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        public decimal ValorInicial { get { return valorInicial; } set { valorInicial = value; } }

        public decimal ValorFinal { get { return valorFinal; } set { valorFinal = value; } }

        public Monedas.Moneda Moneda { get { return moneda; } set { moneda = value; } }

        public int MetrosTerrenoInicial { get { return metrosTerrenoInicial; } set { metrosTerrenoInicial = value; } }

        public int MetrosTerrenoFinal { get { return metrosTerrenoFinal; } set { metrosTerrenoFinal = value; } }

        public int MetrosCubiertosInicial { get { return metrosCubiertosInicial; } set { metrosCubiertosInicial = value; } }

        public int MetrosCubiertosFinal { get { return metrosCubiertosFinal; } set { metrosCubiertosFinal = value; } }

        public Nullable<DepartamentoDisposicion> Disposicion
        {
            get { return disposicion; }
            set
            {
                if (value.HasValue && value.Value == DepartamentoDisposicion.SinDefinir)
                    disposicion = null;
                else
                    disposicion = value;
            }
        }

        public bool EsDepartamento
        {
            get
            {
                if(this.TipoPropiedad != null)
                    return this.TipoPropiedad.Descripcion == "Departamento";
                return false;
            }
        }

        public Nullable<bool> EsAptoProfesional { get { return esAptoProfesional; } set { esAptoProfesional = value; } }

        public Nullable<TipoZona> TipoZona
        {
            get { return tipoZona; }
            set
            {
                if (value.HasValue && value.Value == GI.BR.Propiedades.TipoZona.SinDefinir)
                    tipoZona = null;
                else
                    tipoZona = value;
            }
        }

        public int MetrosConstruiblesInicial { get { return metrosConstruiblesInicial; } set { metrosConstruiblesInicial = value; } }

        public int MetrosConstruiblesFinal { get { return metrosConstruiblesFinal; } set { metrosConstruiblesFinal = value; } }

        public bool Activo { get { return activo; } set { activo = value; } }

        public string Observaciones { get { return observaciones; } set { observaciones = value; } }

        public DateTime FechaAlta { get { return fechaAlta; } set { fechaAlta = value; } }

        private Nullable<decimal> getcantAmbientesFinal()
        {
            if (CantidadAmbientesFinal == null)
                return null;
            else
                return this.CantidadAmbientesFinal.CantidadAmbientes;
        }

        private Nullable<decimal> getcantAmbientesInicial()
        {
            if (CantidadAmbientesInicial == null)
                return null;
            else
                return this.CantidadAmbientesInicial.CantidadAmbientes;
        }

        private Nullable<int> getCategoria()
        {
            if (Categoria == null)
                return null;
            else
                return this.Categoria.IdCategoria;
        }

        private Nullable<int> getDisposicion()
        {
            if (Disposicion.HasValue)
                return (int)this.Disposicion.Value;
            else
                return null;
        }

        private Nullable<int> getEnumEstado()
        {
            if (EnumEstado.HasValue)
                return (int)this.EnumEstado.Value;
            else
                return null;
        }

        private Nullable<bool> getEsAptoProfesional()
        {
            if (EsAptoProfesional.HasValue)
                return (bool)this.EsAptoProfesional.Value;
            else
                return null;
        }

        private Nullable<int> getEstado()
        {
            if (Estado != null)
                return (int)this.Estado.IdEstadoPropiedad;
            else
                return null;
        }

        private Nullable<int> getTipoPropiedad()
        {
            if (TipoPropiedad == null)
                return null;
            else
                return this.TipoPropiedad.IdTipoPropiedad;
        }

        private Nullable<int> getTipoZona()
        {
            if (TipoZona.HasValue)
                return (int)this.TipoZona.Value;
            else
                return null;
        }

        private Nullable<int> getBarrio()
        {
            if (Ubicacion.Barrio != null)
                return Ubicacion.Barrio.IdBarrio;
            else
                return null;
        }

        private Nullable<int> getLocalidad()
        {
            if (Ubicacion.Localidad != null)
                return Ubicacion.Localidad.IdLocalidad;
            else
                return null;
        }

        private Nullable<int> getPais()
        {
            if (Ubicacion.Pais != null)
                return Ubicacion.Pais.IdPais;
            else
                return null;
        }

        private Nullable<int> getProvincia()
        {
            if (Ubicacion.Provincia != null)
                return Ubicacion.Provincia.IdProvincia;
            else
                return null;
        }

        private Nullable<decimal> getValorFinal()
        {
            if (valorFinal != 0)
                return valorFinal;
            else
                return null;
        }

        private Nullable<decimal> getValorInicial()
        {
            if (valorInicial != 0)
                return valorInicial;
            else
                return null;
        }

        private Nullable<int> getMoneda()
        {
            if (Moneda != null)
                return Moneda.IdMoneda;
            else
                return null;
        }
        #endregion

        #region Persistencia

        public bool Guardar()        
        {
            this.Activo = true;
            this.FechaAlta = DateTime.Today;
            GI.DA.PedidosData pd = new GI.DA.PedidosData();
            this.IdPedido = pd.Guardar(
                getcantAmbientesFinal(),
                getcantAmbientesInicial(),
                getCategoria(),
                this.ClientePedido.IdCliente,
                getDisposicion(),
                getEnumEstado(),
                this.EsAptoProfesional,
                getEstado(),
                this.EstadoPropiedad,
                this.MetrosConstruiblesFinal,
                this.MetrosConstruiblesInicial,
                this.MetrosCubiertosFinal, this.MetrosCubiertosInicial,
                this.MetrosTerrenoFinal, this.MetrosTerrenoInicial,
                getTipoPropiedad(),
                getTipoZona(),
                getBarrio(),
                getLocalidad(),
                getPais(),
                getProvincia(),
                getValorFinal(),
                getValorInicial(),
                getMoneda(),
                Observaciones,
                Activo,
                FechaAlta);

            return IdPedido > 0;

        }

        public bool Actualizar()
        {
            GI.DA.PedidosData pd = new GI.DA.PedidosData();
            return pd.Actualizar(
                this.IdPedido,
                getcantAmbientesFinal(),
                getcantAmbientesInicial(),
                getCategoria(),
                this.ClientePedido.IdCliente,
                getDisposicion(),
                getEnumEstado(),
                this.EsAptoProfesional,
                getEstado(),
                this.EstadoPropiedad,
                this.MetrosConstruiblesFinal,
                this.MetrosConstruiblesInicial,
                this.MetrosCubiertosFinal, this.MetrosCubiertosInicial,
                this.MetrosTerrenoFinal, this.MetrosTerrenoInicial,
                getTipoPropiedad(),
                getTipoZona(),
                getBarrio(),
                getLocalidad(),
                getPais(),
                getProvincia(),
                getValorFinal(),
                getValorInicial(),
                getMoneda(),
                Observaciones,
                Activo,
                FechaAlta);
        }

        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion



        internal void fill(System.Data.IDataReader dr)
        {
            if (!dr.IsDBNull(dr.GetOrdinal("CantidadAmbientesFinal")))
            {
                this.CantidadAmbientesFinal = new Ambiente();
                this.CantidadAmbientesFinal.CantidadAmbientes = dr.GetDecimal(dr.GetOrdinal("CantidadAmbientesFinal"));
            }

            if (!dr.IsDBNull(dr.GetOrdinal("CantidadAmbientesInicial")))
            {
                this.CantidadAmbientesInicial = new Ambiente();
                this.CantidadAmbientesInicial.CantidadAmbientes = dr.GetDecimal(dr.GetOrdinal("CantidadAmbientesInicial"));
            }

            if (!dr.IsDBNull(dr.GetOrdinal("IdCategoria")))
            {
                this.Categoria = new CategoriaPropiedad();
                this.Categoria.IdCategoria = dr.GetInt32(dr.GetOrdinal("IdCategoria"));
                this.Categoria.Nombre = dr.GetString(dr.GetOrdinal("NombreCategoria"));
            }

            this.ClientePedido = new GI.BR.Clientes.ClientePedido();
            this.ClientePedido.IdCliente = dr.GetInt32(dr.GetOrdinal("IdCliente"));

            if (dr.IsDBNull(dr.GetOrdinal("Disposicion")))
                this.Disposicion = null;
            else
                this.Disposicion = (DepartamentoDisposicion)dr.GetInt32(dr.GetOrdinal("Disposicion"));


            if (dr.IsDBNull(dr.GetOrdinal("EnumEstado")))
                this.EnumEstado = null;
            else
                this.EnumEstado = (GI.BR.Propiedades.Estado)dr.GetInt32(dr.GetOrdinal("EnumEstado"));


            if (dr.IsDBNull(dr.GetOrdinal("EsAptoProfesional")))
                this.EsAptoProfesional = null;
            else
                this.EsAptoProfesional = dr.GetBoolean(dr.GetOrdinal("EsAptoProfesional"));

            this.EstadoPropiedad = Type.GetType(dr.GetString(dr.GetOrdinal("EstadoPropiedad")));

            if (dr.IsDBNull(dr.GetOrdinal("IdEstadoPropiedad")))
                this.Estado = null;
            else
                this.Estado = EstadoPropiedadFlyweigthFactory.GetInstancia(this.EstadoPropiedad).GetEstado(dr.GetInt32(dr.GetOrdinal("IdEstadoPropiedad")));

            this.IdPedido = dr.GetInt32(dr.GetOrdinal("IdPedido"));

            if (dr.IsDBNull(dr.GetOrdinal("MetrosConstruiblesFinal")))
                this.MetrosConstruiblesFinal = 0;
            else
                this.MetrosConstruiblesFinal = dr.GetInt32(dr.GetOrdinal("MetrosConstruiblesFinal"));


            if (dr.IsDBNull(dr.GetOrdinal("MetrosConstruiblesInicial")))
                this.MetrosConstruiblesInicial = 0;
            else
                this.MetrosConstruiblesInicial = dr.GetInt32(dr.GetOrdinal("MetrosConstruiblesInicial"));


            if (dr.IsDBNull(dr.GetOrdinal("MetrosCubiertosFinal")))
                this.MetrosCubiertosFinal = 0;
            else
                this.MetrosCubiertosFinal = dr.GetInt32(dr.GetOrdinal("MetrosCubiertosFinal"));

            if (dr.IsDBNull(dr.GetOrdinal("MetrosCubiertosInicial")))
                this.MetrosCubiertosInicial = 0;
            else
                this.MetrosCubiertosInicial = dr.GetInt32(dr.GetOrdinal("MetrosCubiertosInicial"));

            if (dr.IsDBNull(dr.GetOrdinal("MetrosTerrenoFinal")))
                this.MetrosTerrenoFinal = 0;
            else
                this.MetrosTerrenoFinal = dr.GetInt32(dr.GetOrdinal("MetrosTerrenoFinal"));

            if (dr.IsDBNull(dr.GetOrdinal("MetrosTerrenoInicial")))
                this.MetrosTerrenoInicial = 0;
            else
                this.MetrosTerrenoInicial = dr.GetInt32(dr.GetOrdinal("MetrosTerrenoInicial"));


            if (dr.IsDBNull(dr.GetOrdinal("IdMoneda")))
                this.Moneda = null;
            else
                this.Moneda = GI.BR.Monedas.MonedasFlyweigthFactory.GetInstancia.GetMoneda(dr.GetInt32(dr.GetOrdinal("IdMoneda")));

            if (dr.IsDBNull(dr.GetOrdinal("IdTipoPropiedad")))
                this.TipoPropiedad = null;
            else
                this.TipoPropiedad = TiposPropiedadFlyweightFactory.GetInstancia.GetTipoPropiedad(dr.GetInt32(dr.GetOrdinal("IdTipoPropiedad")));

            if (dr.IsDBNull(dr.GetOrdinal("TipoZona")))
                this.TipoZona = null;
            else
                this.TipoZona = (GI.BR.Propiedades.TipoZona)dr.GetInt32(dr.GetOrdinal("TipoZona"));

            this.Ubicacion = new Ubicacion();

            if (dr.IsDBNull(dr.GetOrdinal("IdBarrio")))
                this.Ubicacion.Barrio = null;
            else
                this.Ubicacion.Barrio = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetBarrio(dr.GetInt32(dr.GetOrdinal("IdBarrio")));

            if (dr.IsDBNull(dr.GetOrdinal("IdLocalidad")))
                this.Ubicacion.Localidad = null;
            else
                this.Ubicacion.Localidad = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetLocalidad(dr.GetInt32(dr.GetOrdinal("IdLocalidad")));

            if (dr.IsDBNull(dr.GetOrdinal("IdPais")))
                this.Ubicacion.Pais = null;
            else
                this.Ubicacion.Pais = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetPais(dr.GetInt32(dr.GetOrdinal("IdPais")));

            if (dr.IsDBNull(dr.GetOrdinal("IdProvincia")))
                this.Ubicacion.Provincia = null;
            else
                this.Ubicacion.Provincia = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetProvincia(dr.GetInt32(dr.GetOrdinal("IdProvincia")));

            if (dr.IsDBNull(dr.GetOrdinal("ImporteFinal")))
                this.ValorFinal = 0;
            else
                this.ValorFinal = dr.GetDecimal(dr.GetOrdinal("ImporteFinal"));

            if (dr.IsDBNull(dr.GetOrdinal("ImporteInicial")))
                this.ValorInicial = 0;
            else
                this.ValorInicial = dr.GetDecimal(dr.GetOrdinal("ImporteInicial"));

            this.Observaciones = dr.GetString(dr.GetOrdinal("Observaciones"));
            this.Activo = dr.GetBoolean(dr.GetOrdinal("Activo"));
            this.FechaAlta = dr.GetDateTime(dr.GetOrdinal("FechaAlta"));
        }
    }
}
