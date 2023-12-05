namespace WebApplication.Models;

public interface ICategoryRepository
{
    IEnumerable<Category> AllCategories { get; }
}