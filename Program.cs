class Program

{

  
  

  static void Main()

  {
    
      Thread thr1 = new Thread(Opgave11);
      Thread thr2 = new Thread(Opgave12);
      Thread thr3 = new Thread(Opgave13);
      Thread thr4 = new Thread(Opgave22);
      thr1.Start();
      thr2.Start();
      thr3.Start();
      //thr4.Start();
     

  }

  static void Opgave11()

    {
        int[] Tal = {1, 4, 6 ,7 , 3, 3, 1};
        int Mål = 11;

    
        for (int i = 0; i < Tal.Length; i++)
        {
            if (Tal[i] == Mål)
                {
                    Console.Write(" Opgave 1 = " + i);
                    goto Complete;
                }
        }
        Console.Write(" Opgave 1 = NONE");
        Complete:;
    
    
    }
  
  
  
    static void Opgave12()

    {
       int Fund = 0;
       int indexgoal = 5;
       int[] Array = {1, 2, 3, 4, 5, 6 ,7 ,8 ,9 ,10};
       int[] ArrayRemoved = new int[Array.Length - 1];


       for (int i = 0; i < Array.Length; i++)
       {
            if (i != indexgoal)
            {
                ArrayRemoved[i - Fund] = Array[i];
            }
            else 
            {
                Fund = 1;
            }
       }
        Console.WriteLine();
        Console.WriteLine("Opgave2 =");
       foreach (var item in Array)
       {
        Console.Write(item + ", ");
       }
       Console.WriteLine();
       foreach (var item in ArrayRemoved)
       {
        Console.Write(item + ", ");
       }
    

    
    
    }

    static void Opgave13()
    {
       int Fund = 0;
       int indexgoal = 5;
       int Indsæt = 4;
       int[] Array = {1, 2, 3, 4, 5, 6 ,7 ,8 ,9 ,10};
       int[] ArrayRemoved = new int[Array.Length + 1];


       for (int i = 0; i < Array.Length; i++)
       {
            if (i != indexgoal)
            {
                ArrayRemoved[i] = Array[i - Fund];
            }
            else 
            {
                ArrayRemoved[i] =  Indsæt;
            }
       }
        Console.WriteLine();
        Console.WriteLine("Opgave3 =");
       foreach (var item in Array)
       {
        Console.Write(item + ", ");
       }
       Console.WriteLine();
       foreach (var item in ArrayRemoved)
       {
        Console.Write(item + ", ");
       }
    }

    static void Opgave22()
    {
        int Mål = 8;
        int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        int Pos = array.Length / 2;
        while (array[Pos] != Mål)
        {
            if (Mål > array[Pos])
            {
                Pos = Pos + array.Length / 2;
                Console.WriteLine(Pos);
            }
            if (Mål < array[Pos])
            {
                Pos = Pos / 2;
                Console.WriteLine(Pos);
            }

        }
        Console.WriteLine("opgave22 er " + Pos);
        

    }

}