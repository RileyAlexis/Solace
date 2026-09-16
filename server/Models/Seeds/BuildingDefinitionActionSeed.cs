using Solace.Models.Buildings;

namespace Solace.Models.Seeds;

public static class BuildingDefinitionActionSeed
{
    public static BuildingDefinitionAction[] Data =>
       [
        // Building ID 1: Store (Merchant) - Buy, Sell, Trade, Talk
        new BuildingDefinitionAction { BuildingDefinitionId = 1, ActionDefinitionId = 10 }, // Buy
        new BuildingDefinitionAction { BuildingDefinitionId = 1, ActionDefinitionId = 11 }, // Sell
        new BuildingDefinitionAction { BuildingDefinitionId = 1, ActionDefinitionId = 13 }, // Trade (General exchange)
        new BuildingDefinitionAction { BuildingDefinitionId = 1, ActionDefinitionId = 7 },  // Talk to merchant/staff

        // Building ID 2: Guild - Questing, Talking
        new BuildingDefinitionAction { BuildingDefinitionId = 2, ActionDefinitionId = 14 }, // Train (Skill training)
        new BuildingDefinitionAction { BuildingDefinitionId = 2, ActionDefinitionId = 18 }, // Hire (Joining the guild/taking quests)
        new BuildingDefinitionAction { BuildingDefinitionId = 2, ActionDefinitionId = 19 }, // Fire (Leaving the guild)

        // Building ID 3: Inn - Resting, Checking Status
        new BuildingDefinitionAction { BuildingDefinitionId = 3, ActionDefinitionId = 7 },  // Talk to staff/other guests
        new BuildingDefinitionAction { BuildingDefinitionId = 3, ActionDefinitionId = 17 }, // Rest (Sleep)
        new BuildingDefinitionAction { BuildingDefinitionId = 3, ActionDefinitionId = 21 },  // Eat

        // Building ID 4: Tavern - 
        new BuildingDefinitionAction { BuildingDefinitionId = 4, ActionDefinitionId = 7 },  // Talk to patrons/staff
        new BuildingDefinitionAction { BuildingDefinitionId = 4, ActionDefinitionId = 10 }, // Buy (Drinks/Food)
        new BuildingDefinitionAction { BuildingDefinitionId = 4, ActionDefinitionId = 5 },  // Use Item (e.g., using a potion at the table)
        new BuildingDefinitionAction { BuildingDefinitionId = 4, ActionDefinitionId = 21 },  // Eat

        // Building ID 5: Bank - Deposit/Withhdraw funds
        new BuildingDefinitionAction { BuildingDefinitionId = 5, ActionDefinitionId = 15 }, // Deposit
        new BuildingDefinitionAction { BuildingDefinitionId = 5, ActionDefinitionId = 16 }, // Withdraw

        // Building ID 6: Storage/Warehouse items
        new BuildingDefinitionAction { BuildingDefinitionId = 6, ActionDefinitionId = 9 },  // Move (Moving stored goods)
        new BuildingDefinitionAction { BuildingDefinitionId = 6, ActionDefinitionId = 15 }, //Deposit
        new BuildingDefinitionAction { BuildingDefinitionId = 6, ActionDefinitionId = 16 },  // Withdraw

        // Building ID 7: Arena - Combat and practice
        new BuildingDefinitionAction { BuildingDefinitionId = 7, ActionDefinitionId = 20 }, // Initiate Combat

        // Building ID 8: House
        new BuildingDefinitionAction { BuildingDefinitionId = 8, ActionDefinitionId = 17 }, // Rest
        new BuildingDefinitionAction { BuildingDefinitionId = 8, ActionDefinitionId = 7 },  // Talk
        new BuildingDefinitionAction { BuildingDefinitionId = 8, ActionDefinitionId = 21 },  // Eat

        // Building ID 9: Training Hall
        new BuildingDefinitionAction { BuildingDefinitionId = 9, ActionDefinitionId = 14 }, // Train

        // Building ID 10: Service Provider
        new BuildingDefinitionAction { BuildingDefinitionId = 10, ActionDefinitionId = 10 }, // Buy
        new BuildingDefinitionAction { BuildingDefinitionId = 10, ActionDefinitionId = 7 }  // Talk
       ];
}