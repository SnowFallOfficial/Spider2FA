// Copyright (C) 2025 jmh
// SPDX-License-Identifier: GPL-3.0-only

using Android.Content;
using Spider2FA.Droid.Shared.Wear;

namespace Spider2FA.WearOS.Cache
{
    public class CategoryCache(Context context) : ListCache<WearCategory>("categories", context);
}