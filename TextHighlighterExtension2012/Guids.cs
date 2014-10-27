// Guids.cs
// MUST match guids.h
using System;

namespace FredericTorres.TextHighlighterPackage
{
    static class GuidList
    {
        public const string guidTextHighlighterPackagePkgString = "d0a6e040-9636-4b7e-a5c6-5a53591d293a";
        public const string guidTextHighlighterPackageCmdSetString = "3188f87b-8862-4070-8825-3d1763afe907";

        public static readonly Guid guidTextHighlighterPackageCmdSet = new Guid(guidTextHighlighterPackageCmdSetString);
    };
} 