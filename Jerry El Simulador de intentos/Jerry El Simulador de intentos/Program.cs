using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jerry_El_Simulador_de_intentos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salio = false, frustro = false;
            int intentar = 0, salir = 0, count = 0, auto = 0;
            Random ran = new Random();

            while(intentar==0)
            {
                if(count ==0)
                    Console.WriteLine("Jerry esta intentando algo y...");

                //el resto de auto si es igual a 0 es par, sino es inpar
                auto = ran.Next(1, 10);
                if (auto % 2 == 0)
                    salio = true;
                else
                    salio = false;

                if (salio)
                {
                    if(count>0)
                    {
                        if(count==1)
                        {
                            Console.WriteLine("Ha intentado 1 vez y le ha salido muy bien, sigue aprendiendo algo nuevo!");
                        }
                        else
                        {
                            Console.WriteLine($"Ha intentado {count} veces y le ha salido muy bien, sigue aprendiendo algo nuevo!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Le ha salido bien, es habilidoso en lo que hace!");
                    }
                    salir = 1;
                }
                else
                {
                    auto = ran.Next(1, 10);
                    if (auto % 2 == 0)
                        frustro = true;
                    else
                        frustro = false;

                    if (frustro)
                    {
                        if (count > 0)
                        {
                            if (count == 1)
                            {
                                Console.WriteLine("Ha intentado 1 vez y le ha salido muy mal, se frustra y se deprime... No ha soportado el fallar y muere!");
                            }
                            else
                            {
                                Console.WriteLine($"Ha intentado {count} veces y le ha salido muy mal, se frustra y se deprime... No ha soportado el fallar y muere!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Le ha salido muy mal, se frustra y se deprime... No ha soportado el fallar y muere!");
                        }
                        salir = 1;
                    }
                    else
                    {
                        Console.WriteLine("Le ha salido muy mal, se siente muy mal pero sigue intentandolo!");
                        count++;
                    }
                }

                while(salir==1)
                {
                    Console.WriteLine("¿Quieres continuar con la simulación ? ");
                    string rta = Console.ReadLine();
                    switch(rta)
                    {
                        case "si":
                            count = 0;
                            salir = 0;
                            break;
                        case "Si":
                            count = 0;
                            salir = 0;
                            break;
                        case "no":
                            intentar = 1;
                            salir = 0;
                            break;
                        case "No":
                            intentar = 1;
                            salir = 0;
                            break;
                    }
                }
            }
        }
    }
}
