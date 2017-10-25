using FinalFantasyTacticsPartyBuilder.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalFantasyTacticsWebScraper
{
    class Program
    {
        public static string[] menuChoices = new string[] { "Items", "Jobs" };

        static void Main(string[] args)
        {
            bool sentinel = true;

            while (sentinel)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Final Fantasy Tactics Web Scraper!");
                for (int i = 0; i < menuChoices.Length; i++)
                {
                    Console.WriteLine(String.Format("{0}................ {1}", menuChoices[i], i));
                }

                Console.WriteLine("What would you like to do?");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        ScrapeItems();
                        break;
                    case "1":
                        ScrapeJobs();
                        break;
                    default:
                        Console.WriteLine("That is not a valid answer. ");
                        break;
                }
            }

        }

        static void ScrapeItems()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddExtension(@"..\..\Chrome Extensions\3.18.0_0.crx");
            //options.AddExtension(@"C:\Users\hasenb\AppData\Local\Google\Chrome\User Data\Default\Extensions\gighmmpiobklfepjocnamgkkbiglidom\3.18.0_0.crx");
            ChromeDriver driver = new ChromeDriver(options);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://finalfantasy.wikia.com/wiki/List_of_Final_Fantasy_Tactics_Items");
            if (new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(m => m.FindElements(By.CssSelector("table.full-width.FFT")).Count == 21))
            {
                // All item tables for Items
                List<IWebElement> ItemTables = driver.FindElements(By.CssSelector("table.full-width.FFT")).OrderBy(m => m.Location.Y).ToList();
                // All the table row elements for a single item
                List<IWebElement> itemRows = new List<IWebElement>();
                List<Item> Items = new List<Item>();
                // Index of rows for the entire table
                int rowIndex = 0;
                // Flag to initialize new Item object
                bool Itemsentinel = false;

                foreach (IWebElement table in ItemTables)
                {
                    // All of the rows for the table
                    List<IWebElement> rows = table.FindElements(By.CssSelector("tr:not(.a)")).ToList();
                    Item Item = new Item();

                    while (rows.Count != rowIndex)
                    {
                        if (Itemsentinel)
                        {
                            itemRows.Clear();
                            Item = new Item();
                        }

                        // Add the row for the particular item
                        itemRows.Add(rows[rowIndex]);

                        if (rows[rowIndex].FindElements(By.CssSelector("th")).Count > 0)
                        {
                            int magickAttackBoost = 0;
                            List<IWebElement> itemRowElements = itemRows[rowIndex].FindElements(By.CssSelector("td")).ToList();

                            Item.PspName = itemRows[rowIndex].FindElement(By.CssSelector("th > a > span")).Text.Trim();
                            Item.AttackPower = Convert.ToInt16(itemRowElements[0].Text.Trim());
                            Item.HitPercentage = Convert.ToInt16(itemRowElements[1].Text.Trim().Replace("%", ""));
                            Item.MagicAttackBoost = int.TryParse(itemRowElements[2].Text.Trim(), out magickAttackBoost) ? magickAttackBoost : 0;

                            string[] acquiredData = itemRowElements[3].Text.Trim().Split(new string[] { ":", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                            string scrapedText = "";
                            int counter = 1;

                            for (int i = 0; i < acquiredData.Length; i++)
                            {
                                string[] identifiers = new string[] { "Outfitters", "Treasure", "Mode", "Poach", "Steal", "Initial", "Catch" };

                                if (!identifiers.Contains(acquiredData[i]))
                                {
                                    scrapedText += (" " + acquiredData[i]).Trim();
                                    counter++;
                                }

                                if ((!String.IsNullOrEmpty(scrapedText) && identifiers.Contains(acquiredData[i])) || i == acquiredData.Length - 1)
                                {
                                    if (i == acquiredData.Length - 1)
                                    {
                                        counter = 1;
                                    }

                                    switch (acquiredData[i - counter])
                                    {
                                        case "Outfitters":
                                            Item.AcquiredViaLocation = scrapedText;
                                            break;
                                        case "Treasure":
                                            Item.AcquiredViaTreasureHunt = scrapedText;
                                            break;
                                        case "Mode":
                                            Item.AcquiredViaMode = scrapedText;
                                            break;
                                        case "Poach":
                                            Item.AcquiredViaPoach = scrapedText;
                                            break;
                                        case "Steal":
                                            Item.AcquiredViaSteal = scrapedText;
                                            break;
                                        case "Initial":
                                            Item.AcquiredViaInitialEquip = scrapedText;
                                            break;
                                        case "Catch":
                                            Item.AcquiredViaCatch = scrapedText;
                                            break;
                                    }

                                    scrapedText = "";
                                    counter = 1;
                                }
                            }

                            Item.Cost = Convert.ToInt16(itemRowElements[4].Text.Trim());
                            rowIndex++;
                        }
                        else if (rows[rowIndex].FindElements(By.CssSelector("b")).Count > 0)
                        {
                            string rowData = rows[rowIndex].FindElements(By.CssSelector("td"))[0].Text.Trim();
                            string[] itemEffectData = rowData.Split(new string[] { ":", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                            for (int i = 0; i < itemEffectData.Length; i++)
                            {
                                string[] identifiers = new string[] { "Element", "Spell Effect", "Effect", "Equip", "Absorbs", "Boosts", "Removes" };

                                if (identifiers.Contains(itemEffectData[i]))
                                {
                                    switch (itemEffectData[i])
                                    {
                                        case "Element":
                                            Item.AcquiredViaLocation = itemEffectData[i + 1].Trim();
                                            break;
                                        case "Spell Effect":
                                            Item.AcquiredViaTreasureHunt = itemEffectData[i + 1].Trim();
                                            break;
                                        case "Effect":
                                            Item.AcquiredViaMode = itemEffectData[i + 1].Trim();
                                            break;
                                        case "Equip":
                                            Item.AcquiredViaPoach = itemEffectData[i + 1].Trim();
                                            break;
                                        case "Absorbs":
                                            Item.AcquiredViaSteal = itemEffectData[i + 1].Trim();
                                            break;
                                        case "Boosts":
                                            Item.AcquiredViaInitialEquip = itemEffectData[i + 1].Trim();
                                            break;
                                        case "Removes":
                                            Item.AcquiredViaCatch = itemEffectData[i + 1].Trim();
                                            break;
                                    }
                                }
                            }

                            rowIndex++;
                        }
                        else
                        {
                            Item.Description = rows[rowIndex].FindElements(By.CssSelector("i"))[0].Text.Trim();
                            Itemsentinel = true;
                            rowIndex++;
                            Items.Add(Item);              
                        }
                    }
                }

                using (FFTContext context = new FFTContext())
                {
                    context.Items.AddRange(Items);
                }
            }
        }

        static void ScrapeJobs()
        {

        }

        static void ScrapeJobAbilities()
        {

        }
    }
}
