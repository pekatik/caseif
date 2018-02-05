namespace CaseIf.Services
{
    public interface IEmployeeService
    {
        string GetWage(WageService wageService, string authCode);
    }
}
