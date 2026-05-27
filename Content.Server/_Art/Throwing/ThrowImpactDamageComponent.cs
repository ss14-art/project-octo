using Robust.Shared.GameStates;

namespace Content.Server._Art.Throwing;

[RegisterComponent]
public sealed partial class ThrowImpactDamageComponent : Component
{
    [DataField]
    public float BluntDamage = 10f;
}
