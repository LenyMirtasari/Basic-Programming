using System;
using System.Collections.Generic;
using System.Text;

namespace Kantin
{
    class Menu
    {
        protected static List<Menu> pesans = new List<Menu>();
        public string namaPesans;
        public int idPesans, hargaPesans;

        public virtual void TambahMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih yang akan ditambah:");
            Console.WriteLine("1. Makanan");
            Console.WriteLine("2. Minuman");
            Console.Write("Masukkan No Pilihan : ");
        }

        public virtual void PesanMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih yang akan dipesan:");
            Console.WriteLine("1. Makanan");
            Console.WriteLine("2. Minuman");
            Console.Write("Masukkan No Pilihan : ");
        }

        public virtual void UbahMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih yang akan diubah:");
            Console.WriteLine("1. Makanan");
            Console.WriteLine("2. Minuman");
            Console.Write("Masukkan No Pilihan : ");
        }

        public virtual void HapusMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih yang akan dihapus:");
            Console.WriteLine("1. Makanan");
            Console.WriteLine("2. Minuman");
            Console.Write("Masukkan No Pilihan : ");
        }

        public int Total()
        {
            Console.Clear();
            int total = 0;
            Console.WriteLine("======== Total Pembayaran  ========");       
            Console.WriteLine("| NO | Nama Menu |   Harga  |");
            for (int i = 0; i < pesans.Count; i++)
            {
                Console.WriteLine("===================================");
                Console.WriteLine($"| { (i + 1) } |  { pesans[i].namaPesans}  | { pesans[i].hargaPesans}|");
                total = total + pesans[i].hargaPesans;
                Console.WriteLine("===================================");
            }
            Console.WriteLine($"Total : Rp {total},00");
            return total;
        }


    }

    


}
