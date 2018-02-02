using System.Collections.Generic;

namespace CaseIf
{
    //DO NOT CHANGE THIS CODE
    //THIS IS DEMO ONLY

    /// <summary>
    /// Fake static data for mock something
    /// </summary>
    public static class StaticData
    {
        public static List<Developer> DeveloperList => new List<Developer>
        {
            new Developer
            {
                Id = "1",
                Name = "Cafer",
                Surname = "Kafkas",
                Title = DeveloperType.Junior
            },
            new Developer
            {
                Id = "2",
                Name = "Kamil",
                Surname = "Kedi",
                Title = DeveloperType.Senior
            },
            new Developer
            {
                Id = "3",
                Name = "Sosa",
                Surname = "Perreira",
                Title = DeveloperType.Master
            },
            new Developer
            {
                Id = "4",
                Name = "Sadi",
                Surname = "Sucu",
                Title = DeveloperType.Specialist
            }
        };
    }
}
