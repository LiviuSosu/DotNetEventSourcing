﻿using System;

namespace EventSourcing.CQRS.Domain.Mementos
{
    public class BaseMemento
    {
        public Guid Id { get; internal set; }
        public int Version { get; set; }
    }
}
