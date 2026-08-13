// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Spider2FA.Core.Entity;

namespace Spider2FA.Core.Service
{
    public interface IAuthenticatorService
    {
        Task AddAsync(Authenticator auth);
        Task UpdateAsync(Authenticator auth);
        Task<int> UpdateManyAsync(IEnumerable<Authenticator> auths);
        Task ChangeSecretAsync(Authenticator auth, string newSecret);
        Task SetIconAsync(Authenticator auth, string icon);
        Task SetCustomIconAsync(Authenticator auth, CustomIcon icon);
        Task<int> AddManyAsync(IEnumerable<Authenticator> auths);
        Task<ValueTuple<int, int>> AddOrUpdateManyAsync(IEnumerable<Authenticator> auths);
        Task DeleteWithCategoryBindingsAsync(Authenticator auth);
        Task IncrementCounterAsync(Authenticator auth);
        Task IncrementCopyCountAsync(Authenticator auth);
        Task ResetCopyCountsAsync();
    }
}