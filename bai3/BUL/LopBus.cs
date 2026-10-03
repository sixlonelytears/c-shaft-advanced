using QuanLySinhVien.Data.DAL;
using QuanLySinhVien.Data.Entity;
using System.Collections.Generic;

namespace QuanLySinhVien.BUL
{
    public class LopBus
    {
        private LopHocDAL lhd;

        public LopBus()
        {
            lhd = new LopHocDAL();
        }

        public List<LopHoc> GetAllLopHoc()
        {
            return lhd.GetAllLopHoc();
        }
    }
}
