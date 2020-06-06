using System;
using System.Collections.Generic;
using System.Text;

namespace PrimerParcial
{
    public class MenuDispensacion
    {
        public static int dispensingMode = 3;

        enum Opciones 
        {
            PAPELETA = 1,
            PAPELETA1,
            EFICIENTE,
            BACK
        }

        public void ImprimirMenu() 
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            

            try 
            {
                Console.Clear();
                Console.WriteLine("***Dispensacion de dinero***");
                Console.WriteLine();
                Console.WriteLine(" 1-200-1000\n 2-100 -500\n 3-Eficiente\n 4-Volver");
                int Opcion = Convert.ToInt32(Console.ReadLine());
                
                switch (Opcion) 
                {
                    case (int)Opciones.PAPELETA:
                        dispensingMode = 1;
                        menuPrincipal.ImprimirMenu();
                        break;
                    case (int)Opciones.PAPELETA1:
                        dispensingMode = 2;
                        menuPrincipal.ImprimirMenu();
                        break;
                    case (int)Opciones.EFICIENTE:
                        dispensingMode = 3;
                        menuPrincipal.ImprimirMenu();
                        break;
                    case (int)Opciones.BACK:
                        menuPrincipal.ImprimirMenu();
                        break;
                }
            }
            catch (Exception e ) 
            {
                Console.WriteLine("Debe seleccionar una opcion Valida");
                Console.ReadKey();
                menuPrincipal.ImprimirMenu();
            }

        }
    }
}
