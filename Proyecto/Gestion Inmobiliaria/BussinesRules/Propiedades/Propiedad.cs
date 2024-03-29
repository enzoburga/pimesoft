using System;
using System.Collections.Generic;
using System.Text;
using GI.BR.Clientes;

namespace GI.BR.Propiedades
{

    public delegate void DelegateCambioTipoPropiedad(GI.BR.Propiedades.TipoPropiedad Tipo);
    public delegate void DelegateCambioValorPropiedad(GI.BR.Propiedades.Propiedad Propiedad);

    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(Venta))]
    [System.Xml.Serialization.XmlInclude(typeof(Alquiler))]
    public abstract class Propiedad : ICloneable
    {
        public event DelegateCambioTipoPropiedad onCambioTipoPropiedad;
        public event DelegateCambioValorPropiedad onCambioValorPropiedad;


        public Propiedad()
        {

            zonificacion = "";
            fos = "";
            fot = "";
            orientacion = "";
            observaciones = "";
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
        protected int cantidadBa�os;
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
        protected int antiguedad;
        protected InmobiliariaExterna inmobiliaria;
        protected decimal valorExpensas;
        protected bool jardin;
        protected bool patio;
        protected bool piscina;
        protected bool lavadero;
        protected bool dependencia;
        protected bool quincho;
        protected bool parrilla;
        protected bool balcon;
        protected bool terraza;
        protected bool playroom;
        protected bool baulera;
        protected bool cuartoHerraminetas;
        protected MedidasAmbiente medidas;
        protected bool publicarSinPrecio;



        protected bool cargado = false;
        
        #endregion

        #region Propiedades

        public bool PublicarSinPrecio
        {
            get { if (!cargado) Cargar(); return publicarSinPrecio; }
            set { publicarSinPrecio = value; }
        }

        public bool Jardin
        {
            get { if (!cargado) Cargar(); 
                return jardin; }
            set { jardin = value; }
        }


        public bool Patio
        {
            get { if (!cargado) Cargar(); 
                return patio; }
            set { patio = value; }
        }


        public bool Piscina
        {
            get { if (!cargado) Cargar(); 
                return piscina; }
            set { piscina = value; }
        }



        public bool Lavadero
        {
            get { if (!cargado) Cargar(); 
                return lavadero; }
            set { lavadero = value; }
        }

        public bool Dependencia
        {
            get { if (!cargado) Cargar(); 
                return dependencia; }
            set { dependencia = value; }
        }


        public bool Quincho
        {
            get { if (!cargado) Cargar(); 
                return quincho; }
            set { quincho = value; }
        }


        public bool Parrilla
        {
            get { if (!cargado) Cargar(); 
                return parrilla; }
            set { parrilla = value; }
        }


        public bool Balcon
        {
            get { if (!cargado) Cargar(); 
                return balcon; }
            set { balcon = value; }
        }


        public bool Terraza
        {
            get { if (!cargado) Cargar();
                return terraza; }
            set { terraza = value; }
        }

        public bool Playroom
        {
            get
            {
                if (!cargado) Cargar(); 
                return playroom; }
            set { playroom = value; }
        }

        public bool Baulera
        {
            get
            {
                if (!cargado) Cargar(); 
                return baulera; }
            set { baulera = value; }
        }


        public bool CuartoHerraminetas
        {
            get { if (!cargado) Cargar(); 
                return cuartoHerraminetas; }
            set { cuartoHerraminetas = value; }
        }



        public decimal ValorExpensas
        {
            get 
            {
                if (!cargado) Cargar();
                return valorExpensas; 
            }
            set { valorExpensas = value; }
        }

        public int Antiguedad
        {
            get { return antiguedad; }
            set { antiguedad = value; }
        }

        [System.Xml.Serialization.XmlIgnore]
        public InmobiliariaExterna Inmobiliaria
        {
            get 
            {
                if (!cargado) Cargar();
                return inmobiliaria;
            }
            set { inmobiliaria = value; }
        }

        [System.Xml.Serialization.XmlIgnore]
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
            get
            {
                if (!cargado)
                    Cargar();
                return cantidadAmbientes;
            }
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
            get
            {
                if (!cargado)
                    Cargar();
                return tipoPropiedad;
            }
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


        public virtual EstadoPropiedad Estado
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return estado;
            }
            set { estado = value; }
        }


        public Estado EnumEstado
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return enumEstado;
            }
            set { enumEstado = value; }
        }

        [System.Xml.Serialization.XmlIgnore]
        public Propietario Propietario
        {
            get 
            {
                if (!cargado)
                    Cargar();
                return propietario; 
            }
            set { propietario = value; }
        }


        public Ubicacion Ubicacion
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return ubicacion;
            }
            set { ubicacion = value; }
        }


        public Direccion Direccion
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return direccion;
            }
            set { direccion = value; }
        }


        public Valor ValorMercado
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return valorMercado;
            }
            set
            {
                if (onCambioValorPropiedad != null)
                    onCambioValorPropiedad(this);

                valorMercado = value; 
            }
        }


        public Valor ValorPublicacion
        {
            get
            {
                if (!cargado)
                    Cargar();
 

                return valorPublicacion;
            }
            set 
            {
                if (onCambioValorPropiedad != null)
                    onCambioValorPropiedad(this);

                valorPublicacion = value; 
            }
        }


        public string Observaciones
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return observaciones;
            }
            set { observaciones = value; }
        }


        public bool EsOtraInmobiliaria
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return esOtraInmobiliaria;
            }
            set { esOtraInmobiliaria = value; }
        }


        public MedidasAmbiente Medidas
        {
            get 
            {
                if (!cargado)
                    Cargar();
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
            get
            {
                if (!cargado)
                    Cargar(); 
                return medidasPropiedad;
            }
            set { medidasPropiedad = value; }
        }


        public MedidasTerreno MedidasTerreno
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return medidasTerreno;
            }
            set { medidasTerreno = value; }
        }


        public string Orientacion
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return orientacion;
            }
            set { orientacion = value; }
        }


        public int CantidadBa�os
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return cantidadBa�os;
            }
            set { cantidadBa�os = value; }
        }


        public int CantidadCocheras
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return cantidadCocheras;
            }
            set { cantidadCocheras = value; }
        }


        public int CantidadDormitorios
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return cantidadDormitorios;
            }
            set { cantidadDormitorios = value; }
        }


        public int CantidadPlantas
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return cantidadPlantas;
            }
            set { cantidadPlantas = value; }
        }



        public DepartamentoDisposicion Disposicion
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return disposicion;
            }
            set { disposicion = value; }
        }


        public bool EsAptoProfesional
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return esAptoProfesional;
            }
            set { esAptoProfesional = value; }
        }


        public int CantidadPisos
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return cantidadPisos;
            }
            set { cantidadPisos = value; }
        }


        public int DepartamentosPorPiso
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return departamentosPorPiso;
            }
            set { departamentosPorPiso = value; }
        }


        public int CantidadAscensores
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return cantidadAscensores;
            }
            set { cantidadAscensores = value; }
        }


        public int CantidadAscensoresServicio
        {
            get
            {
                if (!cargado)
                    Cargar();
                return cantidadAscensoresServicio;
            }
            set { cantidadAscensoresServicio = value; }
        }



        public TipoZona TipoZona
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return tipoZona;
            }
            set { tipoZona = value; }
        }


        public string Fos
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return fos;
            }
            set { fos = value; }
        }


        public string Fot
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return fot;
            }
            set { fot = value; }
        }


        public string Zonificacion
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return zonificacion;
            }
            set { zonificacion = value; }
        }


        public int MetrosConstruibles
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return metrosConstruibles;
            }
            set { metrosConstruibles = value; }
        }



        
        #endregion

        #region Metodos


        public void Copiar(Propiedad Propiedad)
        {
            //Propiedad = (GI.BR.Propiedades.Propiedad)this.MemberwiseClone();
            Propiedad.CantidadAmbientes = this.CantidadAmbientes;
            Propiedad.CantidadAscensores = this.CantidadAscensores;
            Propiedad.CantidadAscensoresServicio = this.CantidadAscensoresServicio;
            Propiedad.CantidadBa�os = this.CantidadBa�os;
            Propiedad.CantidadCocheras = this.CantidadCocheras;
            Propiedad.CantidadDormitorios = this.CantidadDormitorios;
            Propiedad.CantidadPisos = this.CantidadPisos;
            Propiedad.CantidadPlantas = this.CantidadPlantas;
            Propiedad.Categoria = this.Categoria;
            Propiedad.DepartamentosPorPiso = this.DepartamentosPorPiso;
            Propiedad.Direccion = this.Direccion;
            Propiedad.Disposicion = this.Disposicion;
            Propiedad.EnumEstado = this.EnumEstado;
            Propiedad.EsAptoProfesional = this.EsAptoProfesional;
            Propiedad.EsOtraInmobiliaria = this.EsOtraInmobiliaria;
            Propiedad.Fos = this.Fos;
            Propiedad.Fot = this.Fot;
            Propiedad.Medidas = this.Medidas;
            Propiedad.MedidasPropiedad = this.MedidasPropiedad;
            Propiedad.MedidasTerreno = this.MedidasTerreno;
            Propiedad.MetrosConstruibles = this.MetrosConstruibles;
            Propiedad.Observaciones = this.Observaciones;
            Propiedad.Orientacion = this.Orientacion;
            Propiedad.Propietario = this.Propietario;
            Propiedad.TipoPropiedad = this.TipoPropiedad;
            Propiedad.TipoZona = this.TipoZona;
            Propiedad.Ubicacion = this.Ubicacion;
            Propiedad.ValorMercado = this.ValorMercado;
            Propiedad.ValorPublicacion = this.ValorPublicacion;
            Propiedad.Zonificacion = this.Zonificacion;
            Propiedad.Inmobiliaria = this.Inmobiliaria;
            Propiedad.ValorExpensas = this.ValorExpensas;
            Propiedad.Piscina = this.Piscina;
            Propiedad.Patio = this.Patio;
            Propiedad.Jardin = this.Jardin;
            Propiedad.Lavadero = this.Lavadero;
            Propiedad.Dependencia = this.Dependencia;
            Propiedad.Quincho = this.Quincho;
            Propiedad.Parrilla = this.Parrilla;
            Propiedad.Balcon = this.Balcon;
            Propiedad.Terraza = this.Terraza;
            Propiedad.Playroom = this.Playroom;
            Propiedad.Baulera = this.Baulera;
            Propiedad.CuartoHerraminetas = this.CuartoHerraminetas;

            EstadosPropiedad estados = new EstadosPropiedad();
            estados.RecuperarEstados(Propiedad.GetType());
            Propiedad.Estado = estados[0];



        }

        private void Cargar()
        {
            GI.DA.PropiedadesData data = new GI.DA.PropiedadesData();
            using (System.Data.IDataReader dr = data.RecuperarPropiedadPorId(this.idPropiedad))
            {
                if (dr.Read())
                    CargarPropiedad(dr);
            }
            this.cargado = true;
        }

        public abstract void RecuperarPorId(int IdPropiedad);

        protected void CargarPropiedad(System.Data.IDataReader dr)
        {

            this.cargado = true;

            this.IdPropiedad = dr.GetInt32(dr.GetOrdinal("IdPropiedad"));
            this.CantidadAmbientes = dr.GetDecimal(dr.GetOrdinal("CantidadAmbientes"));
            this.TipoPropiedad = TiposPropiedadFlyweightFactory.GetInstancia.GetTipoPropiedad(dr.GetInt32(dr.GetOrdinal("IdTipoPropiedad")));
            this.estado = new EstadoPropiedad();
            this.estado.IdEstadoPropiedad = dr.GetInt32(dr.GetOrdinal("IdEstadoPropiedad"));
            this.EnumEstado = (Estado)dr.GetInt32(dr.GetOrdinal("EnumEstadoProp"));

            if (!dr.IsDBNull(dr.GetOrdinal("IdPropietario")))
            {
                this.Propietario = new Propietario();
                this.Propietario.IdCliente = dr.GetInt32(dr.GetOrdinal("IdPropietario"));
            }

            this.Direccion = new Direccion();
            this.Direccion.Calle = dr.GetString(dr.GetOrdinal("Calle"));
            this.Direccion.Numero = dr.GetInt32(dr.GetOrdinal("NumeroPostal"));
            this.Direccion.Depto = dr.GetString(dr.GetOrdinal("Depto"));
            this.Direccion.Piso = dr.GetString(dr.GetOrdinal("Piso"));
            this.Direccion.CodigoPostal = dr.GetString(dr.GetOrdinal("CodigoPostal"));
            this.Direccion.CalleEntre1 = dr.GetString(dr.GetOrdinal("CalleEntre1"));
            this.Direccion.CalleEntre2 = dr.GetString(dr.GetOrdinal("CalleEntre2"));

            this.ValorMercado = new Valor();
            this.ValorMercado.Importe = dr.GetDecimal(dr.GetOrdinal("ValorMercadoImporte"));
            this.ValorMercado.Moneda = Monedas.MonedasFlyweigthFactory.GetInstancia.GetMoneda(dr.GetInt32(dr.GetOrdinal("ValorMercadoMoneda")));

            this.ValorPublicacion = new Valor();
            this.ValorPublicacion.Importe = dr.GetDecimal(dr.GetOrdinal("ValorPublicacionImporte"));
            this.ValorPublicacion.Moneda = Monedas.MonedasFlyweigthFactory.GetInstancia.GetMoneda(dr.GetInt32(dr.GetOrdinal("ValorPublicacionMoneda")));

            this.Observaciones = dr.IsDBNull(dr.GetOrdinal("Observaciones")) ? "" : dr.GetString(dr.GetOrdinal("Observaciones"));
            this.EsOtraInmobiliaria = dr.IsDBNull(dr.GetOrdinal("EsOtraInmobiliaria")) ? false : dr.GetBoolean(dr.GetOrdinal("EsOtraInmobiliaria"));

            this.MedidasPropiedad = new MedidaPropiedad();
            this.MedidasPropiedad.MetrosCubiertos = dr.GetDecimal(dr.GetOrdinal("MetrosCubiertos"));
            this.MedidasPropiedad.MetrosLibres = dr.GetDecimal(dr.GetOrdinal("MetrosLibres"));
            this.MedidasPropiedad.MetrosSemicubiertos = dr.GetDecimal(dr.GetOrdinal("MetrosSemicubiertos"));

            this.MedidasTerreno = new MedidasTerreno();
            this.MedidasTerreno.Fondo = dr.GetDecimal(dr.GetOrdinal("TerrenoFondo"));
            this.MedidasTerreno.Frente = dr.GetDecimal(dr.GetOrdinal("TerrenosFrente"));
            this.MedidasTerreno.Metros = dr.GetDecimal(dr.GetOrdinal("TerrenoMetros"));
            this.Orientacion = dr.GetString(dr.GetOrdinal("Orientacion"));
            this.CantidadBa�os = dr.GetInt32(dr.GetOrdinal("CantidadBanos"));
            this.CantidadCocheras = dr.GetInt32(dr.GetOrdinal("CantidadCocheras"));
            this.CantidadDormitorios = dr.GetInt32(dr.GetOrdinal("CantidadDomritorios"));
            this.CantidadPlantas = dr.GetInt32(dr.GetOrdinal("CantidadPlantas"));

            this.Disposicion = dr.IsDBNull(dr.GetOrdinal("IdDepartamentoDisposicion")) ? DepartamentoDisposicion.SinDefinir : (DepartamentoDisposicion)dr.GetInt32(dr.GetOrdinal("IdDepartamentoDisposicion"));
            this.EsAptoProfesional = dr.IsDBNull(dr.GetOrdinal("EsAptoProfesional")) ? false : dr.GetBoolean(dr.GetOrdinal("EsAptoProfesional"));
            this.CantidadPisos = dr.IsDBNull(dr.GetOrdinal("DeptoCantidadPisos")) ? 0 : dr.GetInt32(dr.GetOrdinal("DeptoCantidadPisos"));
            this.DepartamentosPorPiso = dr.IsDBNull(dr.GetOrdinal("DeptoDepartamentosPorPiso")) ? 0 : dr.GetInt32(dr.GetOrdinal("DeptoDepartamentosPorPiso"));
            this.CantidadAscensores = dr.IsDBNull(dr.GetOrdinal("CantidadAscensores")) ? 0 : dr.GetInt32(dr.GetOrdinal("CantidadAscensores"));
            this.CantidadAscensoresServicio = dr.IsDBNull(dr.GetOrdinal("CantidadAscensoresServicio")) ? 0 : dr.GetInt32(dr.GetOrdinal("CantidadAscensoresServicio"));


            this.TipoZona = dr.IsDBNull(dr.GetOrdinal("IdTipoZona")) ? TipoZona.SinDefinir : (TipoZona)dr.GetInt32(dr.GetOrdinal("IdTipoZona"));
            this.Fos = dr.IsDBNull(dr.GetOrdinal("Fos")) ? "" : dr.GetString(dr.GetOrdinal("Fos"));
            this.Fot = dr.IsDBNull(dr.GetOrdinal("Fot")) ? "" : dr.GetString(dr.GetOrdinal("Fot"));
            this.Zonificacion = dr.IsDBNull(dr.GetOrdinal("Zonificacion")) ? "" : dr.GetString(dr.GetOrdinal("Zonificacion"));
            this.MetrosConstruibles = dr.IsDBNull(dr.GetOrdinal("MetrosContruibles")) ? 0 : dr.GetInt32(dr.GetOrdinal("MetrosContruibles"));

            this.Ubicacion = new Ubicacion();
            this.Ubicacion.Barrio = Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetBarrio(dr.GetInt32(dr.GetOrdinal("IdBarrio")));
            this.Ubicacion.Localidad = Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetLocalidad(dr.GetInt32(dr.GetOrdinal("IdLocalidad")));
            this.Ubicacion.Pais = Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetPais(dr.GetInt32(dr.GetOrdinal("IdPais")));
            this.Ubicacion.Provincia = Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetProvincia(dr.GetInt32(dr.GetOrdinal("IdProvincia")));

            this.Antiguedad = dr.IsDBNull(dr.GetOrdinal("Antiguedad")) ? 0 : dr.GetInt32(dr.GetOrdinal("Antiguedad"));

            if (!dr.IsDBNull(dr.GetOrdinal("IdInmobiliaria")))
            {
                this.Inmobiliaria = new InmobiliariaExterna();
                this.Inmobiliaria.IdInmobiliaria = dr.GetInt32(dr.GetOrdinal("IdInmobiliaria"));
                this.Inmobiliaria.Nombre = dr.GetString(dr.GetOrdinal("NombreInmobiliaria"));
                this.Inmobiliaria.PersonaResponsable = dr.GetString(dr.GetOrdinal("ContactoInmobiliaria"));
                this.Inmobiliaria.Telefono = dr.GetString(dr.GetOrdinal("TelefonoInmobiliaria"));
            }

            this.ValorExpensas = dr.IsDBNull(dr.GetOrdinal("ValorExpensas")) ? 0 : dr.GetDecimal(dr.GetOrdinal("ValorExpensas"));

            this.Jardin = dr.IsDBNull(dr.GetOrdinal("Jardin")) ? false : dr.GetBoolean(dr.GetOrdinal("Jardin"));
            this.Patio = dr.IsDBNull(dr.GetOrdinal("Patio")) ? false : dr.GetBoolean(dr.GetOrdinal("Patio"));
            this.Piscina = dr.IsDBNull(dr.GetOrdinal("Piscina")) ? false : dr.GetBoolean(dr.GetOrdinal("Piscina"));
            this.Lavadero = dr.IsDBNull(dr.GetOrdinal("Lavadero")) ? false : dr.GetBoolean(dr.GetOrdinal("Lavadero"));
            this.Dependencia = dr.IsDBNull(dr.GetOrdinal("Dependencia")) ? false : dr.GetBoolean(dr.GetOrdinal("Dependencia"));
            this.Quincho = dr.IsDBNull(dr.GetOrdinal("Quincho")) ? false : dr.GetBoolean(dr.GetOrdinal("Quincho"));
            this.Parrilla = dr.IsDBNull(dr.GetOrdinal("Parrilla")) ? false : dr.GetBoolean(dr.GetOrdinal("Parrilla"));
            this.Balcon = dr.IsDBNull(dr.GetOrdinal("Balcon")) ? false : dr.GetBoolean(dr.GetOrdinal("Balcon"));
            this.Terraza = dr.IsDBNull(dr.GetOrdinal("Terraza")) ? false : dr.GetBoolean(dr.GetOrdinal("Terraza"));
            this.Playroom = dr.IsDBNull(dr.GetOrdinal("Playroom")) ? false : dr.GetBoolean(dr.GetOrdinal("Playroom"));
            this.Baulera = dr.IsDBNull(dr.GetOrdinal("Baulera")) ? false : dr.GetBoolean(dr.GetOrdinal("Baulera"));
            this.CuartoHerraminetas = dr.IsDBNull(dr.GetOrdinal("CuartoHerramientas")) ? false : dr.GetBoolean(dr.GetOrdinal("CuartoHerramientas"));
            this.PublicarSinPrecio = dr.IsDBNull(dr.GetOrdinal("PublicarSinPrecio")) ? false : dr.GetBoolean(dr.GetOrdinal("PublicarSinPrecio"));


        }

        public virtual bool Guardar() 
        {

            bool retVal = new DA.PropiedadesData().InsertarPropiedades(
                IdPropiedad, Observaciones, CantidadAmbientes, TipoPropiedad.IdTipoPropiedad, Estado.IdEstadoPropiedad, (int)EnumEstado, (Propietario == null) ? 0 : Propietario.IdCliente, Ubicacion.Pais.IdPais, Ubicacion.Provincia.IdProvincia,
                Ubicacion.Localidad.IdLocalidad, Ubicacion.Barrio.IdBarrio, Direccion.Calle, Direccion.Numero, Direccion.Depto, Direccion.Piso, Direccion.CodigoPostal, Direccion.CalleEntre1, Direccion.CalleEntre2,
                ValorMercado.Importe, ValorMercado.Moneda.IdMoneda, ValorPublicacion.Importe, ValorPublicacion.Moneda.IdMoneda, EsOtraInmobiliaria,
                MedidasPropiedad.MetrosCubiertos, MedidasPropiedad.MetrosSemicubiertos, MedidasPropiedad.MetrosLibres, MedidasTerreno.Metros, MedidasTerreno.Fondo, MedidasTerreno.Frente,
                Orientacion, CantidadBa�os, CantidadCocheras, CantidadDormitorios, CantidadPlantas, (int)Disposicion, EsAptoProfesional, CantidadPisos, DepartamentosPorPiso, CantidadAscensores, CantidadAscensoresServicio, (int)TipoZona,
                Fos, Fot, Zonificacion, MetrosConstruibles, Antiguedad, ((Inmobiliaria == null) ? 0 : Inmobiliaria.IdInmobiliaria), valorExpensas,
                Jardin, Patio, Piscina, Lavadero, Dependencia, Quincho, Parrilla, Balcon, Terraza, Playroom, Baulera, CuartoHerraminetas, PublicarSinPrecio);



            if (retVal)
            {
                foreach (MedidaAmbiente ambiente in this.Medidas)
                {
                    ambiente.Crear(this);
                }
            }

            
            return retVal;
        }


        public virtual bool Actualizar()
        {
            bool retVal = new DA.PropiedadesData().ActualizarPropiedad(Observaciones, IdPropiedad, CantidadAmbientes, TipoPropiedad.IdTipoPropiedad, Estado.IdEstadoPropiedad, (int)EnumEstado, (Propietario == null) ? 0 : Propietario.IdCliente, Ubicacion.Pais.IdPais, Ubicacion.Provincia.IdProvincia,
                Ubicacion.Localidad.IdLocalidad, Ubicacion.Barrio.IdBarrio, Direccion.Calle, Direccion.Numero, Direccion.Depto, Direccion.Piso, Direccion.CodigoPostal, Direccion.CalleEntre1, Direccion.CalleEntre2,
                ValorMercado.Importe, ValorMercado.Moneda.IdMoneda, ValorPublicacion.Importe, ValorPublicacion.Moneda.IdMoneda, EsOtraInmobiliaria,
                MedidasPropiedad.MetrosCubiertos, MedidasPropiedad.MetrosSemicubiertos, MedidasPropiedad.MetrosLibres, MedidasTerreno.Metros, MedidasTerreno.Fondo, MedidasTerreno.Frente,
                Orientacion, CantidadBa�os, CantidadCocheras, CantidadDormitorios, CantidadPlantas, (int)Disposicion, EsAptoProfesional, CantidadPisos, DepartamentosPorPiso, CantidadAscensores, CantidadAscensoresServicio, (int)TipoZona,
                Fos, Fot, Zonificacion, MetrosConstruibles, Antiguedad, ((Inmobiliaria == null) ? 0 : Inmobiliaria.IdInmobiliaria), valorExpensas,
                Jardin, Patio, Piscina, Lavadero, Dependencia, Quincho, Parrilla, Balcon, Terraza, Playroom, Baulera, CuartoHerraminetas, PublicarSinPrecio);

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


        public static int RecuperarProxIdPropiedad()
        {
            return new DA.PropiedadesData().RecuperarProxIdPropiedad();
        }

        public bool MarcarPropiedadComoOfrecida(GI.BR.Pedidos.Pedidos pedidos)
        {
            bool error = false;
            GI.DA.PedidosData pd = new GI.DA.PedidosData();
            foreach (GI.BR.Pedidos.Pedido p in pedidos)
            {

                if (!pd.MarcarPropiedadOfrecida(this.idPropiedad, p.IdPedido))
                    error = true;
            }

            return error;
        }

        public virtual void EliminarAmbientes()
        {
            new DA.PropiedadesData().EliminarAmbientes(this.IdPropiedad);
        }
    }
}
