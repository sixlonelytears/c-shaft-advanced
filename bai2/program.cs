using System;
using System.Collections.Generic;

namespace bai2
{
    interface Hinh
    {
        double GetDienTich();
        double GetChuVi();
        void Nhap();
        void HienThi();
    }

    class HinhTron : Hinh
    {
        private double r;

        public double BanKinh
        {
            get => r;
            set
            {
                if (value <= 0) throw new ArgumentException("ban kinh phai > 0");
                r = value;
            }
        }

        public HinhTron() { }

        public HinhTron(double r)
        {
            BanKinh = r;
        }

        public double GetDienTich()
        {
            return 3.14 * r * r;
        }

        public double GetChuVi()
        {
            return 2 * 3.14 * r;
        }

        public void Nhap()
        {
            while (true)
            {
                try
                {
                    Console.Write("nhap ban kinh r: ");
                    BanKinh = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("loi: " + ex.Message + ", nhap lai!");
                }
            }
        }

        public void HienThi()
        {
            Console.WriteLine("hinh tron [r = " + r + "] - chu vi = " + Math.Round(GetChuVi(), 2) + " - dien tich = " + Math.Round(GetDienTich(), 2));
        }
    }

    class HinhChuNhat : Hinh
    {
        private double dai;
        private double rong;

        public double ChieuDai
        {
            get => dai;
            set
            {
                if (value <= 0) throw new ArgumentException("chieu dai phai > 0");
                dai = value;
            }
        }

        public double ChieuRong
        {
            get => rong;
            set
            {
                if (value <= 0) throw new ArgumentException("chieu rong phai > 0");
                rong = value;
            }
        }

        public HinhChuNhat() { }

        public HinhChuNhat(double dai, double rong)
        {
            ChieuDai = dai;
            ChieuRong = rong;
        }

        public double GetDienTich()
        {
            return dai * rong;
        }

        public double GetChuVi()
        {
            return (dai + rong) * 2;
        }

        public void Nhap()
        {
            while (true)
            {
                try
                {
                    Console.Write("nhap chieu dai: ");
                    ChieuDai = double.Parse(Console.ReadLine());
                    Console.Write("nhap chieu rong: ");
                    ChieuRong = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("loi: " + ex.Message + ", nhap lai!");
                }
            }
        }

        public void HienThi()
        {
            Console.WriteLine("hinh chu nhat [dai = " + dai + ", rong = " + rong + "] - chu vi = " + Math.Round(GetChuVi(), 2) + " - dien tich = " + Math.Round(GetDienTich(), 2));
        }
    }

    class HinhTamGiac : Hinh
    {
        private double a, b, c;

        public double CanhA
        {
            get => a;
            set
            {
                if (value <= 0) throw new ArgumentException("canh a phai > 0");
                a = value;
            }
        }

        public double CanhB
        {
            get => b;
            set
            {
                if (value <= 0) throw new ArgumentException("canh b phai > 0");
                b = value;
            }
        }

        public double CanhC
        {
            get => c;
            set
            {
                if (value <= 0) throw new ArgumentException("canh c phai > 0");
                c = value;
            }
        }

        public HinhTamGiac() { }

        public HinhTamGiac(double a, double b, double c)
        {
            if (!IsTamGiac(a, b, c)) throw new ArgumentException("3 canh khong tao thanh tam giac");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool IsTamGiac()
        {
            return IsTamGiac(a, b, c);
        }

        public static bool IsTamGiac(double a, double b, double c)
        {
            return (a > 0 && b > 0 && c > 0) && (a + b > c) && (a + c > b) && (b + c > a);
        }

        public double GetChuVi()
        {
            return a + b + c;
        }

        public double GetDienTich()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public void Nhap()
        {
            while (true)
            {
                try
                {
                    Console.Write("nhap canh a: ");
                    double ca = double.Parse(Console.ReadLine());
                    Console.Write("nhap canh b: ");
                    double cb = double.Parse(Console.ReadLine());
                    Console.Write("nhap canh c: ");
                    double cc = double.Parse(Console.ReadLine());

                    if (!IsTamGiac(ca, cb, cc))
                    {
                        Console.WriteLine("3 canh vua nhap khong tao thanh tam giac, nhap lai!");
                        continue;
                    }

                    CanhA = ca;
                    CanhB = cb;
                    CanhC = cc;
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("loi: " + ex.Message + ", nhap lai!");
                }
            }
        }

        public void HienThi()
        {
            Console.WriteLine("hinh tam giac [3 canh: " + a + ", " + b + ", " + c + "] - chu vi = " + Math.Round(GetChuVi(), 2) + " - dien tich = " + Math.Round(GetDienTich(), 2));
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            List<Hinh> ds = new List<Hinh>();

            while (true)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Nhap hinh tron");
                Console.WriteLine("2. Nhap hinh chu nhat");
                Console.WriteLine("3. Nhap hinh tam giac");
                Console.WriteLine("4. In danh sach cac hinh");
                Console.WriteLine("0. Thoat");
                Console.Write("chon: ");
                int chon;
                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    Console.WriteLine("nhap so thoi!");
                    continue;
                }

                if (chon == 0) break;

                if (chon == 1)
                {
                    HinhTron ht = new HinhTron();
                    ht.Nhap();
                    ds.Add(ht);
                    Console.WriteLine("them xong hinh tron");
                }
                else if (chon == 2)
                {
                    HinhChuNhat hcn = new HinhChuNhat();
                    hcn.Nhap();
                    ds.Add(hcn);
                    Console.WriteLine("them xong hinh chu nhat");
                }
                else if (chon == 3)
                {
                    HinhTamGiac htg = new HinhTamGiac();
                    htg.Nhap();
                    ds.Add(htg);
                    Console.WriteLine("them xong hinh tam giac");
                }
                else if (chon == 4)
                {
                    if (ds.Count == 0)
                    {
                        Console.WriteLine("danh sach dang trong");
                    }
                    else
                    {
                        Console.WriteLine("danh sach cac hinh:");
                        for (int i = 0; i < ds.Count; i++)
                        {
                            Console.Write((i + 1) + ". ");
                            ds[i].HienThi();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("chon sai roi!");
                }
            }
        }
    }
}
