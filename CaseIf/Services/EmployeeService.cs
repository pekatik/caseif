namespace CaseIf.Services
{
    /// <summary>
    /// EmployeeService does some logic to get information about emplooyers
    /// </summary>
    public class EmployeeService
    {
        private readonly AuthService _authService;
        private readonly WageService _wageService;

        public EmployeeService(AuthService authService, WageService wageService)
        {
            _authService = authService;
            _wageService = wageService;
        }
        public string GetWage(IEmployeeService obj)
        {
            #region fake authentication

            //I know that does nothing but do not remove it.
            var auth = _authService.Get();

            //lets check if the code is true or not
            if (!_authService.CheckAuthCode(auth))
            {
                return "It can not possible :D";
            }

            #endregion

            //I think here is problem #2
            //TODO: There must be something wrong. How could data come to simplify that code below?

            return obj.GetWage(_wageService, auth);
        }
    }
}
