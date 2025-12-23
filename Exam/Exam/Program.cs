
namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------- 1-Masala  ------------


            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(GetEvenElements(list1));


            //------------------------------- 2-Masala --------------



            List<string> list2 = new List<string>() { "Salom", "Pdp", "Universitiy", "AkobirUstozN1" };

            Console.WriteLine(GetElementsHaigherLenthThanFive(list2));



            //------------------------------- 3-Masala --------------


            Console.WriteLine(ReturnThreeSign("Hello World"));



            //------------------------------- 4-Masala  ------------


            Console.WriteLine(GetFalseOrTrue("PDPuniversitiy"));


            //------------------------------- 5-Masala  ------------



            Console.WriteLine(IsG13Contains(" G13 Guruhi pdp da oqiydi"));





            //------------------------------- 6-Masala  ------------

            List<int> list5 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(SumOfFirstTwo(list5));

        }




        //------------------------------- 1-Masala  ------------

        static int GetEvenElements(List<int> list1)
        {
            int count = 0;

            for (int i = 0; i < list1.Count; i++)
            {

                if (list1[i] % 2 == 0)
                {
                    count++;
                }

            }

            return count;
        }





        //-------------------------------- 2-Masala -----------




        static bool GetElementsHaigherLenthThanFive(List<string> list2)
        {
            var resCount = 0;

            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i].Length > 5)
                {
                    resCount++;
                }
            }
            if (resCount == list2.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //------------------------------- 3-Masala  ------------


        static string ReturnThreeSign(string str)
        {
            return str.Substring(0, 3);
        }






        //------------------------------- 4-Masala  ------------



        static bool GetFalseOrTrue(string str)
        {
            if (str.StartsWith("PDP"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        //------------------------------- 5-Masala  ------------

        static bool IsG13Contains(string str)
        {
            if (str.Contains("G13"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        //------------------------------- 6-Masala  ------------


        static int SumOfFirstTwo(List<int> list)
        {
            int sum = 0;

            sum = list[0] + list[1];

            return sum;
        }


    }
}
