# Especificações do Projeto

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001|A aplicação deve permitir o cadastro de usuários|ALTA|
|RF-002|A aplicação deve permitir que o usuário realize login no sistema|ALTA|
|RF-003|A aplicação deve permitir o cadastro, alteração, consulta e exclusão de filas|ALTA|
|RF-004|A aplicação deve permitir ativar e desativar uma fila|ALTA|
|RF-005|A aplicação deve permitir que o usuário obtenha uma senha em uma fila ativa|ALTA|
|RF-006|A aplicação deve permitir que o usuário consulte as senhas de uma fila|MÉDIA|
|RF-007|A aplicação deve permitir o cancelamento de uma senha|MÉDIA|
|RF-008|A aplicação deve permitir que o atendente chame a próxima senha da fila|ALTA|
|RF-009|A aplicação deve permitir iniciar e finalizar o atendimento de uma senha|ALTA|
|RF-010|A aplicação deve permitir consultar o estado atual de uma fila|ALTA|

### Requisitos não Funcionais

|ID|Descrição do Requisito|Prioridade|
|------|-----------------------------------------|----|
|RNF-001|A aplicação deve ser desenvolvida utilizando C# e ASP.NET Core|ALTA|
|RNF-002|A aplicação deve utilizar Entity Framework Core e SQLite para persistência dos dados|ALTA|
|RNF-003|A API deve seguir os princípios REST e utilizar códigos de status HTTP adequados|ALTA|
|RNF-004|A aplicação deve utilizar arquitetura em camadas, separando Controllers, Services, Repositories e acesso aos dados|ALTA|
|RNF-005|A aplicação deve utilizar autenticação e autorização para controlar o acesso às funcionalidades|ALTA|
|RNF-006|A aplicação deve possuir tratamento centralizado de erros e testes automatizados das principais regras de negócio|MÉDIA|

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                                        |
|--|------------------------------------------------------------------|
|01| O projeto deverá ser desenvolvido dentro do prazo definido      |
|02| O sistema deverá utilizar C# e ASP.NET Core no desenvolvimento da API |
|03| O sistema deverá utilizar SQLite como banco de dados            |
|04| O sistema deverá utilizar Entity Framework Core para acesso aos dados |
|05| O projeto deverá manter o escopo limitado às funcionalidades definidas nos requisitos |




