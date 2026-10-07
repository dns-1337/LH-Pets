# LH-Pets API

Web API em ASP.NET Core (C#) com padrao de Controllers para cadastro e listagem
de clientes e pets da empresa LH-Pets.

Os dados sao guardados em memoria com `List<T>`, sem banco de dados.

## Como executar

```bash
dotnet run
```

Depois abra o Swagger no navegador:

```
http://localhost:5056/swagger
```

A porta pode mudar. O valor correto aparece no terminal (`Now listening on: ...`)
e tambem esta em `Properties/launchSettings.json`.

## Endpoints

| Metodo | Rota                             | Descricao                              |
|--------|----------------------------------|----------------------------------------|
| GET    | /api/clientes                    | Lista todos os clientes                |
| POST   | /api/clientes                    | Cadastra um cliente                    |
| GET    | /api/pets                        | Lista todos os pets                    |
| POST   | /api/pets                        | Cadastra um pet vinculado a um cliente |
| GET    | /api/pets/cliente/{clienteId}    | Lista os pets de um cliente            |

## Estrutura

```
LHPets/
├── Controllers/
│   ├── ClientesController.cs
│   └── PetsController.cs
├── Models/
│   ├── Cliente.cs
│   └── Pet.cs
└── Program.cs
```
