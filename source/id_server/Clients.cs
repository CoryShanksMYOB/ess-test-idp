using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using IdentityServer4;
using IdentityServer4.Models;

namespace id_server
{
    internal class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "PayGlobalESS",
                    ClientName = "PayGlobal Employee Self-Service",
                    AllowedGrantTypes = GrantTypes.Hybrid,
                    ClientSecrets = new List<Secret> { new Secret("{AA3E3B1E-B306-435E-B460-9D5D5C48881C}".Sha256()) },
                    RedirectUris = new List<string> {"https://localhost/ess/ssolanding.aspx"},
                    PostLogoutRedirectUris = new List<string> { "https://localhost/ess/ssologout.aspx" },
                    AllowedScopes = new List<string> 
                    { 
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "ess.user"
                    },
                    RequirePkce = false,
                    AccessTokenType = AccessTokenType.Jwt
                }
            };
        }
    }
}
