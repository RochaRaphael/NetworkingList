# NetworkingList

### Introdução

A ideia desse projeto é armazenar uma lista de contatos e a especialidade de cada um, as "skills". Ao cadastrar um contato novo, você insere a skill 
que a pessoa tem, e caso a skill não esteja cadastrada no banco ainda, aparecerá a opção de inserir a nota de  10 do quanto você já sabe daquela skill.
A vantagem seria você digitar o nome da skill que você deseja, e o programa mostra todas as pessoas que tem essa habilidade, para que você, consiga entrar 
em contato.

--------------------------------------
## Arquitetura do projeto

O arquivo DataAccess é onde tem todos os acessos ao banco de dados. Apenas nessa classe terá os métodos que editará diretamente o banco.
Na pasta Models, teremos as classes que simulam as tabelas do banco de dados.
Na pasta Data, fazemos a conexão e mapeamento com o banco de dados.

--------------------------------------

### Executando a Aplicação Localmente 🔥

- Caso não tenha o .NET instalado, [clique aqui](https://balta.io/blog/dotnet-instalacao-configuracao-e-primeiros-passos) para entender como instalar.

- Para os dados serem inseridos no banco, usaremos o Azure Data Studio, para baixá-lo [clique aqui](https://azure.microsoft.com/pt-br/products/data-studio/#overview)

- Caso não tenha o sistema operacional Linux, baixe o Docker. As instruções para instalação do mesmo [está aqui](https://balta.io/blog/docker-instalacao-configuracao-e-primeiros-passos)

- Instale o Sql no docker. [Clique aqui](https://balta.io/blog/sql-server-docker) para as instruções 

Se tiver feita as instalações conforme os tutoriais, você chegará em uma ela do Docker parecida com essa, onde terá pelo menos o container `sqlserver`
Clique no botão de Play indicado pela seta para rodar o Docker e conseguirmos conectar com o Azure Data Studio

![Doker](https://user-images.githubusercontent.com/109389657/205405654-27f5f268-5e89-4ae8-a870-1c28c9b20c60.PNG)


Agora abra o Azure Data Studio e gere uma nova conexão
Os dados de conexão são os da imagem e a senha é: 1q2w3e4r@#$

![Conexão](https://user-images.githubusercontent.com/109389657/205406558-62e7ca62-338f-4bb9-81c4-650b1a2e7df8.PNG)


Para executar localmente a aplicação você precisa entrar na pasta `HospitalWarehouse` e executar o seguinte comando:

```
> dotnet run
```

Para que, possamos executar o `Entity Framework` no projeto, se faz necessário executar os seguintes comandos dentro da pasta HospitalWarehouse
```
> dotnet tool install --global dotnet-ef
> dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
> dotnet add package Microsoft.EntityFrameworkCore.Design
> dotnet add package Microsoft.EntityFrameworkCore.Sqlite
> dotnet restore
> dotnet ef migrations add InitialCreate
> dotnet ef database update
```

# Tenho Dúvidas... O que Faço?! ❓
Caso tenham dúvidas aos códigos desenvolvidos aqui, sintam-se a vontade em abrir uma [ISSUE AQUI](https://github.com/RochaRaphael/NetworkingList/issues). Assim que possível, estarei respondendo as todas as dúvidas que tiverem!
