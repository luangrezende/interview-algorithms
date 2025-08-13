# Interview Algorithms - C#

[![Build Status](https://github.com/luangrezende/interview-algorithms/workflows/CI/badge.svg)](https://github.com/luangrezende/interview-algorithms/actions)
[![.NET](https://img.shields.io/badge/.NET-6.0+-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-11.0+-239120?style=flat-square&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square)](LICENSE)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)](http://makeapullrequest.com)
[![GitHub issues](https://img.shields.io/github/issues/luangrezende/interview-algorithms?style=flat-square)](https://github.com/luangrezende/interview-algorithms/issues)
[![GitHub stars](https://img.shields.io/github/stars/luangrezende/interview-algorithms?style=flat-square)](https://github.com/luangrezende/interview-algorithms/stargazers)

A comprehensive collection of essential algorithms and data structures implementations in C#, perfect for technical interviews, competitive programming, and algorithm study.

## Features

- **Interactive Console Application**: Run and compare different algorithms
- **Performance Benchmarking**: Execution time measurements for all algorithms
- **Well-documented Code**: Clear, readable implementations with comments
- **Real Interview Problems**: LeetCode and common interview questions
- **Educational Examples**: Learn algorithm complexities and use cases
- **CI/CD Pipeline**: Automated build and testing
- **.NET 6+ Support**: Modern C# implementation

## Quick Start

### Prerequisites
![.NET](https://img.shields.io/badge/.NET-6.0%2B-512BD4?style=flat-square&logo=dotnet)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022-5C2D91?style=flat-square&logo=visual-studio)

### Installation

```bash
# Clone the repository
git clone https://github.com/luangrezende/interview-algorithms.git

# Navigate to project directory
cd interview-algorithms/interview-algorithms

# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the application
dotnet run
```

### Using GitHub Codespaces
[![Open in GitHub Codespaces](https://img.shields.io/badge/Open%20in-Codespaces-informational?style=flat-square&logo=github)](https://codespaces.new/luangrezende/interview-algorithms)

## Code Quality & Statistics

[![Code Quality](https://img.shields.io/codacy/grade/your-project-id?style=flat-square&logo=codacy)](https://app.codacy.com/gh/luangrezende/interview-algorithms)
[![Maintainability](https://img.shields.io/codeclimate/maintainability/luangrezende/interview-algorithms?style=flat-square&logo=code-climate)](https://codeclimate.com/github/luangrezende/interview-algorithms)
[![Lines of Code](https://img.shields.io/tokei/lines/github/luangrezende/interview-algorithms?style=flat-square)](https://github.com/luangrezende/interview-algorithms)
[![Languages](https://img.shields.io/github/languages/count/luangrezende/interview-algorithms?style=flat-square)](https://github.com/luangrezende/interview-algorithms)
[![Top Language](https://img.shields.io/github/languages/top/luangrezende/interview-algorithms?style=flat-square)](https://github.com/luangrezende/interview-algorithms)

## Project Structure

```
interview-algorithms/
├── Program.cs                          # Main interactive menu
├── sorting/                            # Sorting Algorithms
│   ├── BubbleSort.cs                  # O(n²) - Simple comparison sort
│   ├── QuickSort.cs                   # O(n log n) - Divide and conquer
│   ├── MergeSort.cs                   # O(n log n) - Stable divide and conquer
│   ├── SelectionSort.cs               # O(n²) - In-place comparison sort
│   ├── InsertionSort.cs               # O(n²) - Adaptive sort
│   ├── HeapSort.cs                    # O(n log n) - Binary heap based
│   └── core/
│       └── Builders.cs                # Utility for generating test data
├── searching/                          # Searching Algorithms
│   ├── LinearSearch.cs                # O(n) - Sequential search
│   └── BinarySearch.cs                # O(log n) - Divide and conquer search
├── dynamicProgramming/                 # Dynamic Programming
│   ├── Fibonacci.cs                   # Classic DP problem with optimizations
│   └── KnapsackProblem.cs            # 0/1 and fractional knapsack variants
├── graphs/                            # Graph Algorithms
│   ├── Graph.cs                       # DFS, BFS, cycle detection
│   └── DijkstraAlgorithm.cs          # Shortest path algorithm
├── trees/                             # Tree Algorithms
│   └── BinarySearchTree.cs           # BST with traversals and operations
├── strings/                           # String Algorithms
│   └── StringMatching.cs             # Naive, KMP, and Rabin-Karp
├── greedy/                            # Greedy Algorithms
│   └── GreedyAlgorithms.cs           # Activity selection, knapsack, Huffman
├── leetCode/                          # LeetCode Problems
│   ├── TwoSum.cs                     # Hash table approach
│   ├── FindMedianSortedArrays.cs     # Binary search approach
│   ├── LengthOfLongestSubstring.cs   # Sliding window
│   └── DetermineifStringHalvesAreAlike.cs
└── types/                             # Custom Data Structures
    └── Array.cs                       # Dynamic array implementation
```

## Getting Started

### Prerequisites
- .NET 6.0 or later
- Visual Studio 2022 or VS Code

### Running the Application

1. Clone the repository:
```bash
git clone https://github.com/luangrezende/interview-algorithms.git
cd interview-algorithms
```

2. Build and run:
```bash
dotnet build
dotnet run --project interview-algorithms
```

3. Use the interactive menu to explore different algorithm categories.

## Algorithm Categories

### 1. Sorting Algorithms
| Algorithm | Time Complexity | Space Complexity | Stable | In-place | Best For |
|-----------|----------------|------------------|--------|----------|----------|
| ![Bubble Sort](https://img.shields.io/badge/Bubble-Sort-orange?style=flat-square) | O(n²) | O(1) | ✅ | ✅ | Educational |
| ![Selection Sort](https://img.shields.io/badge/Selection-Sort-red?style=flat-square) | O(n²) | O(1) | ❌ | ✅ | Small datasets |
| ![Insertion Sort](https://img.shields.io/badge/Insertion-Sort-yellow?style=flat-square) | O(n²) | O(1) | ✅ | ✅ | Nearly sorted |
| ![Merge Sort](https://img.shields.io/badge/Merge-Sort-green?style=flat-square) | O(n log n) | O(n) | ✅ | ❌ | Large datasets |
| ![Quick Sort](https://img.shields.io/badge/Quick-Sort-blue?style=flat-square) | O(n log n) | O(log n) | ❌ | ✅ | General purpose |
| ![Heap Sort](https://img.shields.io/badge/Heap-Sort-purple?style=flat-square) | O(n log n) | O(1) | ❌ | ✅ | Memory limited |

### 2. Searching Algorithms
| Algorithm | Time Complexity | Space Complexity | Requirements | Use Case |
|-----------|----------------|------------------|--------------|----------|
| ![Linear Search](https://img.shields.io/badge/Linear-Search-lightblue?style=flat-square) | O(n) | O(1) | None | Unsorted data |
| ![Binary Search](https://img.shields.io/badge/Binary-Search-darkblue?style=flat-square) | O(log n) | O(1) | Sorted array | Large sorted data |

### 3. Dynamic Programming
| Algorithm | Optimization | Applications | Difficulty |
|-----------|-------------|--------------|------------|
| ![Fibonacci](https://img.shields.io/badge/Fibonacci-DP-gold?style=flat-square) | Memoization/Tabulation | Sequence problems | ![Beginner](https://img.shields.io/badge/Level-Beginner-green?style=flat-square) |
| ![Knapsack](https://img.shields.io/badge/Knapsack-Problem-goldenrod?style=flat-square) | 2D DP optimization | Resource allocation | ![Intermediate](https://img.shields.io/badge/Level-Intermediate-orange?style=flat-square) |

### 4. Graph Algorithms
| Algorithm | Time Complexity | Use Case | Implementation |
|-----------|----------------|----------|----------------|
| ![DFS](https://img.shields.io/badge/DFS-Traversal-forestgreen?style=flat-square) | O(V + E) | Path finding, cycle detection | Recursive/Stack |
| ![BFS](https://img.shields.io/badge/BFS-Traversal-limegreen?style=flat-square) | O(V + E) | Shortest path (unweighted) | Queue |
| ![Dijkstra](https://img.shields.io/badge/Dijkstra-Shortest%20Path-darkgreen?style=flat-square) | O(V² / E log V) | Weighted shortest path | Priority Queue |

### 5. Tree Algorithms
- **Binary Search Tree**: Insert, search, delete, and traversals
- **Tree Traversals**: Inorder, preorder, postorder

### 6. String Algorithms
- **Naive String Matching**: O(nm) brute force approach
- **KMP Algorithm**: O(n+m) with failure function
- **Rabin-Karp**: O(n+m) using rolling hash

### 7. Greedy Algorithms
- **Activity Selection**: Maximize non-overlapping activities
- **Fractional Knapsack**: Maximize value with weight constraint
- **Huffman Coding**: Optimal prefix-free encoding

## LeetCode Problems Included

1. **Two Sum** - Hash table solution
2. **Find Median of Sorted Arrays** - Binary search approach
3. **Longest Substring Without Repeating Characters** - Sliding window
4. **Determine if String Halves Are Alike** - String manipulation

## Performance Benchmarking

Each algorithm includes execution time measurements to help you understand:
- Real-world performance differences
- Impact of input size on running time
- Trade-offs between time and space complexity

## Compatibility & Requirements

### Supported Platforms
![Windows](https://img.shields.io/badge/Windows-0078D6?style=flat-square&logo=windows&logoColor=white)
![macOS](https://img.shields.io/badge/macOS-000000?style=flat-square&logo=apple&logoColor=white)
![Linux](https://img.shields.io/badge/Linux-FCC624?style=flat-square&logo=linux&logoColor=black)

### .NET Version
![.NET 6](https://img.shields.io/badge/.NET-6.0-512BD4?style=flat-square&logo=dotnet)

### Development Environment
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022-5C2D91?style=flat-square&logo=visual-studio)
![VS Code](https://img.shields.io/badge/VS%20Code-007ACC?style=flat-square&logo=visual-studio-code)

## Testing

The project includes comprehensive test cases and performance comparisons. Each algorithm can be tested with:
- Random data sets
- Edge cases (empty, single element, already sorted)
- Different input sizes for complexity analysis

## Contributing

![Contributions Welcome](https://img.shields.io/badge/Contributions-Welcome-brightgreen?style=flat-square)
![Good First Issue](https://img.shields.io/badge/Good%20First%20Issue-Available-blue?style=flat-square)
![Help Wanted](https://img.shields.io/badge/Help%20Wanted-orange?style=flat-square)

Contributions are welcome! Please feel free to submit a Pull Request. 

### How to Contribute
1. **Fork** the repository
2. **Create** a feature branch (`git checkout -b feature/amazing-algorithm`)
3. **Commit** your changes (`git commit -m 'Add amazing algorithm'`)
4. **Push** to the branch (`git push origin feature/amazing-algorithm`)
5. **Open** a Pull Request

### Ideas for Contributions
- ![Algorithm](https://img.shields.io/badge/Add-Algorithms-success?style=flat-square) Additional algorithms (A*, Floyd-Warshall, etc.)
- ![LeetCode](https://img.shields.io/badge/Add-LeetCode-orange?style=flat-square) More LeetCode problems
- ![Visualization](https://img.shields.io/badge/Add-Visualizations-purple?style=flat-square) Algorithm visualizations
- ![Tests](https://img.shields.io/badge/Add-Tests-blue?style=flat-square) Unit tests and benchmarks
- ![Documentation](https://img.shields.io/badge/Improve-Docs-green?style=flat-square) Documentation improvements

## Learning Resources

This implementation is designed for learning. Each algorithm includes:
- Time and space complexity analysis
- Best/worst case scenarios
- When to use each algorithm
- Common interview variations

## Interview Preparation

This repository covers the most commonly asked algorithmic concepts in technical interviews:
- **FAANG Companies**: Sorting, searching, DP, graphs, trees
- **System Design**: Understanding algorithm trade-offs
- **Coding Challenges**: LeetCode-style problems with optimized solutions

## License

This project is open source and available under the [MIT License](LICENSE).

## Author & Community

**Luan Rezende**

[![GitHub](https://img.shields.io/badge/GitHub-luangrezende-181717?style=flat-square&logo=github)](https://github.com/luangrezende)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Connect-0077B5?style=flat-square&logo=linkedin)](https://linkedin.com/in/luangrezende)
[![Email](https://img.shields.io/badge/Email-Contact-D14836?style=flat-square&logo=gmail&logoColor=white)](mailto:luan@example.com)

### Support This Project
If this project helps you with your interview preparation, please consider:

[![Star](https://img.shields.io/github/stars/luangrezende/interview-algorithms?style=social)](https://github.com/luangrezende/interview-algorithms/stargazers)
[![Fork](https://img.shields.io/github/forks/luangrezende/interview-algorithms?style=social)](https://github.com/luangrezende/interview-algorithms/fork)
[![Watch](https://img.shields.io/github/watchers/luangrezende/interview-algorithms?style=social)](https://github.com/luangrezende/interview-algorithms/watchers)

## Project Stats

![GitHub repo size](https://img.shields.io/github/repo-size/luangrezende/interview-algorithms?style=flat-square)
![GitHub last commit](https://img.shields.io/github/last-commit/luangrezende/interview-algorithms?style=flat-square)
![GitHub commit activity](https://img.shields.io/github/commit-activity/m/luangrezende/interview-algorithms?style=flat-square)

---

⭐ **Star this repository** if it helps you with your interview preparation!

![Made with Love](https://img.shields.io/badge/Made%20with-❤️-red?style=flat-square)
![Built with C#](https://img.shields.io/badge/Built%20with-C%23-239120?style=flat-square&logo=c-sharp)
