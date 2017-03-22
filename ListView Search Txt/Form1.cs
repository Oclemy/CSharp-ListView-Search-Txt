using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ListView_Search_Txt
{
    public partial class Form1 : MetroForm
    {
        private List<Spacecraft> spacecrafts;
        public Form1()
        {
            InitializeComponent();

            setupListView();
        }
        /*
         * SETUP LISTVIEW COLUMNS AND PRPERTIES
         */
        private void setupListView()
        {
            mListView.View = View.Details;
            mListView.FullRowSelect = true;
            mListView.Columns.Add("Name", 150);
            mListView.Columns.Add("Destination", 230);

            //LISTVIEW
            spacecrafts = new List<Spacecraft>
            {
                new Spacecraft {Name="Casini",Destination = "Saturn"},
                new Spacecraft {Name="Enterprise",Destination="Andromeda"},
                new Spacecraft {Name="Challenger",Destination="Pluto"},
                new Spacecraft {Name="New Horizon",Destination="Asteroid Belt"},
                new Spacecraft {Name="Opportunity",Destination="Mars"},
                new Spacecraft {Name="Curiosity",Destination="Mars"},
                new Spacecraft {Name="Juno",Destination="Jupiter"},
                new Spacecraft {Name="Apollo 15",Destination="Monn"},
                new Spacecraft {Name="Apollo 17",Destination="Moon"},
                new Spacecraft {Name="Voyager A",Destination="Alpha Centauri"},
                new Spacecraft {Name="Voyager B",Destination="Proxima Centauri"},
                new Spacecraft {Name="Rosetter",Destination="Venus"},
                new Spacecraft {Name="Spitzer",Destination="Uranus"},
                new Spacecraft {Name="Chandra",Destination="Mercury"},
                 new Spacecraft{Name="Pioneer",Destination="Mars"},
                new Spacecraft {Name="Atlantis",Destination="Jupiter"}
            };

            //POPULATE SPACECRAFTS
            foreach (Spacecraft s in spacecrafts)
            {
                mListView.Items.Add(new ListViewItem(new []{s.Name,s.Destination}));
            }
           
        }

        /*
         * SEARCH DATA
         */
        private void searchData(string searchTerm)
        {
                mListView.Items.Clear();
           
            
                foreach (Spacecraft s in spacecrafts)
                {
                    if (s.Name.ToLower().Contains(searchTerm.ToLower()) || s.Destination.ToLower().Contains(searchTerm.ToLower()))
                    {
                        mListView.Items.Add(new ListViewItem(new[] { s.Name, s.Destination }));

                    }
                }
            
           
        }

        /*
         * SEARCH VALUE CHANGED
         */
        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            searchData(searchTxt.Text);
        }
    }

    /*
     * POCO
     */
    class Spacecraft
    {
        public string Name { get; set; }

        public string Destination { get; set; }
    }
}
