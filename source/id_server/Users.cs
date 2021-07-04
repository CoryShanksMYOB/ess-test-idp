using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using IdentityModel;

using IdentityServer4.Configuration;
using IdentityServer4.Models;
using IdentityServer4.Test;


namespace id_server
{
    internal class Users
    {
        public static List<TestUser> Get()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1000",
                    Username = "bryan.brown",
                    Password = "00000",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Email, "bryan.brown@treetop.co.nz"),
                        new Claim(JwtClaimTypes.Name, "Bryan Brown")
                    }
                },
                new TestUser
                {
                    SubjectId = "1003",
                    Username = "ally.hill",
                    Password = "00000",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Email, "ally.hill@treetop.co.nz"),
                        new Claim(JwtClaimTypes.Name, "Ally Hill")
                    }
                }

            };
        }
    }
}
