namespace MiniprojectTesting.Services
{
    public class AuthenticationService
    {
        private bool _isAuthenticated;
        private string _email;

        public bool IsAuthenticated()
        {
            return _isAuthenticated;
        }
        public async Task<LoginResult> Login(string email, string password)
        {
            // Example async login implementation
            await Task.Delay(100); // Simulate async operation

            // Validate credentials
            if (email == "admin@example.com" && password == "password")
            {
                return new LoginResult { IsSuccess = true };
            }
            else
            {
                return new LoginResult { IsSuccess = false, ErrorMessage = "Invalid credentials" };
            }
        }
        public class LoginResult
        {
            public bool IsSuccess { get; set; }
            public string ErrorMessage { get; set; }
        }

        public void Logout()
        {
            _isAuthenticated = false;
            _email = null;
        }

        public string GetEmail()
        {
            return _email;
        }
    }
}
