using System;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using DSharpPlus.Entities;
using System.IO;
using DSharpPlus.CommandsNext.Converters;

namespace UGDiscordBot {
    /* Create our class and extend from IModule */
    public class BasicCommandsModule : IModule {
        #region ozel
        /* Commands in DSharpPlus.CommandsNext are identified by supplying a Command attribute to a method in any class you've loaded into it. */
        /* The description is just a string supplied when you use the help command included in CommandsNext. */

        [Command("orn"), Description("Raftan ornege urun cik.")]
        public async Task orn(CommandContext ctx, [Description("Barcode")] string barcode, [Description("Quantity")] int quantity) {
            await ctx.TriggerTypingAsync();
            Tuple<bool, string> t = UserPermissions.check(ctx.User.Id.ToString());
            if (!t.Item1) {
                return;
            }

            bool result = InventoryReceipt.insertItemToInventoryReceiptOrn(UGCore.Functions.GetConnString("ms_sql"), barcode, quantity, t.Item2);
            if (result)
                await ctx.RespondAsync("True -> İşlendi.");
            else
                await ctx.RespondAsync("False -> İşlenemedi!");

        }

        [Command("say"), Description("Sayima urun gir/cik.")]
        public async Task say(CommandContext ctx, [Description("Barcode")] string barcode, [Description("Quantity")] int quantity) {
            Console.WriteLine("say!");
            Console.WriteLine("say!");
            Tuple<bool, string> t = UserPermissions.check(ctx.User.Id.ToString());
            if (!t.Item1) {
                await ctx.RespondAsync("You Do Not Have Permission!");
                return;
            }
            await ctx.TriggerTypingAsync();
            bool result = InventoryReceipt.setItemQuantity(UGCore.Functions.GetConnString("ms_sql"), barcode, quantity, t.Item2);
            if (result)
                await ctx.RespondAsync("True -> İşlendi.");
            else
                await ctx.RespondAsync("False -> İşlenemedi!");
        }

        [Command("ted"), Description("Urunu tedarik listesine ekle.")]
        public async Task ted(CommandContext ctx, [Description("Barcode")] string barcode, [Description("Quantity")] int quantity) {
            Tuple<bool, string> t = UserPermissions.check(ctx.User.Id.ToString());
            if (!t.Item1) {
                return;
            }
            await ctx.TriggerTypingAsync();
            bool result = QuotationReceipt.addQuotationItem(barcode, quantity, t.Item2);
            if (result)
                await ctx.RespondAsync("True -> İşlendi.");
            else
                await ctx.RespondAsync("False -> İşlenemedi!");

        }

        [Command("kul"), Description("Urun kullanima ac.")]
        public async Task kul(CommandContext ctx, [Description("Barcode")] string barcode) {
            Tuple<bool, string> t = UserPermissions.check(ctx.User.Id.ToString());
            if (!t.Item1) {
                return;
            }
            await ctx.TriggerTypingAsync();
            string result = SentezSimple.activateProduct(barcode, t.Item2);

            if (!string.IsNullOrEmpty(result))
                await ctx.RespondAsync(result);
            else
                await ctx.RespondAsync("Olmadi!");
        }


        [Command("cokKuul"), Description("Urunleri kullanima ac.")]
        public async Task cokKuul(CommandContext ctx, [Description("Barcodes")] params string[] barcodes) {
            Tuple<bool, string> t = UserPermissions.check(ctx.User.Id.ToString());
            if (!t.Item1) {
                Console.WriteLine("yow");
                return;
            }

            List<string> barcodeList = barcodes.OfType<string>().ToList();
            var barcodeChunks = SplitToSublists(barcodeList, 25);
            string result = "";

            foreach (var item in barcodeChunks) {                
                foreach (var barcode in item) {
                    //await ctx.TriggerTypingAsync();
                    Console.WriteLine(barcode);
                    result += SentezSimple.activateProduct(barcode, t.Item2) + "\n";
                    
                }
                await ctx.TriggerTypingAsync();
                await ctx.RespondAsync(result);
                result = "";
                await Task.Delay(2 * 1000);
            }

            await ctx.TriggerTypingAsync();
            await ctx.RespondAsync("Done!");
        }
        public List<List<string>> SplitToSublists(List<string> source, int size) {
            return source
                     .Select((x, i) => new { Index = i, Value = x })
                     .GroupBy(x => x.Index / size)
                     .Select(x => x.Select(v => v.Value).ToList())
                     .ToList();
        }

