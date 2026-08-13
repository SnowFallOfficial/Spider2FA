// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using Spider2FA.Core.Entity;
using Spider2FA.Core.Persistence;

namespace Spider2FA.Droid.Persistence
{
    public class CategoryRepository : AsyncRepository<Category, string>, ICategoryRepository
    {
        public CategoryRepository(Database database) : base(database)
        {
        }
    }
}