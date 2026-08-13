// Copyright (C) 2023 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Spider2FA.Core.Entity;

namespace Spider2FA.Core.Persistence
{
    public interface IIconPackEntryRepository : IAsyncRepository<IconPackEntry, ValueTuple<string, string>>
    {
        Task CreateManyAsync(List<IconPackEntry> items);
        Task<List<IconPackEntry>> GetAllForPackAsync(IconPack pack);
        Task DeleteAllForPackAsync(IconPack pack);
    }
}