using System;
namespace RentExpress.Options
{
    public class AppSettings
    {
        public AuthSettings Auth { get; set; }
        public JwtSettings Jwt { get; set; }
        public JwtSettings LightWeightJwt { get; set; }
        public SwaggerSetting Swagger { get; set; }
    }
}
