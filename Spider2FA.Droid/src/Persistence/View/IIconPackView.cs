// Copyright (C) 2023 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System.Threading.Tasks;
using Spider2FA.Core.Entity;

namespace Spider2FA.Droid.Persistence.View
{
    public interface IIconPackView : IView<IconPack>
    {
        Task LoadFromPersistenceAsync();
        int IndexOf(string name);
    }
}