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
            return context.Scores.AsEnumerable();
        }

        public void AddNewScore(Score score)
        {
            context.Scores.Add(score);
            context.SaveChanges();
        }
    }
}
