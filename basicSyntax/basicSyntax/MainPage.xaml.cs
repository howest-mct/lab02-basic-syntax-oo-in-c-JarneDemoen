using basicSyntax.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace basicSyntax
{
    public partial class MainPage : ContentPage
    {

        //globale variabele
        private List<Quote> quoteList;
        private Random myRandomGenerator = new Random();

        public MainPage()
        {
            InitializeComponent();
            //TestModels();
            LoadQuotes();
        }

 
        //deze methode test de verschillende klassen in de map model
        private void TestModels()
        {
            Quote mijnEersteQuote = new Quote
            {
                Author = "Jarne Demoen",
                Content = "Tis bijna weekend",
                Subject = "Programming"
            };

            Debug.WriteLine("Even testen");
            Debug.WriteLine(mijnEersteQuote); // hier wordt de ToString geactiveerd

            Quote mijnTweedeQuote = new Quote()
            {
                Author = "Frederik",
                Subject = "Start",
                Content = "MCT DP"
            };

            Debug.WriteLine(mijnTweedeQuote);

            List<Quote> listQuotes = Quote.GetQuotes();
            Debug.WriteLine($"Aantal Quotes {listQuotes.Count}");

            //Thuis
            List<Quote> filtered = Quote.GetQuotesFiltered(listQuotes, true);
            Debug.WriteLine($"Aantal anonieme quotes{ filtered.Count}");


        }

        private void LoadQuotes()
        {
            quoteList = Quote.GetQuotes();
            ShowRandomQuotes();
        }

        private void ShowRandomQuotes()
        {
            int index = myRandomGenerator.Next(0, quoteList.Count);
            Quote gekozenQuote = quoteList[index];

            lblAuthor.Text = gekozenQuote.Author;
            lblContent.Text = gekozenQuote.Content;
            lblSubject.Text = gekozenQuote.Subject;

            imgSubject.Source = gekozenQuote.SubjectImage;

        }

        private void btnRandom_Clicked(object sender, EventArgs e)
        {
            ShowRandomQuotes();
        }
    }
}