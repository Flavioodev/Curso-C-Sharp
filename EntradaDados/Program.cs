using System.Globalization;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//TRABALHANDO COM STRINGS

System.Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();
System.Console.WriteLine("\nA frase digitada é: " + frase);


System.Console.WriteLine("digite os dois valores do primeiro Array:");
string a = Console.ReadLine();
string b = Console.ReadLine();

string[] array1 = new string[2];
array1[0] = a;
array1[1] = b;

Console.WriteLine("IMPRIMINDO OS ELEMENTOS DO ARRAY");
foreach(var varreArray in array1)
{
    Console.WriteLine(varreArray);
}


//usando o split
Console.WriteLine("Digite uma frase para o segundo Array: ");
String s = Console.ReadLine();

string[] array2 = s.Split(" ");

foreach (var varreArray in array2)
{
    Console.WriteLine(varreArray);
}


//criando o array e lendo seus valores ao mesmo tempo
Console.WriteLine("Digite uma frase para completar o terceiro Array");
string[] array3 = Console.ReadLine().Split(" ");
foreach (var varreArray in array3)
{
    Console.WriteLine(varreArray);
}