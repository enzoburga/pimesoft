using System;
using System.Collections.Generic;
using System.Text;
using GI.BR.Clientes;

namespace GI.BR.Propiedades
{

    public delegate void DelegateCambioTipoPropiedad(GI.BR.Propiedades.TipoPropiedad Tipo);

    public abstract class Propiedad : ICloneable
    {
        public event DelegateCambioTipoPropiedad onCambioTipoPropiedad;

        public Propiedad()
        {

            zonificacion = "";
            fos = "";
            fot = "";
            orientacion = "";
        }

        #region Miembros

        protected int idPropiedad;
        protected decimal cantidadAmbientes;
        protected TipoPropiedad tipoPropiedad;
        protected CategoriaPropiedad categoria;
        protected EstadoPropiedad estado;
        protected Estado enumEstado;
        protected Propietario propietario;
        protected Ubicacion ubicacion;
        protected Direccion direccion;
        protected Valor valorMercado;
        protected Valor valorPublicacion;
        protected string observaciones;
        protected bool esOtraInmobiliaria;
        protected MedidaPropiedad medidasPropiedad;
        protected MedidasTerreno medidasTerreno;
        protected string orientacion;
        protected int cantidadBaños;
        protected int cantidadCocheras;
        protected int cantidadDormitorios;
        protected int cantidadPlantas;
        protected DepartamentoDisposicion disposicion;
        protected bool esAptoProfesional;
        protected int cantidadPisos;
        protected int departamentosPorPiso;
        protected int cantidadAscensores;
        protected int cantidadAscensoresServicio;
        protected TipoZona tipoZona;
        protected string fos;
        protected string fot;
        protected string zonificacion;
        protected int metrosConstruibles;
        protected Galeria.GaleriaFotos galeria;

        protected MedidasAmbiente medidas;
        
        #endregion

        #region Propiedades

        public Galeria.GaleriaFotos GaleriaFotos
        {
            get
            {
                if (galeria == null)
                {
                    galeria = new GI.BR.Propiedades.Galeria.GaleriaFotos();
                    galeria.RecuperarPorPropiedad(this);
                }
                return galeria;
            }
        }

        public CategoriaPropiedad Categoria
        {
            get
            {
                if (categoria == null && TipoPropiedad != null)
                {
                    CategoriasPropiedad categorias = new CategoriasPropiedad();
                    categorias.RecuperarTodas();
                    categoria = categorias.GetByIdCategoria(TipoPropiedad.IdCategoria);

                }
                return categoria; 
            }
            set { categoria = value; }
        }

        public decimal CantidadAmbientes
        {
            get { return cantidadAmbientes; }
            set { cantidadAmbientes = value; }
        }

        public int IdPropiedad
        {
            get { return idPropiedad; }
            set { idPropiedad = value; }
        }


        public string Codigo
        {
            get
            {
                string codigo = (esOtraInmobiliaria) ? "O" : "P";
                codigo += IdPropiedad.ToString("0000000");
                return codigo;
            }
            
        }

        public Ambiente Ambiente
        {
            get 
            {
                GI.BR.Propiedades.Ambiente a = new Ambiente();
                a.CantidadAmbientes = CantidadAmbientes;
                return a;
            }
        }

        public TipoPropiedad TipoPropiedad
        {
            get { return tipoPropiedad; }
            set
            {
                if (onCambioTipoPropiedad != null)
                {
                    if (value != null)
                    {
                        if (tipoPropiedad == null || (value.IdTipoPropiedad != tipoPropiedad.IdTipoPropiedad))
                            onCambioTipoPropiedad(value);
                    }
                }
                tipoPropiedad = value;
            }
        }


        public EstadoPropiedad Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public Estado EnumEstado
        {
            get { return enumEstado; }
            set { enumEstado = value; }
        }


        public Propietario Propietario
        {
            get 
            {
                
                return propietario; 
            }
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


        public Valor ValorMercado
        {
            get { return valorMercado; }
            set { valorMercado = value; }
        }


        public Valor ValorPublicacion
        {
            get { return valorPublicacion; }
            set { valorPublicacion = value; }
        }


        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }


        public bool EsOtraInmobiliaria
        {
            get { return esOtraInmobiliaria; }
            set { esOtraInmobiliaria = value; }
        }


        public MedidasAmbiente Medidas
        {
            get 
            {
                if (medidas == null)
                {
                    medidas = new MedidasAmbiente();
                    medidas.RecuperarPorPropiedad(this);
                }
                return medidas; 
            }
            set { medidas = value; }
        }


        public MedidaPropiedad MedidasPropiedad
        {
            get { return medidasPropiedad; }
            set { medidasPropiedad = value; }
        }


        public MedidasTerreno MedidasTerreno
        {
            get { return medidasTerreno; }
            set { medidasTerreno = value; }
        }


        public string Orientacion
        {
            get { return orientacion; }
            set { orientacion = value; }
        }


        public int CantidadBaños
        {
            get { return cantidadBaños; }
            set { cantidadBaños = value; }
        }


        public int CantidadCocheras
        {
            get { return cantidadCocheras; }
            set { cantidadCocheras = value; }
        }


