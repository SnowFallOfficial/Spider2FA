// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using Spider2FA.Core;
using Spider2FA.Core.Entity;
using Spider2FA.Core.Generator;

namespace Spider2FA.Droid.Interface.Fragment
{
    public class AddAuthenticatorBottomSheet : InputAuthenticatorBottomSheet
    {
        public AddAuthenticatorBottomSheet() : base(Resource.Layout.sheetAddAuthenticator, Resource.String.enterKey)
        {
            InitialAuthenticator = new Authenticator
            {
                Type = AuthenticatorType.Totp,
                Algorithm = HashAlgorithm.Sha1,
                Digits = AuthenticatorType.Totp.GetDefaultDigits(),
                Period = AuthenticatorType.Totp.GetDefaultPeriod()
            };
        }

        protected override bool ShouldShowAdvancedOptions(AuthenticatorType type)
        {
            var hasVariableDigits = type.GetMinDigits() != type.GetMaxDigits();
            return hasVariableDigits || type.HasVariablePeriod();
        }

        protected override bool ShouldShowAdvancedWarning()
        {
            return false;
        }
    }
}