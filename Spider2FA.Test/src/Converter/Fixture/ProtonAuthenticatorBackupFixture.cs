// Copyright (C) 2025 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System.IO;

namespace Spider2FA.Test.Converter.Fixture
{
    public class ProtonAuthenticatorBackupFixture
    {
        public ProtonAuthenticatorBackupFixture()
        {
            var path = Path.Join("data", "protonauthenticator.json");
            Data = File.ReadAllBytes(path);
        }

        public byte[] Data { get; }
    }
}