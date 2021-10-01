using System;
using System.Collections.Generic;
using System.Text;

namespace basicSyntax.Models
{
    public class Quote
    {
        //properties
        public String Content { get; set; }

        public String Author { get; set; }

        public String Subject { get; set; }

        //extra calculated property toevoegen: dit is een property die enkel uit een GET bestaat, en iets teruggeeft
        public string SubjectImage
        {
            get
            {
                switch (this.Subject)
                {
                    case "Programming":
                        return "https://cdn.pixabay.com/photo/2018/08/22/06/47/code-3622942_960_720.jpg";
                    case "Hardware":
                        return "https://s-media-cache-ak0.pinimg.com/736x/fa/1e/b7/fa1eb7cd0dc2a72945148603738e514a.jpg";
                    case "Windows":
                        return "https://www.logodesignlove.com/images/contentious/honest-windows-logo.jpg";
                    default:
                        return "https://nlmmusings.files.wordpress.com/2018/05/datascience_evolution.jpg?w=900";
                }
            }
        }

        //constructor
        public Quote()
        {

        }

        //test
        public Quote(String parcontent)
        {
            this.Content = parcontent;
        }

        //methodes
        public override string ToString() //override wijst op het overschrijven van de methode
        {
            if (string.IsNullOrWhiteSpace(this.Author))
            {
                return this.Content;
            }
            else
            {
                return this.Content + "(" + this.Author + ")";
            }

        }

        //static methods: methode uit een klasse die zonder een object van die klasse kan aangeroepen worden
        public static List<Quote> GetQuotes()
        {
            return new List<Quote>()
                {
                    new Quote() { Content = "If at first you don't succeed; call it version 1.0", Author = "Charles Lauller" , Subject = "Programming" },
                    new Quote() { Content = "The Internet: where men are men, women are men, and children are FBI agents.", Author = "" , Subject = "Varia" },
                    new Quote() { Content = "Some things Man was never meant to know. For everything else, there's Google.", Subject = "Varia" },
                    new Quote() { Content = "The more I C, the less I see.", Subject = "Programming" },
                    new Quote() { Content = "Life would be so much easier if we only had the source code.", Subject = "Programming" },
                    new Quote() { Content = "Unix is user-friendly. It's just very selective about who its friends are.", Subject = "Varia" },
                    new Quote() { Content = "There are 10 types of people in the world: those who understand binary, and those who don't.", Author = "" , Subject = "Varia" },
                    new Quote() { Content = "SUPERCOMPUTER: what it sounded like before you bought it.", Subject = "Hardware" },
                    new Quote() { Content = "I'm not anti-social; I'm just not user friendly", Subject = "Varia" },
                    new Quote() { Content = "A printer consists of three main parts: the case, the jammed paper tray and the blinking red light", Author = "Dave Barry" , Subject = "Hardware" },
                    new Quote() { Content = "The best accelerator available for a Mac is one that causes it to go at 9.81 m/s2.", Subject = "Varia" },
                    new Quote() { Content = "A computer lets you make more mistakes faster than any invention in human history - with the possible exceptions of handguns and tequila", Author = "Mitch Ratcliffe" , Subject = "Programming" },
                    new Quote() { Content = "To go forward, you must backup. ", Subject = "Varia" },
                    new Quote() { Content = "I would love to change the world, but they won't give me the source code", Subject = "Programming" },
                    new Quote() { Content = "A Windows user spends 1/3 of his life sleeping, 1/3 working, 1/3 waiting.", Subject = "Windows" },
                    new Quote() { Content = "My software never has bugs. It just develops random features.", Author = "" , Subject = "Programming" },
                    new Quote() { Content = "Better to be a geek than an idiot.", Author = "" , Subject = "Varia" },
                    new Quote() { Content = "Be nice to geeks when you're in school, you might end-up working for one when you grow up.", Subject = "Varia" },
                    new Quote() { Content = "Difference between a virus and windows? Viruses rarely fail.", Subject = "Windows" },
                    new Quote() { Content = "Evolution is God's way of issuing upgrades.", Subject = "Varia" },
                    new Quote() { Content = "The only problem with troubleshooting is that sometimes trouble shoots back.", Subject = "Varia" },
                    new Quote() { Content = "The box said 'Required Windows 95 or better'. So, I installed LINUX.", Author = "" , Subject = "Windows" },
                    new Quote() { Content = "Computers are like air conditioners: they stop working when you open windows.", Author = "" , Subject = "Windows" },
                    new Quote() { Content = "Like car accidents, most hardware problems are due to driver error.", Author = "" , Subject = "Hardware" },
                    new Quote() { Content = "Real men don't use backups, they post their stuff on a public ftp server and let the rest of the world make copies.", Author = "Linus Torvalds" , Subject = "Varia" },
                    new Quote() { Content = "There are 10 kinds of people in the world, those that understand trinary, those that don't, and those that confuse it with binary.", Subject = "Varia" },
                    new Quote() { Content = "I had a fortune cookie the other day and it said: 'Outlook not so good'. I said: 'Sure, but Microsoft ships it anyway'.", Subject = "Windows" },
                    new Quote() { Content = "Programmers are tools for converting caffeine into code.", Subject = "Programming" },
                    new Quote() { Content = "The great thing about Object Oriented code is that it can make small, simple problems look like large, complex ones.", Author = "" , Subject = "Programming" }
                    };
        }

        // deze static method heeft als parameter de volledige list en een boolean waarde
        // indien de boolean waarde = True --> geef enkel de anonieme terug
        // indien de boolean waarde = False --> geef enkel de NIET anonieme terug

        //public static List<Quote> GetQuotesFiltered(List<Quote> quotes, bool anonymous)
        //{

        //}


    }
}