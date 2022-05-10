using System;
namespace BaiTap
{
    class Program
    {
        public static void Main()
        {
            int[] arr226 = new int[10];
            int i226, mx226, mn226, n226;

            Console.WriteLine("Nhap so phan tu: ");
            n226 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap {0} phan tu vao trong mang:\n",n226);

            for (i226 = 0; i226 < n226; i226++)
            {
                Console.Write("Phan tu - {0}: ", i226);
                arr226[i226] = Convert.ToInt32(Console.ReadLine());
            }


            mx226 = arr226[0];
            mn226 = arr226[0];

            for (i226 = 1; i226 < n226; i226++)
            {
                if (arr226[i226] > mx226)
                {
                    mx226 = arr226[i226];
                }


                if (arr226[i226] < mn226)
                {
                    mn226 = arr226[i226];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", mx226);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn226);

            Console.ReadKey();
        }
    }
}