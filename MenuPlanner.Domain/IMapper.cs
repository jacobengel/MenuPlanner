namespace MenuPlanner.Domain
{
    public interface IMapper<Source, Dom>
    {
        Dom Map(Source source);

        Source Map(Dom dest);
    }
}