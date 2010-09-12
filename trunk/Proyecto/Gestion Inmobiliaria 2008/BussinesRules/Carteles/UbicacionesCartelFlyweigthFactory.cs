using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Carteles
{
    public class UbicacionesCartelFlyweigthFactory
    {
        private System.Collections.Hashtable hashUbicacionesCartel;
        UbicacionesCartel ubicacionesCartel;
        private UbicacionesCartelFlyweigthFactory()
        {
            ubicacionesCartel = new UbicacionesCartel();
            hashUbicacionesCartel = new System.Collections.Hashtable();
            ubicacionesCartel.RecuperarUbicaciones();
            foreach (UbicacionCartel uc in ubicacionesCartel)
                hashUbicacionesCartel.Add(uc.IdUbicacionCartel, uc);
        }


        public UbicacionCartel GetUbicacionCartel(int IdUbicacionCartel)
        {
            return (UbicacionCartel)hashUbicacionesCartel[IdUbicacionCartel];
        }

        public UbicacionesCartel GetUbicacionesCartel
        {
            get
            {
                return ubicacionesCartel;
            }
        }

        private static UbicacionesCartelFlyweigthFactory instancia;
        public static UbicacionesCartelFlyweigthFactory GetInstancia
        {
            get
            {
                if (instancia == null)
                    instancia = new UbicacionesCartelFlyweigthFactory();
                return instancia;
            }
        }

    }
}
