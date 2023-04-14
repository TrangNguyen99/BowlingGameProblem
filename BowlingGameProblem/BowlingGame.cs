namespace BowlingGameProblem
{
    public class BowlingGame
    {
        public const int FRAME = 10;
        public const int PIN = 10;

        private readonly List<int[]> Frames = new();

        public void Roll(int[] frame)
        {
            Frames.Add(frame);
        }

        public int Score()
        {
            var score = 0;

            for (var i = 0; i < FRAME; i++)
            {
                score += Frames[i].Sum();

                if (i != FRAME - 1)
                {
                    if (IsStrike(Frames[i]))
                    {
                        if (Frames[i + 1].Length == 1)
                        {
                            score += Frames[i + 1][0] + Frames[i + 2][0];
                        }
                        else
                        {
                            score += Frames[i + 1][0] + Frames[i + 1][1];
                        }
                    }
                    else if (IsSpare(Frames[i]))
                    {
                        score += Frames[i + 1][0];
                    }
                }
            }

            return score;
        }

        private static bool IsStrike(int[] frame)
        {
            return frame[0] == PIN;
        }

        private static bool IsSpare(int[] frame)
        {
            return frame[0] != PIN && frame.Sum() == PIN;
        }
    }
}
