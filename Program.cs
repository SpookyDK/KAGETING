class Program

{

  
  
  

  static void Main()

  {
    int[] Tal = {1, 2, 3, 3, 4, 6, 7, 1};
    Opgave1_1(3, Tal);
    Opgave1_2();
    Opgave1_3();
    Opgave3_1(new List<int> {10, 20, 30}, 40, 15);
    Opgave3_2(new List<char> {'S','n','a','k','k','e',' ','B','a','g','v','e','n','d','t'});
    Opgave4_1(new Dictionary<string, string>() {    {"kage", "Linux Terminal"}, {"docx", "Linux Terminal"},{"mp3", "Linux Terminal"},   {"flac", "Linux Terminal"},   {"Mp4", "Linux Terminal"}});
    Opgave5_1();
    Opgave6_1();
      
      
      
      
      

    

  }

static void Opgave1_1(int Mål, int[] Tal)

    {
         int zeIndex = -1;
            for (int i = 0; i < Tal.Length; i++)
            {
                if (Tal[i] == Mål)
                {
                    zeIndex = i;
                    break;
                }
            }
            Console.WriteLine("Opgave1_1" );
            Console.WriteLine(Mål);
            
        
        
    }
  
  
  
static void Opgave1_2()

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
        Console.WriteLine("Opgave1_2 =");
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

static void Opgave1_3()
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
        Console.WriteLine();
        Console.WriteLine("Opgave1_3 =");
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

static void Opgave2_2()
    {
        Console.WriteLine();
        Console.WriteLine("Opgave2_2");
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
public int KanelSnegl(int mål)
    {
        
        return 10;
    }
    //Metode er en samling af instrukser, den kan tage og 
    //returnere værdier. Skrives som void, int, double og andet. Return bruges til at afslutte og sende værdier tilbage.
    //Metoder er gode at bruge til sekvens af instrukser som skal 
    //gentages flere gange, de tillader en mere fleksibel kode og en mere vedligeholdbar kode.
static void Opgave3_1(List<int> MyList, int Tal1, int Tal2)

    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Opgave3_1");
        
        MyList.Add(Tal1);
        MyList.Insert(1, Tal2);
        foreach (var item in MyList)
        {
            Console.Write(item+", ");
        }
        MyList.Reverse();
        Console.WriteLine();
         foreach (var item in MyList)
        {
            Console.Write(item+", ");
        }
    }

static void Opgave3_2(List<char> MyList)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Opgave3_2");
    
    foreach (var item in MyList)
        {
            Console.Write(item);
        }
    Console.WriteLine();
    MyList.Reverse();
    foreach (var item in MyList)
        {
            Console.Write(item);
        }
        Console.WriteLine();
}

static void Opgave4_1(Dictionary<string, string> MyDick)
{
    Console.WriteLine();
    Console.WriteLine("Opgave4_1");
    
    Console.WriteLine("Mp4 åbenes i " + MyDick["Mp4"]);
}


static void Opgave5_1()
{
    Console.WriteLine();
    Console.WriteLine("Opgave5_1");
    Stack<int> MyStack = new Stack<int>();
    Stack<char> MyStackChar = new Stack<char>();
    string Ord = "Snakke bagvendt";
    for (int i = 1; i <= 10 ; i++)
    {
        MyStack.Push(i);
    }
    Console.WriteLine(MyStack.Pop());

    while(MyStack.Count > 0)
    {
        Console.Write(MyStack.Pop() + ", ");   
    }
    
    foreach (var item in Ord)
    {
        MyStackChar.Push(item);
    }
    Console.WriteLine();
    while(MyStackChar.Count > 0)
    {
        Console.Write(MyStackChar.Pop());   
    }
    Console.WriteLine();
}

static void Opgave6_1()
{
    Console.WriteLine();
    Console.WriteLine("Opgave6_1");

    Queue<int> MinKø = new Queue<int>();

    for (int i = 1; i <= 5; i++)
    {
        MinKø.Enqueue(i);
    }
    Console.WriteLine(MinKø.Peek());
    


}
}