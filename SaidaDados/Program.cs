using System.Globalization;
// Este código mostrará, entre outras coisas, como gerenciar o número de casas em um float

//diferença entre Write e WriteLine

System.Console.WriteLine("J. K.");//impressão com quebra de linhas
System.Console.WriteLine("Rowling\n");

System.Console.Write("J. K.");//impressão SEM quebra de linhas
System.Console.WriteLine("Rowling\n");


//para determinar o número de casas decimais em um float

float num1 = 1.56849F;//é preciso acrescentar F ao final do número em tipos float
System.Console.WriteLine("Float: "+num1.ToString("F3")+"\n");//basta usar o .ToSting() e o F junto do número de casas. O método converte para String



System.Console.WriteLine("Como usar PlaceHolder: ");
String nome = "Flávio";
int idade = 21;
float saldo = 0.51464887F;
System.Console.WriteLine("{0} tem {1} anos e {2:F2} reais",nome,idade,saldo);

double novoSaldo = 100.15486;
System.Console.WriteLine("{0} tem {1} anos e {2:F2} reais\n",nome,idade,novoSaldo);//o controle de casas decimais funciona igual para float e double


System.Console.WriteLine("Como usar Interpolação: ");
System.Console.WriteLine($"{nome} tem {idade} e {saldo:F2} reais");//a Interpolação é MAIS 'CURTA' que o PlaceHolder
