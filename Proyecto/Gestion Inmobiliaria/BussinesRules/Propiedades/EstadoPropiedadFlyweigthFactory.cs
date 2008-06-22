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
        private EstadoPropiedad estadoBase;
        private int IdReservado;

        private EstadoPropiedadFlyweigthFactory(Type Tipo)
        {

            estadosPropiedad = new Hashtable();
            EstadosPropiedad estados = new EstadosPropiedad();
            estados.RecuperarEstados(Tipo);
            estadoBase = estados[0];
            foreach (EstadoPropiedad e in estados)
            {
                if (e.Descripcion == "Reservado")
                    this.IdReservado = e.IdEstadoPropiedad;
                estadosPropiedad.Add(e.IdEstadoPropiedad, e);
            }
        }

        public EstadoPropiedad GetEstado(int IdestadoPropiedad)
        {
            return (EstadoPropiedad)estadosPropiedad[IdestadoPropiedad];
        }

        public EstadoPropiedad GetEstadoBase()
        {
            return estadoBase;
        }

        public static EstadoPropiedadFlyweigthFactory GetInstancia(Type Tipo)
        {
            if (hashTipoEstados[Tipo.ToString()] == null)
                hashTipoEstados[Tipo.ToString()] = new EstadoPropiedadFlyweigthFactory(Tipo);
            return (EstadoPropiedadFlyweigthFactory)hashTipoEstados[Tipo.ToString()];
        }

        public EstadoPropiedad GetEstadoReservado()
        {
            return (EstadoPropiedad)estadosPropiedad[IdReservado];
        }
    }
}
