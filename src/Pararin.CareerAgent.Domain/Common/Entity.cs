using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pararin.CareerAgent.Domain.Common;

public abstract class Entity
{
    protected Entity(Guid id)
    {
        if (id == Guid.Empty)
            throw new ArgumentException("Entity id cannot be empty.", nameof(id));

        Id = id;
    }

    public Guid Id { get; }
}
