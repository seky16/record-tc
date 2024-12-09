namespace WebAPI;

public static class API
{
    public static void Get()
    {
        var config = new InheritedOptions()
        {
            DataSource = new DPAbstractions.Path(),
        };

        Handler.Get(config);
    }
}