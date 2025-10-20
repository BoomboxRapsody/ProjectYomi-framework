// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using osu.Framework.Localisation;

namespace osu.Framework.Configuration
{
    // todo: revisit when we have a way to exclude enum members from naming rules
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum FrameSync
    {
        [LocalisableDescription(typeof(ProjectYomiVariables), nameof(ProjectYomiVariables.VSync))]
        VSync,

        //[Description("2x refresh rate")]
        [LocalisableDescription(typeof(ProjectYomiVariables), nameof(ProjectYomiVariables.Limit2X))]
        Limit2x,

        [LocalisableDescription(typeof(ProjectYomiVariables), nameof(ProjectYomiVariables.Limit4X))]
        Limit4x,

        [LocalisableDescription(typeof(ProjectYomiVariables), nameof(ProjectYomiVariables.Limit8X))]
        Limit8x,

        [LocalisableDescription(typeof(ProjectYomiVariables), nameof(ProjectYomiVariables.LimitUnlimited))]
        Unlimited,
    }
}
