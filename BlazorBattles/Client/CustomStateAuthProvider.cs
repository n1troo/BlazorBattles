using System.Security.Claims;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorBattles.Client;

public class CustomStateAuthProvider : AuthenticationStateProvider
{
    private readonly ILocalStorageService _localStorageService;

    public CustomStateAuthProvider(ILocalStorageService localStorageService)
    {
        _localStorageService = localStorageService;
    }
    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {

        if (await _localStorageService.GetItemAsync<bool>("isAuthenticated"))
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, "Rafal"),
            }, "Test authentication typ");

            var user = new ClaimsPrincipal(identity);
            var state = new AuthenticationState(user);
            NotifyAuthenticationStateChanged(Task.FromResult(state));
            
            return state;
        }
        return new AuthenticationState(new ClaimsPrincipal());

        
    }
}