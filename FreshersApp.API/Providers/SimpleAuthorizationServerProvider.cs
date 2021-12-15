﻿using FreshersApp.Business.Entities;
using FreshersApp.Data.Repositories;
using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FreshersApp.API.Providers
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            //context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            //using (UserRepository _repo = new UserRepository())
            //{
            //    var filter1 = new { UserName = context.UserName, Password = context.Password };

            //      UserDetailsEntity user = _repo.GetUserdetails<UserDetailsEntity>(filter1);
            //    if (user != null)
            //    {

            //    }
            //    else
            //    {
            //        context.SetError("invalid_grant", "The user name or password is incorrect.");
            //        return;
            //    }
            //}
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("sub", context.UserName));
            identity.AddClaim(new Claim("role", "user"));
            context.Validated(identity);
        }
    }
}