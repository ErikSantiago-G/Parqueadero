using CapaNegocio;
using MongoDB.Driver;

namespace CapaAccesoDatosMongo
{
    public class ConexionMongo : FuenteDeDatos
    {
        private readonly MongoClient cliente;
        private readonly IMongoDatabase baseDatos;
        private readonly IMongoCollection<Vehiculo> vehiculos;

        public ConexionMongo()
        {
            cliente = new MongoClient("mongodb://localhost:27017");
            baseDatos = cliente.GetDatabase("parqueadero");
            vehiculos = baseDatos.GetCollection<Vehiculo>("vehiculos");
        }

        public Vehiculo consultarIngresoVehiculo(string placa)
        {
            return vehiculos
                .Find(v => v.Placa == placa)
                .Project<Vehiculo>(Builders<Vehiculo>.Projection.Exclude("_id"))
                .FirstOrDefault();
        }

        public bool eliminarVehiculo(string placa)
        {
            var resultado = vehiculos.DeleteOne(v => v.Placa == placa);
            return resultado.DeletedCount > 0;
        }

        public bool registrarIngresoVehiculo(Vehiculo vehiculo)
        {
            vehiculos.InsertOne(vehiculo);
            return true;
        }
    }
}