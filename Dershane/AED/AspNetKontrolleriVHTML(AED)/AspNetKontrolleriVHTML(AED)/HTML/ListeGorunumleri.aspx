<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListeGorunumleri.aspx.cs" Inherits="AspNetKontrolleriVHTML_AED_.HTML.ListeGorunumleri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Sıralı Listele</h3>
            <%-- ORDERED LIST --%>
            <ol>
                <li>Ankara</li>
                <li>İstanbul</li>
                <li>Eskişehir</li>
                <li>Adana</li>
                <li>Urfa</li>
                <%-- List Item --%>
            </ol>

            <h3>Farklı Madde İşaretli Sıralı Liste</h3>
            <%-- A,a,I,i,1 --%>
            <ol type="A">
                <li>Ankara</li>
                <li>İstanbul</li>
                <li>Eskişehir</li>
                <li>Adana</li>
                <li>Urfa</li>
            </ol>
            <h3>Sırasız Liste</h3>
            <%-- Unordered List --%>
            <ul>
                <li>Ankara</li>
                <li>İstanbul</li>
                <li>Eskişehir</li>
                <li>Adana</li>
                <li>Urfa</li>
            </ul>
            <h3>Farklı Madde İşaretli Sırasız Liste</h3>
            <%--disc,circle,square --%>
            <ul type="circle">
                <li>Ankara</li>
                <li>İstanbul</li>
                <li>Eskişehir</li>
                <li>Adana</li>
                <li>Urfa</li>
            </ul>
            <h3>İç İçe Listele</h3>
            <ol>
                <li>Ankara</li>
                <li>İstanbul</li>
                <li>Eskişehir</li>
                <ul type="I">
                    <li>Tepebaşı</li>
                    <li>Odunpazarı</li>
                </ul>
                <li>Adana</li>
                <li>Urfa</li>
            </ol>
        </div>
    </form>
</body>
</html>
