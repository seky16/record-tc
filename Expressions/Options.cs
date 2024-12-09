namespace Expressions;

public record Options : IDataSource
{
    public required IDataSource DataSource { get; init; }

    public int? Take { get; init; } = null;
}