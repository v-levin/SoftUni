﻿using System.Collections.Generic;

namespace IntegrationTests.Interfaces
{
    public interface IUser
    {
        string Name { get; }

        IEnumerable<ICategory> Categories { get; }

        void AddCategory(ICategory category);

        void RemoveCategory(ICategory category);
    }
}
