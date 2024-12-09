namespace WebAPI;

internal static class Handler
{
    public static void Get(InheritedOptions config)
    {
        if (config.DataSource is null)
            throw new InvalidProgramException(); // doesnt happen

        var config2 = config with { Take = null, };

        if (config2.DataSource is null)
            throw new StackOverflowException(); // shouldnt happen
    }
}