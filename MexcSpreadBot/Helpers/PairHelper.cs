using MexcSpreadBot.Data;
using System.Diagnostics.Metrics;

namespace MexcSpreadBot.Helpers
{
    public class PairHelper
    {

        /// <summary>
        /// синхронизирует список пар в базе и переданного в параметрах
        /// </summary>
        /// <param name="pairsToSave"></param>
        public static (int countAdd, int countDel) SynchronisePairs(List<Pair> pairsToSave)
        {
            int counterAdd = 0;
            int counterDel = 0;

            var db = new DataBaseContextExchange();

            var pairsDb = db.Pairs.ToList();

            foreach (var p in pairsToSave)
            {
                var pairDb = pairsDb.FirstOrDefault(x => x.Symbol == p.Symbol);

                if (pairDb == null)
                {
                    db.Pairs.Add(p);
                    counterAdd++;
                }
            }

            pairsDb = db.Pairs.ToList();
            foreach (var pairdb in pairsDb)
            {
                var pairToSave = pairsToSave.FirstOrDefault(x => x.Symbol == pairdb.Symbol);
                if (pairToSave == null)
                {
                    db.Pairs.Remove(pairdb);
                    counterDel++;
                }
            }

            db.SaveChanges();

            return (counterAdd, counterDel);

        }

        public static List<Pair> GetAllPairs()
        {
            var db = new DataBaseContextExchange();
            return db.Pairs.ToList();
        }
    }
}
