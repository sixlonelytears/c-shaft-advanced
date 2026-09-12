using System;

namespace bai1
{
    class program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;

            // nhap a bang convert
            while (true)
            {
                try
                {
                    Console.Write("nhap so a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("nhap sai roi, nhap lai so a!");
                }
            }

            // nhap b dung int.parse
            while (true)
            {
                try
                {
                    Console.Write("nhap so b: ");
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("nhap so b loi, nhap lai di!");
                }
            }

            // nhap c dung tryparse
            while (true)
            {
                Console.Write("nhap so c: ");
                bool check = int.TryParse(Console.ReadLine(), out c);
                if (check == true)
                {
                    break;
                }
                Console.WriteLine("c khong phai so nguyen, nhap lai!");
            }

            int s = a + b + c;
            Console.WriteLine("tong 3 so a + b + c = " + s);
        }
    }
}