        [Command("deleteAll"), Description("sil")]
        public async Task DeleteAll(CommandContext ctx) {
            var t = UserPermissions.checkOFM(ctx.User.Id.ToString());
            if (!t) {
                return;
            }
            await ctx.TriggerTypingAsync();
            bool result = false;
            try {
                var messages = await ctx.Channel.GetMessagesAsync();
                if (ctx.Channel.Name == "resim") {
                    await ctx.Channel.DeleteMessagesAsync(messages);
                    result = true;
                }             
                
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }

            if (result)
                await ctx.RespondAsync(result.ToString());
            else
                await ctx.RespondAsync("Olmadi!");
        }

        #endregion

        #region genel
        [Command("ses"), Description("Yasıyorsan ses ver.")]
        public async Task Alive(CommandContext ctx) {
            /* Trigger the Typing... in discord */
            await ctx.TriggerTypingAsync();

            /* Send the message "I'm Alive!" to the channel the message was recieved from */
            await ctx.RespondAsync("Nefes alıp vermiyor!");
        }

        [Command("merdivana"), Description("Cal keke cal.")]
        public async Task merdivana(CommandContext ctx) {
            /* Trigger the Typing... in discord */
            await ctx.TriggerTypingAsync();

            /* Send the message "I'm Alive!" to the channel the message was recieved from */
            await ctx.RespondAsync(@"https://www.youtube.com/watch?v=UaX-sjjLclU");
        }

        [Command("gralll"), Description("Selam ver.")]
        public async Task Ug(CommandContext ctx) {
            /* Trigger the Typing... in discord */
            await ctx.TriggerTypingAsync();

            /* Send the message "I'm Alive!" to the channel the message was recieved from */
            await ctx.RespondAsync(string.Format("**HAIL  {0}  THE SUPREME RULER** \nid:{1}\nmention:{2}\ndisc:{3}", ctx.User.Username, ctx.User.Id.ToString(), ctx.User.Mention.ToString(), ctx.User.Discriminator.ToString()));
        }

        [Command("fiyat"), Description("Urun fiyatini yaz.")]
        public async Task fiyat(CommandContext ctx, [Description("Barcode")] string barcode) {

            await ctx.TriggerTypingAsync();
            string result = SentezSimple.productPrice(barcode);

            if (!string.IsNullOrEmpty(result))
                await ctx.RespondAsync(result);
            else
                await ctx.RespondAsync("Olmadi!");

        }

        [Command("stok"), Description("Urun stoğunu yaz.")]
        public async Task stock(CommandContext ctx, [Description("Barcode")] string barcode) {

            await ctx.TriggerTypingAsync();
            string result = SentezSimple.productStock(barcode);

            if (!string.IsNullOrEmpty(result))
                await ctx.RespondAsync(result);
            else
                await ctx.RespondAsync("Olmadi!");

        }
        [Command("recid"), Description("RecId yaz.")]
        public async Task recid(CommandContext ctx, [Description("Barcode")] string barcode) {

            await ctx.TriggerTypingAsync();
            string result = SentezSimple.recid(barcode);

            if (!string.IsNullOrEmpty(result))
                await ctx.RespondAsync(result);
            else
                await ctx.RespondAsync("Olmadi!");

        }

