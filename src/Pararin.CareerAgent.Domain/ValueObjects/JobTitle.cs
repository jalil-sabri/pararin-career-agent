using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pararin.CareerAgent.Domain.ValueObjects;

public sealed record JobTitle
{
    public string Value { get; }

    public JobTitle(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Job title cannot be empty.", nameof(value));

        Value = value.Trim();
    }
}
