// Add using statement if not already present
using Microsoft.AspNetCore.Builder;

namespace TrilhaApiDesafio
{
    public class Startup
    {
        // Startup class code
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Other middleware configurations

            app.UseHttpsRedirection(); // This line enables HTTPS redirection
        }
    }
}

