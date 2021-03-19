using problem.transport.train;

namespace problem 
{
    public class Part4 
    {
        public Part4() 
        {
            /* problema 
               1. se necesita autos q funcionen a diesel y gasolina
               2. tenemos q aumentar camiones
               3. los vehiculos deben ser hibridos
               4. agregar trenes y q funcionen a electricidad
            */
            Car car1 = new DieselCar();
            Car car2 = new GasolineCar();

                      
            Truck truck1 = new DieselTruck();
            Truck truck2 = new GasolineTruck();


            Car car3 = new HybridCar();
            Truck truck3 = new HybridTruck();

            Transport car4 = new ElectricCar();
            Transport train1 = new ElectricTrain();

            // ....
        }
    }    
}