using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TesteTecnico.Domain.Entities;
using TesteTecnico.Domain.Interfaces;

namespace TesteTecnico.Application.Services.Queries
{
    public class GetUsuarioByIdQuery : IRequest<Usuario>
    {
        public int Id { get; set; }
        public class GetUsuarioByIdQueryHandler : IRequestHandler<GetUsuarioByIdQuery, Usuario>
        {
            private readonly IUsuarioRepository _context;
            private readonly IMediator _mediator;
            public GetUsuarioByIdQueryHandler(IUsuarioRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Usuario> Handle(GetUsuarioByIdQuery query, CancellationToken cancellationToken)
            {
                var usuario = await _context.GetById(query.Id);

                if (usuario == null) return default;

                return usuario;
            }
        }
    }
}
