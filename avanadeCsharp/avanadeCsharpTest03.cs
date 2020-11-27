using System;

public class  Desafio {
 
public static void Main(string[] args)
        {
       int n, chico, bento, bernardo, marina, iara, marlene, total;

           n = int.Parse(Console.ReadLine());
		 if (n == 0)
             chico = 300;
            else
        chico = 300 * n;
		           n = int.Parse(Console.ReadLine());
		 if (n == 0)
             bento = 1500;
            else
        bento = 1500 * n;
		
		 n = int.Parse(Console.ReadLine());
		 if (n == 0)
             bernardo = 600;
            else
        bernardo = 600 * n;
		
				 n = int.Parse(Console.ReadLine());
		 if (n == 0)
             marina = 600;
            else
        marina = 1000 * n;
				
				 n = int.Parse(Console.ReadLine());
		 if (n == 0)
             iara = 150;
            else
        iara = 150 * n;
		

        marlene = 225;
        total = (chico+bento+bernardo+marina+iara+marlene); // Digite aqui o calculo total
        Console.WriteLine(total);
    }
}