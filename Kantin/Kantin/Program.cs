using System;

namespace Kantin
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Makanan makanan = new Makanan();
            Minuman minuman = new Minuman();
            int pilih, i;
            bool cond = false;
            do
            {
                try
                {

                    Console.Clear();
                    Console.WriteLine("=======================");
                    Console.WriteLine("======== Menu =========");
                    Console.WriteLine("=======================");
                    Console.WriteLine("1. Tambah Menu");
                    Console.WriteLine("2. LihatMenu");
                    Console.WriteLine("3. Ubah Menu");
                    Console.WriteLine("4. Hapus Menu");
                    Console.WriteLine("5. Pesan");
                    Console.WriteLine("6. Selesai Pesan");
                    Console.WriteLine("7. Keluar");
                    Console.WriteLine("=======================");
                    Console.Write("Masukkan Menu : ");
                    pilih = Convert.ToInt16(Console.ReadLine());
                    switch (pilih)
                    {
                        case 1:
                            cond = true;
                            menu.TambahMenu();
                            i = Convert.ToInt16(Console.ReadLine());
                            try
                            {
                                switch (i)
                                {
                                    case 1:
                                        cond = true;
                                        makanan.TambahMenu();
                                        break;
                                    case 2:
                                        cond = true;
                                        minuman.TambahMenu();
                                        break;
                                    default:
                                cond = true;
                                Console.WriteLine("Pilihan yang anda masukkan tidak tersedia !");
                                        break;

                                }
                            }
                            catch 
                            {   
                                Console.WriteLine("Pilihan yang anda masukkan tidak tersedia!");
                            }
                            break;
                        case 2:
                            cond = true;
                            makanan.LihatMakanan();
                            minuman.LihatMinuman();
                            try
                            {
                                i = Convert.ToInt32(Console.ReadLine());
                            }
                            catch 
                            {
                                i = 1;
                            }
                        break;
                        case 3:
                            cond = true;
                            menu.UbahMenu();
                            i = Convert.ToInt16(Console.ReadLine());
                            try
                            {
                                switch (i)
                                {
                                    case 1:
                                                
                                        makanan.UbahMenu();
                                        cond = true;
                                        break;
                                    case 2:
                                        minuman.UbahMenu();
                                        cond = true;
                                        break;
                                    default:
                                                
                                        Console.WriteLine("Pilihan yang anda masukkan tidak tersedia !");
                                        cond = true;
                                        break;

                                }
                            }
                            catch 
                            {
                                Console.WriteLine("Pilihan yang anda masukkan tidak tersedia!");
                            }
                            break;
                        case 4:
                            cond = true;
                            menu.HapusMenu();
                            i = Convert.ToInt16(Console.ReadLine());
                            try
                            {
                                switch (i)
                                {
                                    case 1:

                                        makanan.HapusMenu();
                                        cond = true;
                                        break;
                                    case 2:
                                        minuman.HapusMenu();
                                        cond = true;
                                        break;
                                    default:

                                        Console.WriteLine("Pilihan yang anda masukkan tidak tersedia !");
                                        cond = true;
                                        break;

                                }
                            }
                            catch 
                            {
                                Console.WriteLine("Pilihan yang anda masukkan tidak tersedia!");
                            }
                            break;
                        case 5:
                            menu.PesanMenu();
                            i = Convert.ToInt16(Console.ReadLine());
                            try
                            {
                                switch (i)
                                {
                                    case 1:
                                        cond = true;
                                        makanan.PesanMenu();
                                        break;
                                    case 2:
                                        cond = true;
                                        minuman.PesanMenu();
                                        break;
                                    default:
                                        Console.WriteLine("Pilihan yang anda masukkan tidak tersedia !");
                                        break;

                                }
                            }
                            catch 
                            {
                                Console.WriteLine("Pilihan yang anda masukkan tidak tersedia !");
                            }
                            cond = true;
                            break;
                        case 6:
                            cond = false;
                            menu.Total();
                            Console.WriteLine("Terima Kasih");
                            break;
                        case 7:
                            cond = false;
                            Console.WriteLine("Terima Kasih");
                            break;
                        default:
                            cond = true;
                            Console.WriteLine("Pilihan yang anda masukkan tidak tersedia !");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Pilihan yang anda masukkan tidak tersedia !");
                }

            } while (cond);
                
                
                
        }
        
    }
}
