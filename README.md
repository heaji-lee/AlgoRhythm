# AlgoRhythm 🎶

> On the way to becoming the best **AlgoRhythmer** 👩‍🎤 (get it? algorithm + rhythm 🥁🤪)

Welcome to **AlgoRhythm** - my personal playground for solving algorithm problems, learning, experimenting, and tracking progress one LeetCode problem at a time.

## Purpose
This project is my attempt to:

1. Solve daily algorithm problems and build muscle memory for coding interviews.

2. Keep all solutions organised by difficulty: Easy, Medium, Hard.

3. Write tests for each problem to verify correctness.

4. Track problem-solving strategies with pseudocode and personal notes.

I'll try to use as little AI help as possible for solving problems - it's all me, pseudocode and a bit of Bad Bunny 🐰

## Project Structure
```
AlgoRhythm/
├── AlgoRhythm.Problems/.  # Allproblem solutions
│   ├── Easy/
│   ├── Medium/
│   └── Hard/
├── AlgoRhythm.Tests/.     # xUnit tests for each problem
└── AlgoRhythm.slnx
```

* Problems: One class per problem, named after the problem (e.g., `TwoSum.cs`)

* Tests: Each problem has a corresponding `[Fact]` test class. Tests verify correctness and edge cases.

* Runner: Friendly console app that prints test results and sample outputs in a readable dashboard format.

## How ro Run

1. Run tests via dotnet test
```bash
dotnet test
```

* Runs all xUnit tests

* Use a filter to run specific tests only:
``` bash
dotnet test --filter FullyQualifiedName~TwoSumTests
```

## Notes

* This is a personal learning project.








