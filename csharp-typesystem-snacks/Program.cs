
//snack1();
using System.Diagnostics.CodeAnalysis;

//snack2();
//snack3();
snack4();
snack5();




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
