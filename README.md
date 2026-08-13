# 🕷️ Spider2FA

> **Free. Ad-free. Open source. The 2FA app you'd build for yourself.**

A clean, no-tracking, no-subscription, no-cloud-required two-factor authentication app for Android and Wear OS. Rebranded and re-themed fork of [Stratum Authenticator](https://github.com/stratumauth/app) by Jamie Huddleston.

**Black + spider red. Matrix binary rain. Built once, built right.**

---

## About

Spider2FA is a fork of [Stratum](https://github.com/stratumauth/app), the open-source 2FA app by [Jamie Huddleston](https://github.com/jamie-huddleston). We took Stratum's solid cryptographic core, mature Wear OS support, and full TOTP/HOTP implementation, and gave it a new visual identity, a new package, and a new home.

**What's the same** (because it doesn't need to change):
- TOTP (RFC 6238) and HOTP (RFC 4226) with SHA1/256/512
- Steam, Yandex, and Mobile-OTP support
- Encrypted local backups (password-protected)
- Wear OS companion app
- Offline operation — no internet permission required
- QR code scanning for account import
- Icon packs and categories
- Import from Google Authenticator, Authy, Blizzard, Steam
- Material 3 dynamic theming (we add a custom black/red variant on top)

**What's different**:
- App name: Spider2FA
- Package: `com.spider2fa.app`
- Theme: black + spider red `#FF0033`, with optional matrix binary-rain background
- Branding: 🕷️ spider mark, custom wordmark
- Distribution: own GitHub release pipeline + IzzyOnDroid + Google Play (via your dev account)

---

## Why a fork?

Building a 2FA app from scratch is an 18-month project. **TOTP/HOTP are spec'd but everything around them — secure storage, QR scanning, Wear OS sync, encrypted backups — is years of careful work.** Stratum had it. We just put a different paint job on it.

If you want a 2FA app that works, has Wear OS support, encrypted backups, and doesn't track you — forking Stratum and shipping a rebrand is the right call. That's what we did.

---

## Visual identity

| | |
|---|---|
| **App name** | Spider2FA |
| **Display name** | Authenticator |
| **Theme** | Black background, spider red `#FF0033` accent |
| **Icon** | 🕷️ Stylized red spider on black, with 4 glowing red eyes |
| **Background** | Optional matrix binary-rain tile (subtle on the list, loud on splash/About) |
| **Wordmark** | `SPIDER  2FA` in red on black, custom serif |
| **Hex** | `#FF0033` (red), `#000000` (black), `#06060A` (near-black surface) |

---

## Build

This is a [.NET MAUI](https://learn.microsoft.com/dotnet/maui/) Android app (originally Xamarin, migrated). To build:

```bash
# One-time: install the .NET Android workload
dotnet workload install android

# Build the APK
dotnet build Spider2FA.sln -c Debug

# Signed release build (after setting up your keystore)
dotnet publish Spider2FA.Droid -c Release -p:AndroidKeyStore=true \
    -p:AndroidSigningKeyStore=spider2fa.keystore \
    -p:AndroidSigningKeyAlias=spider2fa \
    -p:AndroidSigningKeyPass=<your-password> \
    -p:AndroidSigningStorePass=<your-password>
```

Output APK is at `Spider2FA.Droid/bin/Release/net8.0-android/com.spider2fa.app-Signed.apk`.

---

## Credits

**Spider2FA** is built on the work of:

- **[Stratum Authenticator](https://github.com/stratumauth/app)** by [Jamie Huddleston](https://github.com/jamie-huddleston) — original source code, GNU GPL-3 license
- **Authenticator Pro** by [Cuzimagi](https://github.com/jamie-mh) — for the rebranding material folder structure
- **Material Design 3** by Google — for the design system

This project is licensed under **GNU GPL-3** in accordance with the upstream license. See [LICENSE](LICENSE) for full text.

---

## License

```
Spider2FA - a rebrand of Stratum Authenticator
Copyright (C) 2024-2026  SnowFallOfficial (Spider)

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/gpl-3.0.txt>.
```

Upstream: <https://github.com/stratumauth/app> · Stratum © Jamie Huddleston, GNU GPL-3.

---

## 🕷️

The web doesn't sleep. Neither does your 2FA.
