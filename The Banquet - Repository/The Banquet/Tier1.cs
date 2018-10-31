using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Banquet
{
    public static class Tier1
    {

        //These ints will be used to keep track of what the player did in each tier so they can be referenced later.
        //Their naming scheme is as thus:
        //tXo- Tier X Outcome
        //t1s = Tier 1 Outcome
        public static int t1o;

        public static string tier1choice;
        //Int that holds the player's choice of what they want to do for tier 1
        public static int tier1choicenum;

        //keeps track of what tapestry the player chooses to take.
        public static string tapestryString;
        public static int tapestry;

        public static int Introduction()
        {

            //Creates an instance of the Random Class to be used to select scenario at random if player enters invalid choice
            Random ScenarioSelection = new Random();

            Console.WriteLine("You're fairly tired after your long journey from your home in Tenebrae.");
            Console.WriteLine("The day is young and their is much to see. You won't be able to see everything in a single day\n- that would be impossible -\nbut you'll certainly try to see as much as you can in the hours before the banquet tonight.");

            Console.ReadLine();

            Console.WriteLine("Upon entrance into the city gates, you are immediately greeted by a fairly amiable scene.");
            Console.WriteLine("The first people you see walking about appear to be hard at work or on a morning stroll.");
            Console.WriteLine("It's nice, how the people of the capital appear to be able to live fair lives\ndespite the wars waging overseas.");
            Console.WriteLine("Hopefully the more of them you see, the more of their joy you'll see.");

            Console.ReadLine();

            Console.WriteLine("It’s still quite early, so it doesn’t exactly surprise you that not many people are out and about.");
            Console.WriteLine("On your travels, the busiest place you come across is a marketplace lining a street.");
            Console.WriteLine("A number of stalls are open, and merchants are hawking their wares.");
            Console.WriteLine("Some of the customers are busy at work bartering\nin hopes of saving even a few Dominion on that new tunic they were eyeing,\nand others were buying whatever was handed to them, regardless of price.");

            Console.ReadLine();

            Console.WriteLine("You are almost near the end of the street and free of the market when a number of things happen.");
            Console.WriteLine("\nYou notice a teenage (boy/girl) speaking to a merchant.");
            Console.WriteLine("Their conversation seems a bit one sided, to say the least.");
            Console.WriteLine("\nAnother merchant is busy at work setting up his stall, and he appears to be having some trouble.");
            Console.WriteLine("\nA third merchant is hailing you, a wide, friendly smile on his face.");

            Console.ReadLine();

            Console.WriteLine("What will you do?\n1. Check on the teen to make sure they don’t get cheated.\n2. Help the merchant set up and get a start to his day.\nOr\n3. Heed the merchant’s summons and see what he has to offer.");
            tier1choice = Console.ReadLine();

            if (string.IsNullOrEmpty(tier1choice))
            {
                tier1choicenum = ScenarioSelection.Next(1, 4);
            }

            bool res = int.TryParse(tier1choice, out tier1choicenum);

            if (res != true)
            {
                tier1choicenum = ScenarioSelection.Next(1, 4);
            }

            return tier1choicenum;
        }

        public static int Scenario1(string playerName)
        {
            Console.WriteLine("\nYou wander over to the teen and the merchant. The youth is holding onto a small coin purse.");
            Console.WriteLine("Down on the table between them and the merchant was an assortment of decorated knives.");
            Console.WriteLine("It would appear that it's much more appropriate to call this merchant an Arms Dealer.");
            Console.WriteLine("At first glance, they seemed rather low quality. Not like they'd snap if you stabbed a measly barrel,\nbut they most certainly wouldn't be worthy of a knight of the realm as an emergency Arm.");
            Console.WriteLine("Even a squire would be ashamed to call one of those knives his own.");

            Console.ReadLine();

            Console.WriteLine("Arms Dealer: G'mornin' to ya, milord! What brings you here?");
            Console.WriteLine("\n" + Player.playerName + ": Nothing in particular. I just wanted to see what you had on sale.\nHow about you, lass?");
            Console.WriteLine("\nTeen: I-I wanted t' buy an Arm. Help t' keep me family safe, y'see.");
            Console.WriteLine("\nArms Dealer: Aye, and I was just showing 'em what I had to offer! They'd do quite nicely, I think.");
            Console.WriteLine("\n" + Player.playerName + ": How noble of someone as young as yourself. For as simple a purpose as that,\nyou can't be in the market for anything in particular, can you? Anything should do.");
            Console.WriteLine("\nTeen: Yeah.");

            Console.ReadLine();

            Console.WriteLine("You reach out and pick up one knife with read accents. Where the hilt and blade met, there was as small red gemstone.");
            Console.WriteLine("It would've looked just right in a ring. Small, far as a Beaststone was concerned.");

            Console.ReadLine();

            Console.WriteLine(Player.playerName + ": Do you know how these work?");
            Console.WriteLine("\nTeen: N-not really, no. I just know tha' these 'ere Arms are suppose to be magic.");
            Console.WriteLine("\n" + Player.playerName + ": You got that right. They run off of Beaststones, born from the remains of wild beasts.\nEach and every one.");
            Console.WriteLine("\nTeen: So tha' 'ittle stone was an animal once upon a time?");
            Console.WriteLine("\nArms Dealer: Indeed it was, young one! Not a bad one, at that. While they come from great Beasts,\nBeaststones're curious things. Even small ones can come from mighty predators!");
            Console.WriteLine("\nTeen: So it's strong, then?");
            Console.WriteLine("\nArms Dealer: If you want to fend off a villain who means to do yer family farm, it'll ward 'em off!");
            Console.WriteLine("\nTeen: How much do they cost?");
            Console.WriteLine("\nArms Dealer: Well, the one that milord 'ere is 'olding onto will run ya 200 Dominion.\nYou got that, young one?");
            Console.WriteLine("\nTeen: Just barely...");

            Console.ReadLine();

            Console.WriteLine("The tiny stones in those knives were nothing special. That knife you held would be able to burn someone,\nbut it wouldn't do any significant damage. He made it seem as if you could roast a man alive with this pitiful pebble.");

            Console.ReadLine();

            Console.WriteLine(Player.playerName + ": Shame on you, Arms Dealer.");

            Console.ReadLine();

            Console.WriteLine("As you lay down the knife, the two look at you. The Arms Dealer had a raised brow. The girl simply looked confused.");

            Console.ReadLine();

            Console.WriteLine("Arms Dealer: What's the matter, milord?");
            Console.WriteLine("\n" + Player.playerName + ": What's your name, lass?");
            Console.WriteLine("\nTeen: 'Tis Jordan, sir.");
            Console.WriteLine("\n" + Player.playerName + ": Well, Jordan. I imagine you've heard of Dragonsbane?");
            Console.WriteLine("\nJordan: Ah, I 'ave! That's 'is Majesty's sword!");
            Console.WriteLine("\n" + Player.playerName + ": It is Dragonsbane that holds great power, but not any of these. At best, you'll singe a thief's sleeve.\nMight spook them a bit, but nothing is stopping them from batting it out.");
            Console.WriteLine("\nJordan: Oh...");
            Console.WriteLine("\nArms Dealer: What're you trying to say, milord? This is still enough to protect the young one's family, isn't it?");
            Console.WriteLine("\n" + Player.playerName + ": Oh, it should be. If they don't panic, nothing is stopping her from stabbing someone who means her harm.\nThe thing is, none of these blades are worth 200 Dominion. 50 at best.");
            Console.WriteLine("\nArms Dealer: 50?!");
            Console.WriteLine("\n" + Player.playerName + ": Aye, 50. Wouldn't you agree, Jordan?");
            Console.WriteLine("\nJordan: I guess? I don't know much 'bout these sorts o' things...");
            Console.WriteLine("\n" + Player.playerName + ": Fair enough. I just want you to know this man is trying to swindle you.\nWhether you buy his Arms or not doesn't matter. Just don't give him 200 Dominion for it.");

            Console.ReadLine();

            Console.WriteLine("You're almost certain that you hear the Arms Dealer say something under his breath. When you ask him to repeat himself, he begins laughing.");

            Console.ReadLine();

            Console.WriteLine("Arms Dealer: Nothing, nothing at all! I just need to make a profit, you see. That's life, after all.\nIf not 200, then how about 150?");
            Console.WriteLine("\nJordan: But 'e said that these were no better 'an 50!");
            Console.WriteLine("\nArms Dealer: And I said I need to make a profit.");
            Console.WriteLine("\nJordan: I'll do 100.");
            Console.WriteLine("\nArms Dealer: 100! You mean to take my blade for half the price?!");
            Console.WriteLine("\n" + Player.playerName + ": Well, it's worth a quarter of what you're saying.");
            Console.WriteLine("\nArms Dealer: I've 'ad enough of you! Now, kindly leave! Clearly ya don't mean to buy anything from me!");
            Console.WriteLine("\n" + Player.playerName + ": Very well, then. Jordan, I hope you can find yourself walking away from here with a new Arm.\nI wish the best for you and your family.");
            Console.WriteLine("\nJordan: Thank you sir!");

            Console.ReadLine();

            Console.WriteLine("As you walk away from the stall, you hear Jordan mumble something under her breath.");

            Console.ReadLine();

            Console.WriteLine("Jordan: If I can save some money, maybe I can but something for mum.");


            Player.boldness++;
            return Player.boldness;
        }

        public static int Scenario2(string playerName)
        {
            Console.WriteLine("You approach the merchant and ask him if he needs any help.");

            Console.ReadLine();

            Console.WriteLine("Merchant: Ah, yes! That would be much appreciated, milord!");
            Console.WriteLine("\n" + Player.playerName + ": Why, of course.");
            Console.WriteLine("\nMerchant: Your robes aren't like that of any ordinary person, I see.\nYou must be a knight, or the lord of some fiefdom! What's your name, milord?");
            Console.WriteLine("\n" + Player.playerName + ": I go by " + Player.playerName + ".");
            Console.WriteLine("\nMerchant: A Lord " + Player.playerName + ". Don't believe I recognize the name.\nYou must be the humble lord of some small town out east, then.");
            Console.WriteLine("\n" + Player.playerName + ": My father was granted an estate in Tenebrae for his service to His Majesty.");
            Console.WriteLine("\nMerchant: Ah, Tenebrae! Not too far, that. Curious how I haven't heard of you before.");

            Console.ReadLine();

            Console.WriteLine("As you help the merchant to set up his stall, you notice a wide array of jewelry.\nIt's a bit interesting to see a jeweler operating in the streets of all places.");

            Console.ReadLine();

            Console.WriteLine(Player.playerName + ": These are quite interesting, I must say.");
            Console.WriteLine("\nMerchant: Why thank you, milord. I'm sure you've heard of Sentinel rings, yes?");
            Console.WriteLine("\n" + Player.playerName + ": Rings that allow those poor unfortunate souls without Mana Lobes to use magic, yes? I've heard of them.");

            Console.ReadLine();

            Console.WriteLine("The merchant held up a silver ring that had a small blue jewel, turning it over to give you a better look.");

            Console.ReadLine();

            Console.WriteLine("Merchant: This here rings lets you use Water Magic.");
            Console.WriteLine("\n" + Player.playerName + ": Fascinating.");
            Console.WriteLine("\nMerchant: I quite like selling these to people. People who so often struggle with magic being able to use it with ease.\nSome of my customers come back and tell me how their rings helped them in their work\nor helped them to defend themselves from some ne'er-do-well.");
            Console.WriteLine("\n" + Player.playerName + ": Have you ever had people complain about a customer doing anyone harm with your rings?");
            Console.WriteLine("\nMerchant: Naturally, not all of my customers are saints. There isn't much I can do about it, can I?\nI sell my Sentinel rings in good faith. If someone betrays that trust and uses my rings for evil,\nit isn't as if I was knowingly selling a dangerous item to a criminal.");

            Console.ReadLine();

            Console.WriteLine("You weren't entirely sure how to respond to his indifference towards his customers' potentially criminal acts.");

            Console.ReadLine();

            Console.WriteLine("Merchant: Yet, to this point, the Grand Dragons haven't come knocking on my door to order me to stop\nselling them alongside my normal jewelry.");

            Console.ReadLine();

            Console.WriteLine("The two of you finish setting up the merchant's jewelry stand and step back to admire your work. The merchant flashes a wide smile at you.");

            Console.ReadLine();

            Console.WriteLine("Merchant: Thank you again. I would've been stuck for quite a while longer if it weren't for you.\nWhat brings you to the capital, milord?");
            Console.WriteLine("\n" + Player.playerName + ": I was invited by His Majesty to a banquet in the palace this evening.");
            Console.WriteLine("\nMerchant: Ah, the banquet! Well, I hope you enjoy it. If you happen to see me before you leave the capital,\ncome and buy something, won't you? I might be willing to slash a few Dominion from the price.");
            Console.WriteLine("\n" + Player.playerName + ": A most tempting offer. I'll be sure to keep it in mind.");

            Console.ReadLine();

            Console.WriteLine("You left the merchant to go on your way. As you left him, he called out one final time to thank you.");

            Player.kindness++;
            return Player.kindness;
        }

        public static int Scenario3Pt1(string playerName)
        {
            Random tapestrySelection = new Random();

            Console.WriteLine("You walk over to the merchant to see exactly why he was beckoning you.\nLooking down at his stall, you see an assortment of rolled up tapestries.");

            Console.ReadLine();

            Console.WriteLine("Merchant: Well. what do you think, milord? Anything catch your eye?");
            Console.WriteLine("\n" + Player.playerName + ": Well, I'd have to see them before I can see if I like any of them.");

            Console.ReadLine();

            Console.WriteLine("You pick up one of the tapestries and unraveled it. The woven design depicted an interesting scene.\nA gallant Magianan knight fending off a dragon. The knight was protecting women and children... As was the dragon.\nThe Scouring was fresh in the memory of all but the youngest citizens of the Empire,\nand was as controversial a topic now as it was while that specific campaign of the Great War was raging.\nThe knight stood out as the hero of this little story. The Dracomorphi civilians behind the dragon were\nminiscule compared to the humans. Unless you looked out for them you'd think it was a black and white situation.");

            Console.ReadLine();

            Console.WriteLine("You glance at the smiling merchant and then rolled it up once again. Picking up a second tapestry, you unroll it to see a scene that is nowhere near as dark.\nSitting around an ovular table was a council of men dressed in extravagant clothes of all the colors of the rainbow.\nOn the walls behind them were banners bearing the sigils of various noble houses.\nYou recognize the scene as the first meeting of the Royal Council not long before the beginning of the Great War.");

            Console.ReadLine();

            Console.WriteLine("You roll it up and pick up a third tapestry at random. While you could tell what the first and second\ntapestries were, the third one evaded you. You see an immense lake surrounded by a forest.\nIn the middle of the lake itself was a large glowing platform.\nOn the grass was a large group of people sitting and eating. It looked like a celebration of sorts. The merchant picked up on your confusion.");

            Console.ReadLine();

            Console.WriteLine("Merchant: They, as historians say, are the \"People of the Lake\".\nBefore their civilization disappeared, they were said to have worshipped the Lord of the Seas, Zybris,\nabove all other Gods, hence the name.");
            Console.WriteLine("\n" + Player.playerName + ": I've never heard of them. You say they disappeared?");
            Console.WriteLine("\nMerchant: Yes. After all, should you go to that lake nowadays, all you'll find is the Academy; no platform in sight.\nIt's believed that was the secret to reaching their homeland. With it gone, they're gone.");
            Console.WriteLine("\n" + Player.playerName + ": And no one knows what happened to it or where they are?");
            Console.WriteLine("\nMerchant: Alas, not a soul has a clue.");

            Console.ReadLine();

            Console.WriteLine("You put down the final tapestry and reflect on what you saw. Which one of the three will you take with you on your way?\n1. The Knight and the Dracomorph fighting for their families.\n2. The first meeting of the Royal Council\nOr\n3. The People of the Lake");
            tapestryString = Console.ReadLine();

            if (string.IsNullOrEmpty(tapestryString))
            {
                tapestry = tapestrySelection.Next(1, 4);
            }

            bool tap = int.TryParse(tapestryString, out tapestry);

            if (tap != true)
            {
                tapestry = tapestrySelection.Next(1, 4);
            }

            return tapestry;
        }
        public static int Scenario3Pt2(string playerName)
        {
            Console.ReadLine();

            Console.WriteLine("Merchant: Ah, a fine choice! That'll run you 30 Dominion, milord!");
            Console.WriteLine("\n" + Player.playerName + ": Here's your money, fine sir. Hopefully you have a fruitful day of business.");

            Console.ReadLine();

            Console.WriteLine("With your new tapestry tucked under your arm, you bid the merchant farewell and walk away from his stall.");

            Console.ReadLine();

            Player.intelligence++;
            return Player.intelligence;
        }

        public static int Conclusion()
        {
            Console.WriteLine("You exit the market. After the time you spent browsing, more of the city's residents have started their days,\nand the streets have gotten a bit more crowded. As you navigate them, you hear your stomach growl. ");
            Console.WriteLine("Up to this point you haven't eaten breakfast. Better late than never to grab some food.");
            Console.WriteLine("Finding somewhere to eat would let you explore the city a bit more. You quickly scan the streets,\nand then head off in a random direction in hopes of finding somewhere to eat.");

            switch (tier1choicenum)
            {
                case 1:
                    t1o = 1;
                    break;
                case 2:
                    t1o = 2;
                    break;
                case 3:
                    t1o = 3;
                    break;
                default:
                    Console.WriteLine("I don't know how no Scenario is playing right now, but without that the game can't continue.\nLooks like we'll have to abort.");
                    Environment.Exit(0);
                    break;
            }

            return t1o;
        }

    }
}
