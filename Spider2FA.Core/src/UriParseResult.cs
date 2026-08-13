// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using Spider2FA.Core.Entity;

namespace Spider2FA.Core
{
    public class UriParseResult
    {
        public Authenticator Authenticator { get; set; }
        public int PinLength { get; set; }
    }
}