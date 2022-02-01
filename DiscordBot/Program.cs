using System;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using DiscordBot.commands;

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
                Token = "<token>",
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



