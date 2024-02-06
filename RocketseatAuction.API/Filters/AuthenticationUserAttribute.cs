using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RocketseatAuction.API.Filters
{
    public class AuthenticationUserAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var token = TokenOnRequest(context.HttpContext);
        }

        private string TokenOnRequest(HttpContext context)
        {
            var authentication = context.Request.Headers.Authorization.ToString();

            if (string.IsNullOrEmpty(authentication)) // se a string for vazia | nula retorna Exception
            {
                throw new Exception("Token is missing");
            }

            return authentication["Bearer ".Length..];
        }
    }
}
