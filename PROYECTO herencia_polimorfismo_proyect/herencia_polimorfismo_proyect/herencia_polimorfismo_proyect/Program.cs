using herencia_polimorfismo_proyect.MisClases;

class Program
{
    static void Main(string[] args)
    {
        Vehiculo miCarrito = new Vehiculo(2026, "Azul", "Alfa Romeo");
        Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");
        CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

        // Crear instancias de las nuevas clases
        AutoDeCombustion miAuto = new AutoDeCombustion(2024, "Negro", "Toyota", "Gasolina");
        Motocicleta miMoto = new Motocicleta(2023, "Rojo", "Ducati", 1100, "Deportivo");
        Camión miCamion = new Camión(2022, "Blanco", "Volvo", 5000, 6);

        // Pruebas con CarroElectrico
        miBYD.InformacionVehiculo();
        miBYD.cargarBateria();
        Console.WriteLine("El nivel de batería es: {0}", miBYD.NivelBateria());

        // Pruebas con AutoDeCombustion
        miAuto.Acelerar(20);
        miAuto.Frenar();
        miAuto.CargarCombustible(10);

        // Pruebas con Motocicleta
        miMoto.Acelerar(15);
        miMoto.Frenar();
        miMoto.UsarCasco();

        // Pruebas con Camion
        miCamion.Acelerar(10);
        miCamion.Frenar();
        miCamion.EngancharRemolque();
    }
}