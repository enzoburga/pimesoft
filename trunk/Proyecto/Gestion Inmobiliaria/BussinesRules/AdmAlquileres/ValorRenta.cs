using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class ValorRenta
    {
        private int idValorRenta;
        private Valor monto;
        private int mesVigenciaDesde;
        private int anioVigenciaDesde;
        private int mesVigenciaHasta;
        private int anioVigenciaHasta;



        public int IdValorRenta
        {
            get { return idValorRenta; }
            set { idValorRenta = value; }
        }

        public Valor Monto
        {
            get { return monto; }
            set { monto = value; }
        }        

        public int MesVigenciaDesde
        {
            get { return mesVigenciaDesde; }
            set { mesVigenciaDesde = value; }
        }        

        public int AnioVigenciaDesde
        {
            get { return anioVigenciaDesde; }
            set { anioVigenciaDesde = value; }
        }        

        public int MesVigenciaHasta
        {
            get { return mesVigenciaHasta; }
            set { mesVigenciaHasta = value; }
        }        

        public int AnioVigenciaHasta
        {
            get { return anioVigenciaHasta; }
            set { anioVigenciaHasta = value; }
        }

        internal void fill(System.Data.IDataReader dr)
        {
            this.AnioVigenciaDesde = dr.GetInt32(dr.GetOrdinal("AnioDesde"));
            this.AnioVigenciaHasta = dr.GetInt32(dr.GetOrdinal("AnioHasta"));
            this.MesVigenciaDesde = dr.GetInt32(dr.GetOrdinal("MesDesde"));
            this.MesVigenciaHasta = dr.GetInt32(dr.GetOrdinal("MesHasta"));
            this.Monto = new Valor();
            this.Monto.Importe = dr.GetDecimal(dr.GetOrdinal("Importe"));
            this.Monto.Moneda = new GI.BR.Monedas.Moneda();
            this.Monto.Moneda.IdMoneda = dr.GetInt32(dr.GetOrdinal("IdMoneda"));
            this.IdValorRenta = dr.GetInt32(dr.GetOrdinal("IdValorRenta"));
        }

        public bool Guardar()
        {
            return true;
        }

        public bool Actualizar()
        {
            return true;
        }

        public bool Eliminar()
        {
            return true;
        }
    }
}
