using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_app.Models
{
    public class RandomWrapperService : IRandomWrapper
    {
        private readonly IRandomService _randomService;

        public RandomWrapperService(IRandomService randomService)
        {
            _randomService = randomService;
        }
        public int GetNumber()
        {
            return _randomService.GetNumber();
        }
    }
}
