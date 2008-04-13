using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public abstract class Propiedad
    {

        public Propiedad()
        { }

        #region Miembros

        protected int idPropiedad;
        protected string codigo;
        protected TipoPropiedad tipoPropiedad;
        protected EstadoPropiedad estado;
        protected Propietario propietario;
        protected Ubicacion ubicacion;
        protected Direccion direccion;
        protected Monedas.Moneda moneda;
        protected double valorMercado;
        protected double valorPublicacion;
        protected string observaciones;
        protected bool esOtraInmobiliaria;








        
        #endregion

        #region Propiedades
        public bool EsOtraInmobiliaria
        {
            get { return esOtraInmobiliaria; }
            set { esOtraInmobiliaria = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        public int IdPropiedad
        {
            get { return idPropiedad; }
            set { idPropiedad = value; }
        }


        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        public TipoPropiedad TipoPropiedad
        {
            get { return tipoPropiedad; }
            set { tipoPropiedad = value; }
        }


        public EstadoPropiedad Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public Propietario Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }


        public Ubicacion Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }


        public Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public Monedas.Moneda Moneda
        {
            get { return moneda; }
            set { moneda = value; }
        }


        public double ValorMercado
        {
            get { return valorMercado; }
            set { valorMercado = value; }
        }


        public double ValorPublicacion
        {
            get { return valorPublicacion; }
            set { valorPublicacion = value; }
        }

        #endregion

        #region Metodos

        public virtual bool Guardar()
        {
            throw new Exception("Metodo No Implementado");
        }

        public virtual bool Actualizar()
        {
            throw new Exception("Metodo No Implementado");
        }

        public virtual bool Eliminar()
        {
            throw new Exception("Metodo No Implementado");
        }


        #endregion
    }
}
