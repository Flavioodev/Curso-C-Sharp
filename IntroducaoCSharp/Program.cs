
        Console.WriteLine("Hello, World!");

        //alguns tipos básicos de dados em C#
        bool booleano = false;
        char genero = 'F';
        string nome = "Flávio";
        char letra = '\u0041'; //char representa os caracteres unicodes. é possível usar o código do caracter na Tabela Unicode
        byte n1 = 126;
        int n2 = 2000;
        long n3 = 19478789465L;//é recomendável usar 'L' ao final de números long
        float n4 = 4.5f;//para representar floats é OBRIGATÓRIO usar 'f' ao final do número
        double n5 = 4.5;//o double não precisa de nenhuma indicação como acontece acima
        object obj1 = 1121;
        object obj2 = "Flávio";
        object obj3 = '\u0041';//o tipo obj suporta qualquer carácter


        System.Console.WriteLine(booleano);
        System.Console.WriteLine(genero);
        System.Console.WriteLine(nome);
        System.Console.WriteLine(letra);
        System.Console.WriteLine(n1);
        System.Console.WriteLine(n2);
        System.Console.WriteLine(n3);
        System.Console.WriteLine(n4);
        System.Console.WriteLine(n5);
        System.Console.WriteLine(obj1);
        System.Console.WriteLine(obj2);
        System.Console.WriteLine(obj3);

        //funções dos tipos básicos        
        int i = int.MinValue;
        System.Console.WriteLine("Menor int: "+i);



        System.Console.WriteLine("\nTeste: ");
        int num1 = 11;
        num1 += 1;//equivale a usar "++" , ou seja, acrescenta 1
        System.Console.WriteLine(num1);
        System.Console.WriteLine("Olá, mundooooooo!");
  