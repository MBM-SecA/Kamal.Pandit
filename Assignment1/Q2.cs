/* 
2) Create a function that takes the number of wins, draws and losses, and calculates the number of points a football team has obtained so far.
RULES:
 wins get 5 points
 draws get 2 point
 losses get 0 points
 */
public class PointCalculation
{
    internal int CalculatePoints(int wins ,int draws,int losses)
    {
    
        return(wins*5+ draws*2 + losses*0);

    }
}