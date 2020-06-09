<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ToDoList.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #TextArea1 {
            height: 300px;
            width: 400px;
        }
    </style>
</asp:Content>
    
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" style="float: left; width: 50%; display: inline;">
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" ImageUrl="~/Images/Calender.jpg" />
    <br />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" OnSelectionChanged="SelectedEvent">
        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
        <NextPrevStyle VerticalAlign="Bottom" />
        <OtherMonthDayStyle ForeColor="#808080" />
        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
        <SelectorStyle BackColor="#CCCCCC" />
        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
        <WeekendDayStyle BackColor="#FFFFCC" />
    </asp:Calendar>
    <br />
        <asp:TextBox ID="TextBox2" runat="server" BorderColor="#FF3300" BorderStyle="Groove" Height="300px" TextMode="MultiLine" Width="400px"></asp:TextBox>
    <br />
    <br />
    <asp:Button runat="server" Text="SAVE" OnClick="Unnamed2_Click" BorderStyle="Groove" BorderColor="#00CC00" />
        <asp:Button runat="server" Text="CLEAR" OnClick="Unnamed1_Click" BorderStyle="Groove" BorderColor="#3366CC" />
        <asp:Button runat="server" Text="SEARCH" OnClick="Unnamed3_Click" BorderStyle="Groove" BorderColor="#FF3300" />
        <br />
      <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    </asp:Panel>

    <asp:Panel ID="Panel2" runat="server" style="float: right; width: 50%; display: inline;">
        <br />  
        <h3 id="heading" runat="server"></h3>
        <p id="paragraph" runat="server"></p>
        <br />
    </asp:Panel>

</asp:Content>
