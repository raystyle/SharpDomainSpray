﻿using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace SharpDomainSpray
{
    class ADAuth
    {
        public bool Authenticate(string userName, string password, string domain)
        {
            bool authentic = false;
            try
            {
                DirectoryEntry entry = new DirectoryEntry("LDAP://" + domain,
                    userName, password);
                object nativeObject = entry.NativeObject;
                authentic = true;
            }
            catch (DirectoryServicesCOMException) { }
            return authentic;
        }
    }
}
