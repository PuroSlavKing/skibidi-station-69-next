using Robust.Shared.Configuration;

namespace Content.Shared._CorvaxNext.NextVars;

/// <summary>
///     Corvax modules console variables
/// </summary>
[CVarDefs]
// ReSharper disable once InconsistentNaming
public sealed class NextVars
{
        /// <summary>
        /// Offer item.
        /// </summary>
        public static readonly CVarDef<bool> OfferModeIndicatorsPointShow =
            CVarDef.Create("hud.offer_mode_indicators_point_show", true, CVar.ARCHIVE | CVar.CLIENTONLY);

        /*
        * AUTOVOTE SYSTEM
        */

        /// <summary>
        /// Enables the automatic voting system.
        /// <summary>
        public static readonly CVarDef<bool> AutoVoteEnabled =
            CVarDef.Create("vote.autovote_enabled", false, CVar.SERVERONLY);

        /// <summary>
        /// Automatically starts a map vote when returning to the lobby.
        /// Requires auto voting to be enabled.
        /// <summary>
        public static readonly CVarDef<bool> MapAutoVoteEnabled =
            CVarDef.Create("vote.map_autovote_enabled", true, CVar.SERVERONLY);

        /// <summary>
        /// Automatically starts a gamemode vote when returning to the lobby.
        /// Requires auto voting to be enabled.
        /// <summary>
        public static readonly CVarDef<bool> PresetAutoVoteEnabled =
            CVarDef.Create("vote.preset_autovote_enabled", true, CVar.SERVERONLY);
}