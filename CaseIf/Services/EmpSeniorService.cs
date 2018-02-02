namespace CaseIf.Services
{
    public class EmpSeniorService
    {
        public string GetWage(WageService wageService, string authCode)
        {
            var wat = wageService.Wat(authCode);
            return (500 + wat) + " TL";
        }

    }
}
