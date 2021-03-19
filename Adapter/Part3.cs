namespace problem 
{
    public class Part3 
    {
        public Part3() 
        {
            /* problema 
               1. se necesita autos q funcionen a diesel y gasolina
               2. tenemos q aumentar camiones
               3. los vehiculos deben ser hibridos
            */
            Car car1 = new DieselCar();
            Car car2 = new GasolineCar();

                      
            Truck truck1 = new DieselTruck();
            Truck truck2 = new GasolineTruck();


            Car car3 = new HybridCar();
            Truck truck3 = new HybridTruck();

        }
    }    
}