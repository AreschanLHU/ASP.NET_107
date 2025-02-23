﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OpenAuthProviders.ascx.cs" Inherits="Account_OpenAuthProviders" %>
<%@ Import Namespace="Microsoft.AspNet.Membership.OpenAuth" %>
<fieldset class="open-auth-providers">
    <legend>使用其他服務登入</legend>
    
    <asp:ListView runat="server" ID="providersList" ViewStateMode="Disabled">
        <ItemTemplate>
            <button type="submit" name="provider" value="<%# HttpUtility.HtmlAttributeEncode(Item<ProviderDetails>().ProviderName) %>"
                title="使用您的帳戶<%# HttpUtility.HtmlAttributeEncode(Item<ProviderDetails>().ProviderDisplayName) %>登入。">
                <%# HttpUtility.HtmlEncode(Item<ProviderDetails>().ProviderDisplayName) %>
            </button>
        </ItemTemplate>
    
        <EmptyDataTemplate>
            <div class="message-info">
                <p>未設定任何外部驗證服務。如需設定此 ASP.NET 應用程式以支援透過外部服務登入的詳細資料，請參閱<a href="https://go.microsoft.com/fwlink/?LinkId=252803">此文章</a>。</p>
            </div>
        </EmptyDataTemplate>
    </asp:ListView>
</fieldset>