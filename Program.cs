using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calstring loyihasiga xush keldingiz!!!");
        Console.WriteLine("1.oddiy calculyator.     2.murakkab calculyator");
        Console.WriteLine("1-calkulyatorda -,+,*,/ amallari mavjud");
        Console.WriteLine("2-calculyatorimizda qiyin amallar sonning darajasini topish,ildiz topish amallari mavjud");
        Console.WriteLine("tanlang");

        int bolimtanlash = int.Parse(Console.ReadLine());

        if (bolimtanlash == 1)
        {
            OsonOperatorTanlash();
        }
        else if (bolimtanlash == 2)
        {
            QiyinOperatorTanlash();
        }
        else
        {
            Console.WriteLine("Noto'g'ri tanlov! Faqat 1 yoki 2 ni tanlang.");
        }
    }

    static void OsonOperatorTanlash()
    {
        Console.WriteLine("siz simple calkulationni tanladingiz.");
        Console.WriteLine("inter first number:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("choose one of the operators- -,+,*,/ ");
        char operators = char.Parse(Console.ReadLine());

        Console.WriteLine("inter second number:");
        double b = double.Parse(Console.ReadLine());

        if (operators == '+')
        {
            double result = a + b;
            Console.WriteLine("Result:" + result);
        }
        else if (operators == '-')
        {
            double result1 = a - b;
            Console.WriteLine("Result:" + result1);
        }
        else if (operators == '*')
        {
            double result2 = a * b;
            Console.WriteLine("Result:" + result2);
        }
        else if (operators == '/')
        {
            if (b == 0)
            {
                Console.WriteLine("Xato: 0 ga bo'lish mumkin emas!");
            }
            else
            {
                double result3 = a / b;
                Console.WriteLine("Result:" + result3);
            }
        }
        else
        {
            Console.WriteLine("Noto'g'ri operator!");
        }
    }

    static void QiyinOperatorTanlash()
    {
        Console.WriteLine("you inter dificult calculation");
        Console.WriteLine("sizga aynan qaysi murakkab amal natijasi kerak tanlang:");
        Console.WriteLine("1.sonni darajasini topish. 2.sonni ildizini topish.");

        int dificultOperator = int.Parse(Console.ReadLine());

        switch (dificultOperator)
        {
            case 1:
                Console.WriteLine("Siz bilan sonning darajasini topamiz.");
                Console.WriteLine("Son kiriting:");
                double dificultNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Darajani kiriting:");
                int daraja = int.Parse(Console.ReadLine());

                double resultDaraja = Math.Pow(dificultNumber, daraja);
                Console.WriteLine($"{dificultNumber} ning {daraja}-darajasi = {resultDaraja}");
                break;

            case 2:
                Console.WriteLine("Siz bilan sonning ildizini topamiz.");
                Console.WriteLine("Ixtiyoriy son kiriting:");
                double dificultNumberIldiz = double.Parse(Console.ReadLine());

                if (dificultNumberIldiz < 0)
                {
                    Console.WriteLine("Manfiy son kiritmang!!!");
                }
                else
                {
                    double ildiz = Math.Sqrt(dificultNumberIldiz);
                    Console.WriteLine($"{dificultNumberIldiz} ning ildizi = {ildiz:F4}"); // F4 - 4 xona aniqlik
                }
                break;

            default:
                Console.WriteLine("Noto'g'ri tanlov! Faqat 1 yoki 2 ni tanlang.");
                break;
        }
    }
}