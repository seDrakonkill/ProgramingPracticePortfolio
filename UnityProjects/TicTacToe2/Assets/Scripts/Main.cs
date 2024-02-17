using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // The purpose of this project is to get me reacquainted with Unity.
    // Time line to completion is End of Night January 16, 2024


    public char[,] activeGameBoard = { { "", "", ""},
                                       { "", "", ""},
                                       { "", "", ""}}
    void Start()
    { 
            
            
            
            
     /*2 Modes
            Vs Player and Vs AI
            
        vs Player will simply alter what type of letter the clicking puts 

        vs AI will put select out of a random pool of ais with different styles.
                1 will focus on blocking
                1 will try to fill out a certain strat
                1 will place randomly


        There will be 2 game spaces < Menu and Gameplay.
            Menu will have 

                TicTacToe
                  vs AI
                  vs Player
        
        Gameplay will have a TicTacToe grid in middle of screen. 
        
        Both Game spaces will have the volume in the lower right, lowering and raise similar to an iphone screen.
          
        UI will be handled under UI script, including bolume. 

        X Place and O Place will have different sounds

        Co-Op Letter placing will be controlled in mouse, communicating to the gameboard.

        Each 'AI' will have its own script, controlling the placement, by talking to the gameboard

        Gameboard will control the Letters coming onto the board from beyond where the camera lies.

        Main Menu will be controlled by 1 script alone.

        Camera has no script plans, as I see no reason for it to move.
        */


    }

    // Update is called once per frame
    void Update()
    {

    }

    void ResetGameBoard()
    {
       activeGameBoard =  {{ "", "", ""}, 
                           { "", "", ""}, 
                           { "", "", ""}}
    }

    void InsertChar(int vert, int hori, char token)  //click on a gameboard square will pass the coords of the gameboard square along with the character to be inserted. It should be formatted (0,2, x) This is the top most line, all the way right, inserting an x). The game will have already checked for the spot 
    {
        if (activeGameBoard[vert, hori] == "")
        {
            activeGameBoard[vert, hori] = token;
        }

        else
        {
            //Make return the function
        }
    }
}