        //[Command("sip"), Description("Yeni siparisleri sirala.")]
        //public async Task Sip(CommandContext ctx/*,string newCustomer, string newProducts*/) {
        //    OrderReceipt o = new OrderReceipt();
        //    var customerList = o.checkOrders(@"https://www.uzaktangelir.com/extensions/sentez/index.php?export_orders=1&id=0", "3", "yourPass", "yourPass");
        //    if (customerList.Count == 0) {
        //        await ctx.TriggerTypingAsync();
        //        await ctx.RespondAsync("\"Yeni Sipariş\" Boş!");
        //    }
        //    foreach (var c in customerList) {
        //        await ctx.TriggerTypingAsync();
        //        await ctx.RespondAsync(string.Format("{0}\n=>{1} | {2} | {3} | {4} | {5} | {6}", "▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬",
        //                               c.m_ordCode, c.m_name, c.m_ordPaymentType, c.m_ordDate, c.m_ordTotalPrice, c.m_ordCargo));
        //        for (int i = 0; i < c.m_productList.Count; i++) {
        //            if (c.m_productList[i].m_quantity != "1") {
        //                await ctx.TriggerTypingAsync();
        //                await ctx.RespondAsync(string.Format("\n{0}. {1} |:bird: {2} Adet | {3} \n {4}",
        //                                       (i + 1).ToString(), c.m_productList[i].m_barcode, c.m_productList[i].m_quantity, c.m_productList[i].m_name, c.m_productList[i].m_link));
        //            }
        //            else {
        //                await ctx.TriggerTypingAsync();
        //                await ctx.RespondAsync(string.Format("\n{0}. {1} | {2} Adet | {3} \n {4}",
        //                                       (i + 1).ToString(), c.m_productList[i].m_barcode, c.m_productList[i].m_quantity, c.m_productList[i].m_name, c.m_productList[i].m_link));
        //            }
        //        }
        //        await Task.Delay(1);
        //    }
        //}

        [Command("sip"), Description("Teslimata hazırlanıyor icinden siparis koduna göre getir.")]
        public async Task sip(CommandContext ctx, string orderCode/*, string newProducts*/) {
            OrderReceipt o = new OrderReceipt();
            var customerList = o.checkOrders(@"https://www.uzaktangelir.com/extensions/sentez/index.php?export_orders=1&id=0", "3", "yourPass", "yourPass", "12");
            if (customerList.Count == 0) {
                await ctx.TriggerTypingAsync();
                await ctx.RespondAsync("\"Teslimata Hazırlanıyor\" Boş!");
            }
            string result = "";
            orderCode = orderCode.ToUpper();
            await ctx.TriggerTypingAsync();
            await ctx.RespondAsync(orderCode);
            foreach (var c in customerList) {
                if (orderCode.Trim() == c.m_ordCode.Trim()) {
                    result += string.Format("{0}\n=>{1} | {2} | {3} | {4} | {5} | {6}", "▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬",
                                            c.m_ordCode, c.m_name, c.m_ordPaymentType, c.m_ordDate, c.m_ordTotalPrice, c.m_ordCargo);
                    for (int i = 0; i < c.m_productList.Count; i++) {
                        if (c.m_productList[i].m_quantity != "1") {
                            result += string.Format("\n{0}. {1} |:bird: {2} Adet | {3} \n {4}",
                                                   (i + 1).ToString(), c.m_productList[i].m_barcode, c.m_productList[i].m_quantity, c.m_productList[i].m_name, c.m_productList[i].m_link);
                        }
                        else {
                            result += (string.Format("\n{0}. {1} | {2} Adet | {3} \n {4}",
                                                    (i + 1).ToString(), c.m_productList[i].m_barcode, c.m_productList[i].m_quantity, c.m_productList[i].m_name, c.m_productList[i].m_link));
                        }
                    }
                    await ctx.TriggerTypingAsync();
                    await ctx.RespondAsync(result);
                    result = "";
                    await Task.Delay(2 * 1000);
                }
            }
        }

