using SaveGameManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveGameManager
{
    public class GamesViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        public GamesViewModel()
        {
            SeedSampleData();
        }

        private void SeedSampleData()
        {
            GameCollection = new List<GameState>
            {
                new GameState { GameId = Guid.NewGuid(), GameName = "Alice Madness Returns", InCloud = true, IsInstalled = false, IsSynced = true },
                new GameState { GameId = Guid.NewGuid(), GameName = "Elderscrolls V: Skyrim", InCloud = true, IsInstalled = true, IsSynced = false },
                new GameState { GameId = Guid.NewGuid(), GameName = "Alice Madness Returns", InCloud = true, IsInstalled = false, IsSynced = true },
                new GameState { GameId = Guid.NewGuid(), GameName = "Elderscrolls V: Skyrim", InCloud = true, IsInstalled = true, IsSynced = false },
                new GameState { GameId = Guid.NewGuid(), GameName = "Alice Madness Returns", InCloud = true, IsInstalled = false, IsSynced = true },
                new GameState { GameId = Guid.NewGuid(), GameName = "Elderscrolls V: Skyrim", InCloud = true, IsInstalled = true, IsSynced = false },
                new GameState { GameId = Guid.NewGuid(), GameName = "Alice Madness Returns", InCloud = true, IsInstalled = false, IsSynced = true },
                new GameState { GameId = Guid.NewGuid(), GameName = "Elderscrolls V: Skyrim", InCloud = true, IsInstalled = true, IsSynced = false },
                new GameState { GameId = Guid.NewGuid(), GameName = "Alice Madness Returns", InCloud = true, IsInstalled = false, IsSynced = true },
                new GameState { GameId = Guid.NewGuid(), GameName = "Elderscrolls V: Skyrim", InCloud = true, IsInstalled = true, IsSynced = false },
                new GameState { GameId = Guid.NewGuid(), GameName = "Alice Madness Returns", InCloud = true, IsInstalled = false, IsSynced = true },
                new GameState { GameId = Guid.NewGuid(), GameName = "Elderscrolls V: Skyrim", InCloud = true, IsInstalled = true, IsSynced = false },
                new GameState { GameId = Guid.NewGuid(), GameName = "Alice Madness Returns", InCloud = true, IsInstalled = false, IsSynced = true },
                new GameState { GameId = Guid.NewGuid(), GameName = "Elderscrolls V: Skyrim", InCloud = true, IsInstalled = true, IsSynced = false },
                new GameState { GameId = Guid.NewGuid(), GameName = "Alice Madness Returns", InCloud = true, IsInstalled = false, IsSynced = true },
                new GameState { GameId = Guid.NewGuid(), GameName = "Elderscrolls V: Skyrim", InCloud = true, IsInstalled = true, IsSynced = false },
                new GameState { GameId = Guid.NewGuid(), GameName = "Alice Madness Returns", InCloud = true, IsInstalled = false, IsSynced = true },
                new GameState { GameId = Guid.NewGuid(), GameName = "Elderscrolls V: Skyrim", InCloud = true, IsInstalled = true, IsSynced = false },
                new GameState { GameId = Guid.NewGuid(), GameName = "Alice Madness Returns", InCloud = true, IsInstalled = false, IsSynced = true },
                new GameState { GameId = Guid.NewGuid(), GameName = "Elderscrolls V: Skyrim", InCloud = true, IsInstalled = true, IsSynced = false },
                new GameState { GameId = Guid.NewGuid(), GameName = "Alice Madness Returns", InCloud = true, IsInstalled = false, IsSynced = true },
                new GameState { GameId = Guid.NewGuid(), GameName = "Elderscrolls V: Skyrim", InCloud = true, IsInstalled = true, IsSynced = false },
                new GameState { GameId = Guid.NewGuid(), GameName = "Alice Madness Returns", InCloud = true, IsInstalled = false, IsSynced = true },
                new GameState { GameId = Guid.NewGuid(), GameName = "Elderscrolls V: Skyrim", InCloud = true, IsInstalled = true, IsSynced = false }
            };
        }

        public List<GameState> GameCollection { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
