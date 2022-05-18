using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //İsArrayContains methodu var parametr olaraq iki int arrayi alır və ikinci arrayın birinci arrayin daxilində olub olmadığın qaytarır. Məsələn: arr1 = [2,3,4,7]
            // arr2 = [3, 2, 7]-> false

            //arr1 = [2, 3, 4, 7]
            //arr2 = [3, 4]-> true
                int[] firstArr = { 2, 3, 4, 7 };
                int[] secondArr = { 2,3 };

                Console.WriteLine(IsArrayContains(firstArr, secondArr));

            }
            static bool IsArrayContains(int[] Arr1, int[] Arr2)
            {
                string ConvertFirstArr = string.Join(",", Arr1);
                string ConvertSecArr = string.Join(",", Arr2);
                
                 if (ConvertSecArr.Length <= ConvertFirstArr.Length)
                {
                     if (ConvertFirstArr.Contains(ConvertSecArr))
                        return true;
                }
                return false;
            }
        }

        }

