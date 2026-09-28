using CapaNegocio;

namespace CapaDatosMemoria
{
    public class DatosMemoria : FuenteDeDatos
    {

        List<Vehiculo> vehiculosIngresados;

        public DatosMemoria()
        {
            this.vehiculosIngresados = new List<Vehiculo>();
            this.vehiculosIngresados.Add(new Vehiculo("ABC123F",DateTime.Now.AddMinutes(-10),"M"));
            this.vehiculosIngresados.Add(new Vehiculo("ABC123H", DateTime.Now.AddMinutes(-67), "M"));
            this.vehiculosIngresados.Add(new Vehiculo("THC123F", DateTime.Now.AddMinutes(-90), "M"));
            this.vehiculosIngresados.Add(new Vehiculo("ABD123A", DateTime.Now.AddMinutes(-10), "A"));
            this.vehiculosIngresados.Add(new Vehiculo("AWEC123", DateTime.Now.AddMinutes(-50), "A"));
        }

        public Vehiculo consultarIngresoVehiculo(string placa)
        {
            Vehiculo? v= vehiculosIngresados.Find(Vehiculo => Vehiculo.Placa == placa);
            if ( v ==null)
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
            throw new NotImplementedException();
            this.vehiculosIngresados.RemoveAll(Vehiculo => Vehiculo.Placa == placa);
            return true;
        }

        public bool registrarIngresoVehiculo(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
            this.vehiculosIngresados.Add(vehiculo);
            return true;
        }
    }
}
