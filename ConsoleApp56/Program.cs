using System;
using System.Linq;

namespace ConsoleApp55
{
    class Program
    {


        static void Main(string[] args)
        {

            int[] myArray = new int[2];
            string?  returnValue;
            
            
            for (int f = 0; f < 5; f++) // Будет перезапускать программу при ошибках 
            {
                Console.WriteLine("Введите число или два числа через запятую!");
                try
                {
                    string? x = Console.ReadLine();
                    myArray[0] = Convert.ToInt32(x.Split(',')[0]); //разделение строки и запись в массив

                    try // для двух чисел
                    {
                        myArray[1] = Convert.ToInt32(x.Split(',')[1]);
                        int[] myArray_sort = myArray.OrderBy(i => i).ToArray(); // сортировка элеменов в массиве 

                        int t_min, t_max, c;
                        c = 0;
                        t_min = myArray_sort[0];
                        t_max = myArray_sort[1];
                        int[] itog2 = new int[100];// здесь нужно изменить размерность массива но не знаю как....
                        for (int i = t_min; i <= t_max; i++)
                        {
                            if (yes_pr(N: i))
                            {

                                itog2[c] = i;
                                c = c + 1;

                            }

                        }
                        itog2 = itog2.Where(x => x != 0).ToArray();// убрал 0 из массива
                        Console.WriteLine("Два числа,ввидете направление ");
                        Console.WriteLine("0-прямое направление,1-обратное ");
                        returnValue = Console.ReadLine();
                        if (One_two(returnValue))
                        {
                            Console.WriteLine(" обратное направление ");
                            Console.WriteLine(itog2[itog2.Length - 1]);  //  - первый с конца или последний элемент
                            Console.WriteLine(itog2[itog2.Length - 2]);  //  - второй с конца или предпоследний элемент
                            Console.WriteLine(itog2[itog2.Length - 3]);  //  - третий элемент с конца
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("прямое направление ");
                            Console.WriteLine(itog2[0]);
                            Console.WriteLine(itog2[1]);
                            Console.WriteLine(itog2[2]);
                            Console.ReadKey();
                        }


                    }
                    catch
                    {
                        Console.WriteLine("Сейчас работает одно число,ввидете направление ");
                        Console.WriteLine("0-прямое направление,1-обратное ");
                        returnValue = (Console.ReadLine());

                        if (One_two(returnValue))   // если введен 0
                        {
                            int o_min, o_max, c;
                            o_max = myArray[0];
                            o_min = 0;
                            c = 0;
                            int[] itog1 = new int[3];


                            for (int i = o_max; 2 >= o_min; i--)
                            {
                                if (yes_pr(N: i) && o_min <= 2)
                                {
                                    o_min = o_min + 1;
                                    itog1[c] = i;
                                    c = c + 1;
                                }




                            }
                            Console.WriteLine("Обратное направление");
                            Console.WriteLine(itog1[0]);
                            Console.WriteLine(itog1[1]);
                            Console.WriteLine(itog1[2]);
                            Console.ReadKey();

                        }
                        else
                        {
                            int o_min, o_max, c;
                            o_max = myArray[0];
                            o_min = 0;
                            c = 0;
                            int[] itog1 = new int[3];


                            for (int i = o_max; 2 >= o_min; i++)
                            {
                                if (yes_pr(N: i) && o_min <= 2)
                                {
                                    o_min = o_min + 1;
                                    itog1[c] = i;
                                    c = c + 1;
                                }




                            }
                            Console.WriteLine("Прямое направление");
                            Console.WriteLine(itog1[0]);
                            Console.WriteLine(itog1[1]);
                            Console.WriteLine(itog1[2]);
                            Console.ReadKey();
                        }
                    }
                }
                catch (Exception ex)
                { Console.WriteLine($"Возникла ошибка:{ex.Message}"); }
            }
            Console.ReadKey();
             static bool yes_pr(int N)  // проверка чиссел
            {
                
                for (int i = 2; i <= (int)(N / 2); i++)
                {
                    if (N % i == 0)
                        return false;
                }
                return true;
            } 
            
            static bool One_two(string returnValue) // проверка на ввод 0,1
            {
                if (returnValue == "1")
                {
                    return true;
                }
                else if (returnValue == "0")
                {
                    return false;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }

       
    }
}
