using System;

namespace PON_BOT
{
	class Program
	{
		static void Main(string[] args)
		{
			var bot = new Bot();
			bot.RunAsync().GetAwaiter().GetResult();
		}
	}
}
