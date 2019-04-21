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
        #region init
        public frmCharacterCreator()
        {
            InitializeComponent();
        }

        private void frmCharacterCreator_Load(object sender, EventArgs e)
        {
            // disables all other tabs but the starting racial tab
            disableTabs();

            // hides those ugly blank combo boxes when the form loads
            hideAllComboBoxes();

            trvRaces.ExpandAll();
        }
        #endregion

        #region General Methods

        public void disableTabs()
        {
            foreach (TabPage tab in tabCharacterCreator.TabPages)
            {
                tab.Enabled = false;
            }
            (tabCharacterCreator.TabPages[0] as TabPage).Enabled = true;
        }

        public void resetComboBox()
        {
            // supplementry to the hiding of combo boxes and prevents accidentally combining data

            // clears text from the combo boxes
            cboRaceOption1.Text = "";
            cboRaceOption2.Text = "";
            cboRaceOption3.Text = "";
            cboRaceOption4.Text = "";
            cboRaceOption5.Text = "";

            // clearing the combox collections
            cboRaceOption1.Items.Clear();
            cboRaceOption2.Items.Clear();
            cboRaceOption3.Items.Clear();
            cboRaceOption4.Items.Clear();
            cboRaceOption5.Items.Clear();
        }

        public void hideAllComboBoxes()
        {
            // hides the combo boxes
            cboRaceOption1.Hide();
            cboRaceOption2.Hide();
            cboRaceOption3.Hide();
            cboRaceOption4.Hide();
            cboRaceOption5.Hide();
        }
        #endregion

        #region Racial Descriptions

        // provides all text for the racial tab easier to hard code rather than storing a txt or db

        #region Dragonborn   
        string dragonbornTraits = "Dragonborn Traits\r\n\r\nYour Draconic heritage manifests in a variety of traits you share with other dragonborn.\r\n\r\nAbility Score Increase: Your Strength score increases by 2, and your Charisma score increases by 1.\r\n\r\nAge: Young dragonborn grow quickly.They walk hours after hatching, attain the size and development of a 10-year-old human child by the age of 3, and reach Adulthood by 15. They live to be around 80.\r\n\r\nAlignment: Dragonborn tend to extremes, making a conscious choice for one side or the other in the cosmic war between good and evil.Most dragonborn are good, but those who side with evil can be terrible villains.\r\n\r\nSize: Dragonborn are taller and heavier than humans, standing well over 6 feet tall and averaging almost 250 pounds.Your size is Medium.\r\n\r\nSpeed: Your base walking speed is 30 feet.\r\n\r\nDraconic Ancestry\r\n\r\nDragon Damage Type Breath Weapon\r\nBlack   Acid    5 by 30 ft.line (Dex.save)\r\nBlue    Lightning   5 by 30 ft.line (Dex.save)\r\nBrass   Fire    5 by 30 ft.line (Dex.save)\r\nBronze  Lightning   5 by 30 ft.line (Dex.save)\r\nCopper  Acid    5 by 30 ft.line (Dex.save)\r\nGold    Fire    15 ft.cone (Dex.save)\r\nGreen   Poison  15 ft.cone (Con.save)\r\nRed Fire    15 ft.cone (Dex.save)\r\nSilver  Cold    15 ft.cone (Con.save)\r\nWhite   Cold    15 ft.cone (Con.save)\r\n\r\nDraconic Ancestry: You have Draconic ancestry. Choose one type of dragon from the Draconic Ancestry table. Your breath weapon and damage Resistance are determined by the dragon type, as shown in the table.\r\n\r\nBreath Weapon: You can use your action to exhale destructive energy.Your Draconic ancestry determines the size, shape, and damage type of the exhalation.\r\nWhen you use your breath weapon, each creature in the area of the exhalation must make a saving throw, the type of which is determined by your Draconic ancestry.The DC for this saving throw equals 8 + your Constitution modifier + your Proficiency Bonus.A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th level, and 5d6 at 16th level.\r\nAfter you use your breath weapon, you can’t use it again until you complete a short or Long Rest.\r\n\r\nDamage Resistance: You have Resistance to the damage type associated with your Draconic ancestry.\r\n\r\nLanguages: You can speak, read, and write Common and Draconic.Draconic is thought to be one of the oldest Languages and is often used in the study of magic. The language sounds harsh to most other creatures and includes numerous hard consonants and sibilants.";
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
";
        #endregion

        #region Half-Orc
        string halfOrcTraits = @"Half-Orc Traits

Your half-orc character has certain traits deriving from your orc ancestry.

Ability Score Increase: Your Strength score increases by 2, and your Constitution score increases by 1.

Age: Half-Orcs mature a little faster than humans, reaching Adulthood around age 14. They age noticeably faster and rarely live longer than 75 years.

