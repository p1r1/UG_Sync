using System;
using System.Collections.Generic;
using System.Text;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity;
using System.Threading.Tasks;

namespace UGDiscordBot {
    /* Create our class and extend from IModule */
    public class BasicCommandsModule : IModule {
        /* Commands in DSharpPlus.CommandsNext are identified by supplying a Command attribute to a method in any class you've loaded into it. */
        /* The description is just a string supplied when you use the help command included in CommandsNext. */
        [Command("alive")]
        [Description("Simple command to test if the bot is running!")]
        public async Task Alive(CommandContext ctx) {
            /* Trigger the Typing... in discord */
            await ctx.TriggerTypingAsync();
            
            /* Send the message "I'm Alive!" to the channel the message was recieved from */
            await ctx.RespondAsync("I'm alive!");
        }

        [Command("kralll")]
        [Description("Simple command to test if the bot is running!")]
        public async Task kralll(CommandContext ctx) {
            /* Trigger the Typing... in discord */
            await ctx.TriggerTypingAsync();

            /* Send the message "I'm Alive!" to the channel the message was recieved from */
            await ctx.RespondAsync("***THE SUPREME RULER***");
        }

        [Command("sip")]
        [Description("Simple command to list orders from website!")]
        public async Task Sip(CommandContext ctx/*,string newCustomer, string newProducts*/) {
            order o = new order();
            string newCustomer = "";
            string newProducts = "";
            var customerList = o.checkOrders(@"https://www.uzaktangelir.com/extensions/sentez/index.php?export_orders=1&id=0", "3", "uzaktanGLR6523", "654Dfg654DFgj5645");
            foreach (var c in customerList) {
                newCustomer = string.Format("{0} | {1} | {2} | {3} | {4} | {5}", c.m_ordCode, c.m_name, c.m_ordPaymentType, c.m_ordDate, c.m_ordTotalPrice, c.m_ordCargo);
                foreach (var p in c.m_productList) {
                    newProducts += string.Format("\n{0} | {1} Adet | {2} \n {3}", p.m_barcode, p.m_quantity, p.m_name, p.m_link);
                }
                await ctx.TriggerTypingAsync();
                await ctx.RespondAsync(newCustomer + "\n" + newProducts + "\n▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬\n");
                newCustomer = "";
                newProducts = "";
            }

        }
    }
    
}
