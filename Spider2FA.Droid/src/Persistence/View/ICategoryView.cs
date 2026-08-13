// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System.Threading.Tasks;
using Spider2FA.Core.Entity;

namespace Spider2FA.Droid.Persistence.View
{
    public interface ICategoryView : IReorderableView<Category>
    {
        Task LoadFromPersistenceAsync();
        int IndexOf(string id);
    }
}