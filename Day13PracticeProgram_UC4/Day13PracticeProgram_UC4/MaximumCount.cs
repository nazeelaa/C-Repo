using System;
using System.Collections.Generic;
using System.Text;

namespace Day13PracticeProgram_UC4
{

	public class MaximumCount<T> where T : IComparable<T>
	{
		List<T> maxValue = new List<T>();
		public MaximumCount(params T[] values)
		{
			this.ValuesBuilder(values);
		}
		public void ValuesBuilder(T[] maxValue)
		{
			foreach (T item in maxValue)
			{
				this.maxValue.Add(item);
			}
		}
		public void Values()
		{
			this.maxValue.Sort();
			Console.WriteLine(this.maxValue[this.maxValue.Count - 1]);
		}
	}
}

