# Introdução

O QueueFlow é uma API REST para gerenciamento de filas de atendimento. Usuários fazem login,
escolhem uma fila ativa e retiram uma senha. Funcionários chamam a próxima senha, iniciam o
atendimento e o finalizam. Administradores gerenciam usuários e filas.
O projeto é propositalmente pequeno em banco de dados, com apenas três tabelas, mas utiliza regras
de negócio, autenticação, autorização, arquitetura em camadas, DTOs, tratamento de erros e testes.

## Objetivos

Treinar o desenvolvimento de uma API backend organizada, praticando CRUD, REST, relacionamentos,
EF Core, migrations, Services, Data/Repositories, DTOs, regras de negócio, JWT, validação, erros, testes
e integração frontend → API → banco.
 
## Objetivos especificos

Objetivos específicos
1. Cadastrar usuários.
2. Autenticar usuários.
3. Diferenciar permissões por tipo.
4. Cadastrar, ativar e desativar filas.
5. Criar e controlar senhas.
6. Associar senhas a usuários e filas.
7. Chamar, iniciar, finalizar e cancelar atendimentos.
8. Impedir operações inválidas.
9. Retornar HTTP adequado.
10. Organizar a aplicação em camadas.
11. Criar testes das principais regras.
12. Disponibilizar Swagger.


## Tecnologias

C#
ASP.NET Core Web API
Entity Framework Core
MySQL
JWT
Swagger/OpenAPI
Linguagem
API REST
ORM/acesso a dados
Banco relacional
Autenticação
Documentação e testes
xUnit
React
Testes
Tecnologia Utilização
Git/GitHub Versionamento e repositório
