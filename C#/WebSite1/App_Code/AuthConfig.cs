﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Membership.OpenAuth;

namespace WebSite1
{
    public static class AuthConfig
    {
        public static void RegisterOpenAuth()
        {
            // 如需設定此 ASP.NET 的詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=252803
            //以支援透過外部服務進行登入。

            //OpenAuth.AuthenticationClients.AddTwitter(
            //    consumerKey: "您的 Twitter 使用者金鑰",
            //    consumerSecret: "您的 Twitter 使用者密碼");

            //OpenAuth.AuthenticationClients.AddFacebook(
            //    appId: "您的 Facebook 應用程式識別碼",
            //    appSecret: "您的 Facebook 應用程式密碼");

            //OpenAuth.AuthenticationClients.AddMicrosoft(
            //    clientId: "您的 Microsoft 帳戶用戶端識別碼",
            //    clientSecret: "您的 Microsoft 帳戶用戶端密碼");

            //OpenAuth.AuthenticationClients.AddGoogle();
        }
    }
}