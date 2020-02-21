public class Car {
    public string CarType { get; set; }
    public string WheelBrand { get; set; }

    public void Drive()
    {
        //car driving noise here
    }

}

public class Tuscon : Car 
{
    public Tuscon()
    {
        CarType = "Hyundai";
        WheelBrand = "Firestone";
    }
}

public class Fiesta : Car 
{
    public Tuscon()
    {
        CarType = "Ford";
        WheelBrand = "Michelen";
    }
}


public class Program {
    public static void Main(string[] args)
    {
        Tuscon myCar = new Tuscon();
        Console.WriteLine(myCar.CarType);
    }
}
