using CapaDatosMemoria;
using CapaNegocio;

namespace CapaNegocioTest
{
    [TestClass]
    public sealed class Test1 
    {

        LogicaNegocio logica = new LogicaNegocio(new DatosMemoria());

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
