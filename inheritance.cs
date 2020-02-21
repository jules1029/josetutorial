//Class marked with abstract cannot be instantiated (cannot make new instances) only their child classes
//BaseClass has implementations in it
//BaseClasses allow you to share functionality between several classes at the cost of tying you to it's implementation
public abstract class Car {
    public string CarType { get; set; }
    public string WheelBrand { get; set; }

    public void Drive()
    {
        //car driving noise here
        //Imagine the code
    }

    //Has to be overridden by child class
    public abstract void DrivinDirty()
    {

    }
}

//Child class implements car and only needs to override the parts that need to change
public class Tuscon : Car 
{
    public Tuscon()
    {
        CarType = "Hyundai";
        WheelBrand = "Firestone";
    }

    public override void Drive()
    {
        //Imagine code here that drives differently
    }
}

//Child class implements car and only needs to override the parts that need to change
public class Fiesta : Car 
{
    public Tuscon()
    {
        CarType = "Ford";
        WheelBrand = "Michelen";

        //base lets you call methods on your parent (base) class
        base.Drive();
    }
}


public class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("Which car do you have Tuscon/Fiesta?");
        string carName = console.Readling();

        //Returns an instance of any car 
        Car myCar = GetCar(carName);
        Console.WriteLine(myCar.CarType);
    }

    //Dynamically returns an instance of the Car base class (polymorphism)
    public static Car GetCar(string name)
    {
        if(name == "Tuscon")
            return new Tuscon();

        if(name == "Fiesta")
            return new Fiesta();

        return null;
    }
}
