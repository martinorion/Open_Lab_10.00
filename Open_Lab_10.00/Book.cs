using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    class Book
    {

        private int Pages;

        private int ReleaseDate;


        public string author { get; set; }

        public string category { get; set; }
        public int pages
        {
            get => this.Pages;
            set
            {
                if (value < 1)
                {
                    Pages = 1;
                }
                else
                {
                    Pages = value;
                }
            }
        }


        public int releaseDate
        {
            get => this.ReleaseDate;
            set
            {
                if (value < 1450 || value > 2020)
                {
                    ReleaseDate = -1;
                }
                else
                {
                    ReleaseDate = value;
                }
            }
        }

        public string title
        { get; set; }
    }

}
