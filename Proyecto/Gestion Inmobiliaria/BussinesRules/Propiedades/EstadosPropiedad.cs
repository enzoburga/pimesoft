using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class EstadosPropiedad : List<EstadoPropiedad>
    {

        public void RecuperarEstados(Type Tipo)
        {

            Clear();
            EstadoPropiedad estadoProp;

            if (Tipo == typeof(GI.BR.Propiedades.Venta))
            {
                estadoProp = new EstadoPropiedad();
                estadoProp.Descripcion = "En venta";
                estadoProp.IdEstadoPropiedad = 1;
                Add(estadoProp);

                estadoProp = new EstadoPropiedad();
                estadoProp.Descripcion = "Reservado";
                estadoProp.IdEstadoPropiedad = 2;
                Add(estadoProp);

                estadoProp = new EstadoPropiedad();
                estadoProp.Descripcion = "Vendido";
                estadoProp.IdEstadoPropiedad = 3;
                Add(estadoProp);

                estadoProp = new EstadoPropiedad();
                estadoProp.Descripcion = "Pendiente Tasación";
                estadoProp.IdEstadoPropiedad = 4;
                Add(estadoProp);

                estadoProp = new EstadoPropiedad();
                estadoProp.Descripcion = "Historico";
                estadoProp.IdEstadoPropiedad = 5;
                Add(estadoProp);

            }
            else if (Tipo == typeof(GI.BR.Propiedades.Alquiler))
            {
                estadoProp = new EstadoPropiedad();
                estadoProp.Descripcion = "En alquiler";
                estadoProp.IdEstadoPropiedad = 1;
                Add(estadoProp);

                estadoProp = new EstadoPropiedad();
                estadoProp.Descripcion = "Reservado";
                estadoProp.IdEstadoPropiedad = 2;
                Add(estadoProp);

                estadoProp = new EstadoPropiedad();
                estadoProp.Descripcion = "Alquilado";
                estadoProp.IdEstadoPropiedad = 3;
                Add(estadoProp);

                estadoProp = new EstadoPropiedad();
                estadoProp.Descripcion = "Historico";
                estadoProp.IdEstadoPropiedad = 4;
                Add(estadoProp);

            }


        }


    }
}
