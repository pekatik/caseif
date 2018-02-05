namespace CaseIf.Services
{
    public class EmpMasterService : IEmployeeService
    {
        public string GetWage(WageService wageService, string authCode)
        {
            var wat = wageService.Wat(authCode);
            return (600 + wat) + " TL";
        }

    }
}
