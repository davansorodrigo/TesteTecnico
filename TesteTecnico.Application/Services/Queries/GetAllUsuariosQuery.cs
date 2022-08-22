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
    public class GetAllUsuariosQuery : IRequest<IEnumerable<Usuario>>
    {
        public class GetAllUsuariosQueryHandler : IRequestHandler<GetAllUsuariosQuery,
            IEnumerable<Usuario>>
        {
            private readonly IUsuarioRepository _context;
            private readonly IMediator _mediator;
            public GetAllUsuariosQueryHandler(IUsuarioRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<IEnumerable<Usuario>> Handle(GetAllUsuariosQuery query,
                CancellationToken cancellationToken)
            {
                var customerList = await _context.GetAll();

                if (customerList == null) return default;

                return customerList;
            }
        }

    }
}
