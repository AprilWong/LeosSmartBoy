﻿using LeosSmartBoy.Services;
using Telegram.Bot.Args;

namespace LeosSmartBoy.Commands
{
    public interface ICommandInterface
    {
        void Process(BotContext context, MessageEventArgs args);

        void Callback(BotContext context, CallbackQueryEventArgs args);
    }
}