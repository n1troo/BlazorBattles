using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorBattles.Client;

public class CustomAuthProvider : AuthenticationStateProvider
{
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, "Rafal"),
        }, "Test authentication typ");

        var user = new ClaimsPrincipal(identity);

        return Task.FromResult(new AuthenticationState(user));

        // return Task.FromResult(new AuthenticationState(new ClaimsPrincipal()));
    }
}