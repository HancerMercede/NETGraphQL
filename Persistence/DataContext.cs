using Microsoft.EntityFrameworkCore;

namespace NETGraphQL.Persistence;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        :base(options)
    {
        
    }
    public DataContext()
    {
        
    }
}
