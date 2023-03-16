
//snack1();
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Seleziona uno degli snack da 1 a 12");
int inputSnack = Convert.ToInt16(Console.ReadLine());
switch (inputSnack)
{
    case 1:
        snack1();
        break;
    case 2: 
        snack2();
        break;
        case 3: snack3();
        break;
        case 4: snack4();
        break;
        case 5: snack5();
        break;
        case 6: snack6();   
        break;
        case 7: snack7();
        break;  
        case 8: snack8();
        break;  
        case 9: snack9();
        break;  
        case 10: snack10();
        break;  
            case 11: snack11();
        break;  
            case 12: snack12();
        break;

            
}




void snack1()
{
    Console.WriteLine("Dimmi il Primo numero:");
    int n1 =   Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Dimmi il Secondo numero:");
    int n2 = Convert.ToInt16(Console.ReadLine());
    if(n1 > n2)
    {
        Console.WriteLine(n1);
    }
    else if (n1 == n2)
    {
        Console.WriteLine("I numeri sono uguali");    }
    else{
        Console.WriteLine(n2);
    }
}
void snack2()
{
    Console.WriteLine("Dimmi la prima parola:");
    string word1 = Console.ReadLine() ?? "";
    Console.WriteLine("Dimmi la seconda parola:");
    string word2 = Console.ReadLine() ?? "";
    if(word1.Length > word2.Length)
    {
        Console.WriteLine(word2);
        Console.WriteLine(word1);
    }
    
}
void snack3()
{
   
    int somma = 0;
    for(int i = 1; i <= 10; i++)
    {
        Console.WriteLine("Dammi un numero");
        int inputnumber =   Convert.ToInt16(Console.ReadLine());
        somma += inputnumber;
    }
    Console.WriteLine("La somma dei numberi è" + "" +  somma);
}
void snack4()
{
    int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int somma = 0;
    for( int i = 0; i < numbers.Length; i++)
    {
         somma += numbers[i];
        
    }
    int media = somma / numbers.Length;
    Console.WriteLine(somma);
    Console.WriteLine(media);
}
void snack5()
{
    Console.WriteLine("Dammi un numero");
    int inputnumber = Convert.ToInt16(Console.ReadLine());
    if(inputnumber % 2 == 0)
    {
        Console.WriteLine(inputnumber);
    }
    else
    {
        Console.WriteLine(inputnumber + 1);
    }
}
void snack6()
{
    string[] invitati = { "Camillo", "Ludovico", "Michele", "Andrea", "Luca", "Marco" };
    Console.WriteLine("Qual è il tuo nome?");
    string inputName = Console.ReadLine() ?? "";
    if (invitati.Contains(inputName))
        {
        Console.WriteLine("Puoi Entrare");
    }
    else
    {
        Console.WriteLine("Non sei presente nella lista");
    }

   
}
void snack7()
{
    int[] numbers = new int [6];
    for (int i = 0; i < numbers.Length;i++)
    {
        Console.WriteLine("Dammi un numbero");
    int inputnumber = Convert.ToInt16(Console.ReadLine());
        if (inputnumber % 2 == 0)
        {
            numbers[i] = inputnumber;
        }
        else
        {
            Console.WriteLine("Il numero non è pari");
        }
    }
    for (int i =0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }

}
void snack8()
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
    int somma = 0;
    for (int i = 0;i < numbers.Length;i++)
    {
        if(i% 2 != 0)
        {
            somma += numbers[i];
        }
    }
    Console.WriteLine(somma);
}
void snack9()
{
    int[] arrNumbers = new int[50];
    int somma = 0;
    int index = 0;
    while (index < 50)
    {
        Console.WriteLine("Dammi un numero?");
        int inputnumber = Convert.ToInt16(Console.ReadLine());
         arrNumbers[index] = inputnumber;
         somma += inputnumber;
         index += somma; 
        Console.WriteLine(somma);
    }
}
void snack10()
{
    int N = Convert.ToInt32(Console.ReadLine());
    var random = new Random();
    for(int i = 0; i < N; i++)
    {
        var ints = new int[10];
        for(int j = 0; j < 10; j++)
        {
            ints[j] = random.Next(1, 100);
        }
        foreach(var num in ints)
        {
            Console.Write($"{num}");
        }
        Console.WriteLine();
    }
}
void snack11()
{
    Console.WriteLine("Dimmi la Prima Parola:");
    string inputWord1 = Console.ReadLine() ?? "";
    Console.WriteLine("Dimmi la Seconda Parola:");
    string inputWord2 = Console.ReadLine() ?? "";
    wordLenght(inputWord1 , inputWord2);
   
void wordLenght(string word1, string word2)
{
    if (word1.Length == word2.Length)
    {
        Console.WriteLine(word1 + word2);
    }
    else if (word1.Length > word2.Length)
    {
        Console.WriteLine(word1);
    }
    else
    {
        Console.WriteLine(word2);
    }
}
   
}
void snack12()
{
    Console.WriteLine("Dimmi un numero");
    int inputnumber = Convert.ToInt16(Console.ReadLine());
    checkNumber(inputnumber); 
    void checkNumber(int num)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine("Il numero è pari");
        }
        else
        {
            Console.WriteLine("Il numero è dispari"); 
        }
    }
}
