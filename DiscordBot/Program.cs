using System;
using DiscordBot.commands;
using DSharpPlus;
using DSharpPlus.CommandsNext;

namespace DiscordBot
{
class program
{
static void Main()
{
            MainAsync().GetAwaiter().GetResult();
}

        static async Task MainAsync()
        {
            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = "OTM0NjU0MDA4ODA5OTE0NDM4.YezOYA.4vWe1UO77W4eZVfmyBZqPDvquNI",
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged,
            });

            new DiscordConfiguration()
            {
                MinimumLogLevel = Microsoft.Extensions.Logging.LogLevel.Debug,
            };

            var commands = discord.UseCommandsNext(new CommandsNextConfiguration()
            {
                StringPrefixes = new[] { "." }
            });

            commands.RegisterCommands<com>();

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }



}



}



