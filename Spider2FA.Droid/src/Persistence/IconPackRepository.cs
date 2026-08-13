// Copyright (C) 2023 jmh
// SPDX-License-Identifier: GPL-3.0-only

using Spider2FA.Core.Entity;
using Spider2FA.Core.Persistence;

namespace Spider2FA.Droid.Persistence
{
    public class IconPackRepository : AsyncRepository<IconPack, string>, IIconPackRepository
    {
        public IconPackRepository(Database database) : base(database)
        {
        }
    }
}