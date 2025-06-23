<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeciciTurleri.aspx.cs" Inherits="AspNetKontrolleriVHTML_AED_.CSS.SeciciTurleri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        label {
            font-size: 20pt;
        }

        h1, h2, h3, h4, h5, h6 {
            color: darkslategray
        }

        span {
            color: maroon;
            font-size: 20pt;
            font-weight: 900;
        }

        .abidigubidi {
            color: yellowgreen;
            font-size: 50pt;
            font-weight: 100;
        }
        #lbl_abidigubidi{
            color:gold;
            font-size:35pt;
            font-weight:400;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label style="color: mediumvioletred; font-size: 50px">Satır Bazında CSS(Inline css)</label>
            <br />
            <label>Etiket Seçici</label>
            <h1>DENEME</h1>
            <h2>Bu da mı yeşil</h2>
            <span>Bu da etiket</span>
            <hr />
            <span class="abidigubidi">Span 'a sınıf eklendi</span> <br />
            <label class="abidigubidi">Label'e sınıf eklendi</label> <br />
            <p class="abidigubidi"> Paragraf'a sınıf eklendi</p>
            <br />  
            <span id="lbl_abidigubidi">Span'a ID eklendi</span>
        </div>
    </form>
</body>
</html>
