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
            options.AddExtension(@"C:\Users\hasenb\AppData\Local\Google\Chrome\User Data\Default\Extensions\gighmmpiobklfepjocnamgkkbiglidom\3.18.0_0.crx");
            ChromeDriver driver = new ChromeDriver(options);            
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://finalfantasy.wikia.com/wiki/List_of_Final_Fantasy_Tactics_weapons");
            if (new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(m => m.FindElements(By.CssSelector("table.full-width.FFT")).Count == 21))
            {
                List<IWebElement> weaponTables = driver.FindElements(By.CssSelector("table.full-width.FFT")).ToList();
                List<IWebElement> itemRow = new List<IWebElement>();
                int rowCounter = 0;

                foreach (IWebElement table in weaponTables)
                {                    
                    List<IWebElement> rows = table.FindElements(By.CssSelector("tr:not(.a)")).ToList();                    

                    //foreach (IWebElement row in rows)
                    //{
                    //    if (row.FindElements(By.CssSelector("th")).Count > 0)
                    //    {
                    //        string itemName = row.FindElement(By.CssSelector("th > a > span")).Text.Trim();

                    //    }
                    //}

                    while (rows.Count != rowCounter)
                    {
                        itemRow.Add(rows[rowCounter]);

                        if (rows[rowCounter].FindElements(By.CssSelector("i")).Count > 0)
                        {
                            Weapon weapon = new Weapon();

                            weapon.Name = itemRow[0].FindElement(By.CssSelector("th > a > span")).Text.Trim();
                            //weapon.

                        }
                        else
                        {
                            rowCounter++;
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
