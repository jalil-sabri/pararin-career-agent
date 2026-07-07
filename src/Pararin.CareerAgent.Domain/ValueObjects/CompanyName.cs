using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pararin.CareerAgent.Domain.ValueObjects;

public sealed record CompanyName
{
    public string Value { get; }

    public CompanyName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Company name cannot be empty.", nameof(value));

        Value = value.Trim();
    }

    public override string ToString() => Value;
}
