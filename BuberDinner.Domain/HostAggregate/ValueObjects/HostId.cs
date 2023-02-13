using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.HostAggregate.ValueObjects;

public sealed class HostId : ValueObject
{
    public string Value { get; private set; }

    private HostId(string value) => Value = value;

    // public static HostId Create(UserId userId)
    // {
    //     // TODO: enforce invariants
    //     return new HostId($"Host_{userid.Value}");
    // }

    public static HostId Create(string hostId)
    {
        // TODO: enforce invariants
        return new HostId(hostId);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}