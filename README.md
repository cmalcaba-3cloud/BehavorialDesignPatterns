# BehavorialDesignPatterns
Demonstration for Behavioral Design Patterns

This repository contains implementations of all eleven behavioral design patterns in C# (.NET 9.0), following the same structure and style as the [StructuralDesignPatterns](https://github.com/cmalcaba-3cloud/StructuralDesignPatterns) repository.

## Behavioral Design Patterns

Behavioral patterns focus on communication between objects and the delegation of responsibilities.

### 1. Chain of Responsibility Pattern
**Location:** `ChainOfResponsibilityPattern/`

Passes a request along a chain of handlers until one processes it.

### 2. Command Pattern
**Location:** `CommandPattern/`

Encapsulates requests as objects to support undo, queueing, and logging.

### 3. Interpreter Pattern
**Location:** `InterpreterPattern/`

Defines a grammar and interpreter for evaluating expressions.

### 4. Iterator Pattern
**Location:** `IteratorPattern/`

Provides a way to access elements of a collection sequentially without exposing its internals.

### 5. Mediator Pattern
**Location:** `MediatorPattern/`

Centralizes communication between related objects to reduce coupling.

### 6. Memento Pattern
**Location:** `MementoPattern/`

Captures and restores an object's internal state without violating encapsulation.

### 7. Observer Pattern
**Location:** `ObserverPattern/`

Defines one-to-many dependencies so observers are notified when subject state changes.

### 8. State Pattern
**Location:** `StatePattern/`

Lets an object alter its behavior when its internal state changes.

### 9. Strategy Pattern
**Location:** `StrategyPattern/`

Defines interchangeable algorithms and selects behavior at runtime.

### 10. Template Method Pattern
**Location:** `TemplateMethodPattern/`

Defines the skeleton of an algorithm while deferring specific steps to subclasses.

### 11. Visitor Pattern
**Location:** `VisitorPattern/`

Separates operations from object structures by moving behavior into visitors.

## Running the Examples

Each pattern is in its own directory with a solution file. To run any example:

```bash
cd [PatternName]/[PatternName]
dotnet run
```

For example:
```bash
cd StrategyPattern/StrategyPattern
dotnet run
```

## Structure

Each pattern follows a consistent structure:
- **[PatternName]/** - Pattern directory
  - **[PatternName]/** - Solution and project directory
    - **[PatternName].sln** - Solution file
    - **[PatternName].csproj** - Project file
    - Pattern-specific subdirectories (e.g., Handlers, Commands, Strategies)
    - **Program.cs** - Main program demonstrating the pattern

## Requirements

- .NET 9.0 SDK or later
