using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using ChatBot.Model;

namespace ChatBot.Telegram
{
    public static class Program
    {
        private static Assistant _assistant;

        public static async Task Main(string[] args)
        {
            Console.Title = "Desafio Banco Carrefour ChatBot";

            var cts = new CancellationTokenSource();
            if (args.Length > 0)
            {
                try
                {
                    var bot = new TelegramBotClient(args[args.Length - 1]);
                    var me = await bot.GetMeAsync();

                    var scriptfile = Path.Combine(Environment.CurrentDirectory, Path.ChangeExtension(me.Username, "json"));
                    if (System.IO.File.Exists(scriptfile))
                    {
                        Console.Title = string.Concat(Console.Title, " - ", me.Username);
                        
                        _assistant = new Assistant(scriptfile);
                        bot.StartReceiving(
                            new DefaultUpdateHandler(HandleUpdateAsync, HandleErrorAsync),
                            cts.Token
                        );
                    }
                    else
                    {
                        Console.WriteLine("O arquivo de script para o bot não foi encontrado em:");
                        Console.WriteLine(scriptfile);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro não tratado na aplicação:");
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                Console.WriteLine("O programa deve ser executado com o token do Telegram como parâmetro.");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadKey();
            cts.Cancel();
        }

        private static async Task HandleUpdateAsync(ITelegramBotClient bot, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == UpdateType.Message)
            {
                var handler = BotOnMessageReceived(bot, update.Message);
                try
                {
                    await handler;
                }
                catch (Exception exception)
                {
                    await HandleErrorAsync(bot, exception, cancellationToken);
                }
            }
        }

        private static async Task BotOnMessageReceived(ITelegramBotClient bot, Message message)
        {
            if (message.Type == MessageType.Text)
            {
                var session = new Session()
                {
                    Id = message.Chat.Id,
                    FirstName = message.Chat.FirstName
                };
                var dialog = _assistant.GetResponseForText(session, message.Text);
                await SendDialog(bot, session, dialog);
            }
        }

        private static async Task SendDialog(ITelegramBotClient bot, Session session, Dialog dialog)
        {
            for (var i = 0; i < dialog.Phrases.Length; i++)
            {
                await bot.SendChatActionAsync(session.Id, ChatAction.Typing);
                await Task.Delay(500);

                IReplyMarkup reply;
                if (i == dialog.Phrases.Length - 1 && dialog.Dialogs.Count > 0)
                {
                    var keyboard = new List<KeyboardButton>();
                    foreach (var choice in dialog.Dialogs)
                        keyboard.Add(new KeyboardButton(choice.Label));
                    reply = new ReplyKeyboardMarkup(keyboard.ToArray(), oneTimeKeyboard: true, resizeKeyboard: true);
                }
                else
                {
                    reply = new ReplyKeyboardRemove();
                }

                await bot.SendTextMessageAsync(
                    chatId: session.Id,
                    text: dialog.Phrases[i],
                    parseMode: ParseMode.Html,
                    replyMarkup: reply
                );
            }
        }

        private static async Task HandleErrorAsync(ITelegramBotClient bot, Exception exception, CancellationToken cancellationToken)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            Console.WriteLine(ErrorMessage);
        }
    }
}
