using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseVsEnemy
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        Outside garden;
        OutsideWithDoor backYard;
        OutsideWithDoor frontYard;
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;
        Room diningRoom;

        public Form1()
        {
            
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }
        public void CreateObjects()
        {
            garden = new Outside("Garden", false);
            backYard = new OutsideWithDoor("BackYard", true, "a screen door");
            frontYard = new OutsideWithDoor("FrontYard", false, "an oak door with a brass knob");
            diningRoom = new Room("DiningRoom", "a crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances",
                "a screen door");
            livingRoom = new RoomWithDoor("LivingRoom",
                "an antique carpet", "an oak door with a brass knob");
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { frontYard, backYard };
            livingRoom.Exits = new Location[] { diningRoom };
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { diningRoom };

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

            frontYard.DoorLocation = livingRoom;
            livingRoom.DoorLocation = frontYard;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       public void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            this.exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;
            descriptipn.Text = currentLocation.Description;
            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
            
        }

        private void gottre_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {

            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
            

        }
    }
}
