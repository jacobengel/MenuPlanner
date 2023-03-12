namespace MenuPlanner.Domain.Models
{
    public interface IMapper<Source, Dest>
    {
        Dest Map(Source source);

        Source Map(Dest dest);
    }
}