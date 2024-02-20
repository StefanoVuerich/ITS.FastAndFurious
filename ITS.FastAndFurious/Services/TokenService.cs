namespace ITS.FastAndFurious.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string VerifyToken(string token)
        {
            //implementa la verifica del token passato in input
            if (token == _configuration.GetValue<string>("MyKey"))
            {
                return "La password è corretta";
            }

            return "La password non è corretta";
        }
    }
}
