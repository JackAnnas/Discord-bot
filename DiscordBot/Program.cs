using System;
using DSharpPlus;

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
                Token = "OTM0NjU0MDA4ODA5OTE0NDM4.YezOYA.ofyJXMvkN5K9T4_S-csw2ap1zj0",
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged,
            });

            new DiscordConfiguration()
            {
                MinimumLogLevel = Microsoft.Extensions.Logging.LogLevel.Debug,
            };



            await discord.ConnectAsync();
            await Task.Delay(-1);
        }



}



}



