using System;

namespace Variable_Constants_For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Milestone1();
            //Milestone2();
            Milestone3();
        }

        static void Milestone1()
        {
            // fase1
            string nom = "victor";
            string cognom = "alfonso";
            string cognom2 = "marti";
            int dia = 19;
            int mes = 11;
            int any = 1993;

            Console.WriteLine("{0} {1}, {2}", nom, cognom, cognom2);

            Console.WriteLine("{0}/{1}/{2}", dia, mes, any);

            // fase 2
            const int anyTraspas = 1948;
            int quantTraspas = 4;
            int cantitatTraspas = (any - anyTraspas) / quantTraspas; // calculem quantitat de anys de traspas hi ha

            Console.WriteLine(cantitatTraspas);


            // fase 3
            Boolean naixementTraspas = false;
            Console.WriteLine("Anys de traspàs:");
            for (int x = anyTraspas; x <= any; x+=4) //salts de 4 en 4 per printar els anys.
            {
                Console.WriteLine(x);
                if (x == any)
                {
                    naixementTraspas = true; //si coincideix amb l'any naixement = true
                }
            }

            string siEs = "{0} Sí es any de traspàs.";
            string noEs = "{0} No es any de traspàs.";

            
            if (naixementTraspas) Console.WriteLine(siEs, any); //si true printem
            else Console.WriteLine(noEs, any);

            // fase 4
            Console.WriteLine("-----------------------------");
            string nomTotJunt = nom + " " + cognom + " " + cognom2;
            string dataTotJunt = dia + "/" + mes + "/" + any;
            Console.WriteLine(nomTotJunt + "\n" + dataTotJunt);
            if (naixementTraspas) Console.WriteLine(siEs, any); //si true printem
            else Console.WriteLine(noEs, any);
            Console.WriteLine("-----------------------------");
        }

        public static void Milestone2()
        {
            Double var1 = 0.1234;
            int var2 = (int) var1;
            float var3 = (float) var1;
            string var4 = Convert.ToString(var1);

            Console.WriteLine("Double: {0}", var1);
            Console.WriteLine("Int: {0}", var2);
            Console.WriteLine("Float: {0}", var3);
            Console.WriteLine("String: {0}", var4);
        }

        public static void Milestone3()
        {
            int[] cadena = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("[{0}]", string.Join(", ", cadena));

            // variable auxiliar
            int auxiliar;

            for (int x=0; x<=(cadena.Length/2); x++) // hacemos for hasta la mitad del tamaño del array para no hacer efecto doopler. 
            {
                auxiliar = cadena[x]; // asignamos ultimo valor al auxiliar
                cadena[x] = cadena[9 - x]; //modificamos el valor de la posicion que acabamos de guardar
                cadena[9 - x] = auxiliar; // pegamos el valor guardado de donde hemos sacado el valor en el cambio anterior
            }

            Console.WriteLine("[{0}]", string.Join(", ", cadena));
        }


    }
}
