// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using Spider2FA.Core.Entity;
using Spider2FA.Core.Persistence;

namespace Spider2FA.Droid.Persistence
{
    public class CustomIconRepository : AsyncRepository<CustomIcon, string>, ICustomIconRepository
    {
        public CustomIconRepository(Database database) : base(database)
        {
        }
    }
}