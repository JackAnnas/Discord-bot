using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.commands
{
   public class com : BaseCommandModule
    {
        [Command("ping")]
        [Description("returns pong")]
        public async Task pong(CommandContext ctx)
        {
            await ctx.RespondAsync("pong!");
        }

        [Command("greet")]
        public async Task greet(CommandContext ctx, DiscordMember member)
        {
          await  ctx.RespondAsync("hello" + member);
        }
    }
}
