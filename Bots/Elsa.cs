// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with EchoBot .NET Template version v4.17.1

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using Namespace;

namespace EchoBot.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var replyText = Stepper.Step(int.Parse(turnContext.Activity.Text));
            await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "Hi 👋, my name is Elsa your modern whatsapp banking companion.";
            /*
            var onboarding = """
                Kindly pick a number to proceed 🙂
                1️⃣ Sign up or Register
                2️⃣ Sign in or Login
                """;
            */
            var onboarding = "Kindly pick a number to proceed 🙂\r\n1️⃣ Sign up or Register\r\n2️⃣ Sign in or Login";
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                    await turnContext.SendActivityAsync(MessageFactory.Text(onboarding, welcomeText), cancellationToken);
                }
            }
        }
    }
}
