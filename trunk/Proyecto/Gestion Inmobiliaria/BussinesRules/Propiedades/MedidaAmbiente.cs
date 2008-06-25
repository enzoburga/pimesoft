using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    [Serializable]
    public class MedidaAmbiente
    {

        public MedidaAmbiente()
        {
            nombreAmbiente = "";
        }

        private int idMedidaAmbiente;


        private decimal ancho;
        private decimal largo;
        private string nombreAmbiente;
        private TipoDePiso tipoDePiso;
        private TipoAmbiente tipoAmbiente;

        public TipoAmbiente TipoAmbiente
        {
            get { return tipoAmbiente; }
            set { tipoAmbiente = value; }
        }

        public decimal Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }

        public int IdMedidaAmbiente
        {
            get { return idMedidaAmbiente; }
            set { idMedidaAmbiente = value; }
        }

        public decimal Largo
        {
            get { return largo; }
            set { largo = value; }
        }
        
        public string NombreAmbiente
        {
            get { return nombreAmbiente; }
            set { nombreAmbiente = value; }
        }
        

        public TipoDePiso TipoDePiso
        {
            get { return tipoDePiso; }
            set { tipoDePiso = value; }
        }


        public bool Eliminar()
        {
            return new DA.PropiedadesData().EliminarMedidaAmbiente(idMedidaAmbiente);
        }


        public bool Crear(Propiedad p)
        {
            int id = new DA.PropiedadesData().GuardarMedidaAmbiente(Ancho, Largo, NombreAmbiente, TipoDePiso.IdTipoPiso, p.IdPropiedad, TipoAmbiente.IdTipoAmbiente);
            idMedidaAmbiente = id;

            return idMedidaAmbiente > 0;
        }


        public override string ToString()
        {
            if (tipoAmbiente.Codigo == 0)
                return nombreAmbiente;
            else
                return tipoAmbiente.Nombre;
        }

    }
}
