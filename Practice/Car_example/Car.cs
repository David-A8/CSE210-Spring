public class Car{

    public string brand;
    public string year;
    public int mileage;
    public bool lights = false;

    //public Car(){

    //}

    public void displayInfo(){
        Console.WriteLine($"Brand: {brand}, year: {year}, mileage: {mileage}, lights: {lights}.");
    }

    public void turnOn(){
        lights = true;

    }
}
