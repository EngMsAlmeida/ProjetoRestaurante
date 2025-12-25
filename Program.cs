using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Photino.Blazor;
using ProjetoRestaurante.Data;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic;
using ProjetoRestaurante;

namespace ProjetoRestaurante;

class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        var builder = PhotinoBlazorAppBuilder.CreateDefault(args);

        //Configuração do Banco de dados SQLite
        builder.Services.AddDbContext<AppDbContext>(Options => Options.UseSqlite("Data Source=restaurante.db"));

        //Registro do componente principal (App)
        builder.RootComponents.Add<App>("#app");

        var app = builder.Build();

        //Tratamento de erros Globais
        app.MainWindow
            .SetTitle("Sistema de Gestão Gastronômica - GourmetPro")
            .SetSize (1200, 800)
            //.SetIconFile ("wwwroot/favicon.ico")
            .SetLogVerbosity(0);

            app.Run();
    }
}