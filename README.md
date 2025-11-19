📌 ToDoListApp — API REST em .NET 8

Uma API REST simples e moderna para gerenciamento de tarefas (To-Do), desenvolvida em ASP.NET Core 8, utilizando Entity Framework Core, Migrations, Injeção de Dependência e boas práticas de organização de código.
Ideal para estudos, portfólio e demonstração de arquitetura limpa para pequenos serviços.

🚀 Tecnologias Utilizadas

.NET 8 (ASP.NET Core Web API)

Entity Framework Core (Code-First)

SQLite / SQL Server (configurável)

JWT (JSON Web Token) – estrutura preparada

Swagger / OpenAPI

Injeção de Dependência

Migrations (EF Core)

🗂️ Estrutura do Projeto
ToDoListApp/
│
├── Controllers/
│   └── TodoController.cs        → Endpoints da API
│
├── Data/
│   ├── TodoContext.cs           → DbContext (EF Core)
│   └── TodoContextFactory.cs    → Suporte a migrations
│
├── Migrations/                  → Histórico de migrations EF
│
├── Models/
│   ├── TodoItem.cs              → Modelo principal
│   └── DateTimeConverter.cs     → Conversão automática de datas
│
├── Services/
│   └── TodoServices.cs          → Lógica de negócios
│
├── appsettings.json             → Configurações gerais
├── Program.cs                   → Configuração da aplicação
└── ToDoListApp.csproj           → Configuração do projeto

⚙️ Como Executar o Projeto
🔧 1. Clonar o repositório
git clone https://github.com/Wellington-Roveder/ToDoListApp.git
cd ToDoListApp

🔐 2. Configure a string de conexão com User Secrets
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost;Database=ToDoListDb;User=root;Password=senha;"

📦 3. Restaurar dependências
dotnet restore

🗄️ 4. Executar Migrations
dotnet ef database update

▶ 5. Rodar a aplicação
dotnet run
Acesse o Swagger em:

👉 http://localhost:5149/swagger
📡 Endpoints Disponíveis
➤ GET /api/todo

Retorna todas as tarefas.

➤ GET /api/todo/{id}

Retorna uma tarefa específica.

➤ POST /api/todo

Cria uma nova tarefa.

Exemplo de JSON:

{
  "title": "Estudar .NET",
  "description": "Praticar Web API e EF Core",
  "isCompleted": false
}

➤ PUT /api/todo/{id}

Atualiza uma tarefa existente.

➤ DELETE /api/todo/{id}

Remove uma tarefa.

🔒 Segurança

O projeto possui estrutura preparada para:

Chave JWT via appsettings.json

Autenticação baseada em token

Permissão de endpoints protegidos

.gitignore impedindo que chaves sensíveis vazem no repositório

🧹 Boas Práticas Implementadas

✔ .gitignore configurado (bin/, obj/, appsettings*, .env)
✔ Estrutura por camadas (Controllers → Services → Data → Models)
✔ Program.cs limpo e organizado
✔ Uso de Dependency Injection
✔ Código padronizado para portfólio
✔ Migrations organizadas
✔ Zero arquivos sensíveis versionados

👨‍💻 Autor

Wellington Roveder
Desenvolvedor .NET & apaixonado por tecnologia
🔗 https://www.linkedin.com/in/wellington-roveder-04637b37b


