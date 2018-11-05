using System;

namespace Torres
{
    class Program
    {
        static void TorresHanoi( int o, int n, int v, int aux)
        {
            if(n>0)
            {
                TorresHanoi(n-1, o, aux, v);
                Console.WriteLine("Se mueve anillo desde torre"+ o +" hasta torre "+v);
                TorresHanoi(n-1, aux, v, o);
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Favor de ingresar cantidad de anillos: ");
            n = int.Parse(Console.ReadLine());
            TorresHanoi(n, 1,3,2);
            Console.ReadKey();
        }
    }
}
