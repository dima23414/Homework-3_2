using System;
using System.IO;

namespace Hello_Exception_stud
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine("Observation titmouse flight");
            Bird My_Bird = new Bird("Titmouse", 20);
            int ii;
            char rdk;
            try
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Monitoring in Try block ");
                        Console.WriteLine(@"Please, type the number
                1. array overflow
                2. throw exception
                3. user exception
                4. Division by zero
                5. Going beyond
                6. Incorrect number
                7. Element outside the array
                8. Calculating the square root of a negative number
                9. Trying to open a non-existent file
                ");
                        uint i = uint.Parse(Console.ReadLine());
                        switch (i)
                        {
                            case 1:
                                int j = My_Bird.FlySpeed[4];
                                break;

                            case 2:
                                throw (new System.Exception("Oh! My system exception..."));

                            case 3:
                                for (ii = 0; ii < My_Bird.FlySpeed[3]; ii++)
                                {
                                    My_Bird.FlyAway(ii);
                                }
                                break;

                            case 4:
                                int j1 = 0;
                                int j2 = 1 / j1;
                                break;

                            case 5:
                                int j4 = int.MaxValue;
                                int j3 = j4 + 1;

                                if (j3 < 0)
                                {
                                    throw new System.Exception("Error out of bounds");
                                }
                                    break;

                            case 6:
                                string invalidString = "abc";
                                int invalidConversion = int.Parse(invalidString);
                                break;

                            case 7:
                                int[] array = new int[3];
                                int indexOutOfRange = array[5];
                                break;

                            case 8:
                                double negativeNumber = -25;
                                double j5 = Math.Sqrt(negativeNumber);

                                if (double.IsNaN(j5))
                                {
                                    throw new System.Exception("Error: Calculating the square root of a negative number");
                                }
                                break;

                            case 9:
                                StreamReader reader = new StreamReader("несуществующий_файл.txt");
                                break;



                            default:
                                break;
                        }
                    }

                    catch (System.ArithmeticException e)
                    {
                        Console.WriteLine("CLS exception: Message -  " + e.Message + " Source - " + e.Source);
                    }

                    catch (BirdFlewAwayException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.When);
                        Console.WriteLine(e.Why);

                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("CLS exception: Message -  " + e.Message + " Source - " + e.Source);

                    }
                    finally
                    {
                        Console.WriteLine("For next step ...");
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    
                    rdk = Console.ReadKey().KeyChar;
                } while (rdk != ' ');

            }
            catch (Exception mn)
            {
            }


        }

    }
}
