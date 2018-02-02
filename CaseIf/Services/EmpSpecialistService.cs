namespace CaseIf.Services
{
    public class EmpSpecialistService
    {
        public string GetWage(WageService wageService, string authCode)
        {
            var wat = wageService.Wat(authCode);
            return (300 + wat) + " TL";
        }

    }
}
