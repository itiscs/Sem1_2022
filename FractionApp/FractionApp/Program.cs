
namespace FractionApp
{
    
    public class Program
    {
        public static void Main()
        {
            //try
            //{
            Fraction f1 = new Fraction(4, 11);
            Fraction f2 = new Fraction(2, 5);
            Fraction f3 = new Fraction(-5,13);


            Console.WriteLine(f1 > f2);

            Console.WriteLine(f1 < f2);


            f1.Numerator = 3;
            //f1.SetDenom(2);


            Console.WriteLine($"++f1 - {++f1}");

            Console.WriteLine($"{f2} + 5 = {f2 + 5}  = {5 + f2}");



            Fraction.StaticMethod();
            
            
            //f1.Print();
            Console.WriteLine(f1);


            //f2.SetNum(2);
            f2.Denominator = 1;

            //Console.WriteLine($"Fraction - {f2.Numerator}/{f2.Denominator}");
            Console.WriteLine($"Fraction - {f2}");


            //f3.Print();
            Console.WriteLine($"f3 = {f3}");

            f1.Add(f2);
            //f1.Print();
            Console.WriteLine($"f1 - {f1}");

            f3.Add(f1, f2);
            //f3 = f3 + f2;
            //f3.Print();
            Console.WriteLine($"f3 - {f3}");


            Console.WriteLine("*******************************");
            Console.WriteLine(f1 + f2);
            Console.WriteLine(f2 + f3);



            




            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }

    }

}

