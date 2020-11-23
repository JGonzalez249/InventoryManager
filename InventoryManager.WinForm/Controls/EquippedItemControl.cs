﻿using System.Collections.Generic;
using System.Windows.Forms;
using InventoryManager.Data;

namespace InventoryManager.WinForm.Controls
{
    public partial class EquippedItemControl : UserControl
    {

        public Player Player
        {
            get => mPlayer;
            set
            {
                if (mPlayer != value)
                {
                    mPlayer = value;
                    if (mPlayer != null)
                    {
                        var inventory = new List<Item>(mPlayer.Inventory);
                        inventory.Insert(0, NoItem);

                        equippedItemComboBox.SelectedIndexChanged -= EquippedItemComboBox_SelectedIndexChanged;
                        equippedItemComboBox.DataSource = inventory;
                        EquippedItem = mPlayer.EquippedItems.TryGetValue(EquipLocation, out Item equippedItem) ? equippedItem : NoItem;

                    }
                    else
                    {
                        equippedItemComboBox.DataSource = null;
                    }
                }
            }
        }
        public EquipLocations EquipLocation
        {
            get => mEquipLocation;
            set
            {
                mEquipLocation = value;
                equippedLocationTextBox.Text = mEquipLocation.ToString();
            }
        }

        public Item EquippedItem 
        {
            get => (Item)equippedItemComboBox.SelectedItem;
            set => equippedItemComboBox.SelectedItem = value; 
        }

        public EquippedItemControl()
        {
            InitializeComponent();
        }

        private void EquippedItemComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (mPlayer != null)
            {
                Item equippedItem = EquippedItem;
                if (equippedItem == NoItem)
                {
                    mPlayer.EquippedItems.Remove(EquipLocation);
                }
                else
                {
                    mPlayer.EquippedItems[EquipLocation] = equippedItem;
                }
            }
        }

        private static readonly Item NoItem = new Item() { Name = "None" };
        private Player mPlayer;
        private EquipLocations mEquipLocation;
    }
}
