
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.ValueProps;


namespace Alpecor_Test.Cards;

// These are the card's base stats.
// The constructor arguments are: cost, CardType, CardRarity, TargetType   
public class AlpecorFirstCard : CardModel
{
    protected override HashSet<CardTag> CanonicalTags => [CardTag.Strike];
    protected override IEnumerable<DynamicVar> CanonicalVars => [new DamageVar(6, ValueProp.Move)];
    // These are the card's base stats.
    // The constructor arguments are: cost, CardType, CardRarity, TargetType
    public AlpecorFirstCard() : base(1, 
                                    CardType.Attack, 
                                    CardRarity.Common, 
                                    TargetType.AnyEnemy)
    {
        // DamageVar sets how much damage the card deals.
        // The number here is the base value.
        DamageVar = new DamageVar(8);
    }

    protected override void OnUpgrade()
    {
        DynamicVars.Damage.UpgradeValueBy(3m);
    }
}