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

3. Execute o projeto:

    ```bash
    dotnet run
    ```

4. Acesse a documentação da API via Swagger:

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
