using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
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
            int id = new DA.PropiedadesData().GuardarMedidaAmbiente(Ancho, Largo, NombreAmbiente, TipoDePiso.IdTipoPiso, p.IdPropiedad);
            idMedidaAmbiente = id;

            return idMedidaAmbiente > 0;
        }

    }
}
