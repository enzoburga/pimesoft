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
