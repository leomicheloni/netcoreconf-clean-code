using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace SaludoGlobalizado
{
    // Definimos una interfaz para la abstracción del log
    public interface ILogService
    {
        Task LogAsync(string mensaje);
    }

    // Implementación concreta del servicio de log
    public class ConsoleLogService : ILogService
    {
        public async Task LogAsync(string mensaje)
        {
            await Task.Run(() => Console.WriteLine($"[LOG]: {mensaje}"));
        }
    }

    // Definimos un comando para solicitar el saludo en un idioma específico
    public class ObtenerSaludoCommand : IRequest<string>
    {
        public string Idioma { get; set; }
    }

    // Manejador para el comando de obtener saludo
    public class ObtenerSaludoCommandHandler : IRequestHandler<ObtenerSaludoCommand, string>
    {
        private readonly ILogService _logService;

        public ObtenerSaludoCommandHandler(ILogService logService)
        {
            _logService = logService;
        }

        public async Task<string> Handle(ObtenerSaludoCommand request, CancellationToken cancellationToken)
        {
            var idiomaEncontrado = ObtenerIdioma(request.Idioma);
            if (idiomaEncontrado != null)
            {
                await _logService.LogAsync($"Saludo en {idiomaEncontrado.Nombre}: {idiomaEncontrado.Saludo}");
                return idiomaEncontrado.Saludo;
            }
            else
            {
                await _logService.LogAsync("No se encontró el idioma especificado.");
                return "No se encontró el idioma especificado.";
            }
        }

        private Idioma ObtenerIdioma(string idioma)
        {
            // Implementación ficticia para obtener el idioma (similar a la versión anterior)
            return idioma.Equals("Inglés", StringComparison.OrdinalIgnoreCase)
                ? new Idioma { Nombre = "Inglés", Saludo = "Hello, World!" }
                : idioma.Equals("Español", StringComparison.OrdinalIgnoreCase)
                    ? new Idioma { Nombre = "Español", Saludo = "¡Hola, Mundo!" }
                    : null;
        }
    }

    // Configuración y ejecución
    class Program
    {
        static async Task Main(string[] args)
        {
            // Creamos una instancia del servicio de log
            var logService = new ConsoleLogService();

            // Configuramos MediatR con un service locator
            var mediator = ConfigureMediator(logService);

            // Solicitamos el saludo en un idioma específico (por ejemplo, inglés)
            var idiomaElegido = "Inglés";
            var saludo = await mediator.Send(new ObtenerSaludoCommand { Idioma = idiomaElegido });

            // No necesitamos Console.WriteLine aquí, ya que el log se maneja internamente
        }

        // Configuración de MediatR con un service locator
        static IMediator ConfigureMediator(ILogService logService)
        {
            var serviceFactory = new ServiceFactory(type =>
            {
                if (type == typeof(ObtenerSaludoCommandHandler))
                    return new ObtenerSaludoCommandHandler(logService);

                // Agrega más manejadores aquí si es necesario

                throw new InvalidOperationException($"Manejador no registrado para {type}");
            });

            return new Mediator(serviceFactory);
        }
    }
}