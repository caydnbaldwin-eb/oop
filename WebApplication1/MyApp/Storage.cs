using System;
using Microsoft.VisualBasic;

namespace MyApp
{
    public static class Storage
    {
        private static readonly Dictionary<string, User>
            _users = new Dictionary<string, User>();

        public static bool UsernameExists(string username) =>
            _users.ContainsKey(username);

        public static void Add(User user) =>
            _users[user.Username] = user;

        public static bool Validate(string username, string password) =>
            _users.TryGetValue(username, out var user)
            && user.Password == password;
    }
}