Alignment: Half-Orcs inherit a tendency toward chaos from their orc Parents and are not strongly inclined toward good. Half-Orcs raised among orcs and willing to live out their lives among them are usually evil.

Size: Half-Orcs are somewhat larger and bulkier than humans, and they range from 5 to well over 6 feet tall. Your size is Medium.

Speed: Your base walking speed is 30 feet.

Darkvision: Thanks to your orc blood, you have superior vision in dark and dim Conditions. You can see in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light. You can’t discern color in Darkness, only shades of gray.

Menacing: You gain proficiency in the Intimidation skill.

Relentless Endurance: When you are reduced to 0 Hit Points but not killed outright, you can drop to 1 hit point instead. You can’t use this feature again until you finish a Long Rest.

Savage Attacks: When you score a critical hit with a melee weapon Attack, you can roll one of the weapon’s damage dice one additional time and add it to the extra damage of the critical hit.

Languages: You can speak, read, and write Common and Orc. Orc is a harsh, grating language with hard consonants. It has no script of its own but is written in the Dwarvish script.
";
        #endregion

        #region General Halfling
        string halflingTraits = @"Halfling Traits

Your halfling character has a number of traits in Common with all other Halflings.

Ability Score Increase: Your Dexterity score increases by 2.

Age: A halfling reaches Adulthood at the age of 20 and generally lives into the middle of his or her second century.

Alignment: Most Halflings are lawful good. As a rule, they are good-hearted and kind, hate to see others in pain, and have no tolerance for oppression. They are also very orderly and traditional, leaning heavily on the support of their community and the comfort of their old ways.

Size: Halflings average about 3 feet tall and weigh about 40 pounds. Your size is Small.

Speed: Your base walking speed is 25 feet.

Lucky: When you roll a 1 on The D20 for an Attack roll, ability check, or saving throw, you can reroll the die and must use the new roll.

Brave: You have advantage on Saving Throws against being Frightened.

Halfling Nimbleness: You can move through the space of any creature that is of a size larger than yours.

Languages: You can speak, read, and write Common and Halfling. The Halfling language isn’t Secret, but Halflings are loath to share it with others. They write very little, so they don’t have a rich body of literature. Their oral tradition, however, is very strong. Almost all Halflings speak Common to converse with the people in whose lands they dwell or through which they are traveling.

Subrace: The two main kinds of halfling, lightfoot and stout, are more like closely related families than true subraces.
Choose one of these subraces.
";
        #endregion

        #region Lightfoot Halfling
        string lightfootHalflingTraits = @"Lightfoot Halfling Traits

As a lightfoot halfling, you can easily hide from notice, even using other people as cover.

Ability Score Increase: Your Charisma score increases by 1.

Naturally Stealthy: You can attempt to hide even when you are obscured only by a creature that is at least one size larger than you.
";
        #endregion

        #region Stout Halfling
        string stoutHalflingTraits = @"Stout Halfling Traits

As a stout halfling, you’re hardier than average and have some resistance to poison. Some say that stouts have dwarven blood.

Ability Score Increase: Your Constitution score increases by 1.

Stout Resilience: You have advantage on saving throws against poison, and you have resistance against poison damage.
";
        #endregion

        #region Human
        string humanTraits = @"Human Traits

It’s hard to make generalizations about humans, but your human character has these traits.

Ability Score Increase: Your Ability Scores each increase by 1.

Age: Humans reach Adulthood in their late teens and live less than a century.

Alignment: Humans tend toward no particular Alignment. The best and the worst are found among them.

Size: Humans vary widely in height and build, from barely 5 feet to well over 6 feet tall. Regardless of your position in that range, your size is Medium.

Speed: Your base walking speed is 30 feet.

Languages: You can speak, read, and write Common and one extra language of your choice. Humans typically learn the Languages of other peoples they deal with, including obscure dialects. They are fond of sprinkling their Speech with words borrowed from other tongues: Orc curses, Elvish musical expressions, Dwarvish military phrases, and so on.";
        #endregion

        #region Tiefling
        string tieflingTraits = @"Tiefling Traits

Tieflings share certain Racial Traits as a result of their Infernal descent.

Ability Score Increase: Your Intelligence score increases by 1, and your Charisma score increases by 2.

Age: Tieflings mature at the same rate as humans but live a few years longer.

Alignment: Tieflings might not have an innate tendency toward evil, but many of them end up there. Evil or not, an independent Nature inclines many tieflings toward a chaotic Alignment.

Size: Tieflings are about the same size and build as humans. Your size is Medium.

Speed: Your base walking speed is 30 feet.

Darkvision: Thanks to your Infernal heritage, you have superior vision in dark and dim Conditions. You can see in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light. You can’t discern color in Darkness, only shades of gray.

