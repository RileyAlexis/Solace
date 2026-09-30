using Solace.Models.Player;

namespace Solace.Models.Seeds;

public static class ActionDefinitionSeed
{
    public static readonly Guid AttackId = new Guid("a1111111-2020-3030-4040-5060708090a1");
    public static readonly Guid DefendId = new Guid("a1111111-2020-3030-4040-5060708090a2");
    public static readonly Guid CastId = new Guid("a1111111-2020-3030-4040-5060708090a3");
    public static readonly Guid EquipId = new Guid("a1111111-2020-3030-4040-5060708090a4");
    public static readonly Guid UseItemId1 = new Guid("a1111111-2020-3030-4040-5060708090a5");
    public static readonly Guid RunId = new Guid("a1111111-2020-3030-4040-5060708090a6");
    public static readonly Guid TalkId = new Guid("a1111111-2020-3030-4040-5060708090a7");
    public static readonly Guid UseItemId2 = new Guid("a1111111-2020-3030-4040-5060708090a8");
    public static readonly Guid MoveId = new Guid("a1111111-2020-3030-4040-5060708090a9");
    public static readonly Guid BuyId = new Guid("a1111111-2020-3030-4040-5060708090aa");
    public static readonly Guid SellId = new Guid("a1111111-2020-3030-4040-5060708090ab");
    public static readonly Guid TradeId = new Guid("a1111111-2020-3030-4040-5060708090ac");
    public static readonly Guid TrainId = new Guid("a1111111-2020-3030-4040-5060708090ad");
    public static readonly Guid DepositId = new Guid("a1111111-2020-3030-4040-5060708090ae");
    public static readonly Guid WithdrawId = new Guid("a1111111-2020-3030-4040-5060708090af");
    public static readonly Guid RestId = new Guid("a1111111-2020-3030-4040-5060708090b0");
    public static readonly Guid HireId = new Guid("a1111111-2020-3030-4040-5060708090b1");
    public static readonly Guid FireId = new Guid("a1111111-2020-3030-4040-5060708090b2");
    public static readonly Guid InitiateCombatId = new Guid("a1111111-2020-3030-4040-5060708090b3");
    public static readonly Guid EatId = new Guid("a1111111-2020-3030-4040-5060708090b4");

    public static ActionDefinition[] Data =>
    [
        new ActionDefinition { Id = AttackId, Name = "Attack", ActionPoints = 1, IsCombatAction = true, IsItemAction = false },
        new ActionDefinition { Id = DefendId, Name = "Defend", ActionPoints = 1, IsCombatAction = true, IsItemAction = false },
        new ActionDefinition { Id = CastId, Name = "Cast", ActionPoints = 2, IsCombatAction = true, IsItemAction = false },
        new ActionDefinition { Id = EquipId, Name = "Equip", ActionPoints = 2, IsCombatAction = true, IsItemAction = false },
        new ActionDefinition { Id = UseItemId1, Name = "Use Item", ActionPoints = 1, IsCombatAction = true, IsItemAction = true },
        new ActionDefinition { Id = RunId, Name = "Run", ActionPoints = 1, IsCombatAction = true, IsItemAction = false },
        new ActionDefinition { Id = TalkId, Name = "Talk", ActionPoints = 0, IsCombatAction = false, IsItemAction = false },
        new ActionDefinition { Id = UseItemId2, Name = "Use Item", ActionPoints = 0, IsCombatAction = false, IsItemAction = true },
        new ActionDefinition { Id = MoveId, Name = "Move", ActionPoints = 0, IsCombatAction = false, IsItemAction = false },
        new ActionDefinition { Id = BuyId, Name = "Buy", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = SellId, Name = "Sell", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = TradeId, Name = "Trade", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = TrainId, Name = "Train", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = DepositId, Name = "Deposit", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = WithdrawId, Name = "Withdraw", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = RestId, Name = "Rest", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = HireId, Name = "Hire", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = FireId, Name = "Fire", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = InitiateCombatId, Name = "InitiateCombat", ActionPoints = 0, IsCombatAction = false, IsItemAction = false},
        new ActionDefinition { Id = EatId, Name = "Eat", ActionPoints = 0, IsCombatAction = false, IsItemAction = false}
    ];
}