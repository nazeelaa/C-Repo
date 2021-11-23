using System;
using System.Collections.Generic;
using System.Text;

namespace Day13PracticeProgram_UC5
{
   
		public class MaxCount<T> where T : IComparable<T>
		{
			List<T> maxValue = new List<T>();
			public MaxCount(params T[] values)
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

			public void PrintMaxValue(int value)
			{
				Console.WriteLine("Maximum values is : ", this.maxValue[value]);
			}
		}
	}

