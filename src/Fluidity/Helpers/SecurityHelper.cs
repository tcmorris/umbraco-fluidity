﻿// <copyright file="SecurityHelper.cs" company="Matt Brailsford">
// Copyright (c) 2017 Matt Brailsford and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

using Umbraco.Core;

namespace Fluidity.Helpers
{
    internal static class SecurityHelper
    {
        internal static string Encrypt(string input)
        {
            return input.EncryptWithMachineKey();
        }

        internal static string Decrypt(string input)
        {
            return input.DecryptWithMachineKey();
        }
    }
}
