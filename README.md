# Catalog GraphQL API — Learning Demo

This project is a **learning-focused demo** built to get hands-on experience with **GraphQL in .NET**.

I had heard a lot about GraphQL and watched a few tutorials before, but **never actually implemented it in code**.  
This repository is the result of that first practical exploration.

⚠️ **This is NOT a production-ready project**.  
It is intentionally simple and exists purely for **learning and experimentation**.

---

## 🎯 Purpose

- Understand how GraphQL works in practice
- Learn how to build a GraphQL API with **ASP.NET Core**
- Explore **HotChocolate** as a GraphQL server
- Integrate GraphQL with **Entity Framework Core**
- Use **PostgreSQL** with a code-first approach

---

## 🛠 Tech Stack

- **.NET 9 / ASP.NET Core**
- **HotChocolate (GraphQL)**
- **Entity Framework Core**
- **PostgreSQL**
- **EF Core Migrations**

---

## ✨ What’s Implemented

- Basic GraphQL queries
- Simple domain model (Products, Brands, Product Types)
- EF Core + PostgreSQL integration
- Automatic database migrations on startup
- Database seeding at startup
- GraphQL Playground (Banana Cake Pop UI)

---

## 🗂 Project Structure (simplified)

```

catalog.api
├── Data
│   ├── CatalogContext.cs
│   └── EFCore
│       └── Seeders
├── Types
│   └── ProductsQuery.cs
├── Program.cs
└── appsettings.json

````

---

## ▶️ Running the Project

### Prerequisites

- .NET SDK 9+
- PostgreSQL running locally

---

### Steps

1. Clone the repository

```bash
git clone https://github.com/AboubacarSow/catalog.api
cd catalog.api
````

2. Configure the database connection string in `appsettings.json`

```json
"ConnectionStrings": {
  "Database": "Server=localhost;Port=5432;Database=GQCatalogDb;Username=postgres;Password=postgres"
}
```

3. Run the application

```bash
dotnet run
```

On startup:

* The database is created if it doesn’t exist
* Migrations are applied automatically
* Initial seed data is inserted

---

## 🧪 GraphQL Playground

Open in your browser:

```
http://localhost:5096/graphql
```

Example query:

```graphql
query {
  allProducts {
    id
    name
    price
  }
}
```

---

## 📌 Notes

* No authentication or authorization
* No advanced error handling
* No production optimizations
* Focused purely on **learning GraphQL concepts**

---

## 📚 Status

✅ First hands-on GraphQL project
✅ Learning-by-doing
🔄 Will evolve as understanding improves

---

## 📄 License

This project is for **educational purposes only**.


