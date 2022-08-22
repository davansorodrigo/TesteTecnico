using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TesteTecnico.Domain.Entities;
using TesteTecnico.Domain.Interfaces;

namespace TesteTecnico.Application.Services.Commands
{
    public class DeleteUsuarioCommand : IRequest<int>
    {
        public int Id { get; set; }

        public class DeleteUsuarioCommandHandler : IRequestHandler<DeleteUsuarioCommand, int>
        {
            private readonly IUsuarioRepository _context;
            private readonly IMediator _mediator;

            public DeleteUsuarioCommandHandler(IUsuarioRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<int> Handle(DeleteUsuarioCommand command,
                CancellationToken cancellationToken)
            {
                var usuario = await _context.GetById(command.Id);

                if (usuario == null) return default;

                _context.Remove(usuario);

                return usuario.Id;
            }
        }
    }
}
