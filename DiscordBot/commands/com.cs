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
        [Description("returns ping")]
        public async Task ping(CommandContext ctx)
        {
            await ctx.RespondAsync("pong!");
        }

        [Command("greet")]
        [Description("says hello")]
        public async Task greet(CommandContext ctx, DiscordMember member)
        {
            ctx.RespondAsync("hello");
        }
    }
}
