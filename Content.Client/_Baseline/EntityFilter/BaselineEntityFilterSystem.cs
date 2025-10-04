using Content.Shared.CCVar;
using Robust.Shared;
using Robust.Shared.Configuration;

namespace Content.Client._Baseline.EntityFilter;

/// <summary>
/// On the client side, it automatically enables entity filtering to hide all vanilla ss14 entities
/// not marked with the ForkFiltered category from the spawn menu.
/// </summary>
public sealed class BaselineEntityFilterSystem : EntitySystem
{
    [Dependency] private readonly IConfigurationManager _cfg = default!;

    public override void Initialize()
    {
        _cfg.SetCVar(CVars.EntitiesCategoryFilter, "ForkFiltered");
    }
}
