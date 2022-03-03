using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // TODO - create a List to store all inventory objects
        List<Player> player = new List<Player>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string team = teamInput.Text;
            string position = positionInput.Text;
            int age = Convert.ToInt32(ageInput.Text);

            Player p = new Player(name, team, position, age);
            player.Add(p);
            DisplayItemsAdd();

            // TODO - gather all information from screen 

            // TODO - create object with gathered information

            // TODO - add object to global list

            // TODO - display message to indicate addition made
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------
            string name =  removeInput.Text;

            for (int i = 0; i < player.Count; i++)
            {
                if (name == player[i].name)
                {
                    player.RemoveAt(i);
                    outputLabel.Text = "\nPlayer was removed";
                }


                // TODO - if object is in list remove it

                // TODO - display message to indicate deletion made
            }
            DisplayItemsRemove();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // TODO - if object entered exists in list show it
            // TODO - else show not found message
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            DisplayItems();
            // TODO - show all objects in list. Use a foreach loop.
        }

        public void DisplayItemsAdd()
        {
            outputLabel.Text = "";
            outputLabel.Text = "Player was added";
            outputLabel.Text += $"\n{player[player.Count-1].name} {player[player.Count - 1].team} {player[player.Count - 1].position} {player[player.Count - 1].age}\n";

            //foreach (Player player in player)
            //{
            //    outputLabel.Text += $"\n{player.name} {player.team} {player.position} {player.age}\n";
            //}
        }

        public void DisplayItemsRemove()
        {
            outputLabel.Text = "";
            outputLabel.Text = "Player was removed";
            outputLabel.Text += $"\n{player[player.Count - 1].name} {player[player.Count - 1].team} {player[player.Count - 1].position} {player[player.Count - 1].age}\n";
            //    foreach (Player player in player)
            //    {
            //        outputLabel.Text += $"\n{player.name} {player.team} {player.position} {player.age}\n";
            //    }
        }

        public void DisplayItems()
        {
            outputLabel.Text = "";

            foreach (Player player in player)
            {
                outputLabel.Text += $"{player.name} {player.team} {player.position} {player.age}\n";
            }
        }


    }
}
