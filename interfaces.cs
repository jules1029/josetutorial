//interfaces are like a class with no body implementation
//Contracts only plz!!!
//Every part of the ICar contract (every public method, property, and field declaration) must be implemented
interface ICar {
    string CarType { get; set; }
    string WheelBrand { get; set; }
    void Drive();
    void DrivinDirty();
}

//Tuscon is an implementation of ICar and has to implement everything on the ICar interface
public class Tuson : ICar 
{
    public string CarType { get; set; }
    public string WheelBrand { get; set; }

    public void Drive()
    {
        //driving code here
        //vroom vroom
    }

    public void DrivinDirty()
    {
        //they see me rollin
    }
}

//Fiesta is an implementation of ICar and has to implement everything on the ICar interface
public class Fiesta : ICar 
{
    public string CarType { get; set; }
    public string WheelBrand { get; set; }

    public void Drive()
    {
        //driving code here
        //vroom vroom
    }

    public void DrivinDirty()
    {
        //they see me rollin
    }
}

public class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("Which car do you have Tuscon/Fiesta?");
        string carName = console.Readling();

        //Can use myCar variable based on what's on the interface (drive, CarType, WheelBrand, etc..)
        ICar myCar = GetCar(carName);
        Console.WriteLine(myCar.CarType);
    }

    //Dynamically returns an instance of ICar polymorphically (can be Tuscon or a Fiesta)
    public static ICar GetCar(string name)
    {
        if(name == "Tuscon")
            return new Tuscon();

        if(name == "Fiesta")
            return new Fiesta();

        return null;
    }
}
