using System.Collections.Generic;
using System.Linq;
using FibonacciGenerator.Exceptions;

namespace FibonacciGenerator
{
    public class Generator
    {
        private int _currentNumber;
        private int _mostPreviousNumber;
        private int _immediatelyPreviousNumber;

        public Generator()
        {
            _currentNumber = 1;
            _immediatelyPreviousNumber = 1;
            _mostPreviousNumber = 0;
        }

        public List<int> Generate(int numberOfRequestedItems)
        {
            ValidateNumberOfRequestedItems(numberOfRequestedItems);

            List<int> items = new List<int>(numberOfRequestedItems) { _mostPreviousNumber, _immediatelyPreviousNumber, _currentNumber };
            _mostPreviousNumber = 1;
            _immediatelyPreviousNumber = 1;

            for (int i = 0; i < numberOfRequestedItems; i++)
            {
                _currentNumber = _immediatelyPreviousNumber + _mostPreviousNumber;

                items.Add(_currentNumber);

                _mostPreviousNumber = _immediatelyPreviousNumber;
                _immediatelyPreviousNumber = _currentNumber;
            }

            return items.Take(numberOfRequestedItems).ToList();
        }

        private void ValidateNumberOfRequestedItems(int numberOfRequestedItems)
        {
            if (numberOfRequestedItems < 8)
            {
                throw new InputTooShortException("Input cannot be less than 8");
            }

            if (numberOfRequestedItems > 50)
            {
                throw new InputTooLongException("Input cannot be greater than 50");
            }
        }
    }
}
