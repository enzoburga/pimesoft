using System;
using System.Collections.Generic;
using System.Text;
using GI.BR.Propiedades;

namespace GI.BR.Pedidos
{
    public class Pedido
    {
        #region Miembros

        private int idPedido;
        private GI.BR.Clientes.ClientePedido clientePedido;

        private Type estadoPropiedad;
        private TipoPropiedad tipoPropiedad;
        private CategoriaPropiedad categoria;
        private EstadoPropiedad estado;
        private Estado enumEstado;
        private Ambiente cantidadAmbientesInicial;
        private Ambiente cantidadAmbientesFinal;
        private Ubicacion ubicacion;
        private Valor valorInicial;
        private Valor valorFinal;
        private int metrosTerrenoInicial;
        private int metrosTerrenoFinal;
        private int metrosCubiertosInicial;
        private int metrosCubiertosFinal;

        private DepartamentoDisposicion disposicion;
        private bool esDepartamento;
        private bool esAptoProfesional;

        private TipoZona tipoZona;
        private int metrosConstruiblesInicial;
        private int metrosConstruiblesFinal;

        #endregion

        #region Miembros Publicos

        public int IdPedido { get { return idPedido; } set { idPedido = value; } }

        public GI.BR.Clientes.ClientePedido ClientePedido { get { return clientePedido; } set { clientePedido = value; } }

        public Type EstadoPropiedad { get { return estadoPropiedad; } set { estadoPropiedad = value; } }

        public TipoPropiedad TipoPropiedad { get { return tipoPropiedad; } set { tipoPropiedad = value; } }

        public CategoriaPropiedad Categoria { get { return categoria; } set { categoria = value; } }

        public EstadoPropiedad Estado { get { return estado; } set { estado = value; } }

        public Estado EnumEstado { get { return enumEstado; } set { enumEstado = value; } }

        public Ambiente CantidadAmbientesInicial { get { return cantidadAmbientesInicial; } set { cantidadAmbientesInicial = value; } }

        public Ambiente CantidadAmbientesFinal { get { return cantidadAmbientesFinal; } set { cantidadAmbientesFinal = value; } }

        public Ubicacion Ubicacion { get { return ubicacion; } set { ubicacion = value; } }

        public Valor ValorInicial { get { return valorInicial; } set { valorInicial = value; } }

        public Valor ValorFinal { get { return valorFinal; } set { valorFinal = value; } }

        public int MetrosTerrenoInicial { get { return metrosTerrenoInicial; } set { metrosTerrenoInicial = value; } }

        public int MetrosTerrenoFinal { get { return metrosTerrenoFinal; } set { metrosTerrenoFinal = value; } }

        public int MetrosCubiertosInicial { get { return metrosCubiertosInicial; } set { metrosCubiertosInicial = value; } }

        public int MetrosCubiertosFinal { get { return metrosCubiertosFinal; } set { metrosCubiertosFinal = value; } }

        public DepartamentoDisposicion Disposicion { get { return disposicion; } set { disposicion = value; } }

        public bool EsDepartamento { get { return esDepartamento; } set { esDepartamento = value; } }

        public bool EsAptoProfesional { get { return esAptoProfesional; } set { esAptoProfesional = value; } }

        public TipoZona TipoZona { get { return tipoZona; } set { tipoZona = value; } }

        public int MetrosConstruiblesInicial { get { return metrosConstruiblesInicial; } set { metrosConstruiblesInicial = value; } }

        public int MetrosConstruiblesFinal { get { return metrosConstruiblesFinal; } set { metrosConstruiblesFinal = value; } }
        
        #endregion

        #region Persistencia

        public bool Guardar()
        {
            GI.DA.PedidosData pd = new GI.DA.PedidosData();
            this.IdPedido = pd.Guardar(
                this.CantidadAmbientesFinal.CantidadAmbientes,
                this.CantidadAmbientesInicial.CantidadAmbientes,
                this.Categoria.IdCategoria,
                this.ClientePedido.IdCliente,
                (int)this.Disposicion,
                (int)this.EnumEstado,
                this.EsAptoProfesional,
                this.EsDepartamento,
                this.Estado.IdEstadoPropiedad,
                this.EstadoPropiedad,
                this.MetrosConstruiblesFinal,
                this.MetrosConstruiblesInicial,
                this.MetrosCubiertosFinal, this.MetrosCubiertosInicial,
                this.MetrosTerrenoFinal, this.MetrosTerrenoInicial,
                this.TipoPropiedad.IdTipoPropiedad,
                (int)this.TipoZona,
                this.Ubicacion.Barrio.IdBarrio,
                this.Ubicacion.Localidad.IdLocalidad,
                this.Ubicacion.Pais.IdPais,
                this.Ubicacion.Provincia.IdProvincia,
                this.ValorFinal.Importe,
                this.ValorFinal.Moneda.IdMoneda,
                this.ValorInicial.Importe,
                this.ValorInicial.Moneda.IdMoneda);

            return IdPedido > 0;

        }

        public bool Actualizar()
        {
            GI.DA.PedidosData pd = new GI.DA.PedidosData();
            return pd.Actualizar(
                this.IdPedido,
                this.CantidadAmbientesFinal.CantidadAmbientes,
                this.CantidadAmbientesInicial.CantidadAmbientes,
                this.Categoria.IdCategoria,
                this.ClientePedido.IdCliente,
                (int)this.Disposicion,
                (int)this.EnumEstado,
                this.EsAptoProfesional,
                this.EsDepartamento,
                this.Estado.IdEstadoPropiedad,
                this.EstadoPropiedad,
                this.MetrosConstruiblesFinal,
                this.MetrosConstruiblesInicial,
                this.MetrosCubiertosFinal, this.MetrosCubiertosInicial,
                this.MetrosTerrenoFinal, this.MetrosTerrenoInicial,
                this.TipoPropiedad.IdTipoPropiedad,
                (int)this.TipoZona,
                this.Ubicacion.Barrio.IdBarrio,
                this.Ubicacion.Localidad.IdLocalidad,
                this.Ubicacion.Pais.IdPais,
                this.Ubicacion.Provincia.IdProvincia,
                this.ValorFinal.Importe,
                this.ValorFinal.Moneda.IdMoneda,
                this.ValorInicial.Importe,
                this.ValorInicial.Moneda.IdMoneda);
        }

        #endregion

    }
}
