// Copyright (C) 2023 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System.Threading.Tasks;
using Spider2FA.Core.Entity;

namespace Spider2FA.Core.Service
{
    public interface IIconPackService
    {
        Task ImportPackAsync(IconPack pack);
        Task DeletePackAsync(IconPack pack);
    }
}