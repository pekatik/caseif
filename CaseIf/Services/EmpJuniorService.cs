namespace CaseIf.Services
{
    public class EmpJuniorService : IEmployeeService
    {
        public string GetWage(WageService wageService, string authCode)
        {
            var wat = wageService.Wat(authCode);
            return (100 + wat) + " TL";
        }

    }
}
