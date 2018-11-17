using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace TokenServiceApi
{
    public static class SigninKeyExtension
    {
        public static void AddCertificateFromFile(
        this IIdentityServerBuilder builder,
        IConfigurationSection options)
        {
            var keyFilePath = options.GetValue<string>("KeyFilePath");
            var keyFilePassword = options.GetValue<string>("KeyFilePassword");

            if (File.Exists(keyFilePath))
            {
                

                // You can simply add this line in the Startup.cs if you don't want an extension. 
                // This is neater though ;)
                builder.AddSigningCredential(new X509Certificate2(keyFilePath, keyFilePassword));
            }
        }
    }
}
