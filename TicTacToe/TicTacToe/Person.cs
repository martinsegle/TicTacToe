namespace TicTacToe
{
    static class Person
    {

        //Pārbaude, vai kāds spēlētājs ir uzvarējis vai nav uzvarējis
        public static int CheckWin(string[] arr)
        {

            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            //    Ja visas šūnas vai vērtības ir aizpildītas ar X vai O, tad neviens spēlētājs nav uzvarējis
            else if (arr[1] == "1" && arr[2] == "2" && arr[3] == "3" && arr[4] == "4" && arr[5] == "5" && arr[6] == "6" && arr[7] == "7" && arr[8] == "8" && arr[9] == "9")
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }

    }
}


