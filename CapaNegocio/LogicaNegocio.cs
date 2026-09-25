namespace CapaNegocio
{
    public class LogicaNegocio
    {

        FuenteDeDatos conexion;

        public LogicaNegocio(FuenteDeDatos conexion)
        {
            this.conexion = conexion;
        }

        public bool ingresarVehiculo(string placa, string tipoVehiculo)
        {
            placa = placa.ToUpper().Replace(" ", "");

            DateTime momentoIngreso = DateTime.Now;

            if (tipoVehiculo == "Automovil")
            {
                tipoVehiculo = "A";
            }
            else
            {
                tipoVehiculo = "M";
            }

            Vehiculo vehiculo = new Vehiculo(placa, momentoIngreso, tipoVehiculo);

            return conexion.registrarIngresoVehiculo(vehiculo);
        }

        public int consultarValorAPagar(string placa)
        {
            placa = placa.ToUpper().Replace(" ", "");

            Vehiculo vehiculo = conexion.consultarIngresoVehiculo(placa);

            double minutosParqueado = (DateTime.Now - vehiculo.MomentoIngreso).TotalMinutes;

            if (minutosParqueado < 15)
            {
                return 0;
            }
            else
            {
                int horasACobrar = (int) Math.Ceiling(minutosParqueado / 60);
                if (vehiculo.TipoVehiculo == "A")
                {
                    return horasACobrar * 6000;
                }
                else
                {
                    return horasACobrar * 3000;
                }
            }
        }

        public bool darSalida(string placa)
        {
            placa = placa.ToUpper().Replace(" ", "");
            return conexion.eliminarVehiculo(placa);
        }
    }
}
