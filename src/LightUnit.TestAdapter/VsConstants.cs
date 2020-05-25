using System;

namespace LightUnit.TestAdapter
{
    internal static class VsConstants
    {
        public const string ExecutorUriString = "executor://lightunit";
        public static readonly Uri ExecutorUri = new Uri(ExecutorUriString);
    }
}