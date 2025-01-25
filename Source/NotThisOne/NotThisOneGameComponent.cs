using System.Collections.Generic;
using Verse;

namespace NotThisOne;

public class NotThisOneGameComponent : GameComponent
{
    public HashSet<Pawn> list = [];

    public NotThisOneGameComponent(Game game)
    {
    }

    public override void ExposeData()
    {
        Scribe_Collections.Look(ref list, "AnimalsNotToSlaughter", LookMode.Reference);
        base.ExposeData();
    }
}