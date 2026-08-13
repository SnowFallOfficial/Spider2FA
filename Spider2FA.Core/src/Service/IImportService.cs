// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System;
using System.Threading.Tasks;
using Spider2FA.Core.Backup;
using Spider2FA.Core.Converter;

namespace Spider2FA.Core.Service
{
    public interface IImportService
    {
        Task<ValueTuple<ConversionResult, RestoreResult>> ImportAsync(BackupConverter converter, byte[] data,
            string password);
    }
}