using System.Security.Claims;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace IdentityServer;

public class Config
{
    public static IEnumerable<Client> Clients => new Client[]
    {
        new()
        {
            ClientId = "movieClient",
            AllowedGrantTypes = GrantTypes.ClientCredentials,
            ClientSecrets =
            {
                new Secret("secret".Sha256())
            },
            AllowedScopes = {"movieAPI"}
        },
        new()
        {
            ClientId = "movies_mvc_client",
            ClientName = "Movies MVC Web App",
            AllowedGrantTypes = GrantTypes.Code,
            AllowRememberConsent = false,
            RedirectUris =
                {
                    "https://localhost:7186/signin-oidc"
                },
            PostLogoutRedirectUris =
                {
                    "https://localhost:7186/signout-callback-oidc"
                },
            ClientSecrets =
            {
                new Secret("secret".Sha256())
            },
            AllowedScopes =
            {
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile,
            }
        }
    };
    public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
    {
        new("movieAPI", "Movie API")
    };
    public static IEnumerable<ApiResource> ApiResources => new ApiResource[] { };
    public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
    {
        new IdentityResources.OpenId(),
        new IdentityResources.Profile()
    };
    public static List<TestUser> TestUsers => new List<TestUser>
    {
        new TestUser
        {
            SubjectId = "5BE86359-073C-434B-AD2D-A3932222DABE",
            Username = "mehmet",
            Password = "mehmet",
            Claims = new List<Claim>
            {
                new Claim(JwtClaimTypes.GivenName, "Mehmet"),
                new Claim(JwtClaimTypes.FamilyName, "Ozkaya")
            }
        }
    };
}