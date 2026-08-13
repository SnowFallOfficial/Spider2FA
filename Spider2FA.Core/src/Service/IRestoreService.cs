// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System.Threading.Tasks;
using Spider2FA.Core.Backup;

namespace Spider2FA.Core.Service
{
    public interface IRestoreService
    {
        Task<RestoreResult> RestoreAsync(Backup.Backup backup);
        Task<RestoreResult> RestoreAndUpdateAsync(Backup.Backup backup);
    }
}