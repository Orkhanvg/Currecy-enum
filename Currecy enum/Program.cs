using System;


namespace Currecy_enum
{
    enum Currency { usd=1, euro, tl }
    enum notcurrency { five, six, eight }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the azn");
            double azn = double.Parse(Console.ReadLine() );
            Console.WriteLine(Exchange(Currency.euro,azn));
        }

        public static double Exchange(Enum obj,double azn )
        {
            double result = 0;
	     if (!(obj is Currency))
            {
                Console.WriteLine("please check correct object");
            }
            else
            {
                switch (obj)
                {
                    case Currency.usd:
                        {
                            result = azn * 0.59;
                            break;
                        }
                    case Currency.euro:
                        {
                            result = azn * 0.53;
                            break;
                        }

                    case Currency.tl:
                        {
                            result = azn * 8.63;
                            break;
                        }
                    
                }
            }
            return result;

            

        }



    }
}
