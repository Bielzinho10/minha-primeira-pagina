using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// ✅ Serve index.html automaticamente se alguem acessar "/"
app.UseDefaultFiles(); 

// ✅ Permite carregar arquivos staticos (como HTML, CSS, JS, imagens)
app.UseStaticFiles();

// ✅ Rota personalizada para a pagina "Sobre Mim"
app.MapGet("/sobre", async context =>
{
    await context.Response.SendFileAsync("wwwroot/sobre.html");
});

app.Run();
