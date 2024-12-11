using System.ComponentModel;
using DesignCS.src.OopPrinciples.Polymorphism;

List <object> vehicles = new List<object>();
//This list can add any objects

vehicles.Add(new Car{Brand="Toyota", Model="Camry", Year=2020, NumberOfDoors=4});
vehicles.Add(new Motorcycle{Brand="Harley Davidson", Model="Sports", Year=2021});

//Vehicle Inspection

foreach (var vehicle in vehicles){
    if(vehicle is Car){
        var car = (Car)vehicle;
        car.Start();
    }
    else if(vehicle is Motorcycle){
        var motorcycle = (Motorcycle)vehicle;
        motorcycle.Start();
    }
    //Lots of Else If statement
}

//Instead do this
List <Vehicle> vehicles2 = new List<Vehicle>();
vehicles2.Add(new Car{Brand="Toyota", Model="Camry", Year=2020, NumberOfDoors=4});
vehicles2.Add(new Motorcycle{Brand="Harley Davidson", Model="Sports", Year=2021});

foreach(var vehicle in vehicles2){
    vehicle.Start();
}

//or this
foreach (var vehicle in vehicles){
    if(vehicle is Vehicle v){
        v.Start();
    }
}
