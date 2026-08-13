// Copyright (C) 2023 jmh
// SPDX-License-Identifier: GPL-3.0-only

using Spider2FA.Core.Entity;

namespace Spider2FA.Core.Persistence
{
    public interface IIconPackRepository : IAsyncRepository<IconPack, string>;
}