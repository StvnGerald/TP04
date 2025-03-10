using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL4
{
    class KodePosMain
    {
        static void Main()
        {
            KodePos kodePos = new KodePos();

            Console.Write("Masukkan nama kelurahan: ");
            string kelurahan = Console.ReadLine();

            int kode = kodePos.GetKodePos(kelurahan);
            if (kode != -1)
            {
                Console.WriteLine($"Kode pos untuk {kelurahan} adalah {kode}");
            }
            else
            {
                Console.WriteLine("Kelurahan tidak ditemukan.");
            }
        }
    }
}
