// Copyright (C) 2023 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System.Collections.Generic;
using System.Threading.Tasks;
using Android.Graphics;
using Spider2FA.Core.Entity;

namespace Spider2FA.Droid.Persistence.View
{
    public interface IIconPackEntryView : IView<KeyValuePair<string, Bitmap>>
    {
        string Search { get; set; }
        Task LoadFromPersistenceAsync(IconPack pack);
    }
}