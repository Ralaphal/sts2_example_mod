using BaseLib.Patches.Content;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models;

namespace Oddmelt.OddmeltCode;

public static class OddmeltKeywords
{
    public static CardKeyword Rotation;
    public static CardKeyword Rotational; //applied to cards to mark them having Rotation already

    
    public static bool IsRotation(this CardModel card)
    {
        return card.Keywords.Contains(Rotation);
    }


}