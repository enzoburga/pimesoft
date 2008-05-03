using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GI.BR.Propiedades.Ubicaciones
{
    public class UbicacionFlyweightFactory
    {
        private GI.BR.Propiedades.Ubicaciones.Paises hashPaises;
        private GI.BR.Propiedades.Ubicaciones.Provincias hashProvincias;
        private GI.BR.Propiedades.Ubicaciones.Localidades hashLocalidades;
        private GI.BR.Propiedades.Ubicaciones.Barrios hashBarrios;

        private UbicacionFlyweightFactory()
        {
            hashBarrios = new Barrios();
            hashLocalidades = new Localidades();
            hashPaises = new Paises();
            hashProvincias = new Provincias();

            hashBarrios.RecuperarTodos();
            hashLocalidades.RecuperarTodas();
            hashPaises.RecuperarTodos();
            hashProvincias.RecuperarTodas();
        
        
        }

        private static UbicacionFlyweightFactory instancia;
        public static UbicacionFlyweightFactory GetInstancia
        {
            get
            {
                if (instancia == null)
                    instancia = new UbicacionFlyweightFactory();
                return instancia;
            }
        }




        public Pais GetPais(int IdPais)
        {
            foreach (GI.BR.Propiedades.Ubicaciones.Pais p in hashPaises)
            {
                if (p.IdPais == IdPais)
                    return p;
            }

            return null;

        }

        public Provincias GetProvincias(int IdPais)
        {
            Provincias p = new Provincias();
            foreach (GI.BR.Propiedades.Ubicaciones.Provincia pr in hashProvincias)
            {
                if (pr.IdPais == IdPais)
                    p.Add(pr);
            }
            return p;
        }

        public Paises GetPaises()
        {
            return hashPaises;
        }

        public Localidades GetLocalidades(int IdProvincia)
        {
            Localidades p = new Localidades();
            foreach (GI.BR.Propiedades.Ubicaciones.Localidad l in hashLocalidades)
            {
                if (l.IdProvincia == IdProvincia)
                    p.Add(l);
            }
            return p;
        }

        public Barrios GetBarrios(int IdLocalidad)
        {
            Barrios p = new Barrios();
            foreach (GI.BR.Propiedades.Ubicaciones.Barrio b in hashBarrios)
            {
                if (b.IdLocalidad == IdLocalidad)
                    p.Add(b);
            }
            return p;
        }

        public Provincia GetProvincia(int IdProvincia)
        {
            foreach (GI.BR.Propiedades.Ubicaciones.Provincia p in hashProvincias)
            {
                if (p.IdProvincia == IdProvincia)
                    return p;
            }

            return null;
        }

        public Localidad GetLocalidad(int IdLocalidad)
        {
            foreach (GI.BR.Propiedades.Ubicaciones.Localidad l in hashLocalidades)
            {
                if (l.IdLocalidad == IdLocalidad)
                    return l;
            }

            return null;
        }

        public Barrio GetBarrio(int IdBarrio)
        {
            foreach (GI.BR.Propiedades.Ubicaciones.Barrio b in hashBarrios)
            {
                if (b.IdBarrio == IdBarrio)
                    return b;
            }

            return null;
        }

    }
}
