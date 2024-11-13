using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Quotes
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //QuoteRepository quoteRepository = new QuoteRepository();
            
            repeaterQuotes.DataSource = GetQuotess();
            repeaterQuotes.DataBind();
        }

        public List<string> GetQuotess()
        {
            List<string> quotes = new List<string>();

            quotes.Add("Creativity is intelligence having fun");
            quotes.Add("Champions keep playing until they get it right");
            quotes.Add("The best time to lant a tree was 20 years ago. The second best time is now");
            quotes.Add("The only person you are destined to becoe is the person you decide to be ");
            quotes.Add("Believe you can and yu're halfway there");

            return quotes;
        }
    }
}