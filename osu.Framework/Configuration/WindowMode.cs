// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Framework.Configuration
{
    public enum WindowMode
    {
        [LocalisableDescription(typeof(ProjectYomiVariables), nameof(ProjectYomiVariables.WindowedMode))]
        Windowed = 0,
        [LocalisableDescription(typeof(ProjectYomiVariables), nameof(ProjectYomiVariables.BorderlessMode))]
        Borderless = 1,
        [LocalisableDescription(typeof(ProjectYomiVariables), nameof(ProjectYomiVariables.FullscreenMode))]
        Fullscreen = 2
    }
}
