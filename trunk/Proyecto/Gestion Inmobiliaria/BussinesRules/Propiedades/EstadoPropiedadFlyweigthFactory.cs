using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GI.BR.Propiedades
{
    public class EstadoPropiedadFlyweigthFactory
    {
        
        private Hashtable estadosPropiedad;
        private static Hashtable hashTipoEstados = new Hashtable();

        private EstadoPropiedadFlyweigthFactory(Type Tipo)
        {

            estadosPropiedad = new Hashtable();
            EstadosPropiedad estados = new EstadosPropiedad();
            estados.RecuperarEstados(Tipo);
            foreach (EstadoPropiedad e in estados)
            {
                estadosPropiedad.Add(e.IdEstadoPropiedad, e);
            }
        }

        public EstadoPropiedad GetEstado(int IdestadoPropiedad)
        {
            return (EstadoPropiedad)estadosPropiedad[IdestadoPropiedad];
        }

        public static EstadoPropiedadFlyweigthFactory GetInstancia(Type Tipo)
        {
            if (hashTipoEstados[Tipo.ToString()] == null)
                hashTipoEstados[Tipo.ToString()] = new EstadoPropiedadFlyweigthFactory(Tipo);
            return (EstadoPropiedadFlyweigthFactory)hashTipoEstados[Tipo.ToString()];
        }

    }
}
