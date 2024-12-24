<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKyThongTin.aspx.cs" Inherits="Lab01.DangKyThongTin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet"  type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="4" cellspacing="0" class="w-100">
                <tr>
                    <td colspan="2" class="text-center h3 alert alert-info">ĐĂNG KÝ THÔNG TIN</td>
                </tr>
                <tr>
                    <td class="text-end">Họ tên</td>
                    <td>
                        <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-end">Ngày sinh</td>
                    <td>
                        <asp:TextBox ID="txtNgaySinh" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-end">Giới tính</td>
                    <td>
                        <asp:RadioButton ID="rdNam" runat="server" Text="Nam" Checked="true" GroupName="GT" />
                        <asp:RadioButton ID="rdNu" runat="server" Text="Nữ" GroupName="GT"/>
                    </td>
                </tr>
                <tr>
                    <td class="text-end">Trình độ</td>
                    <td>
                        <asp:DropDownList ID="ddlTrinhDo" runat="server" CssClass="form-select">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="text-end">Nghề nghiệp</td>
                    <td>
                        <asp:ListBox ID="lstNgheNghiep" runat="server" Rows="6" Width="266px" CssClass="form control"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-end">Hình</td>   
                    <td>
                        <asp:FileUpload ID="FHinh" runat="server" CssClass="form control" />
                    </td>
                </tr>
                <tr>
                    <td class="text-end">Sở thích</td> 
                    <td>
                        <asp:CheckBoxList ID="cklSoThich" runat="server" CssClass="form-check">
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btGui" runat="server" Text="Gửi" CssClass="btn btn-primary" OnClick="btGui_Click"/>
                        <asp:Button ID="btNhapLai" runat="server" Text="Làm lại" CssClass="btn btn-secondary" OnClick="btNhapLai_Click"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="text-center h3 alert alert-info">KẾT QUẢ ĐĂNG KÝ</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lbKetQua" runat="server"></asp:Label>
                    </td>                    
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
