// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using Spider2FA.Core;

namespace Spider2FA.Droid.Shared.Wear
{
    public class WearPreferences
    {
        public string DefaultCategory { get; set; }
        public SortMode SortMode { get; set; }
        public CodeGrouping CodeGroupSize { get; set; }
        public bool ShowUsernames { get; set; }
    }
}