// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.ComponentModel;
using osu.Framework.Localisation;

namespace osu.Framework.Platform
{
    public enum ExecutionMode
    {
        [LocalisableDescription(typeof(ProjectYomiVariables), nameof(ProjectYomiVariables.SingleThread))]
        SingleThread,

        [LocalisableDescription(typeof(ProjectYomiVariables), nameof(ProjectYomiVariables.MultiThreaded))]
        MultiThreaded
    }
}
