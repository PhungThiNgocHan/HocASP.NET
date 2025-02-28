using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQLDaoTao.Models
{
    public class SinhVienDAO
    {
        public List<SinhVien> getAll()
        {
            List<SinhVien> ds = new List<SinhVien>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringName"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SinhVien", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ds.Add(new SinhVien()
                {
                    MaSV = rd["MaSV"].ToString(),
                    HoSV = rd["HoSV"].ToString(),
                    TenSV = rd["TenSV"].ToString(),
                    GioiTinh = Convert.ToBoolean(rd["GioiTinh"]),
                    NgaySinh = Convert.ToDateTime(rd["ngaysinh"]),
                    NoiSinh = rd["noisinh"].ToString(),
                    DiaChi = rd["diachi"].ToString(),
                    MaKH = rd["makh"].ToString()
                });
            }

            return ds;
        }
    }
}