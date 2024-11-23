# My C# Project

## Description
This project demonstrates the implementation of clean and maintainable architecture using the **MediatR library**. By leveraging the **Mediator Pattern** and the **CQRS Pattern**, the project aims to decouple dependencies, improve scalability, and enhance the clarity of request handling in modern C# applications.

The project is structured to:
- Implement the **Mediator Pattern** for loose coupling between components.
- Use the **CQRS Pattern** to separate responsibilities for read and write operations.
- Showcase the benefits of MediatR in reducing boilerplate code and improving modularity.

---

## What is MediatR?
MediatR is a lightweight library that simplifies the implementation of the **Mediator Pattern** in C#. It helps in managing communication between components through a mediator, avoiding direct dependencies.

MediatR also aligns well with the **CQRS Pattern**, making it easier to handle distinct command and query models for scalable applications.

---

## Key Patterns Used

### Mediator Pattern
The Mediator Pattern centralizes communication between objects via a mediator. Instead of objects interacting directly, they rely on the mediator to relay requests and responses. This results in a modular and testable system.

### CQRS Pattern
CQRS (Command Query Responsibility Segregation) separates the logic for reading data (queries) from the logic for writing data (commands). This improves application performance and scalability by tailoring solutions to each concern.

---

## Features
- Decoupled request handling via MediatR.
- Implementation of commands and queries using the CQRS approach.
- Integration with modern .NET dependency injection for easy configuration.
- A clear and extensible architecture for building scalable applications.

---

## Getting Started

### Install MediatR
Add the required NuGet packages to your project:
```bash
dotnet add package MediatR
dotnet add package MediatR.Extensions.Microsoft.DependencyInjection
