using System;
using System.Globalization;

namespace StarWarsRescue
{
    internal class MainGame
    { 
        public static bool AhsokaAlive = true;
        public static bool AhsokaSaved = false;
        public static void Main()
        {
            Console.WriteLine(
                " Welcome to a Text Based Star Wars Rescue game. Your goal is to rescue the mentioned characters and escape alive." +
                "\nSome paths will lead to a successful rescue, some will lead to you and the characters dying. Some will lead to a mix thereof." +
                "\n\nChoose Wisely!\nType Yes or No as an answer ONLY!\nPress Enter one time to start...\n\n\n");
            Console.ReadKey();

            FlowChartTexts Text = new FlowChartTexts();
            Text.StartGame();
        }

        public static bool PickPath()
        {
            string choice = Console.ReadLine().ToString();
            if (choice == "Yes" || choice == "yes" || choice == "eys" || choice == "Eys")
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal class FlowChartTexts
    {
        public virtual void StartGame()
        {
            Console.WriteLine(
                "In a galaxy far, far away...\n\n Ahsoka Tano has crashlanded on an undiscovered planet on the edge of the galaxy." +
                "\n\nHaving heard nothing from her, the Jedi Council decides to send you, a new Jedi Knight, to locate and rescue the duo!" +
                "\n\nShortly after arriving to the planet, you locate the smoldering remains of the ship she was travelling on. All signs point to a cave practically underneath their ship!" +
                "\n\nMere seconds after you enter the cave, the ship collapses, sealing you in. Your saber ignites as you use it as a light. Ahead of you lies two paths, the first of which has the trickle of water echoing out." +
                "\n\nThe second path seems unnaturally silent. You can sense Ahsoka within the caves. Will you take the watery path?");

            if (MainGame.PickPath())
            {
                WateryCave();
            }
            else
            {
                SilentCave();
            }
        }

        public virtual void WateryCave()
        {
            Console.WriteLine("\nThe water echos down the stony hallway as you walk down. The rippling noise grows with each step. After a short while, you emerge into an underground river area, lit only by your saber" +
                "\nThe river fades into the darkness of the cave, both upstream and downstream. Will you go upstream?");
            if (MainGame.PickPath())
            {
                WentUpstream();
            }
            else
            {
                WentDownstream();
            }

        }

        public virtual void SilentCave()
        {
            Console.WriteLine("\nYou step down the rocky entrance, each click of your footfall seemingly louder than the last.  After a tense moment, the pathway opens up into a large cavern." +
               "\nThe blue glow of your saber does not do much to light your way here. From further in, you notice a soft rush of air, methodical, rythmic. You're not sure what it is" +
               "\nWould you like to search the previously silent cave?");
            if (MainGame.PickPath())
            {
                SearchSilentCave();
            }
            else
            {
                BackToCaveStart();
            }
        }

        public virtual void WentUpstream()
        {
            Console.WriteLine("\nYour steps begin to echo amongst the trickling of the river. Before long, a splashing noise starts to sound, and the air in the cave gets brighter" +
                "\nA moment more, you see the light of day crack through the underground waterways mossy entrance. Would you like to exit?");

            if (MainGame.PickPath())
            {
                ExitCaveThroughStream();
            }
            else
            {
                BackToCaveStart();
            }
        }

        public virtual void WentDownstream()
        {   
            Console.WriteLine("\nYour steps begin to clash amongst the growing speed of the river alongside you. Before long, the river turns off sharply to the right, heading further into the darkness." +
                "\nYou can sense a familiar life force ahead... Will you head forward to check out the dark?");
            if (MainGame.PickPath())
            {
                FindAhsokaPinned();
            }
            else
            {
                BackToCaveStart();
            }
        }

        public virtual void SearchSilentCave()
        {
            Console.WriteLine("\nYou spend a moment in the cave searching. You're unable to find Ahsoka. You suspect she might be down the other path. However, you do find the crunched remains of many different animals"+
                "\nWill you turn back?");
            if (MainGame.PickPath())
            {
                MonsterAwakens();
                BackToCaveStart();
            }
            else
            {
                MonsterAwakens();
                StayInSilentCave();
            }
        }
        public virtual void BackToCaveStart()
        {
            Console.WriteLine("\nYou return to the front of the cave. Will you take the watery path?");
            if (MainGame.PickPath())
            {
                WateryCave();
            }
            else
            {
                SilentCave();
            }
        }

        public virtual void FindAhsokaPinned()
        {
            Console.WriteLine("\nYou follow the path before you, your path now slick with water. It's not long before your feeling turns true: Ahsoka is down this path." +
                "\nYou find the injured Jedi Knight pinned beneath some fallen rocks, half drowning in the river. It's all she can do to stay awake. You help unpin her." +
                "\nYou have a medic kit with you here. Will you heal her here before leaving?");
            MainGame.AhsokaSaved = true;
            if (MainGame.PickPath())
            {
                HealAhsokaBeforeLeaving();
                MonsterAwakens();
            }
            else
            {
                HealAhsokAfterLeaving();
                MonsterAwakens();
            }
        }

        public virtual void HealAhsokaBeforeLeaving()
        {//both paths here lead to victory. 
            
            Console.WriteLine("\nYou apply medical gauze and tonic. The two of you run back to the cave entrance, wary of the noises you've heard. From the path of silence, a foul beast emerges." +
                "\nA brown carapice, breath like death, no eyes, a bald head, four huge arms on a thick torso. Will you two fight the monster together?");// You go bring her back to cave start, the monster attacks.
            if (MainGame.PickPath())
            {
                FightMonsterTogether();
            }
            else
            {
                UseForceOnCaveEntranceWithAhsoka();
            }
        }

        public virtual void HealAhsokAfterLeaving()
        {
            Console.WriteLine("\nYou carry the hurting Jedi Knight to the cave entrance, hauling her on your shoulder. As you prepare to treat her wounds, a low rumble then a roar tears through the cave"+
                "\nFrom the shadows of the silent path jets a fearsome creature. A brown carapice, breath like death, no eyes, a bald head, four huge arms on a thick torso."+
                "\nWill you attempt to take on the beast alone?");
            if (MainGame.PickPath())
            {
                FightMonsterAlone();
            }
            else
            {
                RetreatIntoCave();
            }
        }
        public virtual void UseForceOnCaveEntranceWithAhsoka()
        {
            Console.WriteLine("\nUsing the combined might of two Jedi Knights, you push the wreckage of her ship out of the way and escape onto your vessel." +
                "\n\nCongratulations!\n\nYou have rescued Ahsoka Tano and escaped alive!"); // Victory! No more paths needed!
            Console.ReadKey();
        }
        public virtual void ExitCaveThroughStream()
        {
            
            Console.WriteLine("\nYou exit through the sunlit hole in the ceiling, the gentle trickle of the river behind you.");
            if (MainGame.AhsokaSaved)
            {
              Console.WriteLine("\nAlong side you, Ahsoka Tano enjoys the warm sun on this strange planet. A moment more and you two hop on your ship and head back to the Jedi Temple in Corusant.");
              Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nYour mission failed, you prepare to return to Corusant. You fear that you will have to be the one to deliver the news to Jedi Master Anakin.");
                Console.ReadKey();
            }
        }
        public virtual void MonsterAwakens()
        {
            Console.WriteLine("A dull roar echos through the cave system...");
            
        }
        public virtual void FightMonsterAlone()
        {
            Console.WriteLine("\nYour saber shakes slightly as you turn to face the terrible monster ahead of you. Perhaps you could beat it with Ahsoka's help, but you soon learn that facing it alone was folly..." +
                "\nYou saber is soon knocked from your hand and before you can retrieve it, everything goes dark.\n\nYou have lost.");
            Console.ReadKey();
        }
        public virtual void FightMonsterTogether()
        {
            Console.WriteLine("\nTwo more sabers ignite to join yours. A cacophany of whirs disorient the beast. It does not seem used to having a challenge for a meal." +
                "\nBetween the two of you, quick work is made of the beast.");
            UseForceOnCaveEntranceWithAhsoka();
        }

        public virtual void StayInSilentCave()
        {//Both paths here are a loss. The game is as good as over at this point.
            Console.WriteLine("\nYou take a moment to further search the silent cave. And in that moment, you can sense death approach. Behind you, the visage of a ghastly creature takes form on the edge of the light radiated by your saber."+
                "\nWill you fight the beast alone?");
            if (MainGame.PickPath())
            {
                FightMonsterAlone();
            }
            else
            {
                TryToEscape();
            }
        }
        public virtual void TryToEscape()
        {
            Console.WriteLine("\nYou try to escape from the monster that has gotten between you and the door. Dash to the left, zip to the right! But alas..."+
                "\n\nYou're not quick enough. You feel its enourmous hands take hold and hear its mouth open as you brace yourself to become its next prey"+
                "\n\nYou have Lost.");
            Console.ReadKey();
        }

        public virtual void RetreatIntoCave()
        {
            Console.WriteLine("\n You pick up Ahsoka and turn to dash. The monster has repositioned itself between the two caves, unsure of where you will go."+
                "\nWill you head upstream through the watery cave?");
            if (MainGame.PickPath())
            {
                WentUpstream();
            }
            else
            {
                RetreatToSilentCave();
            }
        }

        public virtual void RetreatToSilentCave()
        {
            Console.WriteLine("\nYou grab Ahsoka and run into the silent cave, narrowly avoiding the monsters swipe. It lets out a roar as you head into the main chamber of the silent channel, where some fallen boulders appear on the edge of the saberlight."+
                "\nYou hear the beast coming up behind you. Will you fight the monster solo?"); 
            if (MainGame.PickPath())
            {
                FightMonsterAlone();
            }
            else
            {
                HideInSilentCave();
            }
        }

        public virtual void HideInSilentCave()
        {
            Console.WriteLine("\nYou duck behind the rocks, setting Ahsoka down as gentle as you can while being quick about it. The creature enters the room, trying to find the injured jedi and her companion."+
                "\nWill you treat Ahsoka's wounds before attempting to fight the creature?");
            if (MainGame.PickPath())
            {
                Console.WriteLine("\nYou quickly patch together your Jedi friend."); //Victory
                FightMonsterTogether();
            }
            else
            {
                FightMonsterAlone();//Loss
            }
        }
    }
}
