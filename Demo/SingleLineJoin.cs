using System.Text;

using BenchmarkDotNet.Attributes;

namespace Demo
{
	public class SingleLineJoin
	{
		public string string1 = "S";
		public string string2 = "I";
		public string string3 = "N";
		public string string4 = "J";
		public string string5 = "U";
		public string string6 = "L";

		[Benchmark]
		public string Interpolation() =>
			$"{string1} {string2} {string3} {string4} {string5} {string6}";

		[Benchmark]
		public string PlusOperator() =>
			string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5 + " " + string6;

		[Benchmark]
		public string StringConcatenate() =>
			string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5, " ", string6);

		[Benchmark]
		public string StringJoin() =>
			string.Join(" ", string1, string2, string3, string4, string5, string6);

		[Benchmark]
		public string StringFormat() =>
			string.Format("{0} {1} {2} {3} {4} {5}", string1, string2, string3, string4, string5, string6);

		[Benchmark]
		public string StringBuilderAppend()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append(string1);
			builder.Append(" ");
			builder.Append(string2);
			builder.Append(" ");
			builder.Append(string3);
			builder.Append(" ");
			builder.Append(string4);
			builder.Append(" ");
			builder.Append(string5);
			builder.Append(" ");
			builder.Append(string6);
			return builder.ToString();
		}
	}
}
