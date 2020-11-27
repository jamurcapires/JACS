using System;

class Desafio {
    static void Main() {
		int n;
		       n = int.Parse(Console.ReadLine());
        int quilometros = n;
        int minutos = quilometros * 60;
		double resultado = n*2;// Digite aqui o calculo dos minutos
        Console.WriteLine(resultado + " minutos");
    }
}