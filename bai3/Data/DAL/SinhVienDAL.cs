using QuanLySinhVien.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySinhVien.Data.DAL
{
    public class SinhVienDAL
    {
        private List<SinhVien> sinhViens = new List<SinhVien>();

        public SinhVienDAL()
        {
            sinhViens.Add(new SinhVien
            {
                MaSV = "SV0001",
                HoTen = "Nguyễn Văn A",
                NgaySinh = new DateTime(2000, 1, 1),
                GioiTinh = "Nam",
                Email = "a.nv@vnu.edu.vn",
                SoDienThoai = "0912345678",
                MaLop = "BCSE2024",
                Diem = 8.5
            });
            sinhViens.Add(new SinhVien
            {
                MaSV = "SV0002",
                HoTen = "Trần Thị B",
                NgaySinh = new DateTime(2000, 2, 2),
                GioiTinh = "Nữ",
                Email = "b.tt@vnu.edu.vn",
                SoDienThoai = "0987654321",
                MaLop = "BCSE2024",
                Diem = 7.0
            });
            sinhViens.Add(new SinhVien
            {
                MaSV = "SV0003",
                HoTen = "Lê Văn C",
                NgaySinh = new DateTime(2000, 3, 3),
                GioiTinh = "Nam",
                Email = "c.lv@vnu.edu.vn",
                SoDienThoai = "0901234567",
                MaLop = "CSE0001",
                Diem = 9.0
            });
        }

        public List<SinhVien> GetAllSinhVien()
        {
            return sinhViens;
        }

        public void AddSinhVien(SinhVien sv)
        {
            sinhViens.Add(sv);
        }

        public void UpdateSinhVien(SinhVien sv)
        {
            SinhVien sve = sinhViens.FirstOrDefault(s => s.MaSV == sv.MaSV);
            if (sve != null)
            {
                sve.HoTen = sv.HoTen;
                sve.NgaySinh = sv.NgaySinh;
                sve.GioiTinh = sv.GioiTinh;
                sve.Email = sv.Email;
                sve.SoDienThoai = sv.SoDienThoai;
                sve.MaLop = sv.MaLop;
                sve.Diem = sv.Diem;
            }
        }

        public void DeleteSinhVien(string maSV)
        {
            SinhVien sv = sinhViens.FirstOrDefault(s => s.MaSV == maSV);
            if (sv != null)
            {
                sinhViens.Remove(sv);
            }
        }

        public SinhVien GetSinhVienById(string maSV)
        {
            return sinhViens.FirstOrDefault(s => s.MaSV == maSV);
        }

        public SinhVien GetSinhVienByMaSV(string maSV)
        {
            return sinhViens.FirstOrDefault(s => s.MaSV == maSV);
        }

        public List<SinhVien> GetSinhViensByMaLop(string maLop)
        {
            return sinhViens.Where(s => s.MaLop == maLop).ToList();
        }
    }
}