Hellish Resistance: You have Resistance to fire damage.

Infernal Legacy. You know the Thaumaturgy cantrip. When you reach 3rd level, you can cast the Hellish Rebuke spell as a 2nd-level spell once with this trait and regain the ability to do so when you finish a Long Rest. When you reach 5th level, you can cast the Darkness spell once with this trait and regain the ability to do so when you finish a Long Rest. Charisma is your Spellcasting ability for these Spells.

Languages: You can speak, read, and write Common and Infernal.";
        #endregion

        #endregion

        #region Racial Items
        public void DragonbornAncestry()
        {
            // racial items for the dragonborn race
            resetComboBox();

            cboRaceOption1.Show();
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
            // adds artisan tools to the dwarf subraces
            resetComboBox();

            cboRaceOption1.Show();
            cboRaceOption1.Text = "Tool Type";

            cboRaceOption1.Items.Add("Smith's Tools");
            cboRaceOption1.Items.Add("Brewer's Supplies");
            cboRaceOption1.Items.Add("Mason's Tools");
        }

        public void highElfCantrip()
        {
            // racial items for the high elf subrace
            resetComboBox();

            cboRaceOption1.Show();
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
            //extra languages separated into different statements to make sense in terms of presentation when it comes to different races
            if (txtRaceDetails.Text == highElfTraits)
            {
                cboRaceOption2.Show();
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
                cboRaceOption5.Show();
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
            else if (txtRaceDetails.Text == humanTraits)
            {
                resetComboBox();

                cboRaceOption1.Show();
                cboRaceOption1.Text = "Languages";

                cboRaceOption1.Items.Add("Abyssal");
                cboRaceOption1.Items.Add("Celestial");
                cboRaceOption1.Items.Add("Deep Speech");
                cboRaceOption1.Items.Add("Draconic");
                cboRaceOption1.Items.Add("Dwarvish");
                cboRaceOption1.Items.Add("Giant");
                cboRaceOption1.Items.Add("Gnomish");
                cboRaceOption1.Items.Add("Goblin");
                cboRaceOption1.Items.Add("Halfling");
                cboRaceOption1.Items.Add("Infernal");
                cboRaceOption1.Items.Add("Orc");
                cboRaceOption1.Items.Add("Primordial");
                cboRaceOption1.Items.Add("Sylvan");
                cboRaceOption1.Items.Add("Undercommon");
            }
        }

        public void halfElfAbilityScoreIncrease1()
        {
            // adds combo boxes for the half elf that showcase the 2 ability scores to be selected
            resetComboBox();

            cboRaceOption1.Show();
            cboRaceOption1.Text = "Ability 1";

            cboRaceOption1.Items.Add("Constitution");
            cboRaceOption1.Items.Add("Dexerity");
            cboRaceOption1.Items.Add("Intelligence");
            cboRaceOption1.Items.Add("Strength");
            cboRaceOption1.Items.Add("Wisdom");
        }

        public void halfElfAbilityScoreIncrease2()
        {
            cboRaceOption2.Show();
            cboRaceOption2.Text = "Ability 2";

            cboRaceOption2.Items.Add("Constitution");
            cboRaceOption2.Items.Add("Dexerity");
            cboRaceOption2.Items.Add("Intelligence");
            cboRaceOption2.Items.Add("Strength");
            cboRaceOption2.Items.Add("Wisdom");
        }

        public void halfElfSkillProfiency()
        {
            // the same as the ability score option for half elf, just with skills
            cboRaceOption3.Show();
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

            cboRaceOption4.Show();
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
            // when nodes are clicked they trigger racial specfic methods from above

            //textBox1.Text = e.Node.Text;

            if (e.Node.Text == "Dragonborn")
            {
                txtRaceDetails.Text = dragonbornTraits;

                hideAllComboBoxes();

                DragonbornAncestry();

                cboRaceOption1.Text = "Ancestry Type";
            }

            if (e.Node.Text == "Dwarf")
            {
                txtRaceDetails.Text = dwarfTraits;

                resetComboBox();
                hideAllComboBoxes();
            }

            if (e.Node.Text == "Hill Dwarf")
            {
                txtRaceDetails.Text = hillDwarfTraits;

                hideAllComboBoxes();

                DwarvenTools();
            }

            if (e.Node.Text == "Mountain Dwarf")
            {
                txtRaceDetails.Text = mountainDwarfTraits;

                hideAllComboBoxes();

                DwarvenTools();
            }

            if (e.Node.Text == "Elf")
            {
                resetComboBox();
                hideAllComboBoxes();

                txtRaceDetails.Text = elfTraits;
            }

            if (e.Node.Text == "High Elf")
            {
                txtRaceDetails.Text = highElfTraits;

                highElfCantrip();

                ExtraLanguages();
            }

            if (e.Node.Text == "Wood Elf")
            {
                hideAllComboBoxes();
                resetComboBox();

                txtRaceDetails.Text = woodElfTraits;
            }

            if (e.Node.Text == "Dark Elf (Drow)")
            {
                hideAllComboBoxes();
                resetComboBox();

                txtRaceDetails.Text = darkElfTraits;
            }

            if (e.Node.Text == "Gnome")
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\Microsoft Visual Studio\Side projects\DnD-5E-Character-Sheet-Project\CharacterCreator\CharacterCreator\Gnome.wav");
                player.Play();

                hideAllComboBoxes();
                resetComboBox();

                txtRaceDetails.Text = gnomeTraits;
            }

            if (e.Node.Text == "Forest Gnome")
            {
                hideAllComboBoxes();
                resetComboBox();

                txtRaceDetails.Text = forestGnomeTraits;
            }

            if (e.Node.Text == "Rock Gnome")
            {
                hideAllComboBoxes();
                resetComboBox();

                txtRaceDetails.Text = rockGnomeTraits;
            }

            if (e.Node.Text == "Half-Elf")
            {
                txtRaceDetails.Text = halfElfTraits;

                hideAllComboBoxes();

                halfElfAbilityScoreIncrease1();
                halfElfAbilityScoreIncrease2();

                halfElfSkillProfiency();

                ExtraLanguages();
            }

            if (e.Node.Text == "Half-Orc")
            {
                resetComboBox();
                hideAllComboBoxes();

                txtRaceDetails.Text = halfOrcTraits;
            }

            if (e.Node.Text == "Halfling")
            {
                resetComboBox();
                hideAllComboBoxes();

                txtRaceDetails.Text = halflingTraits;
            }

            if (e.Node.Text == "Lightfoot Halfling")
            {
                resetComboBox();
                hideAllComboBoxes();

                txtRaceDetails.Text = lightfootHalflingTraits;
            }

            if (e.Node.Text == "Stout Halfling")
            {
                resetComboBox();
                hideAllComboBoxes();

                txtRaceDetails.Text = stoutHalflingTraits;
            }

            if (e.Node.Text == "Human")
            {
                txtRaceDetails.Text = humanTraits;

                hideAllComboBoxes();

                ExtraLanguages();
            }

            if (e.Node.Text == "Tiefling")
            {
                resetComboBox();
                hideAllComboBoxes();

                txtRaceDetails.Text = tieflingTraits;
            }

        }
        #endregion

        #region Half-Elf ComboBox Trait changes

        // the half elf combo boxes needed some logic to remove already selected items in the connected combo box

        // these methods do contain a bug but shouldn't be a big issue
        // this bug being that the user could potentially remove half of each cbo list if they select too many different lists
        // this is under the assumtion that the user won't select several option in one sitting and they may change the race
        // before it becomes a glaring issue

        // a future fix maybe be found but due to the minor impact of the bug, and the fact i've dedicated quite some time to try and fix this already

        private void cboRaceOption1_TextChanged(object sender, EventArgs e)
        {
            if (trvRaces.SelectedNode.Text == "Half-Elf")
                cboRaceOption2.Items.Remove(cboRaceOption1.Text);
        }

        private void cboRaceOption2_TextChanged(object sender, EventArgs e)
        {
            if (trvRaces.SelectedNode.Text == "Half-Elf")
                cboRaceOption1.Items.Remove(cboRaceOption2.Text);
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
        #endregion

        #region button events
        private void btnChooseRace_Click(object sender, EventArgs e)
        {
            if (trvRaces.SelectedNode.Text == "Dwarf" || trvRaces.SelectedNode.Text == "Elf" || trvRaces.SelectedNode.Text == "Gnome" || trvRaces.SelectedNode.Text == "Halfling")
            {
                // won't move to the class tab unless a valid race is selected
                MessageBox.Show("Please select a race or subrace to continue.");
            }
            else if (txtRaceDetails.Text != "Please Choose a Race or Subrace")
            {
                currentIndex += 1;

                if (currentIndex >= tabCharacterCreator.TabPages.Count)
                {
                    currentIndex = 0;
                }

                foreach (TabPage pg in tabCharacterCreator.TabPages)
                {
                    pg.Enabled = false;
                }

                tabCharacterCreator.TabPages[currentIndex].Enabled = true;
                tabCharacterCreator.SelectedIndex = currentIndex;
            }
            else
            {
                MessageBox.Show("Please select a race or subrace to continue.");
            }


        }
        #endregion

        #region TabControl Events
        int currentIndex = 0; //global initial setting

        private void tabCharacterCreator_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabCharacterCreator.SelectedIndex = currentIndex;
            return;
        }

        #endregion
    }
}
