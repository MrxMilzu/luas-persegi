using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace milzu_technicall_github_MrxMilzu_INGAT_JANGAN_RECODE_NTAR_EROR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            float luaspersegipanjang,panjang,lebar;
            Double luaslingkaran,r;
            float volbalok, p, l, t;
            int pilih;
            const double phi = 3.14;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║ * Youtube   : Milzu-XD                 ║");
            Console.WriteLine("║ * Facebook  : Milzu-Tc                 ║");
            Console.WriteLine("║ * instagram : milzu_technicall         ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("⟨•⟩▬▬▬▬▬▬▬▬▬▬▬▬▬▬>>>menu<<<▬▬▬▬▬▬▬▬▬▬▬▬▬▬⟨•⟩");
            Console.WriteLine(">>> 1.luas persegi panjang             <<<");
            Console.WriteLine(">>> 2.luas lingkaran                   <<<");
            Console.WriteLine(">>> 3.vol balok                        <<<");
            Console.WriteLine(">>> 4.Keluar                           <<<");
            Console.WriteLine("⟨•⟩▬▬▬▬▬▬▬▬▬▬▬▬▬>>>Pilih<<<▬▬▬▬▬▬▬▬▬▬▬▬▬▬⟨•⟩");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(">>>Masukan Pilihan Menu Anda (1-4) : ");
            pilih = Convert.ToInt16(Console.ReadLine());
            switch(pilih)
            {
                case 1 :
                    Console.Write("[+] Masukan Panjang                : ");
                    panjang = Convert.ToSingle(Console.ReadLine());
                    Console.Write("[+] Masukan Sisi Lebar             : ");
                    lebar = Convert.ToSingle(Console.ReadLine());
                    luaspersegipanjang= panjang*lebar;
                    Console.Write(">>>luas persegi panjang adalah     : " + luaspersegipanjang);
                    Console.ReadKey();
                    break;
                case 2 :
                    Console.Write("[+] Masukan jari-jari lingkaran    : ");
                    r = Convert.ToDouble(Console.ReadLine());
                    luaslingkaran= r * r * phi;
                    Console.Write("luas lingkaran                     : " + luaslingkaran);
                    Console.ReadKey();
                    break;
                case 3 :
                    Console.Write("[+] Masukan Sisi Panjang           : ");
                    p = Convert.ToSingle(Console.ReadLine());
                    Console.Write("[+] Masukan Lebar                  : ");
                    l = Convert.ToSingle(Console.ReadLine());
                    Console.Write("[+] Masukan Tinggi                 : ");
                    t = Convert.ToSingle(Console.ReadLine());

                    volbalok = p*l*t;
                    Console.Write(">>>Volome Balok                    : " + volbalok);
                    Console.ReadKey();
                    break;
                case 4 :
                    Console.WriteLine("Terimakasih... Sayonara ");
                    Console.ReadKey();
                break;
            }
        }
    }
}
