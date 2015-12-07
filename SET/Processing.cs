﻿namespace SET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class contains variables which can hold every element
    /// and method relating to processing instructions from the
    /// GameBoard.cs class and Data.cs class.
    /// </summary>
    public class Processing
    {
        private Data gameData = new Data();

        public void startGame(int[] options)
        {
            setOptions(options);
            createDeck();
        }

        private void setOptions(int[] options)
        {
            if (options[0] == 0)
                gameData.changeColorMode();
            else if (options[0] == 1)
                gameData.changeBeginnerMode();
            else if (options[0] == 2)
                gameData.changeTutorialMode();
            else if (options[0] == 3)
                gameData.changeTutorialMode();
            gameData.changeNumberOfSets(options[1]);
        }

        private void createDeck()
        {
            gameData.buildDeck();
        }

        public int getNumberUsers()
        {
            return gameData.getUsers();
        }

        public int getUserScore()
        {
            return gameData.getUserScore();
        }

        public List<List<Cards>> getUserSets()
        {
            return gameData.getUserSets();
        }

        public Cards[] getCardsOnBoard()
        {
            return gameData.getCardsOnBoard();
        }

        /// <summary>
        /// method confirms whether three chosen cards are an actual set
        /// after selecting 3 cards and pressing the set button.
        /// </summary>
        /// <param name="cardList"></param>
        /// <returns>boolean true/false</returns>
        public bool ConfirmSet(List<Cards> cardList)
        {
            // true if valid set, false if invalid
            int counter = 0;

            // check if color, number, shade, and shape between all 3 cards are the same or all different
            if (cardList.ElementAt(0).Color == cardList.ElementAt(1).Color && cardList.ElementAt(1).Color == cardList.ElementAt(2).Color)
            {
                counter++;
            }
            else if (cardList.ElementAt(0).Color != cardList.ElementAt(1).Color && cardList.ElementAt(1).Color != cardList.ElementAt(2).Color)
            {
                counter++;
            }

            if (cardList.ElementAt(0).Number == cardList.ElementAt(1).Number && cardList.ElementAt(1).Number == cardList.ElementAt(2).Number)
            {
                counter++;
            }
            else if (cardList.ElementAt(0).Number != cardList.ElementAt(1).Number && cardList.ElementAt(1).Number != cardList.ElementAt(2).Number)
            {
                counter++;
            }

            if (cardList.ElementAt(0).Shade == cardList.ElementAt(1).Shade && cardList.ElementAt(1).Shade == cardList.ElementAt(2).Shade)
            {
                counter++;
            }
            else if (cardList.ElementAt(0).Shade != cardList.ElementAt(1).Shade && cardList.ElementAt(1).Shade != cardList.ElementAt(2).Shade)
            {
                counter++;
            }

            if (cardList.ElementAt(0).Shape == cardList.ElementAt(1).Shape && cardList.ElementAt(1).Shape == cardList.ElementAt(2).Shape)
            {
                counter++;
            }
            else if (cardList.ElementAt(0).Shape != cardList.ElementAt(1).Shape && cardList.ElementAt(1).Shape != cardList.ElementAt(2).Shape)
            {
                counter++;
            }

            // check to see if all 4 stipulations to make a set have been satisfied
            if (counter == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Unfinished
        public bool checkSet(Cards[] set)
        {
            return true;
        }

        // Unfinished
        private bool checkFinish()
        {
            return false;
        }

        // Unfinished
        private void shuffleDeck()
        {

        }
    }
}
