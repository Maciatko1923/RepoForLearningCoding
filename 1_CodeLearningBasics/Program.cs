using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Program przeliczający temperaturę w stopniach Celcjusza na temperaturę w stopniach Fahrenheita. 
//   Program prosi użytkownika o podanie temperatury w stopiach Celsjusza. Wzór : F = 32 + (9/5)*C

//2. Program obliczający deltę równania kwadratowego ax^2 + bx + c = 0. 
//   Program prosi użytkownika o podanie a,b,c. , d = b^2 - 4ac

    //zad3
    //Program ktory oblicza bmi, program prosi o podane wagi w kg, wzrostu w m?, bmi = (m / w)

namespace Lesson1_Basics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //zad1
            // double temperatureInCelsius = 0;
            // double temperatureInFarenheit = 0;

            // Console.WriteLine("could you give me a temperature in Celsius?:");
            //temperatureInCelsius = double.Parse(Console.ReadLine());   //parsowanie string / double
            // temperatureInFarenheit = 32 + ((9d / 5) * temperatureInCelsius);  // literaly du
            // Console.WriteLine(temperatureInCelsius +   " in Celsius equals " + temperatureInFarenheit + " in Farenheit ");
            // Console.ReadLine();

            ////zad2
            //double a, b, c, d;
            //Console.WriteLine("podaj wartosc a:");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("podaj wartosc b:");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("podaj wartosc c:");
            //c = double.Parse(Console.ReadLine());

            //d = (b * b) - (4 * a * c);
            //Console.WriteLine("Result of formula equals: " + d);
            //Console.ReadLine();


            //int / double  int calkowite , rzeczywiste 
            // f float, d double , var 3.0 lub  3d, m decimal, l long ,
            // + konkatenacja String dodawanie 
            //Console.WriteLine();  zwraca zawsze String 
            //  konwersja jawna czyli jestem swiadomy dokonywania konwersji i ze moge utracic dane,
            //niejawna obecnosc String powoduje ze 2 argument jest dolaczany jako lancuch znakow
            //

            double bmi = 0;
            int weight = 0;
            int height = 0;

            Console.WriteLine("Podaj wagę w kg:?");
                weight = int.Parse( Console.ReadLine());
            Console.WriteLine("Podaj wzrost w cm:?");
            height = int.Parse(Console.ReadLine());

            bmi = (double)weight / height;  // rzutowanie czyli zmieniam typ, konwersja zamiana
            Console.WriteLine("wspolczynnik bmi wynosi:" + bmi);
            Console.ReadLine();







        }
    }
}
