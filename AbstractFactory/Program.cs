// Abstract factory provides an interface for creating families of related of dependant objects without specifying their concrete classes.

using AbstractFactory.Factories;

// Creating regular vehicles and printing their details
var regularVehicleFactory = new RegularVehicleFactory();

var regularBike = regularVehicleFactory.CreateBike();
regularBike.GetDetails();

var regularCar = regularVehicleFactory.CreateCar();
regularCar.GetDetails();

// Creating sport vehicles and printing their details
var sportsVehicleFactory = new SportsVehicleFactory();

var sportsBike = sportsVehicleFactory.CreateBike();
sportsBike.GetDetails();

var sportsCar = sportsVehicleFactory.CreateCar();
sportsCar.GetDetails();