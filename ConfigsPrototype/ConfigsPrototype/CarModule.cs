using Nancy;

namespace ConfigsPrototype
{
    public class CarModule : NancyModule
    {
        //notice that this is all in the class constructor
        public CarModule()
        {
            Get["/carsample"] = _ => "Hello World!";
            //these {} will append these to the parameters that we have here

            //i got a 500 error here... why? I did the same thing... 
            Get["/car/{id}"] = parameters =>
            {
                int id = parameters.id;
                return Negotiate
                    .WithStatusCode(HttpStatusCode.OK)
                    .WithModel(id);
            };

            Get["/{make}/{model}"] = parameters =>
            {
                var carQuery = this.Bind<CarQuery>();
                var ListOfCars = new List<Car>()
                         {
                                 new Car { ID = 1, Make = carQuery.Make, Model = carQuery.Model },
                                 new Car { ID = 2, Make = carQuery.Make, Model = carQuery.Model },
                                 new Car { ID = 2, Make = carQuery.Make, Model = carQuery.Model };

                return Negotiate
                      .WithStatusCode(HttpStatusCode.OK)
                      .WithModel(ListOfCars);
            };
        }



        public class CarQuery
        {
            public string Make { get; set; }
            public string Model { get; set; }
        }

        public class Car
        {
            public int ID { get; set; }
            public string Make { get; set; }
            public string Model { get; set; };
        }
    }
}