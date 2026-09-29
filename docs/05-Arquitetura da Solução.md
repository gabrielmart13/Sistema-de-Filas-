# Arquitetura da Solução

## Modelo de Dados

Uma pessoa pode possuir várias senhas ao longo do tempo. Uma fila pode possuir várias senhas. Cada
senha pertence a exatamente um usuário e uma fila.

|Campo|Tipo|Detalhes|
|------|------|------|
|Id|INT|PK, AUTO_INCREMENT, REQUIRED|
|Nome|VARCHAR(100)|REQUIRED|
|Email|VARCHAR(150)|REQUIRED, UNIQUE|
|SenhaHash|VARCHAR(255)|REQUIRED|
|Tipo|VARCHAR(20)|REQUIRED|
|CriadoEm|DATETIME|REQUIRED|


|Campo|Tipo|Detalhes|
|------|------|------|
|Id|INT|PK, AUTO_INCREMENT, REQUIRED|
|Nome|VARCHAR(100)|REQUIRED|
|Descricao|VARCHAR(255)|NULL|
|Ativa|BOOLEAN|REQUIRED, DEFAULT TRUE|
|CriadaEm|DATETIME|REQUIRED|


|Campo|Tipo|Detalhes|
|------|------|------|
|Id|INT|PK, AUTO_INCREMENT, REQUIRED|
|Numero|INT|REQUIRED|
|Status|VARCHAR(30)|REQUIRED|
|CriadaEm|DATETIME|REQUIRED|
|ChamadoEm|DATETIME|NULL|
|FinalizadaEm|DATETIME|NULL|
|UsuarioId|INT|REQUIRED, FK|
|FilaId|INT|REQUIRED, FK|

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.
