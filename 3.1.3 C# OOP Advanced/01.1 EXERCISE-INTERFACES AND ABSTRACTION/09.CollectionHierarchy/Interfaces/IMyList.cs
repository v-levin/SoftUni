﻿namespace CollectionHierarchy.Interfaces
{
    public interface IMyList<T> : IAddRemoveCollection<T>
    {
        int Used { get; }
    }
}