namespace CapaNegocio
{
    public class Vehiculo   // DTO
    {
        public string Placa {  get; set; }
        public DateTime MomentoIngreso { get; set; }
        public string TipoVehiculo {  get; set; }


        public Vehiculo(){

        }

        public Vehiculo(string placa, DateTime momentoIngreso, string tipoVehiculo)
        {
            this.Placa = placa;
            this.MomentoIngreso = momentoIngreso;
            this.TipoVehiculo = tipoVehiculo;
        }

    }
}
