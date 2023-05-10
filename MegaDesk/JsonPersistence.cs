using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MegaDesk
{
    /// <summary>
    /// 
    /// JsonPersistence class implements saving and reading quote data from a json file.
    ///
    /// </summary>
    public class JsonPersistence
    {
        const string defaultFileName = "quotes.json";



        /// <summary>
        /// 
        /// This method returns a list of DeskQuotes from the default file. 
        /// the caller can provide an override for the filename, and can provide a filter value such that it will return only those items
        /// that have a specific material type
        /// 
        /// </summary>
        /// 
        /// <param name="fileName"></param>
        /// <param name="filterMaterial"></param>
        /// 
        public List<DeskQuote> LoadQuotes(string fileName = defaultFileName, filterByMaterial filterMaterial = filterByMaterial.None)
        {
            string fileData = "";
            List<DeskQuote> quotes = new List<DeskQuote>();

            try
            {
                // load file
                 fileData = File.ReadAllText(fileName);

                // deserialize
                quotes = JsonConvert.DeserializeObject<DeskQuote[]>(fileData).ToList();

            }
            catch { 
                
        
            }
            


            if (filterMaterial != filterByMaterial.None)
            {
                // filter
                List<DeskQuote> filteredQuotes = quotes.Where(q => q.desk.material.ToString() == filterMaterial.ToString()).ToList();
                return filteredQuotes;

            } else
            {
                return quotes;
            }
            
        }

        /// <summary>
        /// 
        /// provided a Deskquote, this function will append the object to the end of the selected json file.
        /// It assumes that the file is a json array of deskquotes.
        /// 
        /// </summary>
        /// 
        /// <param name="quote"></param>
        /// <param name="fileName"></param>
        /// 
        public void AddToFile(DeskQuote quote, string fileName = defaultFileName)
        {
            // load existing file
            List<DeskQuote> quotes = this.LoadQuotes(fileName);

            // append new item
            quotes.Add(quote);

            // save
            var jsonString = JsonConvert.SerializeObject(quotes, Formatting.Indented);
            File.WriteAllText(fileName, jsonString);
        }
    }
}