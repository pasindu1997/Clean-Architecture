using Boomerang.Employee.Application.Common.Interfaces;
using Boomerang.Employee.Infrastructure.Files;
using Boomerang.Employee.Infrastructure.Persistence;
using Boomerang.Employee.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Security.Claims;

namespace Boomerang.Employee.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"), 
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());

            //if (environment.IsEnvironment("Test"))
            //{
            //    services.AddIdentityServer()
            //        .AddApiAuthorization<ApplicationUser, ApplicationDbContext>(options =>
            //        {
            //            options.Clients.Add(new Client
            //            {
            //                ClientId = "Boomerang.Employee.IntegrationTests",
            //                AllowedGrantTypes = { GrantType.ResourceOwnerPassword },
            //                ClientSecrets = { new Secret("secret".Sha256()) },
            //                AllowedScopes = { "Boomerang.Employee.WebUIAPI", "openid", "profile" }
            //            });
            //        }).AddTestUsers(new List<TestUser>
            //        {
            //            new TestUser
            //            {
            //                SubjectId = "f26da293-02fb-4c90-be75-e4aa51e0bb17",
            //                Username = "jason@clean-architecture",
            //                Password = "Boomerang.Employee!",
            //                Claims = new List<Claim>
            //                {
            //                    new Claim(JwtClaimTypes.Email, "jason@clean-architecture")
            //                }
            //            }
            //        });
            //}
            //else
            //{
                //services.AddIdentityServer()
                //    .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

                services.AddTransient<IDateTime, DateTimeService>();
                //services.AddTransient<IIdentityService, IdentityService>();
                services.AddTransient<ICsvFileBuilder, CsvFileBuilder>();
            //}

            //services.AddAuthentication()
            //    .AddIdentityServerJwt();

            return services;
        }
    }
}
