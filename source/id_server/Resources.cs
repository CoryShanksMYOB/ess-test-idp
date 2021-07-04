using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using IdentityServer4.Models;

namespace id_server
{
    internal class Resources
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource
                {
                    Name = "EmployeeCode",
                    UserClaims = new List<string> {"EmployeeCode"}
                }
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[]
            {
                new ApiResource
                {
                    Name = "ess_api",
                    DisplayName = "ESS API",
                    Description = "Allow the application to access ESS API on your behalf",
                    Scopes = new List<string> { "ess.user", "ess.admin" },
                    ApiSecrets = new List<Secret> {new Secret("ScopeSecret".Sha256())},
                    UserClaims = new List<string> {"EmployeeCode"}
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new[]
            {
                new ApiScope("ess.user", "Acces ESS as user"),
                new ApiScope("ess.admin", "Access ESS as admin")
            };
        }
    }
}
