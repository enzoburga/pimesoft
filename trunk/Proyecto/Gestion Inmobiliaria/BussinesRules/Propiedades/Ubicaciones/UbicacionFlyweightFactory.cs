using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GI.BR.Propiedades.Ubicaciones
{
    public class UbicacionFlyweightFactory
    {
        private Hashtable hashPaises;
        private Hashtable hashProvincias;
        private Hashtable hashLocalidades;
        private Hashtable hashBarrios;

        public UbicacionFlyweightFactory()
        {
            hashBarrios = new Hashtable();
            hashLocalidades = new Hashtable();
            hashPaises = new Hashtable();
            hashProvincias = new Hashtable();

            Paises paises = new Paises();
            paises.RecuperarTodos();
            foreach (Pais p in paises)
                hashPaises.Add(p.IdPais, p);

            Provincias provincias = new Provincias();
            provincias.RecuperarTodas();
            foreach (Provincia p in provincias)
                hashProvincias.Add(p.IdProvincia, p);

            Localidades localidades = new Localidades();
            localidades.RecuperarTodas();
            foreach (Localidad l in localidades)
                hashLocalidades.Add(l.IdLocalidad, l);

            Barrios barrios = new Barrios();
            barrios.RecuperarTodos();
            foreach (Barrio b in barrios)
                hashBarrios.Add(b.IdBarrio, b);
        
        
        }




        public Pais GetPais(int IdPais)
        {
            return (Pais)hashPaises[IdPais];

        }

        public Provincias GetProvincias(int IdPais)
        {
            Provincias p = new Provincias();
            foreach (int k in hashProvincias.Keys)
            {
                if (((Provincia)hashProvincias[k]).IdPais == IdPais)
                    p.Add((Provincia)hashProvincias[k]);
            }
            return p;
        }

        public Paises GetPaises()
        {
            Paises p = new Paises();
            foreach (int k in hashPaises.Keys)
            {
                p.Add((Pais)hashPaises[k]);
            }
            return p;
        }

        public Localidades GetLocalidades(int IdProvincia)
        {
            Localidades p = new Localidades();
            foreach (int k in hashLocalidades.Keys)
            {
                if (((Localidad)hashLocalidades[k]).IdProvincia == IdProvincia)
                    p.Add((Localidad)hashLocalidades[k]);
            }
            return p;
        }

        public Barrios GetBarrios(int IdLocalidad)
        {
            Barrios p = new Barrios();
            foreach (int k in hashBarrios.Keys)
            {
                if (((Barrio)hashBarrios[k]).IdLocalidad == IdLocalidad)
                    p.Add((Barrio)hashBarrios[k]);
            }
            return p;
        }

        public Provincia GetProvincia(int IdProvincia)
        {
            return (Provincia)hashProvincias[IdProvincia];
        }

        public Localidad GetLocalidad(int IdLocalidad)
        {
            return (Localidad)hashLocalidades[IdLocalidad];
        }

        public Barrio GetBarrio(int IdBarrio)
        {
            return (Barrio)hashBarrios[IdBarrio];
        }

    }
}