        [Command("tes"), Description("Teslimata hazirlananlari sirala.")]
        public async Task Tes(CommandContext ctx/*,string newCustomer, string newProducts*/) {
            OrderReceipt o = new OrderReceipt();
            var customerList = o.checkOrders(@"https://www.uzaktangelir.com/extensions/sentez/index.php?export_orders=1&id=0", "3", "yourPass", "yourPass", "12");
            if (customerList.Count == 0) {
                await ctx.TriggerTypingAsync();
                await ctx.RespondAsync("\"Teslimata Hazırlanıyor\" Boş!");
            }
            
            foreach (var c in customerList) {
                string result = "";
                result += string.Format("{0}\n=>{1} | {2} | {3} | {4} | {5} | {6}", "▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬",
                                        c.m_ordCode, c.m_name, c.m_ordPaymentType, c.m_ordDate, c.m_ordTotalPrice, c.m_ordCargo);
                for (int i = 0; i < c.m_productList.Count; i++) {
                    if (c.m_productList[i].m_quantity != "1") {
                        result += string.Format("\n{0}. {1} |:bird: {2} Adet | {3} \n {4}",
                                               (i + 1).ToString(), c.m_productList[i].m_barcode, c.m_productList[i].m_quantity, c.m_productList[i].m_name, c.m_productList[i].m_link);
                    }
                    else {
                        result += (string.Format("\n{0}. {1} | {2} Adet | {3} \n {4}",
                                                (i + 1).ToString(), c.m_productList[i].m_barcode, c.m_productList[i].m_quantity, c.m_productList[i].m_name, c.m_productList[i].m_link));
                    }
                    if (result.Length > 1900) {
                        await ctx.TriggerTypingAsync();
                        await ctx.RespondAsync(result);
                        result = "";
                    }
                }
               
                await ctx.TriggerTypingAsync();
                await ctx.RespondAsync(result);
                result = "";
                await Task.Delay(2 * 1000);
            }
            await ctx.TriggerTypingAsync();
            await ctx.RespondAsync("Tes -> Done!");
        }
        
        [Command("muk"), Description("Tes icindeki mukerrer urun siparişlerini siralar.")]
        public async Task muk(CommandContext ctx/*,string newCustomer, string newProducts*/) {
            OrderReceipt o = new OrderReceipt();
            var customerList = o.checkOrders(@"https://www.uzaktangelir.com/extensions/sentez/index.php?export_orders=1&id=0", "3", "yourPass", "yourPass", "12");
            if (customerList.Count == 0) {
                await ctx.TriggerTypingAsync();
                await ctx.RespondAsync("\"Teslimata Hazırlanıyor\" Boş!");
            }
            
            foreach (var c in customerList) {
                foreach (var product in c.m_productList) {
                    //Console.WriteLine($@"{c.m_ordCode}-{c.m_name}-->aksaray siparişi! {c.m_ordCity} {c.m_ordCity}");
                    int quantity;
                    Int32.TryParse(product.m_quantity, out quantity);
                    if (quantity != 0 && quantity > 1) {
                        await ctx.TriggerTypingAsync();
                        await ctx.RespondAsync($@"{c.m_ordCode}-{c.m_name}-->mük ürün --> {product.m_barcode} - {product.m_name}, {quantity} adet :bird:");

                        await Task.Delay(1000);
                    }
                }
                
            }
            await ctx.TriggerTypingAsync();
            await ctx.RespondAsync("muk Done");
        }

        [Command("sip68"), Description("Tes+Eft icindeki Aksaray siparişlerini siralar.")]
        public async Task sip68(CommandContext ctx/*,string newCustomer, string newProducts*/) {
            OrderReceipt o = new OrderReceipt();
            var customerList = o.checkOrders(@"https://www.uzaktangelir.com/extensions/sentez/index.php?export_orders=1&id=0", "3", "yourPass", "yourPass", "12");
            customerList = customerList.Concat(o.checkOrders(@"https://www.uzaktangelir.com/extensions/sentez/index.php?export_orders=1&id=0", "3", "yourPass", "yourPass", "2")).ToList();
            if (customerList.Count == 0) {
                await ctx.TriggerTypingAsync();
                await ctx.RespondAsync("\"Teslimata Hazırlanıyor\" Boş!");
            }
            
            foreach (var c in customerList) {
                //Console.WriteLine($@"{c.m_ordCode}-{c.m_name}-->aksaray siparişi! {c.m_ordCity} {c.m_ordCity}");
                if (c.m_ordCity == "6369" && c.m_ordTown =="1120") {
                    await ctx.TriggerTypingAsync();
                    await ctx.RespondAsync($@"{c.m_ordCode}-{c.m_name}-->aksaray siparişi!");
                    await Task.Delay(1000);
                }
            }
            await ctx.TriggerTypingAsync();
            await ctx.RespondAsync("sip68 Done");
        }

