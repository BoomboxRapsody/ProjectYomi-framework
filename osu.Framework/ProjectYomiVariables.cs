// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Framework
{
    public static class ProjectYomiVariables
    {
        private const string prefix = @"osu.Game.Resources.Localisation.ProjectYomi";

        public static LocalisableString Limit2X => new TranslatableString(getKey(@"osuframework_limit2x"), @"2X Refresh Rate");
        public static LocalisableString Limit4X => new TranslatableString(getKey(@"osuframework_limit4x"), @"4X Refresh Rate");
        public static LocalisableString Limit8X => new TranslatableString(getKey(@"osuframework_limit8x"), @"8X Refresh Rate");
        public static LocalisableString LimitUnlimited => new TranslatableString(getKey(@"osuframework_limitUnlimited"), @"Basically unlimited");

        public static LocalisableString RandomString => new TranslatableString(getKey(@"random"), @"Random");

        public static LocalisableString VSync => new TranslatableString(getKey(@"osuframework_vsync"), @"VSync");

        public static LocalisableString WindowedMode => new TranslatableString(getKey(@"osuframework_windowed"), @"Windowed");
        public static LocalisableString BorderlessMode => new TranslatableString(getKey(@"osuframework_borderless"), @"Borderless");
        public static LocalisableString FullscreenMode => new TranslatableString(getKey(@"osuframework_fullscreen"), @"Fullscreen");

        public static LocalisableString SingleThread => new TranslatableString(getKey(@"osuframework_singleThread"), @"Single thread");
        public static LocalisableString MultiThreaded => new TranslatableString(getKey(@"osuframework_multiThreaded"), @"Multithreaded");

        public static LocalisableString osuframework_renderer_automatic => new TranslatableString(getKey(@"osuframework_renderer_automatic"), @"Automatic");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
