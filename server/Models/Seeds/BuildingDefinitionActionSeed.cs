using Solace.Models.Settlements;

namespace Solace.Models.Seeds;

public static class BuildingDefinitionActionSeed
{
    public static BuildingDefinitionAction[] Data =>
       [
        // Building ID Store
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.StoreId, ActionDefinitionId = ActionDefinitionSeed.BuyId }, // Buy
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.StoreId, ActionDefinitionId = ActionDefinitionSeed.SellId }, // Sell
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.StoreId, ActionDefinitionId = ActionDefinitionSeed.TradeId }, // Trade (General exchange)
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.StoreId, ActionDefinitionId = ActionDefinitionSeed.TalkId },  // Talk to merchant/staff

        // Building ID Guild
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.GuildId, ActionDefinitionId = ActionDefinitionSeed.TrainId }, // Train (Skill training)
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.GuildId, ActionDefinitionId = ActionDefinitionSeed.HireId }, // Hire (Joining the guild/taking quests)
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.GuildId, ActionDefinitionId = ActionDefinitionSeed.FireId }, // Fire (Leaving the guild)

        // Building ID Inn
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.InnId, ActionDefinitionId = ActionDefinitionSeed.TalkId },  // Talk to staff/other guests
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.InnId, ActionDefinitionId = ActionDefinitionSeed.RestId }, // Rest (Sleep)
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.InnId, ActionDefinitionId = ActionDefinitionSeed.EatId },  // Eat

        // Building ID Tavern
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.TavernId, ActionDefinitionId = ActionDefinitionSeed.TalkId },  // Talk to patrons/staff
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.TavernId, ActionDefinitionId = ActionDefinitionSeed.BuyId }, // Buy (Drinks/Food)
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.TavernId, ActionDefinitionId = ActionDefinitionSeed.UseItemId1, }, // Use Item (e.g., using a potion at the table)
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.TavernId, ActionDefinitionId = ActionDefinitionSeed.EatId },  // Eat

        // Building ID Bank
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.BankId, ActionDefinitionId = ActionDefinitionSeed.DepositId }, // Deposit
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.BankId, ActionDefinitionId = ActionDefinitionSeed.WithdrawId }, // Withdraw

        // Building ID Storage
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.StorageId, ActionDefinitionId = ActionDefinitionSeed.MoveId },  // Move (Moving stored goods)
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.StorageId, ActionDefinitionId = ActionDefinitionSeed.DepositId }, //Deposit
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.StorageId, ActionDefinitionId = ActionDefinitionSeed.WithdrawId },  // Withdraw

        // Building ID Arena
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.ArenaId, ActionDefinitionId = ActionDefinitionSeed.InitiateCombatId }, // Initiate Combat

        // Building ID House
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.HouseId, ActionDefinitionId = ActionDefinitionSeed.RestId }, // Rest
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.HouseId, ActionDefinitionId = ActionDefinitionSeed.TalkId },  // Talk
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.HouseId, ActionDefinitionId = ActionDefinitionSeed.EatId },  // Eat

        // Building ID Training Hall
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.TrainingHallId, ActionDefinitionId = ActionDefinitionSeed.TrainId }, // Train

        // Building ID Service Provider
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.ServiceProviderId, ActionDefinitionId = ActionDefinitionSeed.BuyId }, // Buy
        new BuildingDefinitionAction { BuildingDefinitionId = BuildingDefinitionSeed.ServiceProviderId, ActionDefinitionId = ActionDefinitionSeed.TalkId }  // Talk
       ];
}