using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL4
{
    class KodePos
    {
        private Dictionary<string, int> dataKodePos;

        // Konstruktor
        public KodePos()
        {
            dataKodePos = new Dictionary<string, int>
        {
            {"Batununggal", 40266},
            {"Kujangsari", 40287},
            {"Mengger", 40267},
            {"Wates", 40256},
            {"Cijaura", 40287},
            {"Jatisari", 40286},
            {"Margasari", 40286},
            {"Sekejati", 40286},
            {"Kebonwaru", 40272},
            {"Maleer", 40274},
            {"Samoja", 40273}
        };
        }

        // Method buat cek data kelurahan
        public int GetKodePos(string kelurahan)
        {
            if (dataKodePos.ContainsKey(kelurahan))
            {
                return dataKodePos[kelurahan];
            }
            else
            {
                return -1;
            }
        }
    }
}
