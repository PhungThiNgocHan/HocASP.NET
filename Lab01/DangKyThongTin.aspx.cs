using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class DangKyThongTin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                KhoiTaoDuLieu();
            }    
        }

        private void KhoiTaoDuLieu()
        {
            //Khởi tạo cho ddlTrinhDo
            ddlTrinhDo.Items.Add("Trung Cấp");
            ddlTrinhDo.Items.Add("Cao đẳng");
            ddlTrinhDo.Items.Add("Đại học");
            ddlTrinhDo.Items.Add("Sau đại học");

            //Khởi tạo cho lstNgheNghiep
            lstNgheNghiep.Items.Add("Công nhân");
            lstNgheNghiep.Items.Add("Kỹ sư");
            lstNgheNghiep.Items.Add("Lập trình viên");
            lstNgheNghiep.Items.Add("Kế toán viên");
            lstNgheNghiep.Items.Add("Bác sĩ");

            //Khởi tạo cho cklSoThich
            cklSoThich.Items.Add("Xem phim");
            cklSoThich.Items.Add("Mua sắm");
            cklSoThich.Items.Add("Du lịch");
            cklSoThich.Items.Add("Chơi game");
        }
        

        protected void btGui_Click(object sender, EventArgs e)
        {
            //b1 thu thập thông tin gửi từ client
            string kq = "<ul>";
            kq += "<li>Họ tên: <b> " + txtHoTen.Text + "</b>";
            kq += string.Format("<li> Ngày sinh: <b> {0} </b>", txtNgaySinh.Text);
            if (rdNam.Checked)
            {
                kq += string.Format("<li> Giới tính: <b> {0} </b>", rdNam.Text);
            }
            else
            {
                kq += string.Format("<li> Giới tính: <b> {0} </b>", rdNu.Text);
            }
            kq += string.Format("<li> Trình độ: <b> {0} </b>", ddlTrinhDo.SelectedItem.Text);
            kq += string.Format("<li> Nghề nghiệp: <b> {0} </b>", lstNgheNghiep.SelectedItem.Text);

            if (FHinh.HasFile)
            {
                //Xử lý uploadfile
                string path = Server.MapPath("~/Uploads");//Lấy đường dẫn tuyệt đối của thư mục trên máy chủ
                string filename = FHinh.FileName; //Lấy trên file
                FHinh.SaveAs(path + "/" + filename); //sao chép lên web server

                kq += string.Format("<li>Hình: <img src='/Uploads/{0}' width=200px>", filename);
            }

            kq += "</li> Sở thích";
            foreach (ListItem item in cklSoThich.Items)
            {
                if (item.Selected)
                {
                    kq += item.Text + ";";
                }
            }
            kq += "</ul>";
            //b2.Gửi thông tin về client
            lbKetQua.Text = kq;


        }

        protected void btNhapLai_Click(object sender, EventArgs e)
        {
            // Reset các trường dữ liệu về giá trị mặc định
            txtHoTen.Text = string.Empty; // Xóa nội dung của TextBox Họ tên
            txtNgaySinh.Text = string.Empty; // Xóa nội dung của TextBox Ngày sinh

            // Đặt lại RadioButton Nam là Checked mặc định
            rdNam.Checked = true;
            rdNu.Checked = false;

            // Reset DropDownList (trình độ) về mục đầu tiên
            if (ddlTrinhDo.Items.Count > 0)
                ddlTrinhDo.SelectedIndex = 0;

            // Xóa các lựa chọn trong ListBox (nghề nghiệp)
            lstNgheNghiep.ClearSelection();

            // Xóa các lựa chọn trong CheckBoxList (sở thích)
            foreach (ListItem item in cklSoThich.Items)
                item.Selected = false;

            // Xóa kết quả hiển thị
            lbKetQua.Text = string.Empty;
        }
    }
}