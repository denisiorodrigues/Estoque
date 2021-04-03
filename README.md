# Estoque
---Projeto de estudo. Aplicando conceitos aprendido no curso de Asp.net core;

* O projeto foi desenvolvivido utilizando **_Fluent_** para configuração da base de dados.
* Foi adicionao o padrão **_Repository_** na camada de negócio.

---Vamos utilizar o padrão _Repository_ para acesso a base de dados, na camada de apresentação vamos utilizar as ViewsModels, ou DTOs (Data Transformer Objects), 
com Automapper para realizar a troca de informações entre os modelos de negócio e os modelos de aprenseção. Para configurar o _Automapper_ precisadmos adicionar o pacote do mesmo. E também precisamos 
adicionar uma extensão para a injeção de dependência do aspnet para o _Automapper_ funcionar.
---Vamos configurar o _Automapper_ na classe _stratup.cs_ =, referenciando a própria _Stratup_, e depois criar uma arquivo de configuração para configurar as _ViewModels_ com as Entidades(_Models_).
---O _AutoMapper_ entende a configuração desde que possua alguma classe que esteja herdadno de _Profile.cs_, fuinciona meio que automático.

## Camadas:
* WEB
* Business
* e Data (dados)

## Pacotes adicionados
Descrição | Nuget | donet CLI | Observação
--- | --- | --- | ---
**[EntityFramework Core 5.0.4](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/5.0.4)** | `Install-Package Microsoft.EntityFrameworkCore` | `dotnet add package Microsoft.EntityFrameworkCore` | *ORM*
**[EntityFramework Relational](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Relational/6.0.0-preview.2.21154.2)** | `Install-Package Microsoft.EntityFrameworkCore.Relational` | `dotnet add package Microsoft.EntityFrameworkCore.Relational` | *Pacote adicional para usar no mapeamento do Fluent na aplicação*
**[EntityFramework Sqlserver](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/6.0.0-preview.2.21154.2)** | `Install-Package Microsoft.EntityFrameworkCore.SqlServer` | `dotnet add package Microsoft.EntityFrameworkCore.SqlServer` | *Pacote adicional para comandos SQL SERVER ou gerar scripts sql*
**[Automapper](https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection/)** | `Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection -Version 8.1.1` | `dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 8.1.1` | *Pacote adicional para comandos SQL SERVER ou gerar scripts sql*

## :lamp Dicas: 
### Comando para adicionar uma migração
---''' Add-Migration Initial -Verbose -Context MeuDbContext'''
### Comando para gerar *SCRIPT* SQL
---'''Script-Migration''' 
### Atualizando a base de dados com as modificações feita pelo entity. Informando o context pela opção '-Context'
---'''Update-Database -Context ApplicationDbContext''' 