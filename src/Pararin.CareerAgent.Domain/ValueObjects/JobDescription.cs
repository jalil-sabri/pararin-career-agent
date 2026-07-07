using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pararin.CareerAgent.Domain.ValueObjects;

public sealed record JobDescription
{
    private string Value;

    public JobDescription(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Job description cannot be empty.", nameof(value));

        Value = value.Trim();
    }

    public override string ToString() => Value;

}
