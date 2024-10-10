var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "projeto web - Lh pets v1");

app.UseStaticFiles();

Banco banco = new Banco();
app.MapGet("/listaClientes",(HttpContext context)=>{
    context.Response.WriteAsync(banco.GetListaString());
});

app.Run();
