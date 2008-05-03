using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class ValorRenta:ICloneable
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
            this.Monto.Moneda = Monedas.MonedasFlyweigthFactory.GetInstancia.GetMoneda( dr.GetInt32(dr.GetOrdinal("IdMoneda")));
            this.IdValorRenta = dr.GetInt32(dr.GetOrdinal("IdValorRenta"));
        }

        public bool Guardar(Contrato contrato)
        {
            GI.DA.ValoresRentaData vrData = new GI.DA.ValoresRentaData();
            this.idValorRenta = vrData.Guardar(contrato.IdContrato, this.Monto.Importe, this.monto.Moneda.IdMoneda, this.mesVigenciaDesde, this.AnioVigenciaDesde, this.MesVigenciaHasta, this.AnioVigenciaHasta);
            return idValorRenta > 0;
        }

        public bool Actualizar()
        {
            GI.DA.ValoresRentaData vrData = new GI.DA.ValoresRentaData();
            return vrData.Actualizar(idValorRenta, this.Monto.Importe, this.monto.Moneda.IdMoneda, this.mesVigenciaDesde, this.AnioVigenciaDesde, this.MesVigenciaHasta, this.AnioVigenciaHasta);
        }

        public bool Eliminar()
        {
            GI.DA.ValoresRentaData vrData = new GI.DA.ValoresRentaData();
            return vrData.Eliminar(idValorRenta);

        }

        public bool FechaPerteneceARango(DateTime fecha)
        {
            return FechaPerteneceARango(fecha.Month, fecha.Year);
        }

        public bool FechaPerteneceARango(int Mes, int Anio)
        {
            bool esMenorHasta = false;
            bool esMayorDesde = false;

            if (Anio == AnioVigenciaDesde)
            {
                if (Mes >= MesVigenciaDesde)
                    esMayorDesde = true;
            }
            else
                esMayorDesde = (Anio > AnioVigenciaDesde);

            if (Anio == AnioVigenciaHasta)
            {
                if (Mes <= MesVigenciaHasta)
                    esMenorHasta = true;
            }
            else
                esMenorHasta = (Anio < AnioVigenciaHasta);

            return esMenorHasta && esMayorDesde;
        }

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }
}
