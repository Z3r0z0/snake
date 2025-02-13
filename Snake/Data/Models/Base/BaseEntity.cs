﻿using System.ComponentModel.DataAnnotations;

namespace Snake.Data.Models.Base
{
    public interface IEntity
    {
    }

    public abstract record class BaseEntity<T> : IEntity
    {
        [Key]
        public T? Id { get; set; }
    }

    public abstract record class IdEntity : BaseEntity<int>
    {

    }
}
