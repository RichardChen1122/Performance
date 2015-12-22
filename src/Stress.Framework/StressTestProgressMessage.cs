// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Stress.Framework
{
    public class StressTestProgressMessage : ITestProgressMessage
    {
        public StressTestProgressMessage(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}