﻿using IntegrationTests.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace IntegrationTests.Models
{
    public class Category : ICategory
    {
        private string name;
        private IList<IUser> users;
        private IList<ICategory> childCategories;
        private ICategory parent;

        public Category(string name)
        {
            this.Name = name;
            this.users = new List<IUser>();
            this.childCategories = new List<ICategory>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Cannot create category without a name");

                this.name = value;
            }
        }

        public IList<ICategory> ChildCategories => new ReadOnlyCollection<ICategory>(this.childCategories);

        public ICategory Parent
        {
            get => this.parent;
            private set
            {
                this.parent = value;
            }
        }

        public IList<IUser> Users
        {
            get => new ReadOnlyCollection<IUser>(this.users);
            private set
            {
                this.users = value;
            }
        }

        public void MoveUsersToParent()
        {
            if (this.Parent == null)
                return;

            foreach (var user in this.Users)
                this.parent.AddUser(user);
        }

        public void AddChild(ICategory child)
        {
            this.childCategories.Add(child);
            child.SetParent(this);
        }

        public void AddUser(IUser user)
        {
            this.users.Add(user);
            user.AddCategory(this);
        }

        public void RemoveChild(string name)
        {
            var categoryToRemove = this.childCategories.FirstOrDefault(c => c.Name == name);
            this.childCategories?.Remove(categoryToRemove);
        }

        public void SetParent(ICategory category)
        {
            this.Parent = category;
        }
    }
}
