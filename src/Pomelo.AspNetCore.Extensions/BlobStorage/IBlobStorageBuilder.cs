﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public interface IBlobStorageBuilder
    {
        IServiceCollection Services { get; }
    }
}
