using TechVilleSmartCity.Services;

class Program
{
    static void Main(string[] args)
    {
        CitizenRegistrationService service = new CitizenRegistrationService();
        service.RegisterCitizen();
    }
}
