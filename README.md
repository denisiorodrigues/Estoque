# Estoque
Projeto de estudo. Aplicando conceitos aprendido no curso de Asp.net core;
O projeto foi desenvolvivido com fluent.

## Camadas:
* WEB
* Business
* e Data (dados)

## Pacotes adicionados
Descrição | Nuget | donet CLI | Observação
--- | --- | --- | ---
**EntityFramework Core 5.0.4** | `Install-Package Microsoft.EntityFrameworkCore` | `dotnet add package Microsoft.EntityFrameworkCore` | *ORM*
**EntityFramework Relational** | `Install-Package Microsoft.EntityFrameworkCore.Relational` | `dotnet add package Microsoft.EntityFrameworkCore.Relational` | *Pacote adicional para usar no mapeamento do Fluent na aplicação*
**EntityFramework Sqlserver** | `Install-Package Microsoft.EntityFrameworkCore.SqlServer` | `dotnet add package Microsoft.EntityFrameworkCore.SqlServer` | *Pacote adicional para comandos SQL SERVER ou gerar scripts sql*

## :lamp Dicas: 
### Comando para adicionar uma migração
---''' Add-Migration Initial -Verbose -Context MeuDbContext'''
### Comando para gerar *SCRIPT* SQL
---'''Script-Migration''' 
### Atualizando a base de dados com as modificações feita pelo entity. Informando o context pela opção '-Context'
---'''Update-Database -Context ApplicationDbContext''' 