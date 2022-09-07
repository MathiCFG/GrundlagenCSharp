double höhe_double = 32.346;
double breite_double  = 15.193;

string höhe_str = "Höhe";
string breite_str = "Breite";


Console.WriteLine("{0,10}{1,10}\n",höhe_str,breite_str);

for(int i =0; i<100; i++)
{
    Console.WriteLine("{0,10}{1,10}", höhe_str, breite_str);
}