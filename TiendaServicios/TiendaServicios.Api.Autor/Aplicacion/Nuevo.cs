using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using TiendaServicios.Api.Autor.Modelo;
using TiendaServicios.Api.Autor.Persistencia;

namespace TiendaServicios.Api.Autor.Aplicacion
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public DateTime? FechaNacimiento { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly ILogger<Manejador> _logger;
            public readonly ContextoAutor _contexto;

            public Manejador(ContextoAutor contexto, ILogger<Manejador> logger)
            {
                _contexto = contexto;
                _logger = logger;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var autorLibro = new AutorLibro
                {
                    Nombre = request.Nombre,
                    Apellido = request.Apellido,
                    FechaNacimiento = request.FechaNacimiento
                };
                _contexto.AutorLibro.Add(autorLibro);
                var valor = await _contexto.SaveChangesAsync();
                if (valor > 0)
                {
                    _logger.LogInformation("se pudo insertar el Autor del Libro", DateTime.UtcNow);
                    return Unit.Value;
                }
                _logger.LogError("No se pudo insertar el Autor del Libro");
                throw new Exception("No se pudo insertar el Autor del Libro");
            }
        }
    }
}