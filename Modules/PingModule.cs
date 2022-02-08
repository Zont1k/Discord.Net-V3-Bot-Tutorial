﻿using Discord.Interactions;

namespace DNet_V3_Tutorial
{
    // Must use InteractionModuleBase<SocketInteractionContext> for the InteractionService to auto-register the commands
    public class PingModule : InteractionModuleBase<SocketInteractionContext>
    {
        public InteractionService Commands { get; set; }

        private InteractionCommandHandler _handler;
        public PingModule(InteractionCommandHandler handler)
        {
            _handler = handler;
        }


        // Basic slash command. [SlashCommand("name", "description")]
        // Similar to text command creation, and their respective attributes
        [SlashCommand("ping", "Receive a pong!")]
        public async Task Ping()
        {
            await RespondAsync("pong");
        }
    }
}
