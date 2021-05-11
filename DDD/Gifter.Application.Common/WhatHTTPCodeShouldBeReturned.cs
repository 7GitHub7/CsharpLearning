using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Application.Common
{
    public enum  WhatHTTPCodeShouldBeReturned
    {
        Forbid,
        NotFound,
        BadRequest,
        MethodFailure,
        ok
    }
}
