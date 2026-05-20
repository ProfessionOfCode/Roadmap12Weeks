namespace Roadmap12Weeks.Weeks.week1
{
    public interface IBeforeAfterComparer
    {
        string Before();
        string After();
    }

    public interface IBeforeAfterComparerAsync : IBeforeAfterComparer
    {
        Task<string> BeforeAsync();
        Task<string> AfterAsync();
    }
}