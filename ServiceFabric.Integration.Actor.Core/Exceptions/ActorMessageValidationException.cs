﻿using System;

namespace Integration.Common.Actor.Utilities
{
    public class ActorMessageValidationException : Exception
    {
        public ActorMessageValidationException(string message) : base(message)
        {
            
        }
    }
}
