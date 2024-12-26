using System.Collections.Specialized;

namespace assignment4_solution
{
    internal class Program
    {
        #region passing by value Example
        //static void Swap( int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //} 
        #endregion

        #region pass by ref Example
        //static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //} 
        #endregion

        #region pass by reference type
        //public static int SumArray( int[] arr)
        //{
        //    int sum = 0;
        //    arr = new int[] { 14, 51, 61 };
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        //public static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr = new int[] { 14, 51, 61 };
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        #endregion

        #region Q3
        //static  void SumAndSubstraction(int Number1, int Number2,out int Sum,out int Sub) 
        //  {
        //      Console.WriteLine("Enter Number1 : ");
        //      Number1=int.Parse(Console.ReadLine());
        //      Console.WriteLine("Enter Number2 : ");
        //      Number2 =int.Parse(Console.ReadLine());

        //      Sum=Number1+ Number2;
        //      Sub = Number1 - Number2;
        //      Console.Write($"The Sum Is: {Sum}" );
        //      Console.WriteLine();
        //      Console.Write($"The Substruction Is: {Sub}");
        //  } 
        #endregion

        #region Q4
        //Q4
        //static int Check_individual()
        //{
        //    Console.Write("Enter Number: ");
        //    int Number= int.Parse(Console.ReadLine());
        //    if (Number % 2 == 0)
        //        return 0;
        //    else
        //        return Number;
        //}
        //static void Calculate_Sum_Individual(int Number)
        //{
        //    int Sum = 0;
        //    int Reaminder = 0;
        //    for(int i = 0; i <= Number; i++)
        //    {
        //        Reaminder = Number % 10;
        //        Number/=10;
        //        Sum += Reaminder;


        //    }
        //    Console.WriteLine($"The sum of the digits of the number {Reaminder} is {Sum}");

        //} 
        #endregion

        #region Q5
        //Q5
        //static bool Is_Prime(int number)
        //{
        //    Console.Write("Enter Number: ");
        //    number=int.Parse(Console.ReadLine());
        //    if (number == 2)
        //        return true;
        //    else if (number < 2 || number % 2 == 0)
        //        return false;
        //    else 
        //    {
        //        for(int i = 3; i <= number / 2; i += 2)
        //        {
        //            if(number % 1==0)
        //                return false;
        //        }
        //    }
        //    return true;

        //} 
        #endregion

        #region Q6
        ////Q6
        //static void Check_Minimum_Maxmum(int Number,ref int Min,ref int Max)
        //{
        //    int[] arr = new int[5];
        //    Min = arr[0];
        //    Max = arr[0];
        //    Console.WriteLine("Enter Numbers");
        //    for(int i=0;i<arr.Length;i++)
        //    {
        //        Number=int.Parse(Console.ReadLine());
        //        arr[i] = Number;
        //        if(arr[i] > Max)
        //            Max = Number;
        //        else if(arr[i] < Min)
        //            Min = Number;


        //    }
        //    Console.WriteLine($"Min: {Min} ");
        //    Console.WriteLine($"Max: {Max}");


        //} 
        #endregion

        #region Q7
        //static int Factorial_Number(int number)
        //{
        //    int Multiply = 1;
        //    for(int i=1;i<=number;i++)
        //    {
        //        Multiply *= i;
        //    }
        //    return Multiply;
        //} 
        #endregion

        //Q8
        static string Read_string()
        {
            string message=Console.ReadLine();
            return message;
        }
        static char Replace_Letter(char[] Letters,string Read)
        {
            for (int i = 0; i < Read.Length; i++)
            {
                if (Read[0] == 'h')
                    Letters[0] = 'w';
            }
            return Letters[0];

        static void Main()
        {
                #region Q1 Passing by value in case value type 
                //Passing by value in case value type 
                //passing by value is not affects of parameters and variables
                //inside the function and it can't change the parameters value 
                //int A = 4, B = 5;
                //Console.WriteLine($"A: {A}");
                //Console.WriteLine($"B: {B}");
                //Console.WriteLine("-----------After Swap--------------");
                //Swap( A, B);
                //Console.WriteLine($"A: {A}");
                //Console.WriteLine($"B: {B}");


                #endregion

                #region Q1 Passing by reference in case value type
                //Passing by reference in case value type
                //pass by ref is:- the same momery location is used for both variables
                //it can affects on the parameters becouse same the address

                //int A = 4, B = 5;
                //Console.WriteLine($"A: {A}");
                //Console.WriteLine($"B: {B}");
                //Console.WriteLine("----------After Swap-------------------");
                //Swap(ref A, ref B);
                //Console.WriteLine($"A: {A}");
                //Console.WriteLine($"B: {B}");
                #endregion

                #region Q2 Passing by value in case reference type
                //Passing by value in case reference type
                //in that case no would difference between pass by val and ref 
                //but in some cases would difference between their
                //examples
                // here would difference 
                //int[] Numbers = { 11, 8, 13 };
                //Console.WriteLine(SumArray(Numbers));
                //Console.WriteLine(Numbers[0]);

                //passing by ref in case reference type
                //int[] Numbers = { 11, 8, 13 };
                //Console.WriteLine(SumArray(ref Numbers));
                //Console.WriteLine(Numbers[0]);

                #endregion

                #region Q3
                //Q3
                //int a=0, b=0, c, d;

                //SumAndSubstraction(a, b,out c,out d);

                #endregion

                #region Q4
                //Q4

                //int Number = Check_individual();
                //Calculate_Sum_Individual(Number); 
                #endregion

                #region Q5
                ////Q5
                //    int Number = 0;
                //    Console.WriteLine(Is_Prime(Number)); 
                #endregion

                #region Q6
                //int Number = 0,min=0,max=0;
                //Check_Minimum_Maxmum(Number,ref min,ref max); 
                #endregion

                #region Q7
                ////Q7
                //int Number = int.Parse(Console.ReadLine());
                //Console.WriteLine(Factorial_Number(Number)); 
                #endregion

                #region Q8
                string message=Read_string();
                char[] Letters=;
                Replace_Letter(Letters, message);
                #endregion

            }
    }
}
