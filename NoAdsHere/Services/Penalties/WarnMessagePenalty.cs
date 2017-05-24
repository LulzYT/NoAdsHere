﻿using Discord;
using Discord.Commands;
using NLog;
using NoAdsHere.Common;
using System.Threading.Tasks;

namespace NoAdsHere.Services.Penalties
{
    public static class WarnMessagePenalty
    {
        private static Logger _logger = LogManager.GetLogger("AntiAds");

        public static async Task SendAsync(ICommandContext context)
        {
            if (context.Channel.CheckChannelPermission(ChannelPermission.SendMessages, await context.Guild.GetCurrentUserAsync()))
                await context.Channel.SendMessageAsync($":warning: {context.User.Mention} Advertisement is not allowed. ***Last Warning!*** :warning:");
            else _logger.Warn("Unable to send InfoMessage due to missing Permission");
        }
    }
}