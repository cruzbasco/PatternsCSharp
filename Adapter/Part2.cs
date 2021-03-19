namespace problem 
{
    public class Part2 
    {
        public Part2() 
        {
            /* problema 
               1. se necesita autos q funcionen a diesel y gasolina
               2. tenemos q aumentar camiones
            */
            Car car1 = new DieselCar();
            Car car2 = new GasolineCar();

                      
            Truck truck1 = new DieselTruck();
            Truck truck2 = new GasolineTruck();

        }
    }    
}