# Project Agent Context: Solace Server

## Project Overview

Solace is a .NET 10 game server featuring a persistent world with hex-based maps, player progression systems, and procedural content generation. It utilizes Entity Framework Core for persistence with a PostgreSQL backend.

## Technical Stack

- **Framework:** .NET 10
- **ORM:** Entity Framework Core (Npgsql)
- **Database:** PostgreSQL (SnakeCase naming convention)
- **Auth:** JWT-based authentication with Microsoft.AspNetCore.Identity

## Core Domain Entities

### Player System

- `PlayerModel`: Central actor model linking to:
  - `ClassModel`: Player class/archetype.
  - `PlayerStatValue`: Dynamic stats.
  - `PlayerEquipment` & `PlayerInventory`: Item management.
  - `SettlementModel`: Ownership of settlements.

### Items & Effects

- `ItemModel`: Represents weapons, headwear, and other gear. Includes level/type attributes.
- `ItemEffect`: Links items to specific gameplay modifications.
- `EffectsModel`: Handles state modifiers, including:
  - `EffectAffectedStat`: Numerical stat changes.
  - `EffectAffectedAbility`: Action denials/modifiers.
  - `BodyPlacement`: Spatial placement of effects on the character model.

### World & Map

- `SolaceMapModel` & `HexTileModel`: Defines the spatial structure using hex tiles.
- `TerrainTypeModel`: Defines environmental properties of tiles.

## Architectural Patterns

### Configuration-Driven Design

The project prioritizes data-driven logic over hardcoded values.

- **Configurations:** Found in `Models/Configurations`. Used to define game balancing and rules.
- **Seeds:** Found in `Models/Seeds` and `data/*.csv`. These files populate the configurations.
- **Development Workflow:** To balance game stats or add new buildings, modify the seeds/configurations rather than the core logic.

### Procedural Generation

Located in `Services/Generators`:

- `MapGeneratorService`: Generates world maps based on difficulty and population.
- `MarkovNameGeneratorService`: Uses Markov chains for organic NPC/location naming.

## Coding Standards & Patterns

- **Result Pattern:** Use the `Result` type for operation success/failure instead of relying on exceptions.
- **Dependency Injection:** All services must be registered via interfaces (e.g., `IMapGeneratorService`).
- **Naming:** Adhere to the SnakeCase convention for database interactions.

## Key Files for Reference

- `Models/Player/PlayerModel.cs`: Core player logic.
- `Database/SolaceDbContext.cs`: Database schema definition.
- `Models/Configurations/`: Game balancing parameters.
