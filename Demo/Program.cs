using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			BenchmarkSwitcher
				.FromAssembly(typeof(Program).Assembly)
				.Run(args, new DebugInProcessConfig())
			;

			//? var benchmarkRunner = BenchmarkRunner.Run<SingleLineJoin>();

			//? Console.WriteLine(benchmarkRunner.TotalTime);

			Console.ReadLine();
		}
	}
}
