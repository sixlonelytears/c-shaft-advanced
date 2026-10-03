using QuanLySinhVien.Data.Entity;
using System.Collections.Generic;

namespace QuanLySinhVien.Data.DAL
{
    public class LopHocDAL
    {
        private List<LopHoc> lopHocs = new List<LopHoc>();

        public LopHocDAL()
        {
            lopHocs.Add(new LopHoc { MaLop = "BCSE2024", TenLop = "Khoa học máy tính 2024" });
            lopHocs.Add(new LopHoc { MaLop = "CSE0001", TenLop = "Kỹ thuật phần mềm 01" });
            lopHocs.Add(new LopHoc { MaLop = "CSE0002", TenLop = "Trí tuệ nhân tạo 01" });
        }

        public List<LopHoc> GetAllLopHoc()
        {
            return lopHocs;
        }
    }
}
