using MediatR;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using TesteTecnico.Domain.Entities;
using TesteTecnico.Domain.Interfaces;
using static TesteTecnico.Application.Services.Commands.CreateUsuarioCommand;

namespace TesteTecnico.Application.Services.Commands
{
    public class UpdateUsuarioCommand : IRequest<int>
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50, ErrorMessage = "Tamanho máximo é de 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50, ErrorMessage = "Tamanho máximo é de 50 caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50, ErrorMessage = "Tamanho máximo é de 100 caracteres")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required]
        [MyDate(ErrorMessage = "Data de nascimento não pode ser maior que hoje")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, 4, ErrorMessage = "Escolaridade inválida")]
        public int EscolaridadeId { get; set; }
        public int HistoricoEscolarId { get; set; }


        public class UpdateUsuarioCommandHandler : IRequestHandler<UpdateUsuarioCommand, int>
        {
            private readonly IUsuarioRepository _context;
            private readonly IMediator _mediator;

            public UpdateUsuarioCommandHandler(IUsuarioRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<int> Handle(UpdateUsuarioCommand command,
                CancellationToken cancellationToken)
            {
                var usuario = await _context.GetById(command.Id);

                if (usuario == null) return default;

                usuario.Nome = command.Nome;
                usuario.Sobrenome = command.Sobrenome;
                usuario.Email = command.Email;
                usuario.DataNascimento = command.DataNascimento;
                usuario.EscolaridadeId = command.EscolaridadeId;
                usuario.HistoricoEscolarId = command.HistoricoEscolarId;

                _context.Update(usuario);

                return usuario.Id;
            }
        }
    }
}
