namespace AlgoRhythm.Problems.Easy;

public class ClimbingStairs {
  public int Solve(int n) {
//     You are climbing a staircase. It takes n steps to reach the top.

// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

// Example 1:

// Input: n = 2
// Output: 2
// Explanation: There are two ways to climb to the top.
// 1. 1 step + 1 step
// 2. 2 steps
// Example 2:

// Input: n = 3
// Output: 3
// Explanation: There are three ways to climb to the top.
// 1. 1 step + 1 step + 1 step
// 2. 1 step + 2 steps
// 3. 2 steps + 1 step

//5
// 1 + 1 1 1 1
// 1 1 1 2
// 1 1 2 1
// 1 2 1 1
// 2 1 1 1
// 2 2 1
    // n % 2

    if (n <= 2) return n;

    int a = 1;
    int b = 2;

    for (int i = 3; i <= n; i++) {
      int temp = a + b; // 3 // 5 // 8
      a = b; // a=1 b=2 a=2; // a=2 b=3 a=3 // a=3 b=5 a=5
      b = temp; // b=2 temp=3 b=3 // b=3 temp=5 b=5; // 8
    }
    return b;
  }
}
