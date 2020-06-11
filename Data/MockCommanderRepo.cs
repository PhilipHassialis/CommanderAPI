using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        List<Command> mockData;

        public MockCommanderRepo()
        {
            mockData = new List<Command>();
            mockData.Add(new Command() { Id = 0, HowTo = "Boil an egg", Platform = "Linux", Line = "boil egg" });
            mockData.Add(new Command() { Id = 1, HowTo = "Fry an egg", Platform = "Linux", Line = "fry egg" });
            mockData.Add(new Command() { Id = 2, HowTo = "Scramble an egg", Platform = "Linux", Line = "scramble egg" });
        }

        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return mockData;
        }

        public Command GetCommandById(int id)
        {
            if (id >= 0 && id <= mockData.Count - 1) return mockData[id]; else return mockData[0];
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}