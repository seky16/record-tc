using Expressions;
using SharedAbstractions;

namespace WebAPI;

internal record InheritedOptions : Options
{
    public ISet? Set { get; init; }
}