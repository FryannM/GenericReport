using System;
namespace RentExpress.Options
{

    public class JwtSettings
    {
        public string Secret { get; set; }

        public string Issuer { get; set; }

        public TimeSpan LifeTimeDuration { get; set; }
    }
}
