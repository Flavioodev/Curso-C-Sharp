int a = 10;

bool c1 = a < 10;
bool c2 = a < 25;
bool c3 = a > 6;

System.Console.WriteLine(c1);
System.Console.WriteLine(c2);
System.Console.WriteLine(c3);

System.Console.WriteLine("--------------------------");

bool c4 = a <= 10;
bool c5 = a >= 10;
bool c6 = a == 10;
bool c7 = a != 10;

System.Console.WriteLine(c4);
System.Console.WriteLine(c5);
System.Console.WriteLine(c6);
System.Console.WriteLine(c7);

System.Console.WriteLine("\nOperadores Lógicos");

bool l1 = 2 > 3 && 4!=5;
System.Console.WriteLine(l1);

//ordem de precedência dos operadores lógicos:
// not(!) and(&&) or(||): as iniciais formam a palavra nao
bool l2 = c1 || c2 && c3;

