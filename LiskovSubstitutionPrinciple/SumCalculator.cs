using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class SumCalculator
    {
        protected readonly int[] _numbers;
        public SumCalculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public int Sum() => this._numbers.Sum(x => x);
    }

    public class EvenNumberSummation : SumCalculator
    {
        public EvenNumberSummation(int[] numbers) : base(numbers)
        {
        }
        public new int Sum() => this._numbers.Where(x => x % 2 == 0).Sum();
    }

    public class OddNumberSummation : SumCalculator
    {
        public OddNumberSummation(int[] numbers) : base(numbers)
        {
        }
        public new int Sum() => this._numbers.Where(x => x % 2 != 0).Sum();
    }

    // Refactor

    public abstract class Calculator
    {
        protected int[] _numbers;
        public Calculator(int[] numbers)
        {
            this._numbers = numbers;
        }
        public abstract int Sum();
    }
    public class SumAllNumbers : Calculator
    {
        public SumAllNumbers(int[] numbers) : base(numbers)
        {
        }

        public override int Sum() => _numbers.Sum();
    }
    public class SummAllOddNumbers : Calculator
    {
        public SummAllOddNumbers(int[] numbers) : base(numbers)
        {
        }

        public override int Sum() => _numbers.Where(x => x % 2 != 0).Sum();
    }

    public class SummAllEvenNumbers : Calculator
    {
        public SummAllEvenNumbers(int[] numbers) : base(numbers)
        {
        }

        public override int Sum() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