        [Command("eft"), Description("Odeme bekleyen siparisleri sirala.")]
        public async Task Eft(CommandContext ctx/*,string newCustomer, string newProducts*/) {
            OrderReceipt o = new OrderReceipt();
            var customerList = o.checkOrders(@"https://www.uzaktangelir.com/extensions/sentez/index.php?export_orders=1&id=0", "3", "yourPass", "yourPass", "2");
            if (customerList.Count == 0) {
                await ctx.TriggerTypingAsync();
                await ctx.RespondAsync("\"Ödeme Bekleniyor\" Boş!");
            }
            foreach (var c in customerList) {
                await ctx.TriggerTypingAsync();
                await ctx.RespondAsync(string.Format("{0}\n=>{1} | {2} | {3} | {4} | {5} | {6}", "▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬",
                                       c.m_ordCode, c.m_name, c.m_ordPaymentType, c.m_ordDate, c.m_ordTotalPrice, c.m_ordCargo));
                for (int i = 0; i < c.m_productList.Count; i++) {
                    if (c.m_productList[i].m_quantity != "1") {
                        await ctx.TriggerTypingAsync();
                        await ctx.RespondAsync(string.Format("\n{0}. {1} |:bird: {2} Adet | {3} \n {4}",
                                               (i + 1).ToString(), c.m_productList[i].m_barcode, c.m_productList[i].m_quantity, c.m_productList[i].m_name, c.m_productList[i].m_link));
                    }
                    else {
                        await ctx.TriggerTypingAsync();
                        await ctx.RespondAsync(string.Format("\n{0}. {1} | {2} Adet | {3} \n {4}",
                                               (i + 1).ToString(), c.m_productList[i].m_barcode, c.m_productList[i].m_quantity, c.m_productList[i].m_name, c.m_productList[i].m_link));
                    }
                }
                await Task.Delay(1);
            }
        }

        [Command("link"), Description("Urunu ait site linkini gönder.")]
        public async Task ugLink(CommandContext ctx, [Description("Barcode to go")] string barcode) {
            // note the params on the argument. It will indicate
            // that the command will capture all the remaining arguments
            // into a single array

            // let's trigger a typing indicator to let
            // users know we're working
            await ctx.TriggerTypingAsync();

            // calculate the sum
            try {
                barcode = string.Format(@"https://www.uzaktangelir.com/tag/{0}.html", barcode);
            }
            catch (System.Exception) { }

            // and send it to the user
            await ctx.RespondAsync(barcode);
        }
        #endregion

        /// upload image
        //[Command("uploadimage"), Aliases("feelsbadman"), Description("Feels bad, man.")]
        //public async Task uploadimage(CommandContext ctx) {
        //    try {
        //        await ctx.TriggerTypingAsync();
        //        var stream = new FileStream(@"D:\Wallpapers\minimalistic-wallpapers-collection-GizmoAdvices-21.png", FileMode.Open);
        //        var dict = new Dictionary<string, System.IO.Stream>();
        //        dict.Add("yow.png", stream);
        //        //dict.Add("yow", stream);
        //        var message = await ctx.Channel.SendMultipleFilesAsync(dict);
        //        await ctx.RespondAsync(message.Id.ToString());
        //    }
        //    catch (Exception ex) {
        //        Console.WriteLine(ex);
        //    }

        //}

        /// get last x message
        //[Command("uploadimage"), Aliases("feelsbadman"), Description("Feels bad, man.")]
        //public async Task uploadimage(CommandContext ctx, [Description("last x message")] int x) {
        //    try {
        //        await ctx.TriggerTypingAsync();

        //        var messages = await ctx.Channel.GetMessagesAsync(10);

        //        //await ctx.RespondAsync(message.Id.ToString());
        //    }
        //    catch (Exception ex) {
        //        Console.WriteLine(ex);
        //    }

        //}

    }

}
