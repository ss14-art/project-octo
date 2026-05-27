namespace Content.Shared._Art.Effects;

public abstract class SharedOutlineFlashEffectSystem : EntitySystem
{
    public abstract void RaiseEffect(EntityUid target, EntityUid? viewer = null);
}
