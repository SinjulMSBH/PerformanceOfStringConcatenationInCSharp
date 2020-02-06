using System.Collections.Generic;

using BenchmarkDotNet.Attributes;

namespace Demo
{
	public class StringJoinComparison
	{
		public string string1 = "S";
		public string string2 = "I";
		public string string3 = "N";
		public string string4 = "J";
		public string string5 = "U";
		public string string6 = "L";

		public List<string> stringList;

		[GlobalSetup]
		public void Setup()
		{
			System.Diagnostics.Debugger.Launch();

			//? while (!System.Diagnostics.Debugger.IsAttached)
			//?	Thread.Sleep(TimeSpan.FromMilliseconds(100));

			stringList = new List<string> { string1, string2, string3, string4, string5, string6 };
		}

		[Benchmark]
		public string StringJoin() =>
			string.Join(" ", string1, string2, string3, string4, string5, string6);


		[Benchmark]
		public string StringJoinList() => string.Join(" ", stringList);
	}
}