        public int CantidadDormitorios
        {
            get { return cantidadDormitorios; }
            set { cantidadDormitorios = value; }
        }


        public int CantidadPlantas
        {
            get { return cantidadPlantas; }
            set { cantidadPlantas = value; }
        }



        public DepartamentoDisposicion Disposicion
        {
            get { return disposicion; }
            set { disposicion = value; }
        }


        public bool EsAptoProfesional
        {
            get { return esAptoProfesional; }
            set { esAptoProfesional = value; }
        }


        public int CantidadPisos
        {
            get { return cantidadPisos; }
            set { cantidadPisos = value; }
        }


        public int DepartamentosPorPiso
        {
            get { return departamentosPorPiso; }
            set { departamentosPorPiso = value; }
        }


        public int CantidadAscensores
        {
            get { return cantidadAscensores; }
            set { cantidadAscensores = value; }
        }


        public int CantidadAscensoresServicio
        {
            get { return cantidadAscensoresServicio; }
            set { cantidadAscensoresServicio = value; }
        }



        public TipoZona TipoZona
        {
            get { return tipoZona; }
            set { tipoZona = value; }
        }


        public string Fos
        {
            get { return fos; }
            set { fos = value; }
        }


        public string Fot
        {
            get { return fot; }
            set { fot = value; }
        }


        public string Zonificacion
        {
            get { return zonificacion; }
            set { zonificacion = value; }
        }


        public int MetrosConstruibles
        {
            get { return metrosConstruibles; }
            set { metrosConstruibles = value; }
        }



        
        #endregion

        #region Metodos

        public virtual bool Guardar() 
        {

            int id = new DA.PropiedadesData().InsertarPropiedades(
                CantidadAmbientes, TipoPropiedad.IdTipoPropiedad, Estado.IdEstadoPropiedad, (int)EnumEstado, (Propietario == null) ? 0 : Propietario.IdCliente, Ubicacion.Pais.IdPais, Ubicacion.Provincia.IdProvincia,
                Ubicacion.Localidad.IdLocalidad, Ubicacion.Barrio.IdBarrio, Direccion.Calle, Direccion.Numero, Direccion.Depto, Direccion.Piso, Direccion.CodigoPostal, Direccion.CalleEntre1, Direccion.CalleEntre2,
                ValorMercado.Importe, ValorMercado.Moneda.IdMoneda, ValorPublicacion.Importe, ValorPublicacion.Moneda.IdMoneda, EsOtraInmobiliaria,
                MedidasPropiedad.MetrosCubiertos, MedidasPropiedad.MetrosSemicubiertos, MedidasPropiedad.MetrosLibres, MedidasTerreno.Metros, MedidasTerreno.Fondo, MedidasTerreno.Frente,
                Orientacion, CantidadBaños, CantidadCocheras, CantidadDormitorios, CantidadPlantas, (int)Disposicion, EsAptoProfesional, CantidadPisos, DepartamentosPorPiso, CantidadAscensores, CantidadAscensoresServicio, (int)TipoZona,
                Fos, Fot, Zonificacion, MetrosConstruibles);

            IdPropiedad = id;

            if (IdPropiedad > 0)
            {
                foreach (MedidaAmbiente ambiente in this.Medidas)
                {
                    ambiente.Crear(this);
                }
            }

            return IdPropiedad > 0;
            return false;
        }


        public virtual bool Actualizar()
        {
            bool retVal = new DA.PropiedadesData().ActualizarPropiedad(IdPropiedad, CantidadAmbientes, TipoPropiedad.IdTipoPropiedad, Estado.IdEstadoPropiedad, (int)EnumEstado, (Propietario == null) ? 0 : Propietario.IdCliente, Ubicacion.Pais.IdPais, Ubicacion.Provincia.IdProvincia,
                Ubicacion.Localidad.IdLocalidad, Ubicacion.Barrio.IdBarrio, Direccion.Calle, Direccion.Numero, Direccion.Depto, Direccion.Piso, Direccion.CodigoPostal, Direccion.CalleEntre1, Direccion.CalleEntre2,
                ValorMercado.Importe, ValorMercado.Moneda.IdMoneda, ValorPublicacion.Importe, ValorPublicacion.Moneda.IdMoneda, EsOtraInmobiliaria,
                MedidasPropiedad.MetrosCubiertos, MedidasPropiedad.MetrosSemicubiertos, MedidasPropiedad.MetrosLibres, MedidasTerreno.Metros, MedidasTerreno.Fondo, MedidasTerreno.Frente,
                Orientacion, CantidadBaños, CantidadCocheras, CantidadDormitorios, CantidadPlantas, (int)Disposicion, EsAptoProfesional, CantidadPisos, DepartamentosPorPiso, CantidadAscensores, CantidadAscensoresServicio, (int)TipoZona,
                Fos, Fot, Zonificacion, MetrosConstruibles);

            foreach (MedidaAmbiente ambiente in this.Medidas)
            {
                if (ambiente.IdMedidaAmbiente == 0)
                    ambiente.Crear(this);
            }

            return retVal;
        }

        public virtual bool Eliminar()
        {
            throw new Exception("Metodo No Implementado");
        }


        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return base.MemberwiseClone();
        }

        #endregion
    }
}
