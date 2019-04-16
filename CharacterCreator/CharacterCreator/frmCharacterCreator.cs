using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class frmCharacterCreator : Form
    {
        public frmCharacterCreator()
        {
            InitializeComponent();
        }

        #region Racial Descriptions

        #region Dragonborn   
        string dragonbornTraits = "Dragonborn Traits\r\n\r\nYour Draconic heritage manifests in a variety of traits you share with other dragonborn.\r\n\r\nAbility Score Increase: Your Strength score increases by 2, and your Charisma score increases by 1.\r\n\r\nAge: Young dragonborn grow quickly.They walk hours after hatching, attain the size and development of a 10-year-old human child by the age of 3, and reach Adulthood by 15. They live to be around 80.\r\n\r\nAlignment: Dragonborn tend to extremes, making a conscious choice for one side or the other in the cosmic war between good and evil.Most dragonborn are good, but those who side with evil can be terrible villains.\r\n\r\nSize: Dragonborn are taller and heavier than humans, standing well over 6 feet tall and averaging almost 250 pounds.Your size is Medium.\r\n\r\nSpeed: Your base walking speed is 30 feet.\r\n\r\nDraconic Ancestry\r\n\r\nDragon Damage Type Breath Weapon\r\nBlack   Acid    5 by 30 ft.line (Dex.save)\r\nBlue    Lightning   5 by 30 ft.line (Dex.save)\r\nBrass   Fire    5 by 30 ft.line (Dex.save)\r\nBronze  Lightning   5 by 30 ft.line (Dex.save)\r\nCopper  Acid    5 by 30 ft.line (Dex.save)\r\nGold    Fire    15 ft.cone (Dex.save)\r\nGreen   Poison  15 ft.cone (Con.save)\r\nRed Fire    15 ft.cone (Dex.save)\r\nSilver  Cold    15 ft.cone (Con.save)\r\nWhite   Cold    15 ft.cone (Con.save)\r\n\r\nDraconic Ancestry: You have Draconic ancestry. Choose one type of dragon from the Draconic Ancestry table. Your breath weapon and damage Resistance are determined by the dragon type, as shown in the table.\r\n\r\nBreath Weapon: You can use your action to exhale destructive energy.Your Draconic ancestry determines the size, shape, and damage type of the exhalation.\r\nWhen you use your breath weapon, each creature in the area of the exhalation must make a saving throw, the type of which is determined by your Draconic ancestry.The DC for this saving throw equals 8 + your Constitution modifier + your Proficiency Bonus.A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th level, and 5d6 at 16th level.\r\nAfter you use your breath weapon, you can’t use it again until you complete a short or Long Rest.\r\n\r\nDamage Resistance: You have Resistance to the damage type associated with your Draconic ancestry.\r\n\r\nLanguages: You can speak, read, and write Common and Draconic.Draconic is thought to be one of the oldest Languages and is often used in the study of magic. The language sounds harsh to most other creatures and includes numerous hard consonants and sibilants.\r\n\r\nAttributes\r\nSize: Medium\r\nSpeed: 30";
        #endregion

        #region General Dwarf

        string dwarfTraits = @"Dwarf Traits

Your dwarf character has an assortment of inborn Abilities, part and parcel of dwarven Nature.

Ability Score Increase: Your Constitution score increases by 2.

Age: Dwarves mature at the same rate as humans, but they’re considered young until they reach the age of 50. On average, they live about 350 years.

Alignment: Most Dwarves are lawful, believing firmly in the benefits of a well-ordered society. They tend toward good as well, with a strong sense of Fair Play and a belief that everyone deserves to share in the benefits of a just order.

Size: Dwarves stand between 4 and 5 feet tall and average about 150 pounds. Your size is Medium.

Speed: Your base walking speed is 25 feet. Your speed is not reduced by wearing Heavy Armor.

Darkvision: Accustomed to life Underground, you have superior vision in dark and dim Conditions. You can see in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light. You can’t discern color in Darkness, only shades of gray.

Dwarven Resilience: You have advantage on Saving Throws against poison, and you have Resistance against poison damage.

Dwarven Combat Training: You have proficiency with the Battleaxe, Handaxe, Light Hammer, and Warhammer.

Tool Proficiency: You gain proficiency with the artisan’s tools of your choice: smith’s tools, brewer’s supplies, or mason’s tools.

Stonecunning: Whenever you make an Intelligence (History) check related to the Origin of stonework, you are considered proficient in the History skill and add double your Proficiency Bonus to the check, instead of your normal Proficiency Bonus.

Languages: You can speak, read, and write Common and Dwarvish. Dwarvish is full of hard consonants and guttural sounds, and those characteristics spill over into whatever other language a dwarf might speak.

Subraces: Two main subraces of dwarves populate theworlds of D&D: hill dwarves and mountain dwarves.
Choose one of these subraces.";

        #endregion

        #region Hill Dwarf
        string hillDwarfTraits = @"Hill Dwarf Traits
in addition to having standard Dwarf traits as a Hill Dwarf, you have keen Senses, deep intuition, and remarkable resilience.

Ability Score Increase: Your Wisdom score increases by 1.

Dwarven Toughness: Your hit point maximum increases by 1, and it increases by 1 every time you gain a level.";
        #endregion

        #region Mountain Dwarf
        string mountainDwarfTraits = @"Mountain Dwarf Traits
in addition to having standard Dwarf traits as a mountain dwarf, you're strong and hardy, accustomed to a difficult life in rugged terrain. You’re probably on the tall side (for a dwarf), and tend toward lighter coloration.

Ability Score Increase: Your Strength score increases by 2.

Dwarven Armor Training: You have proficiency with light and medium armor.";
        #endregion

        #region General Elf
        #endregion

        #region High Elf
        #endregion

        #endregion

        #region Racial Items
        public void DragonbornAncestry()
        {
            cboRaceOption1.Items.Clear();
            cboRaceOption1.Items.Add("Black Dragon");
            cboRaceOption1.Items.Add("Blue Dragon");
            cboRaceOption1.Items.Add("Brass Dragon");
            cboRaceOption1.Items.Add("Bronze Dragon");
            cboRaceOption1.Items.Add("Copper Dragon");
            cboRaceOption1.Items.Add("Gold Dragon");
            cboRaceOption1.Items.Add("Green Dragon");
            cboRaceOption1.Items.Add("Red Dragon");
            cboRaceOption1.Items.Add("Silver Dragon");
            cboRaceOption1.Items.Add("White Dragon");
        }

        public void DwarvenTools()
        {
            cboRaceOption1.Items.Clear();
            cboRaceOption1.Items.Add("Smith's Tools");
            cboRaceOption1.Items.Add("Brewer's Supplies");
            cboRaceOption1.Items.Add("Mason's Tools");
        }

        #endregion

        private void trvRaces_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //textBox1.Text = e.Node.Text;

            if (e.Node.Text == "Dragonborn")
            {
                txtRaceDetails.Text = "";
                txtRaceDetails.Text = dragonbornTraits;

                cboRaceOption1.Text = "";
                cboRaceOption1.Text = "Ancestry Type";
                DragonbornAncestry();
            }
            else if (e.Node.Text == "Dwarf")
            {
                txtRaceDetails.Text = "";
                txtRaceDetails.Text = dwarfTraits;

                cboRaceOption1.Text = "";
            }
            else if (e.Node.Text == "Hill Dwarf")
            {
                txtRaceDetails.Text = "";
                txtRaceDetails.Text = hillDwarfTraits;

                cboRaceOption1.Text = "";
                cboRaceOption1.Text = "Tool Type";
                DwarvenTools();
            }
            else if (e.Node.Text == "Mountain Dwarf")
            {
                txtRaceDetails.Text = "";
                txtRaceDetails.Text = mountainDwarfTraits;

                cboRaceOption1.Text = "";
                cboRaceOption1.Text = "Tool Type";
                DwarvenTools();


            }


        }
    }
}
