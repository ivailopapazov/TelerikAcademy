namespace IfStatementsRefactor
{
    using CheffClassRefactor;
    using System;

    class IfStatementsRefactor
    {

        //Task 1
        private static void Cook(Potato potato)
        {
            Console.WriteLine("Potato is cooking...");
        }

        static void Main()
        {
            Potato potato = new Potato();
            potato.IsPeeled = true;
            
            if (potato != null)
            {
                if (potato.IsPeeled && !potato.isRotten)
                {
                    Cook(potato);
                }
            }

            //Task 2
            const int MIN_X_VALUE = 0;
            const int MAX_X_VALUE = 13;

            const int MIN_Y_VALUE = 2;
            const int MAX_Y_VALUE = 15;

            
            int x = 5;
            int y = 7;
            bool isVisitedCell = false;

            bool positionXIsInRange = MIN_X_VALUE <= x && x <= MAX_X_VALUE;
            bool positionYIsInRange = MIN_Y_VALUE <= y && y <= MAX_Y_VALUE;
            
            if ((positionXIsInRange && positionYIsInRange) && !isVisitedCell)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            Console.WriteLine("The cell is now visited.");
        }
    }
}
