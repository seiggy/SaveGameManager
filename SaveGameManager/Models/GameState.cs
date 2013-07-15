using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveGameManager.Models
{
    public class GameState
    {
        public Guid GameId { get; set; }
        public string GameName { get; set; }
        public bool InCloud { get; set; }
        public bool IsInstalled { get; set; }
        public bool IsSynced { get; set; }
    }
}
