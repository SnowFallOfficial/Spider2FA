// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

namespace Spider2FA.Core.Util
{
    public static class StringUtil
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            return value.Length <= maxLength ? value : value[..maxLength];
        }
    }
}