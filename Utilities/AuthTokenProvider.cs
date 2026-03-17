using ApiTestFramework.Services;

namespace ApiTestFramework.Utilities
{
    public class AuthTokenProvider
    {
        private readonly AuthService _authService;
        private string _cachedToken;

        public AuthTokenProvider(AuthService authService)
        {
            _authService = authService;
        }

        public async Task<string> GetTokenAsync()
        {
            if (string.IsNullOrEmpty(_cachedToken))
            {
                _cachedToken = await _authService.GetAuthTokenAsync();
            }
            return _cachedToken;
        }

        public void InvalidateToken()
        {
            _cachedToken = null;
        }
    }
}