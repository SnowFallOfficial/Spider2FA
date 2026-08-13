// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System.Threading.Tasks;
using Spider2FA.Core.Entity;

namespace Spider2FA.Core.Persistence
{
    public interface IAuthenticatorRepository : IAsyncRepository<Authenticator, string>
    {
        Task ChangeSecretAsync(string oldSecret, string newSecret);
    }
}