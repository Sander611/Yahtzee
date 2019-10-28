using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yahtzee.Models;

namespace Yahtzee.Repositories
{
    public class ScoreRepository
    {
        private YahtzeeScoreEntities context = new YahtzeeScoreEntities();

        public IEnumerable<Score> GetTopList()
        {
            var top10scores = context.Scores.AsEnumerable().OrderByDescending(x => x.SCORE1).Take(10);
            return top10scores;
        }

        public void AddNewScore(Score score)
        {
            context.Scores.Add(score);
            context.SaveChanges();
        }

    }
}
