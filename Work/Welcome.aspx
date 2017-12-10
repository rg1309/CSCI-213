<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Work_Welcome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
    <br />
</p>
<p class="text-center">
    Welcome To Hospital Manangment</p>
<p class="text-primary">
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Work/Doctor.aspx">Doctor</asp:HyperLink>
</p>
<p class="text-primary">
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Work/Patient.aspx">Patient</asp:HyperLink>
</p>
<p>
</p>
<p>
</p>
</asp:Content>

