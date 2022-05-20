using System;

namespace FirstProjet
{
    class Program
    {
        static void Main(string[] args)
        {
            Cargaison[] c;

            c  = new Cargaison[3];

            c[0] = new Routiere(1, 1000, 5000, 300000);
            c[1] = new Routiere(2, 2000, 6000, 400000);
            c[2] = new Aerienne(3, 3000, 7000, 80000);

            for (int i = 0; i < c.Length; i++)
            {

                if (c[i].cout_transport() > 480000)
                {
                    c[i].afficher();
                }              
            }
        }
    }
}
