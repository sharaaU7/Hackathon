<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FundingAccounts.aspx.cs" Inherits="FundingAccounts" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style type="text/css">
            .MyImageButton
            {
               cursor: hand;
            }
            .EditFormHeader td
            {
                font-size: 14px;
                padding: 4px !important;
                color: #0066cc;
            }
        </style>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server"  />  
</head>
<body>
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
        </Scripts>
    </telerik:RadScriptManager>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" />
    <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server">
        <telerik:RadGrid ID="RadGrid1" GridLines="None" runat="server" AllowAutomaticDeletes="True" AllowSorting="True"
            AllowAutomaticInserts="True" PageSize="10" AllowAutomaticUpdates="True" AllowMultiRowEdit="True" 
            AllowPaging="False" DataSourceID="DataSource1" OnItemUpdated="RadGrid1_ItemUpdated" 
            AllowFilteringByColumn="False" OnItemDeleted="RadGrid1_ItemDeleted" 
            OnItemInserted="RadGrid1_ItemInserted" OnDataBound="RadGrid1_DataBound">
            <PagerStyle Mode="NextPrevAndNumeric" />
            <MasterTableView Width="100%" CommandItemDisplay="TopAndBottom" DataKeyNames="" 
                DataSourceID="DataSource1" HorizontalAlign="NotSet" EditMode="InPlace">
                <Columns>
                    <telerik:GridEditCommandColumn ButtonType="ImageButton" UniqueName="EditCommandColumn">
                        <ItemStyle CssClass="MyImageButton" />
                    </telerik:GridEditCommandColumn>               
                    <telerik:GridButtonColumn ConfirmText="Delete this product?" ConfirmDialogType="RadWindow"
                        ConfirmTitle="Delete" ButtonType="ImageButton" CommandName="Delete" Text="Delete"
                        UniqueName="DeleteColumn">
                        <ItemStyle HorizontalAlign="Center" CssClass="MyImageButton" />
                    </telerik:GridButtonColumn>
                </Columns>
                <EditFormSettings>
                   <FormTableItemStyle Wrap="False"></FormTableItemStyle>
                    <FormCaptionStyle CssClass="EditFormHeader"></FormCaptionStyle>
                    <FormMainTableStyle GridLines="None" CellSpacing="0" CellPadding="3" BackColor="White"
                        Width="100%" />
                    <FormTableStyle CellSpacing="0" CellPadding="2" Height="110px" BackColor="White" />
                    <FormTableAlternatingItemStyle Wrap="False"></FormTableAlternatingItemStyle>
                    <EditColumn ButtonType="ImageButton" 
                        UniqueName="EditCommandColumn1" CancelText="Cancel edit">
                    </EditColumn>
                    <FormTableButtonRowStyle HorizontalAlign="Right" CssClass="EditFormButtonRow"></FormTableButtonRowStyle>
                </EditFormSettings>
            </MasterTableView>
        </telerik:RadGrid>
        <telerik:RadWindowManager ID="RadWindowManager1" runat="server"></telerik:RadWindowManager>
    </telerik:RadAjaxPanel>
<asp:SqlDataSource DeleteCommand="DELETE FROM FundingAccounts" InsertCommand="INSERT INTO FundingAccounts (Name, Balance) VALUES (@Name,@Balance)" SelectCommand="SELECT Name, Balance FROM FundingAccounts" UpdateCommand="UPDATE FundingAccounts SET Name =@Name, Balance =@Balance" ConnectionString="<%$ ConnectionStrings:BuddyCardConnectionString %>" ProviderName="System.Data.SqlClient" ID="DataSource1" runat="server" ></asp:SqlDataSource>
    </form>
</body>
</html>
