using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace MagicTheGathering_DAL
{
    public static class DatabaseOperations
    {
        public static List<Rarity> OphalenRarity()
        {
            using (MagicTheGatheringEntities entities = new MagicTheGatheringEntities())
            {
                var query = entities.Rarity;
                return query.ToList();
            }
        }
        public static List<Type> OphalenType()
        {
            using (MagicTheGatheringEntities entities = new MagicTheGatheringEntities())
            {
                var query = entities.Type;
                return query.ToList();
            }
        }
        public static List<Color> OphalenColor()
        {
            using (MagicTheGatheringEntities entities = new MagicTheGatheringEntities())
            {
                var query = entities.Color;
                return query.ToList();
            }
        }
        public static List<Expansion> OphalenExpansion()
        {
            using (MagicTheGatheringEntities entities = new MagicTheGatheringEntities())
            {
                var query = entities.Expansion;
                return query.ToList();
            }
        }
        public static List<Kaart> OphalenKaart()
        {
            using (MagicTheGatheringEntities entities = new MagicTheGatheringEntities())
            {
                var query = entities.Kaart
                            .Include(x => x.Type)
                            .Include(x => x.Color)
                            .Include(x => x.Rarity)
                            .Include(x => x.Expansion);



                return query.ToList();
            }
        }
        public static List<Kaart> OphalenKaartViaZoeken(string naam)
        {
            using (MagicTheGatheringEntities entities = new MagicTheGatheringEntities())
            {
                var query = entities.Kaart
                            .Include(x => x.Type)
                            .Include(x => x.Color)
                            .Include(x => x.Rarity)
                            .Include(x => x.Expansion)
                            .Where(x => x.Naam.Contains(naam));
                return query.ToList();
            }
        }
        public static List<Kaart> ZoekenOpExpansion(string expansion)
        {
            using (MagicTheGatheringEntities entities = new MagicTheGatheringEntities())
            {
                var query = entities.Kaart
                            .Include(x => x.Type)
                            .Include(x => x.Color)
                            .Include(x => x.Rarity)
                            .Include(x => x.Expansion)
                            .Where(x => x.Expansion.Naam == expansion);
                return query.ToList();
            }
        }
    }
}
