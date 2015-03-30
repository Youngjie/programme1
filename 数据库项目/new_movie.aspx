<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="new_movie.aspx.cs" Inherits="数据库项目.new_movie" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class = "电影信息">
    <p>
        <asp:TextBox ID="TextBox1" runat="server" >电影名</asp:TextBox>
    </p>
        <asp:TextBox ID="TextBox2" runat="server" >上映时间</asp:TextBox>
    <p>
        <asp:TextBox ID="TextBox3" runat="server">出品国家</asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="TextBox4" runat="server">电影导演</asp:TextBox>
    </p> 
    <p>
        <asp:TextBox ID="TextBox6" runat="server">预告片路径</asp:TextBox>
    </p>
        <asp:Label ID="Label1" runat="server" Text="在下面勾选电影风格，可多选"></asp:Label>
        
    <p>
        <asp:TextBox ID="TextBox8" runat="server" Height="98px" TextMode="MultiLine" 
            Width="344px">演员名单表(请用,隔开)</asp:TextBox>
        
    </p>

    <div style="height: 72px; margin-top: 6px">
        <br />
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="40px" 
            Width="430px" RepeatDirection="Horizontal" RepeatLayout="Flow" 
            style="margin-left: 0px">
            <asp:ListItem>动作</asp:ListItem>
            <asp:ListItem>喜剧</asp:ListItem>
            <asp:ListItem>爱情</asp:ListItem>
            <asp:ListItem>科幻</asp:ListItem>
            <asp:ListItem>奇幻</asp:ListItem>
            <asp:ListItem>灾难</asp:ListItem>
            <asp:ListItem>恐怖</asp:ListItem>
            <asp:ListItem>纪录</asp:ListItem>
            <asp:ListItem>犯罪</asp:ListItem>
            <asp:ListItem>战争</asp:ListItem>
            <asp:ListItem>冒险</asp:ListItem>
            <asp:ListItem>动画</asp:ListItem>
            <asp:ListItem>剧情</asp:ListItem>
            <asp:ListItem>其他</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <br />
        </div>

    <p>
        <asp:TextBox ID="TextBox9" runat="server" Height="98px" TextMode="MultiLine" 
            Width="344px">电影概要</asp:TextBox>
        
    </p>
    </div>

    <p>
        <asp:Button ID="Button1" runat="server" Height="37px" Text="确认提交" 
            Width="156px" onclick="Button1_Click1" />
    </p>

    </form>
</body>
</html>
