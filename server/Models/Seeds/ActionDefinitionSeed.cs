using Solace.Models.Player;
namespace Solace.Models.Seeds;

public static class ActionDefinitionSeed
{
    public static ActionDefinition[] Data =>
    [
        // TODO: Add additional actions for building types once those tables are in place
        new ActionDefinition { Id = 1, Name = "Attack", ActionPoints = 1, IsCombatAction = true, IsItemAction = false },
        new ActionDefinition { Id = 2, Name = "Defend", ActionPoints = 1, IsCombatAction = true, IsItemAction = false },
        new ActionDefinition { Id = 3, Name = "Cast", ActionPoints = 2, IsCombatAction = true, IsItemAction = false },
        new ActionDefinition { Id = 4, Name = "Equip", ActionPoints = 2, IsCombatAction = true, IsItemAction = false },
        new ActionDefinition { Id = 5, Name = "Use Item", ActionPoints = 1, IsCombatAction = true, IsItemAction = true },
        new ActionDefinition { Id = 6, Name = "Run", ActionPoints = 1, IsCombatAction = true, IsItemAction = false },
        new ActionDefinition { Id = 7, Name = "Talk", ActionPoints = 0, IsCombatAction = false, IsItemAction = false },
        new ActionDefinition { Id = 8, Name = "Use Item", ActionPoints = 0, IsCombatAction = false, IsItemAction = true },
        new ActionDefinition { Id = 9, Name = "Move", ActionPoints = 0, IsCombatAction = false, IsItemAction = false },
        new ActionDefinition { Id = 10, Name = "Buy", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = 11, Name = "Sell", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = 13, Name = "Trade", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = 14, Name = "Train", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = 15, Name = "Deposit", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = 16, Name = "Withdraw", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = 17, Name = "Rest", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = 18, Name = "Hire", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = 19, Name = "Fire", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = 20, Name = "InitiateCombat", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = 21, Name = "Eat", ActionPoints = 0, IsCombatAction = false, IsItemAction = false}
    ];
}