using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PON_BOT
{
	class TestCommands
	{
		static string[] fileData = File.ReadAllLines(@"PONMSG.txt");
		static int lineCount = fileData.Count();
		static Random random = new Random();

		static string[] rate = { "KWINJ", "LIT" };

		[Command("ping")]
		public async Task Ping(CommandContext ctx)
		{
			await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
		}

		[Command("msg")]
		public async Task Msg(CommandContext ctx)
		{


			var randomLine = random.Next(0, lineCount - 1);

			string RandomLine = fileData[randomLine];

			await ctx.Channel.SendMessageAsync(RandomLine).ConfigureAwait(false);
		}

		[Command("hello")]
		public async Task Insult(CommandContext ctx)
		{
			await ctx.Channel.SendMessageAsync("FUCK YOU " + ctx.Message.Author.Mention).ConfigureAwait(false);

		}


		[Command("add")]
		public async Task Add(CommandContext ctx, int numberOne, int numberTwo)
		{
			await ctx.Channel.SendMessageAsync((numberOne + numberTwo).ToString()).ConfigureAwait(false);
		}

		[Command("subtract")]
		public async Task Subtract(CommandContext ctx, int numberOne, int numberTwo)
		{
			await ctx.Channel.SendMessageAsync((numberOne - numberTwo).ToString()).ConfigureAwait(false);
		}

		[Command("multiply")]
		public async Task Multiply(CommandContext ctx, int numberOne, int numberTwo)
		{
			await ctx.Channel.SendMessageAsync((numberOne * numberTwo).ToString()).ConfigureAwait(false);
		}

		[Command("divide")]
		public async Task Divide(CommandContext ctx, float numberOne, float numberTwo)
		{
			await ctx.Channel.SendMessageAsync((numberOne / numberTwo).ToString()).ConfigureAwait(false);
		}
		
		[Command("rate")]
		public async Task Rate(CommandContext ctx)
		{
			await ctx.Channel.SendMessageAsync(rate[Convert.ToInt32((random.Next(0, 2) == 0))]);
		}
	}
}
