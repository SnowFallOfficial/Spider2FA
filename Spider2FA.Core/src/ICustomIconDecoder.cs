// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System.Threading.Tasks;
using Spider2FA.Core.Entity;

namespace Spider2FA.Core
{
    public interface ICustomIconDecoder
    {
        Task<CustomIcon> DecodeAsync(byte[] data, bool shouldPreProcess);
    }
}