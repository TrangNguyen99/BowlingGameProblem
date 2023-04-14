using BowlingGameProblem;

// Test 1
var bowlingGame1 = new BowlingGame();

bowlingGame1.Roll(new int[] { 4, 3 });
bowlingGame1.Roll(new int[] { 10 });
bowlingGame1.Roll(new int[] { 4, 5 });
bowlingGame1.Roll(new int[] { 1, 3 });
bowlingGame1.Roll(new int[] { 0, 4 });
bowlingGame1.Roll(new int[] { 2, 5 });
bowlingGame1.Roll(new int[] { 8, 0 });
bowlingGame1.Roll(new int[] { 9, 1 });
bowlingGame1.Roll(new int[] { 6, 2 });
bowlingGame1.Roll(new int[] { 2, 8, 3 });

Console.WriteLine(bowlingGame1.Score()); // 95

// Test 2
var bowlingGame2 = new BowlingGame();

bowlingGame2.Roll(new int[] { 10 });
bowlingGame2.Roll(new int[] { 10 });
bowlingGame2.Roll(new int[] { 10 });
bowlingGame2.Roll(new int[] { 10 });
bowlingGame2.Roll(new int[] { 10 });
bowlingGame2.Roll(new int[] { 10 });
bowlingGame2.Roll(new int[] { 10 });
bowlingGame2.Roll(new int[] { 10 });
bowlingGame2.Roll(new int[] { 10 });
bowlingGame2.Roll(new int[] { 10, 10, 10 });

Console.WriteLine(bowlingGame2.Score()); // 300
