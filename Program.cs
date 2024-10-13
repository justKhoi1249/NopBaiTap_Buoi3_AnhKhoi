using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        /*
        static int kiemTraSoNguyenTo(int n)
        {
            
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return 1;
                }
            }

            return 0;
        }
        */
        static void Main(string[] args)
        {
            //-------------BÀI 5: VIẾT CHƯƠNG TRÌNH C# LIỆT KÊ TẤT CẢ CÁC SỐ NGUYÊN TỐ NHỎ HƠN N.---------------
            /*
            int N;
            Console.WriteLine("Nhap so nguyen N = ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Cac so nguyen to nho hon {0} la: ", N);
            for (int i = 1; i <= N; i++)
            {
                if (kiemTraSoNguyenTo(i) == 0)
                {
                    Console.Write("{0}", i);
                }
            }
            Console.ReadLine();
            */

            //----------------BÀI 6: KIỂM TRA MỘT SỐ LÀ SỐ CHẴN HAY SỐ LẺ TRONG C#-------------------
            /*
            int a;
            Console.WriteLine("Moi nhap vao mot so tu nhien a: ");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} la so chan", a);
            }
            else 
            {
                Console.WriteLine("{0} la so le", a);
            }
            */

            //----------------BÀI 7: KIỂM TRA 1 SỐ CÓ PHẢI SỐ NGUYEN TỐ KHÔNG ?--------------------------
            /*
            Console.WriteLine("Nhap vao so a: ");
            int a = int.Parse(Console.ReadLine());
            int soUoc = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                soUoc++;
            }
            Console.WriteLine("So uoc cua so nguyen to {0} la: {1}", a, soUoc);
            if (soUoc == 2) 
            {
                Console.WriteLine("{0} la so nguyen to", a);
            }
            else
            {
                Console.WriteLine("{0} khong phai la so nguyen to", a);
            }
            */

            //----------------BÀI 8: CHO MỘT MẢNG SỐ NGUYÊN HÃY IN RA MẢNG SỔ LẺ VÀ MẢNG------------------
            /*
            int[] mangChung = new int[10];
            int[] mangChan = new int[10];
            int[] mangLe = new int[10];
            int i, j = 0, k = 0, n;
            Console.WriteLine("Nhap so phan tu cua mang chung: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cac phan tu vao trong mang chung: \n");
            for (i = 0; i < n; i++) 
            {
                Console.WriteLine("Phan tu {0}", i);
                mangChung[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (mangChung[i] % 2 == 0)
                {
                    mangChan[i] = mangChung[i];
                    j++;
                }
                else
                {
                    mangLe[i] = mangChung[i];
                    k++;
                }
            }
            Console.WriteLine("\n Cac phan tu chan la: \n");
            for (i = 0; i < j; i++)
            {
                 Console.WriteLine("{0}", mangChan[i]);
            }
            Console.WriteLine("\n Cac phan tu le la: \n");
            for (i = 0; i < k; i++)
            {
                 Console.WriteLine("{0}", mangLe[i]);
            }
            */

            //---------------BÀI 9: CHO MỘT MẢNG SỐ NGUYÊN HÃY THỰC HIỆN SẮP XẾP DÃY TĂNG VÀ GIẢM DẦN-----------------
            /*
            int[] arrNum = { 4, 12, 3, 21, 50, 42, 7, 15 };
            Console.WriteLine("Mang truoc khi tang dan: \n");
            HienThi(arrNum);
            Console.WriteLine("Mang sau khi tang dan: \n");
            Array.Sort(arrNum);
            HienThi(arrNum);
            Console.ReadLine();
         }
         private static void HienThi(int[] arrNum)
         {
            foreach (var item in arrNum)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
         }
         */
            //---------------BÀI 10: NHẬP MỘT SỐ BẤT KỲ VÀ HIỂN THỊ SỐ BẰNG CHỮ TƯƠNG ỨNG TRONG C#------------------

            /*
            int n;
            Console.WriteLine("Nhap vao mot so tu 0 den 5 va hien thi so do bang chu tuong ung: ");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 0:
                    Console.WriteLine("So khong \n");
                    break;
                case 1:
                    Console.WriteLine("So mot \n");
                    break;
                case 2:
                    Console.WriteLine("So hai \n");
                    break;
                case 3:
                    Console.WriteLine("So ba \n");
                    break;
                case 4:
                    Console.WriteLine("So bon \n");
                    break;
                case 5:
                    Console.WriteLine("So nam \n");
                    break;


            }

            */


        }
    }

}
