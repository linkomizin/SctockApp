using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.GeneratorObject
{
    public class MakerBox
    {
        private Random _random;

        public MakerBox()
        {
            _random = new Random();
        }

        public List<Box> CreateBoxes(int totalCount, int minimalDay, double minimalNum, double maxH, double maxW, double maxL, double maxScale, int countDayExp = 100)
        {
            List<Box> boxes = new List<Box>();

            for (int i = 0; i < totalCount; i++)
            {
                var item = CreateBox(minimalNum, countDayExp, minimalDay, maxH, maxW, maxL, maxScale);
                boxes.Add(item);
            }
            return boxes;
        }

        private Box CreateBox(double minimalNum, int countDayExp, int minimalDay, double maxH, double maxW, double maxL, double maxScale)
        {
            //from null or not null set productionDate
            int num = _random.Next(0, 2);

            return new Box(
                id: Guid.NewGuid().ToString(),
                expirationDate: DateOnly.FromDayNumber(_random.Next(minimalDay, DateOnly.FromDateTime(DateTime.Now).DayNumber + countDayExp + 1)),
                productionDate: num == 0 ? null : DateOnly.FromDayNumber(_random.Next(minimalDay, (DateOnly.FromDateTime(DateTime.Now).DayNumber))),
                countDay: countDayExp,
                length: (_random.NextDouble() + minimalNum) * maxL,
                 height: (_random.NextDouble() + minimalNum) * maxH,
                 width: (_random.NextDouble() + minimalNum) * maxW,
                 scale: (_random.NextDouble() + minimalNum) * maxScale
                 );

        }

    }
}
