using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiScope> ApiScope => new List<ApiScope>
        {
            new ApiScope("testapis","Test API Scope")

        };
        public static IEnumerable<Client> Clients => new List<Client>
        {
            new Client
            {
                ClientId ="testclient",
                AllowedGrantTypes= GrantTypes.ClientCredentials,
                ClientSecrets =
                {
                    new Secret("testsecret".Sha256())
                    
                },
                AllowedScopes =
                {
                    "testapis"
                }
            }

        };
    }
}
