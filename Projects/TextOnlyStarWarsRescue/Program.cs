using System;
using System.Globalization;

namespace StarWarsRescue
{
    internal class MainGame
    {
        public int AhsokaTurnsLeft = 10;//Use this to have "You feel Ahsokas life force fade from the surroundings..." 
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
                Console.WriteLine("You've chosen Option 1");
                return true;
            }
            else
            {
                Console.WriteLine("Option 2 was selected instead");
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
            Console.WriteLine(
                "The water echos down the stony hallway as you walk down. The rippling noise grows with each step. After a short while, you emerge into an underground river area, lit only by your saber" +
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
            Console.WriteLine("You step down the rocky entrance, each click of your footfall seemingly louder than the last.  After a tense moment, the pathway opens up into a large cavern."+
               "\nThe blue glow of your saber does not do much to light your way here. From further in, you notice a soft rush of air, methodical, rythmic. You're not sure what it is"+
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
            Console.WriteLine("Your steps begin to echo amongst the trickling of the river. Before long, a splashing noise starts to sound, and the air in the cave gets brighter"+
                "\nA moment more, you see the light of day crack through the underground waterways mossy entrance. Would you like to exit?"/*Game Text Goes here*/);

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
        {   //Ahsoka is pinned down stream
            Console.WriteLine(/*Game Text Goes here*/);
            if (MainGame.PickPath())
            {
                FindAhsokaPinned(); //This is the "Will you keep going?" option
            }
            else
            {
                BackToCaveStart();
            }
        }

        public virtual void SearchSilentCave()
        {
            Console.WriteLine(/*Game Text Goes here*/);
            if (MainGame.PickPath())
            {
                BackToCaveStart();
            }
            else
            {
                //StayInSilentCave();
            }
        }
        public virtual void BackToCaveStart()
        {
            Console.WriteLine(/*Game Text Goes here*/);
            if (MainGame.PickPath())
            {
                //Put Method that going Option 1 will call
            }
            else
            {
                //Put Method that going Option 2 will call
            }
        }

        public virtual void FindAhsokaPinned()
        {
            Console.WriteLine(/*Game Text Goes here*/);
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
        {
            Console.WriteLine(/*Game Text Goes here*/);
            if (MainGame.PickPath())
            {
                FightMonsterTogether();
            }
            else
            {
                //Put Method that going Option 2 will call
            }
        }

        public virtual void HealAhsokAfterLeaving()
        {
            Console.WriteLine(/*Game Text Goes here*/);
            if (MainGame.PickPath())
            {
                FightMonsterAlone();
            }
            else
            {
                //Put Method that going Option 2 will call
            }
        }

        public virtual void CarryAhsoka()
        {
            Console.WriteLine(/*Game Text Goes here*/);
            if (MainGame.PickPath())
            {
                //Put Method that going Option 1 will call
            }
            else
            {
                //Put Method that going Option 2 will call
            }
        }
        public virtual void UseForceOnCaveEntranceAlone()
        {
            Console.WriteLine(/*Game Text Goes here*/);
            if (MainGame.PickPath())
            {
                //Put Method that going Option 1 will call
            }
            else
            {
                //Put Method that going Option 2 will call
            }
        }

        public virtual void UseForceOnCaveEntranceWithAhsoka()
        {//She has to be healed for this
            Console.WriteLine(/*Game Text Goes here*/);
            if (MainGame.PickPath())
            {
                //Put Method that going Option 1 will call
            }
            else
            {
                //Put Method that going Option 2 will call
            }
        }
        public virtual void ExitCaveThroughStream()
        {
            Console.WriteLine(/*Game Text Goes here*/);
            if (MainGame.PickPath())
            {
                //Put Method that going Option 1 will call
            }
            else
            {
                //Put Method that going Option 2 will call
            }
        }
        public virtual void MonsterAwakens()
        {//This will Autotrigger a bit in. Will trigger early if you search cave. Monster is not supposed to be in cave, can be lost by outrunning it for two turns
            Console.WriteLine(/*Game Text Goes here*/);
            if (MainGame.PickPath())
            {
                //Put Method that going Option 1 will call
            }
            else
            {
                //Put Method that going Option 2 will call
            }
        }
        public virtual void FightMonsterAlone()
        {
            Console.WriteLine(/*Game Text Goes here*/);
            if (MainGame.PickPath())
            {
                //Put Method that going Option 1 will call
            }
            else
            {
                //Put Method that going Option 2 will call
            }
        }
        public virtual void FightMonsterTogether()
        {
            Console.WriteLine(/*Game Text Goes here*/);
            if (MainGame.PickPath())
            {
                //Put Method that going Option 1 will call
            }
            else
            {
                //Put Method that going Option 2 will call
            }
        }

        /*  internal class FaceArt
          {
              public virtual string[] Ahsoka()
              {
                  Console.WriteLine("%%%%%%%%########%%%%%%%%%%%%########%%%%%%%%%%%%");

                  return new string[0];
              }

              public virtual string[] Rex()
              {
                  return new string[0];
              }

              public virtual string[] Anakin()
              {
                  return new string[0];
              }

              public virtual string[] Cody ()
              {
                  return new string[0];
              }
          }*/
    }
}
