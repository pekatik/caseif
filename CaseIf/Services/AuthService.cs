namespace CaseIf.Services
{
    //DO NOT CHANGE THIS CODE
    //THIS IS DEMO ONLY

    /// <summary>
    /// Authentication service. Imagine that goes and get authentication from somewhere.
    /// </summary>
    public class AuthService
    {

        private string authCode = "A1FS223AASS";
        public string Get()
        {
            return authCode;
        }

        public bool CheckAuthCode(string auth)
        {
            return auth == authCode;
        }
    }
}
