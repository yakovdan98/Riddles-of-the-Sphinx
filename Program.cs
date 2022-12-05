using System;
using Questions;

class Program
{
  static void Main()
  {
    Riddle riddles = new Riddle();

    riddles.addRiddle("What has to be broken before you can use it?", "egg");
    riddles.addRiddle("What is always in front of you but cannot be seen?", "future");
    riddles.addRiddle("What can you break, even if you never pick it up or touch it?", "promise");
    riddles.addRiddle("What gets wet while drying?", "towel");
    riddles.addRiddle("You walk into a room that contains a match, a kerosene lamp, a candle and a fireplace. What would you light first?", "match");

    int level = 1;
    Console.WriteLine("Wanna solve a riddle?");
    if (Console.ReadLine().Equals("yes"))
    {
      while (true && riddles.NumRiddles > 0)
      {



        Random rand = new Random();
        int riddleNum = rand.Next(0, riddles.NumRiddles);

        Console.WriteLine(riddles.RiddleList[riddleNum]);

        if (Console.ReadLine().Equals(riddles.AnswerList[riddleNum]))
        {
          //Console.WriteLine("You passed level " + level);
          Console.WriteLine($"You passed level {level}");
          level++;
          riddles.NumRiddles--;
          riddles.RiddleList.RemoveAt(riddleNum);
          riddles.AnswerList.RemoveAt(riddleNum);
        }
        else
        {
          Console.WriteLine($"you got the riddle wrong, the answer was: {riddles.AnswerList[riddleNum]}");

        }

      }
    }
    if (riddles.NumRiddles == 0)
    {
      Console.WriteLine("Ran out of riddles");
    }

  }
}