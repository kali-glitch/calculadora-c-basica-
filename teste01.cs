using System;

class Teste01{
    static void Main(string[] args)
    {
        double m1,m2,m3,s1,s2,s3,d1,d2,d3,su1,su2,su3;
        Console.WriteLine("Escolha uma opção: \n[ 0 ] mutiplicar\n[ 1 ] somar\n[ 2 ] dividir\n[ 3 ] subtrair\n[ 4 ] sair: ");
        string ok = Console.ReadLine();
        if (ok == "4"){
            Console.WriteLine("ENCERRADO...");
        }
        if (ok == "0"){
        Console.WriteLine("MUTIPLICAR");
        Console.Write("Primeiro valor: ");
        m1 = int.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        m2 = int.Parse(Console.ReadLine());
        m3 = (m2 * m1);
        Console.WriteLine("{0} x {1} = {2}",m1,m2,m3);
        Console.WriteLine("Escolha uma opção: \n[ 0 ] mutiplicar\n[ 1 ] somar\n[ 2 ] dividir\n[ 3 ] subtrair\n[ 4 ] sair: ");
        string ok1 = Console.ReadLine();
        ok = ok1;
        }
        if (ok == "2"){
        Console.WriteLine("DIVIDIR");
        Console.Write("Primeiro valor: ");
        d1 = int.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        d2 = int.Parse(Console.ReadLine());
        d3 = (d1 / d2);
        Console.WriteLine("{0} : {1} = {2}",d1,d2,d3);
        Console.WriteLine("Escolha uma opção: \n[ 0 ] mutiplicar\n[ 1 ] somar\n[ 2 ] dividir\n[ 3 ] subtrair\n[ 4 ] sair: ");
        string ok2 = Console.ReadLine();
        ok = ok2;
        }
        if (ok == "1"){
        Console.WriteLine("SOMAR");
        Console.Write("Primeiro valor: ");
        s1 = int.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        s2 = int.Parse(Console.ReadLine());
        s3 = (s2 + s1);
        Console.WriteLine("{0} + {1} = {2}",s1,s2,s3);
        Console.WriteLine("Escolha uma opção: \n[ 0 ] mutiplicar\n[ 1 ] somar\n[ 2 ] dividir\n[ 3 ] subtrair\n[ 4 ] sair: ");
        string ok3 = Console.ReadLine();
        ok = ok3;
        }
        if (ok == "3"){
        Console.WriteLine("SUBTRAIR");
        Console.Write("Primeiro valor: ");
        su1 = int.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        su2 = int.Parse(Console.ReadLine());
        su3 = (su1 - su2);
        Console.WriteLine("{0} x {1} = {2}",su1,su2,su3);
        Console.WriteLine("Escolha uma opção: \n[ 0 ] mutiplicar\n[ 1 ] somar\n[ 2 ] dividir\n[ 3 ] subtrair\n[ 4 ] sair: ");
        string ok4 = Console.ReadLine();
        ok = ok4;
        }
    }
}
