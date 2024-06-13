using Microsoft.AspNetCore.Razor.Language;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using StarWarsDnDHelperApp.Components.Models;

namespace StarWarsDnDHelperApp.Components.Repository
{
    public static class PlayerDataRepository
    {
		// What players start out with
		private static int basePlayerHealth = 16; 

        private static List<PlayerData> players = new List<PlayerData>()
        {
            new PlayerData(1, "Alex", "B0-E501", basePlayerHealth),
            new PlayerData(2, "Adrian", "Gio", basePlayerHealth),
            new PlayerData(3, "Hunter", "Boz", basePlayerHealth)

            //////////////////////////////////////////////////////////////////////
            ///
            /// Use to add guests, npcs and enemies
            ///
            /////////////////////////////////////////////////////////////////////

            //// Guests
            //add Guests group 1
            //new PlayerData(-1, "Diego", "E", basePlayerHealth),
            //addPlayer(new PlayerData(-1, "Diego", "", basePlayerHealth),
            // Add as many as you want!!!

            ///// NPCs
            //add Npcs group 1
            //new PlayerData(-1, "Jina", "E", 16),
            //new PlayerData(-1, "Endo","E", 16),
            //addPlayer(new PlayerData(-1, "E", "E", 16),
            // Add as many as you want!!!

            //add Npcs group 2
            //new PlayerData(-1, "Jina", "E", 16),
            //new PlayerData(-1, "E", "E", 16),
            //addPlayer(new PlayerData(-1, "E", "E", 16),
            // Add as many as you want!!!

            //// Enemies
            //add Enemies group 1
            //new PlayerData(-1, "Enemy1", "Droid", 5),
            //new PlayerData(-1, "Enemy2", "Clone", 10),
            //addPlayer(new PlayerData(-1, "Enemy3", "E", 10),
            // Add as many as you want!!!

            //add Enemies group 2
            //new PlayerData(-1, "Enemy1", "Droid", 5),
            //new PlayerData(-1, "Enemy2", "Clone", 10),
            //addPlayer(new PlayerData(-1, "Enemy3", "E", 10),
            // Add as many as you want!!!

            //// Bosses
            //add Bosses group 1
            //new PlayerData(-1, "Boss1", "Dune Worm", 50),
            //new PlayerData(-1, "Enemy1", "Droid", 5),
            //addPlayer(new PlayerData(-1, "Enemy2", "Clone", 8),
            // Add as many as you want!!!

            //add Bosses group 2
            //new PlayerData(-1, "Boss1", "Watto", 9999),
            //new PlayerData(-1, "Enemy1", "Droid", 5),
            //addPlayer(new PlayerData(-1, "Enemy2", "Clone", 8),
            // Add as many as you want!!!

            //////////////////////////////////////////////////////////////////////////////////////
            /// Add more groups if needed
        };

        public static void addPlayer(PlayerData player)
        {
			var maxId = players.Max(size => size.getId());
			player.setId(maxId + 1);
			players.Add(player);
        }

        public static List<PlayerData> getPlayers() => players;

        public static PlayerData getPlayerByName(string name)
        {
            List<PlayerData> player = players.Where(p => p.getName().Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (player.Count > 0) {
                return player[0];
            }

            return null;
        }

	}
}
