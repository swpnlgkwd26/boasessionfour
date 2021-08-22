using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Models
{
    public class RandomService : IRandomService
    {
        private int _randomNumber;
        public RandomService()
        {
            Random random = new Random();
            _randomNumber = random.Next(1, 100000);
        }

        // Generate and Return Random Number
        public int GetNumber()
        {
            return _randomNumber;
        }
    }
}
