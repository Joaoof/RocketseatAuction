using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RocketseatAuction.API.Repositories;

namespace RocketseatAuction.API.Filters
{
    public class AuthenticationUserAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                var token = TokenOnRequest(context.HttpContext);

                var repository = new RocktseatAuctionDbContext(); // criando um contexto para verificação do token do email do user

                var email = FromBase64String(token);

                var exists = repository.Users.Any(user => user.Email.Equals(email)); // Verificando se existir o email do token

                if (exists == false) // o token recebido tem o email n encontrado no db, por isso false
                {
                    context.Result = new UnauthorizedObjectResult("E-mail not valid");
                }
            }
            catch (Exception ex)
            {
                context.Result = new UnauthorizedObjectResult(ex.Message);
            }
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

        private string FromBase64String(string base64)
        {
            var data = Convert.FromBase64String(base64);

            return System.Text.Encoding.UTF8.GetString(data);
        }
    }
}
