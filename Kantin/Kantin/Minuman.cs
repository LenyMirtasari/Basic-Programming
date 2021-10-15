using System;
using System.Collections.Generic;

namespace Kantin
{
    class Minuman : Menu
    {
        private int hargaMinumans, idMinumans;
        private string namaMinumans;
        private static List<Minuman> minumans = new List<Minuman>();
        public override void TambahMenu()
        {
            Console.Clear();
            Console.Write("Masukkan Nama Minuman :");
            string namaMinuman= Console.ReadLine();
            if (namaMinuman == "")
            {
                Console.WriteLine("Tidak boleh kosong");
            }
            else
            {
                try
                {

                    Console.Write("Masukkan Harga Makanan :");
                    int hargaMinuman= Convert.ToInt32(Console.ReadLine());
                    int idMinuman= (minumans.Count) + 1;
                    minumans.Add(new Minuman { idMinumans= idMinuman, namaMinumans= namaMinuman, hargaMinumans= hargaMinuman});
                }
                catch
                {
                    Console.WriteLine("Harga yang anda masukkan salah");
                }
            }

        }

        public void LihatMinuman()
        {
            if (minumans.Count>0) { 
                Console.WriteLine("====== Minuman =======");

                for (int i = 0; i < minumans.Count; i++)
                {
                    Console.WriteLine("======================");
                    Console.WriteLine($"NO          : {minumans[i].idMinumans}");
                    Console.WriteLine($"NAMA MINUMAN: {minumans[i].namaMinumans}");
                    Console.WriteLine($"HARGA       : {minumans[i].hargaMinumans}");
                    Console.WriteLine("======================");
                }
                }
            else
            {
                Console.WriteLine();
            }

        }

        public override void PesanMenu()
        {
            Console.Clear();
            LihatMinuman();
            Console.Write("Masukkan Nomor Minuman : ");
            try
            {
                int idMinuman= Convert.ToInt32(Console.ReadLine());
                var index = minumans.FindIndex(c => c.idMinumans== idMinuman);
                int id = (pesans.Count) + 1;
                pesans.Add(new Menu { idPesans = id, namaPesans = minumans[index].namaMinumans, hargaPesans = minumans[index].hargaMinumans});
            }
            catch 
            {
                Console.WriteLine("Menu tidak tersedia");
            }
        }

        public override void UbahMenu()
        {

            LihatMinuman();
            try
            {
                Console.Write("Pilih No Minuman yang akan diubah:");
                int id = Convert.ToInt16(Console.ReadLine());
                Console.Write("Masukkan Nama Minuman Baru   :");
                string namaMinuman= Console.ReadLine();
                Console.Write("Masukkan Harga Baru          :");
                int harga = Convert.ToInt32(Console.ReadLine());
                var index = minumans.FindIndex(c => c.idMinumans== id);
                minumans[index].namaMinumans= namaMinuman;
                minumans[index].hargaMinumans= harga;

            }
            catch 
            {
                Console.WriteLine("Pilihan yang anda masukkan tidak tersedia !");
            }

        }

        public override void HapusMenu()
        {

            LihatMinuman();
            Console.Write("Pilih No Minuman yang akan dihapus:");
            int id = Convert.ToInt16(Console.ReadLine());
            var index = minumans.FindIndex(c => c.idMinumans== id);
            if (index >= 0)
            {
                minumans.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Pilihan yang anda masukkan tidak tersedia !");
            }

        }
    }
}
