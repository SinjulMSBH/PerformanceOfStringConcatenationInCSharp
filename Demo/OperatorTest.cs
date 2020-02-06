using BenchmarkDotNet.Attributes;

namespace Demo
{
	[MemoryDiagnoser]
	public class OperatorTest
	{
		public string string1 = "S";
		public string string2 = "I";
		public string string3 = "N";
		public string string4 = "J";
		public string string5 = "U";
		public string string6 = "L";


		[Benchmark]
		public string PlusOperatorWithResult()
		{
			var result = string1 + " ";
			result += string2 + " ";
			result += string3 + " ";
			result += string4 + " ";
			result += string5 + " ";
			result += string6 + " ";
			return result;
		}


		[Benchmark]
		public string PlusOperator()
		{
			var result = string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5 + " " + string6;
			return result;
		}
	}
}
