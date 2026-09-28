using CapaDatosMemoria;
using CapaNegocio;

namespace CapaNegocioTest
{
    [TestClass]
    public sealed class LogicaNegocioTest
    {
        LogicaNegocio logica;


        [TestMethod]
        public void probarIngresoAutomovil()
        {
            DatosMemoria datos = new DatosMemoria();
            logica = new LogicaNegocio(datos);
            int cantidadActualVehiculos = datos.vehiculosIngresados.Count();
            bool resultado = logica.ingresarVehiculo("AUT789", "Automovil");
            int cantidadNuevaVehiculos = datos.vehiculosIngresados.Count();
            Assert.IsTrue(resultado);
            Assert.AreEqual(cantidadActualVehiculos + 1, cantidadNuevaVehiculos);
            Vehiculo? v = datos.vehiculosIngresados.Find(vehiculo => vehiculo.Placa == "AUT789");
            Assert.IsNotNull(v);
        }


        [TestMethod]
        public void probarIngresoMotocicleta()
        {
            DatosMemoria datos = new DatosMemoria();
            logica = new LogicaNegocio(datos);
            int cantidadActualVehiculos = datos.vehiculosIngresados.Count();
            bool resultado = logica.ingresarVehiculo("MOT789", "Motocicleta");
            int cantidadNuevaVehiculos = datos.vehiculosIngresados.Count();
            Assert.IsTrue(resultado);
            Assert.AreEqual(cantidadActualVehiculos + 1, cantidadNuevaVehiculos);
            Vehiculo? v = datos.vehiculosIngresados.Find(vehiculo => vehiculo.Placa == "MOT789");
            Assert.IsNotNull(v);
        }

        [TestMethod]
        public void probarDarSalida()
        {
            DatosMemoria datos = new DatosMemoria();
            logica = new LogicaNegocio(datos);
            int cantidadActualVehiculos = datos.vehiculosIngresados.Count();
            bool resultado = logica.darSalida("MOT456");
            int cantidadNuevaVehiculos = datos.vehiculosIngresados.Count();
            Assert.IsTrue(resultado);
            Assert.AreEqual(cantidadActualVehiculos - 1, cantidadNuevaVehiculos);
            Vehiculo? v = datos.vehiculosIngresados.Find(vehiculo => vehiculo.Placa == "MOT789");
            Assert.IsNull(v);
        }

        [TestMethod]
        public void probarTarifaAutoMenos15Mins()
        {
            DatosMemoria datos = new DatosMemoria();
            logica = new LogicaNegocio(datos);
            int valorAPagar = logica.consultarValorAPagar("AUT123");
            Assert.AreEqual(0, valorAPagar);
        }

        [TestMethod]
        public void probarTarifaMotoMenos15Mins()
        {
            DatosMemoria datos = new DatosMemoria();
            logica = new LogicaNegocio(datos);
            int valorAPagar = logica.consultarValorAPagar("MOT123");
            Assert.AreEqual(0, valorAPagar);
        }

        [TestMethod]
        public void probarTarifaAutoMas15Mins()
        {
            DatosMemoria datos = new DatosMemoria();
            logica = new LogicaNegocio(datos);
            int valorAPagar = logica.consultarValorAPagar("AUT456");
            Assert.AreEqual(12000, valorAPagar);
        }

        [TestMethod]
        public void probarTarifaMotoMas15Mins()
        {
            DatosMemoria datos = new DatosMemoria();
            logica = new LogicaNegocio(datos);
            int valorAPagar = logica.consultarValorAPagar("MOT456");
            Assert.AreEqual(6000, valorAPagar);
        }

        [TestMethod]
        public void probarConstructorVehiculo()
        {
            Vehiculo v = new Vehiculo();

            Assert.IsNull(v.Placa);
            Assert.IsNull(v.TipoVehiculo);
            Assert.AreEqual(new DateTime(), v.MomentoIngreso);
        }
    }
}
