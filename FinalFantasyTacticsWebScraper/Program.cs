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
            options.AddExtension(@"C:\Users\Braedon\AppData\Local\Google\Chrome\User Data\Profile 1\Extensions\gighmmpiobklfepjocnamgkkbiglidom\3.18.0_0.crx");
            //options.AddExtension(@"C:\Users\hasenb\AppData\Local\Google\Chrome\User Data\Default\Extensions\gighmmpiobklfepjocnamgkkbiglidom\3.18.0_0.crx");
            ChromeDriver driver = new ChromeDriver(options);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://finalfantasy.wikia.com/wiki/List_of_Final_Fantasy_Tactics_weapons");
            if (new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(m => m.FindElements(By.CssSelector("table.full-width.FFT")).Count == 21))
            {
                // All item tables for weapons
                List<IWebElement> weaponTables = driver.FindElements(By.CssSelector("table.full-width.FFT")).ToList();
                // All the table row elements for a single item
                List<IWebElement> itemRows = new List<IWebElement>();
                // Index of rows for the entire table
                int rowIndex = 0;

                foreach (IWebElement table in weaponTables)
                {
                    // All of the rows for the table
                    List<IWebElement> rows = table.FindElements(By.CssSelector("tr:not(.a)")).ToList();

                    while (rows.Count != rowIndex)
                    {
                        Weapon weapon = new Weapon();
                        // Add the row for the particular item
                        itemRows.Add(rows[rowIndex]);

                        if (rows[rowIndex].FindElements(By.CssSelector("i")).Count == 0)
                        {
                            List<IWebElement> itemRowElements = itemRows[rowIndex].FindElements(By.CssSelector("td")).ToList();                            

                            weapon.Name = itemRows[0].FindElement(By.CssSelector("th > a > span")).Text.Trim();
                            weapon.AttackPower = Convert.ToInt16(itemRowElements[0].Text.Trim());
                            weapon.HitPercentage = Convert.ToInt16(itemRowElements[1].Text.Trim().Replace("%", ""));
                            weapon.MagicAttackBoost = int.TryParse(itemRowElements[2].Text.Trim(), out int n) ? n : 0;

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

                                if ((!String.IsNullOrEmpty(scrapedText) && identifiers.Contains(acquiredData[i])) || i == acquiredData.Length - 1 )
                                {
                                    if (i == acquiredData.Length -1 )
                                    {
                                        counter = 1;
                                    }

                                    switch (acquiredData[i - counter])
                                    {
                                        case "Outfitters":
                                            weapon.AcquiredViaLocation = scrapedText;
                                            break;
                                        case "Treasure":
                                            weapon.AcquiredViaTreasureHunt = scrapedText;
                                            break;
                                        case "Mode":
                                            weapon.AcquiredViaMode = scrapedText;
                                            break;
                                        case "Poach":
                                            weapon.AcquiredViaPoach = scrapedText;
                                            break;
                                        case "Steal":
                                            weapon.AcquiredViaSteal = scrapedText;
                                            break;
                                        case "Initial":
                                            weapon.AcquiredViaInitialEquip = scrapedText;
                                            break;
                                        case "Catch":
                                            weapon.AcquiredViaCatch = scrapedText;
                                            break;
                                    }

                                    scrapedText = "";
                                    counter = 1;
                                }
                            }

                            weapon.Cost = Convert.ToInt16(itemRowElements[4].Text.Trim());
                            rowIndex++;
                        }
                        else
                        {
                            weapon.Description = rows[rowIndex].FindElements(By.CssSelector("i"))[0].Text.Trim();
                            rowIndex++;
                        }
                    }
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
