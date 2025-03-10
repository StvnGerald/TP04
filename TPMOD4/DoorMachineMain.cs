using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4
{
    class DoorMachineMain
    {
        static void Main()
        {
            DoorMachine pintu = new DoorMachine();
            string input;

            Console.WriteLine("\nMasukkan perintah:");
            Console.WriteLine("1 -> Buka Pintu");
            Console.WriteLine("0 -> Kunci Pintu");
            Console.WriteLine("cls -> Keluar Program");

            while (true)
            {
                Console.Write("\nInput: ");
                input = Console.ReadLine();

                if (input == "cls")
                {
                    Console.WriteLine("Menutup program...");
                    break;
                }
                else if (input == "1")
                {
                    pintu.BukaPintu();
                }
                else if (input == "0")
                {
                    pintu.KunciPintu();
                }
                else
                {
                    Console.WriteLine("Input tidak valid! Masukkan 1, 0, atau cls.");
                }
            }
        }
    }
}
