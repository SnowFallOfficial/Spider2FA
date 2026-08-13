// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

namespace Spider2FA.Core
{
    public interface IIconResolver
    {
        string FindServiceKeyByName(string name);
    }
}