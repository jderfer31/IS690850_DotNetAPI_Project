﻿using Entities.Models;
using System.Collections.Generic;

namespace Contracts
{
    public interface IDataShaping<T>
    {
        IEnumerable<Entity> ShapeData(IEnumerable<T> entities, string fieldsString);
        Entity ShapeData(T entity, string fieldsString);
    }

    public class Entity
    {
    }
}