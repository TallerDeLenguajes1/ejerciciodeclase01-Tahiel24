using System;

namespace Problema03
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Auto Auto1 = CrearAutoFiat(2020);
                MostrarAuto(Auto1);

                Auto Auto2 = CrearAutoPeugeot();
                MostrarAuto(Auto2);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("System: Object reference not set to an instance of an object.");
            }



        }

        static Auto CrearAutoFiat(int? anio = null)
        {
            Auto auto = null;

            if (anio != null)
            {
                auto = new Auto()
                {
                    Anio = anio.Value,
                    Modelo = "Fiat"
                };
            }

            return auto;
        }

        static Auto CrearAutoPeugeot(int? anio = null)
        {
            Auto auto = null;

            if (anio != null)
            {
                auto = new Auto()
                {
                    Anio = anio.Value,
                    Modelo = "Peugeot"
                };
            }

            return auto;
        }

        static void MostrarAuto(Auto auto)
        {
            Console.WriteLine("{0} - {1}", auto.Modelo, auto.Anio);
            Console.ReadLine();
        }
    }
}
