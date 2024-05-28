namespace beginner;

public class ComputerPlayer : IPlayer
{

  private Random _rng = new Random();

  public Choice GetChoice()
  {

    Choice p2 = (Choice)_rng.Next(0, 3);
    Console.WriteLine($"Player 2 picked {p2}");

    return p2;
  }
}
