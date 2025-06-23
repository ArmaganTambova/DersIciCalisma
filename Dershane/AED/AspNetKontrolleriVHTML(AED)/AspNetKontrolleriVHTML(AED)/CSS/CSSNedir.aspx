<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CSSNedir.aspx.cs" Inherits="AspNetKontrolleriVHTML_AED_.CSS.CSSNedir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            normal yazı <br />
            <label>Label İle Normal Yazı</label>
            <span>Span ile normal yazı </span>
            <hr />  
            <label style="color:maroon">Css ile renklendir</label><br />
             <label style="color:#e016ff">Css ile renklendir</label> <br />
            <h1 style="font-size:5pt">En Büyük Başlık</h1>
            <h6 style="font-size:50pt">En küçük başlık</h6>
            <label style="font-family:'Times New Roman', 'Times, serif'; color:darkred; font-size:25pt;">Yazı Stilini Değiştirdir</label>
        </div>
    </form>
</body>
</html>
