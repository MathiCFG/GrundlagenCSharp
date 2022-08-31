/*
int x = 9, z = 6; double y = 8;
Console.WriteLine(x-- == y);                    //False
Console.WriteLine(x==(int)y);                   //True
Console.WriteLine("{0:F1}",0.123);              //0,1
Console.WriteLine(z/y);                         //0,75
Console.WriteLine(x-=10);                       //-2
Console.WriteLine(x-- == y & true);             //False
Console.WriteLine(!(z == 6) | false);           //False
Console.WriteLine((x*=-2) == z);                //True
*/

Console.WriteLine("(1) Umrechnung von Celsius nach Kelvin"+
    "\n(2) Umrechnung von Celsius nach Fahrenheit" +
    "\n(3) Umrechnung von Kelvin nach Celsius" +
    "\n(4) Umrechnung von Kelvin nach Fahrenheit");

Console.WriteLine("Treffe eine Auswahl der Umrechnung:");
int auswahl = Convert.ToInt16(Console.ReadLine());  //Auswahl variable festlegen
string er = "ERROR: ";

switch (auswahl)
{
    case 1:
        Console.WriteLine("Gebe deine Celsius Zahl ein: ");
        double Celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Celsius+" C° nach Kelvin ergibt: "+(Celsius + 273.15)+" Kelvin.");
        break;
    
    case 2:
        Console.WriteLine("Gebe deine Celsius Zahl ein: ");
        double Celsius1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Celsius1+" C° nach Fahrenheit ergibt: "+(Celsius1 * 1,8 + 32)+" Fahrenheit.");
        break;    
    
    case 3:
        Console.WriteLine("Gebe deine Kelvin Zahl ein: ");
        double Kelvin = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Kelvin+" Kelvin nach Celsius ergibt: "+(Kelvin - 273.15)+" Celsius.");
        break;

    case 4:
        Console.WriteLine("Gebe deine Kelvin Zahl ein: ");
        double Kelvin1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Kelvin1 + " Kelvin nach Fahrenheit ergibt: " + ((Kelvin1 - 273.15) * 1, 8 + 32));
        break;

}
Console.ReadKey();
