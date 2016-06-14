<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="perguntas.aspx.cs" Inherits="Show_do_Pila.perguntas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="pergunta" runat="server" Text="Label"></asp:Label> 
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <br />
        <asp:RadioButtonList ID="respostas" runat="server"></asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" Text="Enviar Resposta" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
            <a href="edicao.aspx">Edite perguntas</a>
    </form>
</body>
</html>
