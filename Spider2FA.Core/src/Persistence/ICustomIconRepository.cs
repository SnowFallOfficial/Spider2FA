// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using Spider2FA.Core.Entity;

namespace Spider2FA.Core.Persistence
{
    public interface ICustomIconRepository : IAsyncRepository<CustomIcon, string>;
}