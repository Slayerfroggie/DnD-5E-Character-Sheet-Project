﻿using System;
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
        
        public void resetComboBox()
        {
            cboRaceOption1.Text = "";
            cboRaceOption2.Text = "";
            cboRaceOption3.Text = "";
            cboRaceOption4.Text = "";
            cboRaceOption5.Text = "";

            cboRaceOption1.Items.Clear();
            cboRaceOption2.Items.Clear();
            cboRaceOption3.Items.Clear();
            cboRaceOption4.Items.Clear();
            cboRaceOption5.Items.Clear();
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

Attributes
Size: Medium
Speed: 25

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
        string elfTraits = @"Elf Traits

Your elf character has a variety of natural Abilities, the result of thousands of years of elven refinement.

Ability Score Increase: Your Dexterity score increases by 2.

Age: Although elves reach physical maturity at about the same age as humans, the elven understanding of Adulthood goes beyond physical growth to encompass worldly experience. An elf typically claims Adulthood and an adult name around the age of 100 and can live to be 750 years old.

Alignment: Elves love freedom, variety, and self- expression, so they lean strongly toward the gentler aspects of chaos. They value and protect others’ freedom as well as their own, and they are more often good than not.

Size: Elves range from under 5 to over 6 feet tall and have slender builds. Your size is Medium.

Speed: Your base walking speed is 30 feet.

Darkvision: Accustomed to twilit forests and the night sky, you have superior vision in dark and dim Conditions. You can see in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light. You can’t discern color in Darkness, only shades of gray.

Keen Senses: You have proficiency in the Perception skill.

Fey Ancestry: You have advantage on Saving Throws against being Charmed, and magic can’t put you to sleep.

Trance: Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. (The Common word for such meditation is “trance.”) While meditating, you can dream after a fashion; such dreams are actually mental exercises that have become reflexive through years of practice. After Resting in this way, you gain the same benefit that a human does from 8 hours of sleep.

Languages: You can speak, read, and write Common and Elvish. Elvish is fluid, with subtle intonations and intricate grammar. Elven literature is rich and varied, and their songs and poems are famous among other races. Many bards learn their language so they can add Elvish ballads to their repertoires.

Attributes
Size: Medium
Speed: 30

Subrace: Ancient divides among the elven people resulted in three main subraces: high elves, wood elves, and dark elves, who are commonly called drow.
Choose one of these subraces. 
";
        #endregion

        #region High Elf
        string highElfTraits = @"High Elf Traits

As a high elf, you have a keen mind and a mastery of at least the basics of magic.

Ability Score Increase: Your Intelligence scoreincreases by 1.

Elf Weapon Training: You have proficiency withthe longsword, shortsword, shortbow, and longbow.

Cantrip: You know one cantrip of your choice from the wizard spell list. Intelligence is your spellcasting ability for it.

Extra Language: You can speak, read, and write one extra language of your choice.
";
        #endregion

        #region Wood Elf
        string woodElfTraits = @"Wood Elf Traits

As a Wood Elf, you have keen senses and intuition, and your fleet feet carry you quickly and stealthily through your native forests. 

Ability Score Increase: Your Wisdom score increases by 1.

Elf Weapon Training: You have proficiency with thelongsword, shortsword, shortbow, and longbow.

Fleet of Foot: Your base walking speed increases to 35 feet.

Mask of the Wild: You can attempt to hide even when you are only lightly obscured by foliage, heavy rain, falling snow, mist, and other natural phenomena.
";
        #endregion

        #region Dark Elf
        string darkElfTraits = @"Dark Elf (Drow)

Also called Dark Elves, the Drow have black skin that resembles polished obsidian and stark white or pale yellow hair. They commonly have very pale eyes (so pale as to be mistaken for white) in shades of lilac, silver, pink, red, and blue. They tend to be smaller and thinner than most elves. Drow adventurers are rare, and the race does not exist in all worlds.

Ability Score Increase: Your Charisma score increases by 1.

Superior Darkvision: Your darkvision has a radius of 120 feet.

Sunlight Sensitivity: You have disadvantage on attack rolls and on Wisdom (Perception) checks that rely on sight when you, the target of your attack, or whatever you are trying to perceive is in direct sunlight.

Drow Magic: You know the dancing lights cantrip. When you reach 3rd level, you can cast the faerie fire spell once per day. When you reach 5th level, you can also cast the darkness spell once per day. Charisma is your spellcasting ability for these spells.

Drow Weapon Training: You have proficiency with rapiers, shortswords, and hand crossbows.";

        #endregion

        #region General Gnome
        string gnomeTraits = @"Gnome Traits

Your Gnome character has certain characteristics in Common with all other Gnomes.

Ability Score Increase: Your Intelligence score increases by 2.

Age: Gnomes mature at the same rate humans do, and most are expected to settle down into an adult life by around age 40. They can live 350 to almost 500 years.

Alignment: Gnomes are most often good. Those who tend toward law are sages, engineers, researchers, scholars, investigators, or inventors. Those who tend toward chaos are minstrels, tricksters, wanderers, or fanciful jewelers. Gnomes are good-hearted, and even the tricksters among them are more playful than vicious.

Size: Gnomes are between 3 and 4 feet tall and average about 40 pounds. Your size is Small.

Speed: Your base walking speed is 25 feet.

Darkvision: Accustomed to life Underground, you have superior vision in dark and dim Conditions. You can see in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light. You can’t discern color in Darkness, only shades of gray.

Gnome Cunning: You have advantage on all Intelligence, Wisdom, and Charisma Saving Throws against magic.

Languages: You can speak, read, and write Common and Gnomish. The Gnomish language, which uses the Dwarvish script, is renowned for its technical treatises and its catalogs of knowledge about the natural world.

Attributes
Size: Small
Speed: 25

Subrace: Two subraces of Gnomes are found among the worlds of D&D: Forest Gnomes and Rock Gnomes. Choose one of these subraces.
";
        #endregion

        #region Forest Gnome
        string forestGnomeTraits = @"Forest Gnome Traits

As a forest gnome, you have a natural knack for illusion and inherent quickness and stealth. These gnomes also befriend small forest animals and rely on them for information about threats that might prowl their lands.

Ability Score Increase: Your Dexterity score increases by 1.

Natural Illusionist: You know the minor illusion cantrip. Intelligence is your spellcasting ability for it.

Speak with Small Beasts: Through sounds and gestures, you can communicate simple ideas with Small or smaller beasts. Forest gnomes love animals and often keep squirrels, badgers, rabbits, moles, woodpeckers, and other creatures as beloved pets.
";
        #endregion

        #region Rock Gnome
        string rockGnomeTraits = @"Rock Gnome Traits

As a rock gnome, you have a natural inventiveness and hardiness beyond that o f other gnomes.

Ability Score Increase: Your Constitution score increases by 1.

Artificer’s Lore: Whenever you make an Intelligence (History) check related to magic items, alchemical objects, or technological devices, you can add twice your proficiency bonus, instead o f any proficiency bonus you normally apply.

Tinker: You have proficiency with artisan’s tools (tinker’s tools). Using those tools, you can spend 1 hour and 10 gp worth o f materials to construct a Tiny clockwork device (AC 5, 1 hp). The device ceases to function after 24 hours (unless you spend 1 hour repairing it to keep the device functioning), or when you use your action to dismantle it; at that time, you can reclaim the materials used to create it. You can have up to three such devices active at a time.
When you create a device, choose one of the following options:

Clockwork Toy: This toy is a clockwork animal, monster, or person, such as a frog, mouse, bird, dragon, or soldier. When placed on the ground, the toy moves 5 feet across the ground on each o f your turns in a random direction. It makes noises as appropriate to the creature it represents.

Fire Starter: The device produces a miniature flame, which you can use to light a candle, torch, or campfire. Using the device requires your action.

Music Box: When opened, this music box plays a single song at a moderate volume. The box stops playing when it reaches the song’s end or when it is closed.
";

        #endregion

        #region Half-Elf
        string halfElfTraits = @"Half-Elf Traits

Your half-elf character has some qualities in Common with elves and some that are unique to half-elves.

Ability Score Increase: Your Charisma score increases by 2, and two other Ability Scores of your choice increase by 1.

Age: Half-elves mature at the same rate humans do and reach Adulthood around the age of 20. They live much longer than humans, however, often exceeding 180 years.

Alignment: Half-elves share the chaotic bent of their elven heritage. They value both personal freedom and creative expression, demonstrating neither love of leaders nor desire for followers. They chafe at rules, resent others’ demands, and sometimes prove unreliable, or at least unpredictable.

Size: Half-elves are about the same size as humans, ranging from 5 to 6 feet tall. Your size is Medium.

Speed: Your base walking speed is 30 feet.

Darkvision: Thanks to your elf blood, you have superior vision in dark and dim Conditions. You can see in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light. You can’t discern color in Darkness, only shades of gray.

Fey Ancestry: You have advantage on Saving Throws against being Charmed, and magic can’t put you to sleep.

Skill Versatility: You gain proficiency in two Skills of your choice.

Languages: You can speak, read, and write Common, Elvish, and one extra language of your choice.

Attributes
Size: Medium
Speed: 30
";
        #endregion

        #region Half-Orc
        #endregion

        #region General Halfling
        #endregion

        #region Lightfoot Halfling
        #endregion

        #region Stout Halfling
        #endregion

        #region Human
        #endregion

        #region Tiefling
        #endregion

        #endregion

        #region Racial Items
        public void DragonbornAncestry()
        {
            resetComboBox();

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
            resetComboBox();

            cboRaceOption1.Text = "Tool Type";

            cboRaceOption1.Items.Add("Smith's Tools");
            cboRaceOption1.Items.Add("Brewer's Supplies");
            cboRaceOption1.Items.Add("Mason's Tools");
        }

        public void highElfCantrip()
        {
            resetComboBox();

            cboRaceOption1.Text = "Cantrip";

            cboRaceOption1.Items.Add("Acid Splash");
            cboRaceOption1.Items.Add("Blade Ward");
            cboRaceOption1.Items.Add("Chill Touch");
            cboRaceOption1.Items.Add("Dancing Lights");
            cboRaceOption1.Items.Add("Fire Bolt");
            cboRaceOption1.Items.Add("Friends");
            cboRaceOption1.Items.Add("Light");
            cboRaceOption1.Items.Add("Mage Hand");
            cboRaceOption1.Items.Add("Mending");
            cboRaceOption1.Items.Add("Message");
            cboRaceOption1.Items.Add("Minor Illusion");
            cboRaceOption1.Items.Add("Poison Spray");
            cboRaceOption1.Items.Add("Prestidigitation");
            cboRaceOption1.Items.Add("Ray of Frost");
            cboRaceOption1.Items.Add("Shocking Grasp");
            cboRaceOption1.Items.Add("True Strike");
        }

        public void ExtraLanguages()
        {
            if (txtRaceDetails.Text == highElfTraits)
            {
                cboRaceOption2.Text = "Languages";

                cboRaceOption2.Items.Add("Abyssal");
                cboRaceOption2.Items.Add("Celestial");
                cboRaceOption2.Items.Add("Deep Speech");
                cboRaceOption2.Items.Add("Draconic");
                cboRaceOption2.Items.Add("Dwarvish");
                cboRaceOption2.Items.Add("Giant");
                cboRaceOption2.Items.Add("Gnomish");
                cboRaceOption2.Items.Add("Goblin");
                cboRaceOption2.Items.Add("Halfling");
                cboRaceOption2.Items.Add("Infernal");
                cboRaceOption2.Items.Add("Orc");
                cboRaceOption2.Items.Add("Primordial");
                cboRaceOption2.Items.Add("Sylvan");
                cboRaceOption2.Items.Add("Undercommon");
            }
            else if (txtRaceDetails.Text == halfElfTraits)
            {
                cboRaceOption5.Text = "Languages";

                cboRaceOption5.Items.Add("Abyssal");
                cboRaceOption5.Items.Add("Celestial");
                cboRaceOption5.Items.Add("Deep Speech");
                cboRaceOption5.Items.Add("Draconic");
                cboRaceOption5.Items.Add("Dwarvish");
                cboRaceOption5.Items.Add("Giant");
                cboRaceOption5.Items.Add("Gnomish");
                cboRaceOption5.Items.Add("Goblin");
                cboRaceOption5.Items.Add("Halfling");
                cboRaceOption5.Items.Add("Infernal");
                cboRaceOption5.Items.Add("Orc");
                cboRaceOption5.Items.Add("Primordial");
                cboRaceOption5.Items.Add("Sylvan");
                cboRaceOption5.Items.Add("Undercommon");
            }
        }

        public void halfElfAbilityScoreIncrease()
        {
            resetComboBox();

            cboRaceOption1.Text = "Ability 1";

            cboRaceOption1.Items.Add("Constitution");
            cboRaceOption1.Items.Add("Dexerity");
            cboRaceOption1.Items.Add("Intelligence");
            cboRaceOption1.Items.Add("Strength");
            cboRaceOption1.Items.Add("Wisdom");

            cboRaceOption2.Text = "Ability 2";

            cboRaceOption2.Items.Add("Constitution");
            cboRaceOption2.Items.Add("Dexerity");
            cboRaceOption2.Items.Add("Intelligence");
            cboRaceOption2.Items.Add("Strength");
            cboRaceOption2.Items.Add("Wisdom");

        }

        public void halfElfSkillProfiency()
        {
            cboRaceOption3.Text = "Skill 1";

            cboRaceOption3.Items.Add("Acrobatics");
            cboRaceOption3.Items.Add("Animal Handling");
            cboRaceOption3.Items.Add("Arcana");
            cboRaceOption3.Items.Add("Athletics");
            cboRaceOption3.Items.Add("Deception");
            cboRaceOption3.Items.Add("History");
            cboRaceOption3.Items.Add("Insight");
            cboRaceOption3.Items.Add("Intimidation");
            cboRaceOption3.Items.Add("Investigation");
            cboRaceOption3.Items.Add("Medicine");
            cboRaceOption3.Items.Add("Nature");
            cboRaceOption3.Items.Add("Perception");
            cboRaceOption3.Items.Add("Performance");
            cboRaceOption3.Items.Add("Persuasion");
            cboRaceOption3.Items.Add("Religion");
            cboRaceOption3.Items.Add("Sleight of Hand");
            cboRaceOption3.Items.Add("Stealth");
            cboRaceOption3.Items.Add("Survival");

            cboRaceOption4.Text = "Skill 2";

            cboRaceOption4.Items.Add("Acrobatics");
            cboRaceOption4.Items.Add("Animal Handling");
            cboRaceOption4.Items.Add("Arcana");
            cboRaceOption4.Items.Add("Athletics");
            cboRaceOption4.Items.Add("Deception");
            cboRaceOption4.Items.Add("History");
            cboRaceOption4.Items.Add("Insight");
            cboRaceOption4.Items.Add("Intimidation");
            cboRaceOption4.Items.Add("Investigation");
            cboRaceOption4.Items.Add("Medicine");
            cboRaceOption4.Items.Add("Nature");
            cboRaceOption4.Items.Add("Perception");
            cboRaceOption4.Items.Add("Performance");
            cboRaceOption4.Items.Add("Persuasion");
            cboRaceOption4.Items.Add("Religion");
            cboRaceOption4.Items.Add("Sleight of Hand");
            cboRaceOption4.Items.Add("Stealth");
            cboRaceOption4.Items.Add("Survival");
        }

        #endregion

        #region Tree View Node Mouse Click Event
        private void trvRaces_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //textBox1.Text = e.Node.Text;

            if (e.Node.Text == "Dragonborn")
            {
                txtRaceDetails.Text = dragonbornTraits;

                DragonbornAncestry();
                cboRaceOption1.Text = "Ancestry Type";
            }
            else if (e.Node.Text == "Dwarf")
            {
                resetComboBox();
                txtRaceDetails.Text = dwarfTraits;
            }
            else if (e.Node.Text == "Hill Dwarf")
            {
                txtRaceDetails.Text = hillDwarfTraits;

                DwarvenTools();
            }
            else if (e.Node.Text == "Mountain Dwarf")
            {
                txtRaceDetails.Text = mountainDwarfTraits;

                DwarvenTools();
            }
            else if (e.Node.Text == "Elf")
            {
                resetComboBox();

                txtRaceDetails.Text = elfTraits;
            }
            else if (e.Node.Text == "High Elf")
            {
                txtRaceDetails.Text = highElfTraits;

                highElfCantrip();

                ExtraLanguages();
            }
            else if (e.Node.Text == "Wood Elf")
            {
                resetComboBox();

                txtRaceDetails.Text = woodElfTraits;
            }
            else if (e.Node.Text == "Dark Elf (Drow)")
            {
                resetComboBox();

                txtRaceDetails.Text = darkElfTraits;
            }
            else if (e.Node.Text == "Gnome")
            {
                resetComboBox();

                txtRaceDetails.Text = gnomeTraits;
            }
            else if (e.Node.Text == "Forest Gnome")
            {
                resetComboBox();

                txtRaceDetails.Text = forestGnomeTraits;
            }
            else if (e.Node.Text == "Rock Gnome")
            {
                resetComboBox();

                txtRaceDetails.Text = rockGnomeTraits;
            }
            else if (e.Node.Text == "Half-Elf")
            {
                txtRaceDetails.Text = halfElfTraits;

                halfElfAbilityScoreIncrease();

                halfElfSkillProfiency();

                ExtraLanguages();
            }
            else if (e.Node.Text == "Half-Orc")
            {
            }
            else if (e.Node.Text == "Halfling")
            {
            }
            else if (e.Node.Text == "Lightfoot Halfling")
            {
            }
            else if (e.Node.Text == "Stout Halfling")
            {
            }
            else if (e.Node.Text == "Halfling")
            {
            }
            else if (e.Node.Text == "Tiefling")
            {
            }

        }
        #endregion

        private void cboRaceOption1_TextChanged(object sender, EventArgs e)
        {
            if(trvRaces.SelectedNode.Text == "Half-Elf")
            cboRaceOption2.Items.Remove(cboRaceOption1.Text);
        }

        private void cboRaceOption2_TextChanged(object sender, EventArgs e)
        {
            if (trvRaces.SelectedNode.Text == "Half-Elf")
                cboRaceOption2.Items.Remove(cboRaceOption1.Text);
        }

        private void cboRaceOption3_TextChanged(object sender, EventArgs e)
        {
            if (trvRaces.SelectedNode.Text == "Half-Elf")
                cboRaceOption4.Items.Remove(cboRaceOption3.Text);
        }

        private void cboRaceOption4_TextChanged(object sender, EventArgs e)
        {
            if (trvRaces.SelectedNode.Text == "Half-Elf")
                cboRaceOption3.Items.Remove(cboRaceOption4.Text);
        }
    }
}
