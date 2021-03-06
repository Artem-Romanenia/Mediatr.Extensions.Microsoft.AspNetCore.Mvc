﻿using System;

namespace MediatR.Extensions.Microsoft.AspNetCore.Mvc.Internal
{
    internal class RequestTypeVerbAttribute : Attribute
    {
        public string[] Verbs { get; }

        public RequestTypeVerbAttribute(string[] verbs)
        {
            Verbs = verbs;
        }
    }
}
