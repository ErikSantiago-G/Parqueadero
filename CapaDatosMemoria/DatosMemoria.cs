using CapaNegocio;

namespace CapaDatosMemoria
{
    public class DatosMemoria : FuenteDeDatos
    {

        public List<Vehiculo> vehiculosIngresados;

        public DatosMemoria()
        {
            this.vehiculosIngresados = new List<Vehiculo>();
            this.vehiculosIngresados.Add(new Vehiculo("MOT123", DateTime.Now.AddMinutes(-10), "M"));
            this.vehiculosIngresados.Add(new Vehiculo("MOT456", DateTime.Now.AddMinutes(-62), "M"));
            this.vehiculosIngresados.Add(new Vehiculo("AUT123", DateTime.Now.AddMinutes(-10), "A"));
            this.vehiculosIngresados.Add(new Vehiculo("AUT456", DateTime.Now.AddMinutes(-62), "A"));
        }

        public Vehiculo consultarIngresoVehiculo(string placa)
        {
            Vehiculo? v = vehiculosIngresados.Find(vehiculo => vehiculo.Placa == placa);
            if (v == null)
            {
                return new Vehiculo();
            }
            else
            {
                return v;
            }
        }

        public bool eliminarVehiculo(string placa)
        {
            this.vehiculosIngresados.RemoveAll(vehiculo => vehiculo.Placa == placa);
            return true;
        }

        public bool registrarIngresoVehiculo(Vehiculo vehiculo)
        {
            this.vehiculosIngresados.Add(vehiculo);
            return true;
        }
    }
}
