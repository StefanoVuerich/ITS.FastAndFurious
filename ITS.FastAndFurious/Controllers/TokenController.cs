namespace ITS.FastAndFurious.Controllers
{
    using ITS.FastAndFurious.Services;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ITokenService _ts;

        public TokenController(IConfiguration configuration, ITokenService ts)
        {
            _configuration = configuration;
            _ts = ts;
        }

        // risponde all'indirizzo /api/token/create
        [HttpGet]
        public string Create()
        {
            return _configuration.GetValue<string>("MyKey");
        }

        // risponde all'indirizzo /api/token/verify?token=Il Mio Token
        [HttpGet]
        public string Verify(string token) 
        { 
            return _ts.VerifyToken(token);
        }
    }
}
