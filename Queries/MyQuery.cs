using NETGraphQL.Models;

namespace NETGraphQL.Queries
{
    public class MyQuery
    {
        public Developer GetDevInformation() => new Developer
        {
            DevId = 1,
            Name = "Martin Fowler",
            EMail = "MFowler@developer.net",
            Phone = "12345678",
            Tools = new List<Tools> 
            { 
                new Tools
                { 
                   Id = 1,
                   Name = ".NET"
                },
                new Tools
                { 
                    Id= 2,
                    Name = "Sql Server 2022"
            
                }
            }
        };
    }
}
