using System;

namespace Aorcado_5_9_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ahorcado();
        }

         public static void ahorcado()
        {
            string le="",a="";
            string cantidad = "";
            int intentos = 7, k=0;
            string incomnita = "";
            string contesta = "";
            bool pal = false;

            string[] palabra=new string[10];
            palabra[0] = "Brasil";
            palabra[1] = "Francia";
            palabra[2] = "Espana";
            palabra[3] = "Ingleterra";
            palabra[4] = "Suiza";
            palabra[5] = "China";
            palabra[6] = "Japon";
            palabra[7] = "Estados Unidos";
            palabra[8] = "Rapublica Dominicana";
            palabra[9] = "Puerto Rico";

            Random vector = new Random();
            k = vector.Next(0, 10);

            for (int i=0;i<=palabra[k].Length-1;i++)
            {
                if (palabra[k]!=" ") {
                    incomnita = incomnita + "-";
                }
                else
                {
                    incomnita = incomnita + " ";
                }
            }
            //intentos = incomnita.Length;
            do
            {
                Console.WriteLine("Introduse una letra");
                contesta = Convert.ToString(Console.ReadLine());
                for (int j=0;j<=palabra[k].Length-1;j++) {
                    le = palabra[k].Substring(j,1);
                    if (le.Equals(contesta))
                    {
                        

                       incomnita=incomnita.Remove(j,1);
                        incomnita = incomnita.Insert(j, contesta);

                       cantidad = incomnita;
                       Console.WriteLine( cantidad);

                        pal = true;
                    }
                    
                    
                      
                }
                if (pal)
                {
                    
                    Console.WriteLine("Exelente continua aun tienes "+intentos+" intentos");
                    pal = false;
                }
                else
                {
                    intentos--;
                    Console.WriteLine("Ahora Solo te quedan " + intentos + " intentos");
                }
                while ((a!="c") & (a!="s")) {

                    Console.WriteLine("Precione 'c'para continuar o 's' para terminar. ");
                    a = Console.ReadLine();
                    switch (a)
                    {
                        case "c":
                            Console.Clear();
                            
                            break;
                        case "s":
                            intentos = 0;
                            break;
                        default:
                            Console.WriteLine("Debe elegir una de las dos  opciones.");
                            break;
                    }
                    
                }
                a = " ";
                Console.WriteLine(cantidad);
            } while (palabra[k] != cantidad & intentos != 0);

            if (palabra[k]==cantidad)
            {
                Console.WriteLine("Felicidades has completado la palabra "+palabra[k]);
            }else if (intentos==0)
            {
                Console.WriteLine("lo cinento has fracasado tienes "+intentos+" intentos");
            }
        }
    }
}
