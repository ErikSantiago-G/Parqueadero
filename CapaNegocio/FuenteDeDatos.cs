using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public interface FuenteDeDatos
    {
        public bool registrarIngresoVehiculo(Vehiculo vehiculo);

        public bool eliminarVehiculo(string placa);

        public Vehiculo consultarIngresoVehiculo(string placa);

    }
}
