// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System.Collections.Generic;
using System.Threading.Tasks;
using Spider2FA.Core;
using Spider2FA.Core.Entity;
using Spider2FA.Droid.Interface;

namespace Spider2FA.Droid.Persistence.View
{
    public interface IAuthenticatorView : IReorderableView<Authenticator>
    {
        string Search { get; set; }
        CategorySelector CategorySelector { get; set; }
        SortMode SortMode { get; set; }
        Task LoadFromPersistenceAsync();
        bool AnyWithoutFilter();
        int IndexOf(Authenticator auth);
        IEnumerable<AuthenticatorCategory> GetCurrentBindings();
        void CommitRanking();
    }
}