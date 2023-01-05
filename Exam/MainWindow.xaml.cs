/*
 * Mateusz Weclawowicz
 * 5/1/2023
 * Github: https://github.com/MateuszWeclawowicz/OOPExamSem1Year2
 * Winter Exam Sem 1 Year 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetData();


        }
        private void GetData()
        {
            //create players
            //French players
            Player p1 = new Player() { Name = "Marie", ResultRecord = "WWDDL" };
            Player p2 = new Player() { Name = "Claude", ResultRecord = "DDDLW" };
            Player p3 = new Player() { Name = "Antoine", ResultRecord = "LWDLW" };

            //Italian players
            Player p4 = new Player() { Name = "Marco", ResultRecord = "WWDLL" };
            Player p5 = new Player() { Name = "Giovanni", ResultRecord = "LLLLD" };
            Player p6 = new Player() { Name = "Valentina", ResultRecord = "DLWWW" };

            //Spanish players
            Player p7 = new Player() { Name = "Maria", ResultRecord = "WWWWW" };
            Player p8 = new Player() { Name = "Jose", ResultRecord = "LLLLL" };
            Player p9 = new Player() { Name = "Pablo", ResultRecord = "DDDDD" };

            //add players to respective player list
            //France
            List<Player> france = new List<Player>();
            france.Add(p1);
            france.Add(p2);
            france.Add(p3);

            //Italy
            List<Player> italy = new List<Player>();
            italy.Add(p4);
            italy.Add(p5);
            italy.Add(p6);

            //Spain
            List<Player> spain = new List<Player>();
            spain.Add(p7);
            spain.Add(p8);
            spain.Add(p9);

            //create team list
            List<Team> teams = new List<Team>();

            //create teams
            Team t1 = new Team() { Name = "France", Players = france};
            Team t2 = new Team() { Name = "Italy", Players = italy };
            Team t3 = new Team() { Name = "Spain", Players = spain };

            //add teams to list
            teams.Add(t1);
            teams.Add(t2);
            teams.Add(t3);

            //display teams in listbox
            lbxTeams.ItemsSource = teams;
        }

        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Team selected = lbxTeams.SelectedItem as Team;

            lbxPlayers.ItemsSource = selected.Players;
        }
    }
}
