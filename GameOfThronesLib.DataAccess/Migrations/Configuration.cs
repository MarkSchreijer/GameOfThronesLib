namespace GameOfThronesLib.Models.Migrations
{
    using GameOfThronesLib.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<GameOfThronesLib.Models.GoTLibContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GameOfThronesLib.Models.GoTLibContext context)
        {
            context.Families.AddOrUpdate(
                p => p.ID,
                new Family { Name = "House Stark", Description = "House Stark was one of the Great Houses of Westeros, ruling over the vast region known as the North from their seat in Winterfell. It is by far one of the oldest lines of Westerosi nobility, claiming a line of descent stretching back over eight thousand years. The head of the house is the Lord of Winterfell. Before the Targaryen conquest, the leaders of House Stark ruled over the region as the Kings in the North.", Words = "Winter is Coming" },
                new Family { Name = "House Lannister", Description = "House Lannister of Casterly Rock is one of the Great Houses of Westeros, one of its richest and most powerful families and oldest dynasties. The major characters Jaime, Cersei, and Tyrion and the recurring characters Tywin, Kevan, and Lancel are members of the house. Tywin is the head of House Lannister and Lord of Casterly Rock.", Words = "Hear me roar!" },
                new Family { Name = "House Targaryan", Description = "House Targaryen is one former Great Houses of Westeros and was the ruling royal House of the Seven Kingdoms for three centuries, before it was deposed during Robert's Rebellion and House Baratheon replaced it as the new royal House.", Words = "Fire and Blood" },
                new Family { Name = "House Tyrrel", Description = "House Tyrell is one of the Great Houses of Westeros. It rules over the Reach, a vast, fertile, and heavily-populated region of southwestern Westeros, from their castle-seat, Highgarden. It is currently led by Lord Mace Tyrell, although his mother, the indomitable Olenna Tyrell, still wields considerable influence over the House's affairs. His son Loras is a noted tournament knight (and secretly, the lover of Lord Renly Baratheon). Mace's daughter Margaery married Renly when he crowned himself king, to cement the alliance between Renly and her father. Following Renly's death, Margaery was then married to King Joffrey Baratheon before his assassination at his wedding feast.", Words = "Growing Strong" },
                new Family { Name = "House Baratheon", Description = "House Baratheon is one of the Great Houses of Westeros, although also one of the youngest. It is the current royal house.", Words = "Ours is the Fury" }
                );
        }
    }
}
