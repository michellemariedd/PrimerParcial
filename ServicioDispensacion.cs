﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerParcial
{
    public class ServicioDispensacion :  Interface1
    {
        public ServicioDispensacion () : base()
        { 

        }
          MenuPrincipal menuPrincipal = new MenuPrincipal();

        public void DispensingMode(int dispensingMode, int monto) 
        {

             if (dispensingMode == 1)
              {

                if (monto % 200 == 0)
                 {
                      int M1000 = 0;
                      int M200 = 0;

                      if (monto >= 1000)
                     {
                          M1000 = monto / 1000;
                           monto = monto - (M1000 * 1000);
                      }
                       if (monto >= 200)
                        {
                           M200 = monto / 200;
                          monto = monto - (M200 * 200);
                       }
                            Console.WriteLine("Se imprimieron: ");
                            Console.WriteLine($"Papeletas de RD$1000.00: {M1000}");
                            Console.WriteLine($"Papeletas de RD$200.00: {M200}");
                            Console.ReadKey();
                            menuPrincipal.ImprimirMenu();
                }
                   else
                   {
                      Console.WriteLine("Inserte un monto válido, este cajero solo dispensa de papeletas RD$1000.00 y RD$200.00");
                       Console.ReadKey();
                       menuPrincipal.ImprimirMenu();
                           
                   }
             }
            
             if (dispensingMode == 2)
            {

                if (monto % 100 == 0)
                {
                    int M500 = 0;
                    int M100 = 0;

                    if (monto >= 500)
                    {
                        M500 = monto / 500;
                        monto = monto - (M500 * 500);
                    }
                    if (monto >= 100)
                    {
                        M100 = monto / 100;
                        monto = monto - (M100 * 100);
                    }

                    Console.WriteLine("Se imprimieron: ");
                    Console.WriteLine($"Papeletas de RD$1000.00: {M500}");
                    Console.WriteLine($"Papeletas de RD$200.00: {M100}");
                    Console.ReadKey();
                    menuPrincipal.ImprimirMenu();

                }
                else
                {
                    Console.WriteLine("Inserte un monto válido, este cajero solo dispensa de papeletas RD$500.00 y RD$100.00");
                    Console.ReadKey();
                    menuPrincipal.ImprimirMenu();
                }

             }
            if (dispensingMode == 3)
            { 
                if (monto % 100 == 0)
                {
                    int M1000 = 0;
                    int M500 = 0;
                    int M200 = 0;
                    int M100 = 0;

                    if (monto >= 1000)
                {

                    M1000 = monto / 1000;
                    monto = monto - (M1000 * 1000);
                }
                if (monto >= 500)
                {
                    M500 = monto / 500;
                    monto = monto - (M500 * 500);
                }
                if (monto >= 200)
                {
                    M200 = monto / 200;
                    monto = monto - (M200 * 200);

                }
                if (monto >= 100)
                {
                    M100 = monto / 100;
                    monto = monto - (M100 * 100);
                }

                Console.WriteLine("Se imprimieron: ");
                Console.WriteLine($"Papeletas de RD$1000.00: {M1000}");
                Console.WriteLine($"Papeletas de RD$500.00: {M500}");
                Console.WriteLine($"Papeletas de RD$200.00: {M200}");
                Console.WriteLine($"Papeletas de RD$100.00: {M100}");
                Console.ReadKey();
                    menuPrincipal.ImprimirMenu();
                }
                else
                {
                Console.WriteLine("Inserte un monto válido");
                Console.ReadKey();
                menuPrincipal.ImprimirMenu();

                }
            
            }

        }
    }
}
