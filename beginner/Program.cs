using beginner;

GameManager gm = new GameManager();

do
{

  RoundResult result = gm.PlayRound();

  if (result == RoundResult.Player1Win)
  {
    Console.WriteLine("Player 1 Wins!");
  }
  else if (result == RoundResult.Player2Win)
  {
    Console.WriteLine("Player 2 Wins!");
  }
  else
  {
    Console.WriteLine("It is a draw!");
  }

  Console.WriteLine("Play Again: Y/N?");
} while (Console.ReadLine().ToUpper() == "Y");