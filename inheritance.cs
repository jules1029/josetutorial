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

public class Fiesta : Car 
{
    public Tuscon()
    {
        CarType = "Ford";
        WheelBrand = "Michelen";

        base.Drive();
    }
}


public class Program {
    public static void Main(string[] args)
    {
        Car myCar = GetCar();
        Console.WriteLine(myCar.CarType);
    }

    public static Car GetCar(string name)
    {
        if(name == "Tuscon")
            return new Tuscon();

        if(name == "Fiesta")
            return new Fiesta();

        return null;
    }
}
