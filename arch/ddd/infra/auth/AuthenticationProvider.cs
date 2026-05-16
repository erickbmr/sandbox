namespace ddd.infra.auth
{
    public class AuthenticationProvider
    {
        public string GetToken()
        {
            return "new-token-test";
        }

        public string ValidateUser(string name, string pass)
        {
            return string.IsNullOrEmpty(pass) ? name.Length > 0 : false;
        }
    }
}