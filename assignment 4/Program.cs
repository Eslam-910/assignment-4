namespace assignment_4
{
    //classes --> functions
    //struct  --> functions
    //interface --> functions
    //enum --> functions
    internal class Demo
    {
        #region functions and parameters
        //static void PrintShapes()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("*_*");
        //    }
        //}

        //static void PrintShapes(int Count)
        //{
        //    for (int i = 1; i <=Count; i++)
        //    {
        //        Console.WriteLine("*_*");
        //    }
        //}
        //static void PrintShapes(string pattern,int count=4)
        //{
        //    for (int i = 1; i <= count; i++)
        //    {
        //        Console.WriteLine(pattern);
        //    }
        //}
        //static int SumNumber(int Number1,int Number2)
        //  {
        //      return Number1 + Number2;
        //  }
        //static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;

        //} 
        #endregion
        //public static int SumArray(int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for(int i=0;i<arr.Length;i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        //public static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        //public static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr = new int[] { 4, 5, 6 };
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}



        static void Main()
        {
            #region 1D Array
            //int[] Numbers;
            //declare for reference from type 'Array Of Integers'
            //Numbers : can refer to object from type 'Array Of Integers'
            //Numbers : refer to null

            //Numbers = new int[5];
            //allocated the numbers of required bytes for the object at Heap(4 Bytes*5)
            //initialized the alocated of bytes with default value of the datatypes
            //user defind constructor of exisits
            //assign the object to referene Numbers
            //Numbers[0] = 12;
            //Numbers[1] = 6;
            //Numbers[2] = 7;
            //Numbers[3] = 11;
            //Numbers[4] = 19;
            //Numbers[5] = 15; out of range
            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);
            //int[] Number01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] Number02 = new int[5] { 1, 2, 3, 4, 5 };
            //for(int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.Write($"Enter Numbers [{i}]: ");
            //    Numbers[i]=int.Parse( Console.ReadLine() );
            //}

            //Console.WriteLine("==================================");
            //for(int i=0; i< Numbers.Length; i++)
            //{
            //    Console.WriteLine($"{Numbers[i]}");
            //} 
            #endregion

            #region 2D Array
            //2D Array
            //int[,] Marks = new int[3,3];
            //Marks[0, 0] = 99;
            //Marks[0, 1] = 99;
            //Marks[0, 2] = 99;

            //Marks[1, 0] = 63;
            //Marks[1, 1] = 100;
            //Marks[1, 2] = 70;

            //Marks[2, 2] = 40;
            //Marks[2, 0] = 50;
            //Marks[2, 1] = 93;

            //Console.WriteLine(Marks[0, 0]);
            //Console.WriteLine(Marks[0, 1]);
            //Console.WriteLine(Marks[0, 2]);

            //Console.WriteLine(Marks[1, 0]);
            //Console.WriteLine(Marks[1, 1]);
            //Console.WriteLine(Marks[1, 2]);

            //Console.WriteLine(Marks[2, 0]);
            //Console.WriteLine(Marks[2, 1]);
            //Console.WriteLine(Marks[2, 2]);


            //for(int i = 0; i <3; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Marks[i,j]=int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("=============================");

            //for(int i = 0;i < 3; i++)
            //{
            //    for (int j = 0;j < 3; j++)
            //    {
            //        Console.Write($"{Marks[i, j]} "  );
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region juddge Array
            // juddge Array
            //int[][] Marks = new int[3][];
            //Marks[0] = new int [] { 1, 2, 3 };
            //Marks[1] = new int[] { 1, 2 };
            //Marks[1] = new int[] { 1, 2 , 3 ,4 };

            //Marks[0]=new int[3];
            //Marks[1]=new int[5];
            //Marks[2]=new int[2];
            // for(int i = 0; i < 3; i++)
            // {
            //    for(int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Marks[i][j] =int.Parse(Console.ReadLine());
            //    }
            // }
            //Console.WriteLine("===================================");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write($"{Marks[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Functions
            //Functions : block of code that have name if need to excute this code
            //you need call function by the name 
            //function prototype
            //1.signature
            //1.1name 
            //1.2Return Value
            //1.3parameters
            //2.Body(code)

            //PrintShapes(5,"****"); passing by order
            //PrintShapes(pattern: "%_%", count: 6); passing by name
            //PrintShapes("$#*$");
            //Console.WriteLine(SumNumber(5, 4)); 
            #endregion

            #region pass by value and ref in value type
            //int A=4,B=5;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");
            //Console.WriteLine("After Swap");
            //Swap(A,B);
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //int A = 4, B = 5;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");
            //Console.WriteLine("After Swap");
            //Swap(ref A,ref B);
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            #endregion

            #region Pass by value and ref in reference type
            //pass ref type
            //1.passing by value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));

            //2.passing by reference
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers)); 
            #endregion

            //passing Parameter refernce type Ex02
            //by value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);

            //by ref
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);


        }
    }
}
