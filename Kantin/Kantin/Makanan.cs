using System;
using System.Collections.Generic;
using System.Text;

namespace Kantin
{   
    class Makanan : Menu
    {
        private int hargaMakanans, idMakanans;
        private string namaMakanans;
        private static List<Makanan> makanans = new List<Makanan>();
        
        // Makanan m = new Makanan();

        public override void TambahMenu()
        {
            Console.Clear();
            Console.Write("Masukkan Nama Makanan :");
            string namaMakanan = Console.ReadLine();
            if (namaMakanan=="")
            {
                Console.WriteLine("Tidak boleh kosong");
            }
            else { 
                try
                {
                
                    Console.Write("Masukkan Harga Makanan :");
                    int hargaMakanan = Convert.ToInt32(Console.ReadLine());
                    int idMakanan = (makanans.Count) + 1;
                    makanans.Add(new Makanan {idMakanans = idMakanan, namaMakanans = namaMakanan, hargaMakanans = hargaMakanan});
                }
                catch 
                {
                    Console.WriteLine("Harga yang anda masukkan salah");
                }
            }

        }

        public void LihatMakanan()
        {
            if (makanans.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("====== Makanan =======");

                for (int i = 0; i < makanans.Count; i++)
                {
                    Console.WriteLine("======================");
                    Console.WriteLine($"NO          : {makanans[i].idMakanans}");
                    Console.WriteLine($"NAMA MAKANAN: {makanans[i].namaMakanans}");
                    Console.WriteLine($"HARGA       : {makanans[i].hargaMakanans}");
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
            LihatMakanan();
            Console.Write("Masukkan Nomor Makanan :");
            try
            {
                int idMakanan= Convert.ToInt32(Console.ReadLine());
                var index = makanans.FindIndex(c => c.idMakanans== idMakanan);
                int id = (pesans.Count) + 1;
                
                pesans.Add(new Menu{ idPesans = id, namaPesans = makanans[index].namaMakanans, hargaPesans = makanans[index].hargaMakanans });
            }
            catch 
            {
                Console.WriteLine("Menu tidak tersedia");
            }
        }

        public override void UbahMenu()
        {
            
            LihatMakanan();
            try
            {
                Console.Write("Pilih No Makanan yang akan diubah:");
                int id = Convert.ToInt16(Console.ReadLine());
                Console.Write("Masukkan Nama Makanan Baru   :");
                string namaMakanan = Console.ReadLine();
                Console.Write("Masukkan Harga Baru          :");
                int harga = Convert.ToInt32(Console.ReadLine());
                var index = makanans.FindIndex(c => c.idMakanans == id);
                makanans[index].namaMakanans= namaMakanan;
                makanans[index].hargaMakanans = harga;
               
            }
            catch 
            {
                Console.WriteLine("Pilihan yang anda masukkan tidak tersedia !");
            }

        }

        public override void HapusMenu()
        {

            LihatMakanan();   
            Console.Write("Pilih No Makanan yang akan dihapus:");
            int id = Convert.ToInt16(Console.ReadLine());
            var index = makanans.FindIndex(c => c.idMakanans == id);
            if (index >= 0)
            {
                makanans.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Pilihan yang anda masukkan tidak tersedia !");
            }

        }
    }
}
