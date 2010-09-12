using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace GI.Framework.Seguridad
{
    public class MngSeguridadDemo
    {
        private static MngSeguridadDemo instancia;
        private bool versionDemo = false;


        private const int DIASDEMO = 0;
        public static MngSeguridadDemo GetInstancia
        {
            get
            {
                if (instancia == null)
                    instancia = new MngSeguridadDemo();
                return instancia;
            }
        }

        public bool VersionDemo
        {
            get { return versionDemo; }
            set { versionDemo = value; }
        }

        public bool EsDemo
        {
            get
            {
                if (versionDemo)
                    return DiasParaVencimiento == 0;
                else
                    return false;
            }

        }

        public int DiasParaVencimiento
        {
            get
            {
                //if ((DIASDEMO - DiasPasadosDesdePrimeraEjecucion) < 0)
                    return 0;
                //else
                    //return DIASDEMO - DiasPasadosDesdePrimeraEjecucion;
            }
        }

        private int DiasPasadosDesdePrimeraEjecucion
        {
            get
            {
                TimeSpan diff = FechaHoy.Subtract(FechaPrimeraEjecucion);
                return diff.Days;
            }
        }


        private Nullable<DateTime> fechaPrimeraEjecucion;
        /// <summary>
        /// Recupera la fecha de primera ejecucion del registro, o la setea en la primera ejecucion.
        /// </summary>
        private DateTime FechaPrimeraEjecucion
        {            
            get
            {                
                if (!fechaPrimeraEjecucion.HasValue)
                {
                    
                    if (!ExisteClave())
                    {
                        FechaPrimeraEjecucion = FechaHoy;
                    }
                    RegistryKey regKey = Registry.LocalMachine.OpenSubKey("Software\\PIMESOFT\\FirstRun");
                    fechaPrimeraEjecucion = new DateTime(long.Parse(regKey.GetValue("Fecha").ToString()));
                }
                return fechaPrimeraEjecucion.Value;
                
            }
            set 
            {
                //Guarda una clave en el registro con la fecha primera ejecucion.
                RegistryKey regKey = Registry.LocalMachine;
                regKey = regKey.CreateSubKey("Software\\PIMESOFT\\FirstRun");
                regKey.SetValue("Fecha", value.Ticks);
            }
        }

        private bool ExisteClave()
        {
            return Registry.LocalMachine.OpenSubKey("Software\\PIMESOFT\\FirstRun") != null;
        }

        private DateTime FechaHoy
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
