using System.Net;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
const int cacheLivingTime = 1000;

app.UseStaticFiles( new StaticFileOptions
{
    OnPrepareResponse = ctx => ctx.Context.Response.Headers.Append("Cache-Control", $"public, max-age={cacheLivingTime}"),
});
app.UseStaticFiles( new StaticFileOptions
{
    OnPrepareResponse = ctx => ctx.Context.Response.Headers.Append("Cache-Control", $"public, max-age={cacheLivingTime}"),
    FileProvider= new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "libraries")),
    RequestPath= "/libraries"
});
app.Run();
