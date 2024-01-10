# To Do List API

Esta é uma API simples para gerenciar tarefas em uma lista de afazeres. Permite a adição, edição, exclusão e marcação de tarefas como concluídas.

## Funcionalidades

- [x] Adicionar nova tarefa
- [x] Listar todas as tarefas
- [x] Editar uma tarefa
- [x] Excluir uma tarefa
- [x] Marcar uma tarefa como concluída

## Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core (para persistência de dados)
- Swagger (para documentação da API)

## Pré-requisitos

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) ou outro editor de código

## Configuração do Ambiente

1. Clone este repositório:

    ```bash
    git clone [https://github.com/seu-usuario/todo-list-api.git](https://github.com/CristianoAlberto/apiToDoList.git)
    cd apiToDoList
    ```

2. Abra o projeto em seu editor de código ou IDE preferido.

3. **Configuração do Banco de Dados MySQL:**

   - Antes de executar a API, é necessário configurar uma instância MySQL para o banco de dados. Siga as etapas abaixo:

     3.1. **Instalação do MySQL:**
        - Certifique-se de ter o MySQL instalado na sua máquina. Você pode baixá-lo [aqui](https://dev.mysql.com/downloads/mysql/).

     3.2. **Criação do Banco de Dados:**
        - Abra um cliente MySQL e crie um banco de dados para a aplicação.

        ```sql
        CREATE DATABASE ToDoListDB;
        ```

     3.3. **Ajuste da Connection String:**
        - No projeto API, abra o arquivo `appsettings.json` e ajuste a Connection String com as informações do seu banco de dados MySQL.

        ```json
        "ConnectionStrings": {
          "DefaultConnection": "server=SEU_SERVIDOR;port=SUA_PORTA;database=ToDoListDB;user=SEU_USUARIO;password=SUA_SENHA"
        },
        ```

        Substitua `SEU_SERVIDOR`, `SUA_PORTA`, `SEU_USUARIO` e `SUA_SENHA` pelas informações corretas do seu ambiente MySQL.

     3.4. **Execução do Projeto:**
        - Após configurar o MySQL e ajustar a Connection String, execute o projeto novamente:

     # Instale a ferramenta de Entity Framework globalmente
dotnet tool install --global dotnet-ef

# Crie uma migração inicial para o modelo de dados
dotnet ef migrations add FirstModelMigration -o Data/Migrations

# Execute a migração para criar ou atualizar o banco de dados
dotnet ef database update

# Execute o projeto
dotnet run

5. Execute o projeto:

    ```bash
    dotnet run
    ```

6. Acesse a documentação da API via Swagger:

    [http://localhost:5150/swagger](http://localhost:5150/swagger)

## Exemplos de Uso

### Adicionar Nova Tarefa

```http
POST /api/ToDoList
Content-Type: application/json

{
  "taskName": "Completar o README",
  "status": false
}
