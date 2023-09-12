namespace RefOutMokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "Labas, pasauli";
            //GetTextLenght(text, out int ilgis);
            //Console.WriteLine(ilgis);

            //string name;
            //string surname;
            //GetUserData(out name, out surname);

            //Console.WriteLine(name);
            //Console.WriteLine(surname);

            //int number;
            //Console.WriteLine("Atspekite skaiciu, kad iseitumete jis yra didesnis nei: ");
            //NumberIsGreater(out number);

            double number = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());

            bool isValid = Divide(number, number2, out double dalmuo, out double liekana);

            if (isValid)
            {
                Console.WriteLine("jusu dalmuo: " + dalmuo);
                Console.WriteLine("jusu liekana: " + liekana);
            }
            else
            {
                Console.WriteLine("skaicius nedalinamas is 0");
            }
        }

        public static void GetTextLenght(string text, out int lenght)
        {
            lenght = text.Length;
        }

        public static void GetUserData(out string name, out string surname)
        {
            name = Console.ReadLine();
            surname = Console.ReadLine();
        }

        public static void NumberIsGreater(out int number)
        {
            while (true)
            {
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out number) && number > 100)
                {
                    Console.WriteLine(number);
                    break;
                }
                else
                {
                    Console.WriteLine("bandyk dar karta");
                }
            }
        }

        public static bool Divide(double number, double number2, out double dalmuo, out double liekana)
        {                           
                       
            if (number2 != 0)
            {
                dalmuo = number / number2;
                liekana = number % 2;

                return true;
            }            

            else
            {
                dalmuo = 0;
                liekana = 0;
                return false;                             
            }            
        }
    }
}