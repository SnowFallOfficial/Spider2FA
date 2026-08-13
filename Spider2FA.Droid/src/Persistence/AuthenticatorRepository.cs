// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System.Threading.Tasks;
using Spider2FA.Core.Entity;
using Spider2FA.Core.Persistence;
using Spider2FA.Core.Persistence.Exception;
using SQLite;

namespace Spider2FA.Droid.Persistence
{
    public class AuthenticatorRepository : AsyncRepository<Authenticator, string>, IAuthenticatorRepository
    {
        private readonly Database _database;

        public AuthenticatorRepository(Database database) : base(database)
        {
            _database = database;
        }

        public async Task ChangeSecretAsync(string oldSecret, string newSecret)
        {
            var conn = await _database.GetConnectionAsync();

            try
            {
                await conn.ExecuteAsync(
                    "UPDATE authenticator SET secret = ? WHERE secret = ?", newSecret, oldSecret);
            }
            catch (SQLiteException e)
            {
                throw new EntityDuplicateException(e);
            }
        }
    }
}