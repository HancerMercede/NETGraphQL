namespace NETGraphQL.Models;

public class Developer
{
    public int DevId { get; set; }
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? EMail { get; set; }
    public IEnumerable<Tools>? Tools { get; set; }
}
