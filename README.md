# Projeto TesteTecnico

O projeto TesteTecnico é uma API desenvolvida na plataforma .NET Core. Neste projeto foi utilizado conceitos arquiteturais de modelagem de domínio (DDD) e separação de comandos e consultas (CQRS).

A API consiste em adicionar, alterar, listar e excluir usuários.
Regras de validação foram respeitadas, como:
- Validação de email
- Data de nascimento não pode ser maior que hoje
- Escolaridade deve permitir apenas valores (Infantil, Fundamental, Médio e Superior)


#### Tecnologias Implementadas
 - [x] ASP.NET Core 5
 - [x] ASP.NET WebApi Core
 - [x] SQL Server Express
 - [x] Entity Framework Core 5


 #### Arquiteturas
 - [x] Domain Driven Design
 - [x] CQRS
 - [x] Repository e Generic Repository
 - [x] Unit Of Work



 #### Foi desenvolvido um outro projeto em Angular para consumo dos dados da API
[Projeto TesteTecnicoSPAAngular](https://github.com/davansorodrigo/TesteTecnicoSPAAngular)
