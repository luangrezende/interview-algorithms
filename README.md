# Interview Algorithms (C#)

![Build](https://github.com/luangrezende/interview-algorithms/workflows/CI/badge.svg)
![.NET](https://img.shields.io/badge/.NET-6.0+-512BD4?logo=dotnet)
![C#](https://img.shields.io/badge/C%23-11+-239120?logo=csharp)
![License](https://img.shields.io/badge/License-MIT-blue)

A curated collection of **algorithms and data structures implemented in C#**, designed for **technical interview preparation, reasoning practice, and algorithmic fundamentals**.

This repository prioritizes **clarity, correctness, and explicit trade-offs** over competitive programming shortcuts or framework-heavy abstractions.

---

## Overview

The project provides:
- Clean implementations of common interview algorithms
- Explicit time and space complexity considerations
- Simple benchmarking to observe real execution behavior
- An interactive console entry point for exploration

All implementations favor **readability and reasoning** over micro-optimizations.

---

## Key Characteristics

- Modern C# (.NET 6+)
- Deterministic, easy-to-follow implementations
- Isolated algorithm categories
- Cross-platform execution
- CI-validated builds

---

## Project Structure

```
interview-algorithms/
├── Program.cs                 # Interactive entry point
├── sorting/                   # Sorting algorithms
├── searching/                 # Search algorithms
├── dynamicProgramming/        # DP problems
├── graphs/                    # Graph traversal and shortest paths
├── trees/                     # Tree structures and traversals
├── strings/                   # String algorithms
├── greedy/                    # Greedy strategies
├── leetCode/                  # Interview-style problems
└── types/                     # Custom data structures
```

Each folder contains **self-contained implementations** focused on a single concept.

---

## Included Algorithms

### Sorting
- Bubble Sort
- Selection Sort
- Insertion Sort
- Merge Sort
- Quick Sort
- Heap Sort

### Searching
- Linear Search
- Binary Search

### Dynamic Programming
- Fibonacci (memoization / tabulation)
- Knapsack variants

### Graphs
- DFS / BFS
- Dijkstra (shortest path)

### Trees
- Binary Search Tree
- Traversal algorithms

### Strings
- Naive matching
- KMP
- Rabin–Karp

### Greedy
- Activity selection
- Fractional knapsack
- Huffman coding

### Interview Problems
- Two Sum
- Median of sorted arrays
- Longest substring without repetition
- String comparison problems

---

## Getting Started

### Requirements
- .NET 6 SDK or newer
- Any C# compatible IDE

### Setup

```bash
git clone https://github.com/luangrezende/interview-algorithms.git
cd interview-algorithms
dotnet restore
dotnet build
dotnet run
```

The console menu allows selecting and running individual algorithms.

---

## Benchmarking

Basic execution timing is included to illustrate:
- Relative performance differences
- Impact of input size
- Algorithmic trade-offs

This is intended for **learning**, not for precise performance measurement.

---

## Scope and Intent

This repository is not intended as:
- A competitive programming toolkit
- A production-grade algorithms library
- A heavily optimized benchmark suite

It is intended as:
- A structured interview preparation reference
- A reasoning and implementation practice space
- A clean baseline for algorithm discussions

---

## Roadmap

- Expand unit test coverage
- Add complexity annotations per algorithm
- Introduce additional graph algorithms
- Improve benchmark isolation

---

## License

MIT License.
