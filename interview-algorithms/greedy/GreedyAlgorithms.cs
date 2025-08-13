namespace interview_algorithms.greedy
{
    public class ActivitySelection
    {
        public class Activity
        {
            public int Start { get; set; }
            public int End { get; set; }
            public string Name { get; set; } = "";
        }
        
        public static void Run()
        {
            Console.WriteLine("Starting Activity Selection Problem...");
            
            Activity[] activities = {
                new Activity { Start = 1, End = 3, Name = "A1" },
                new Activity { Start = 3, End = 5, Name = "A2" },
                new Activity { Start = 0, End = 6, Name = "A3" },
                new Activity { Start = 5, End = 7, Name = "A4" },
                new Activity { Start = 8, End = 9, Name = "A5" },
                new Activity { Start = 5, End = 9, Name = "A6" }
            };
            
            var selectedActivities = SelectActivities(activities);
            
            Console.WriteLine("Selected activities:");
            foreach (var activity in selectedActivities)
            {
                Console.WriteLine($"{activity.Name}: Start={activity.Start}, End={activity.End}");
            }
        }
        
        public static List<Activity> SelectActivities(Activity[] activities)
        {
            // Sort activities by their end time
            Array.Sort(activities, (a, b) => a.End.CompareTo(b.End));
            
            List<Activity> selected = new List<Activity>();
            
            // The first activity is always selected
            selected.Add(activities[0]);
            int lastSelected = 0;
            
            // Consider remaining activities
            for (int i = 1; i < activities.Length; i++)
            {
                // If this activity starts after the last selected activity ends
                if (activities[i].Start >= activities[lastSelected].End)
                {
                    selected.Add(activities[i]);
                    lastSelected = i;
                }
            }
            
            return selected;
        }
    }
    
    public class FractionalKnapsack
    {
        public class Item
        {
            public int Value { get; set; }
            public int Weight { get; set; }
            public string Name { get; set; } = "";
            public double ValuePerWeight => (double)Value / Weight;
        }
        
        public static void Run()
        {
            Console.WriteLine("Starting Fractional Knapsack Problem...");
            
            Item[] items = {
                new Item { Value = 60, Weight = 10, Name = "Item1" },
                new Item { Value = 100, Weight = 20, Name = "Item2" },
                new Item { Value = 120, Weight = 30, Name = "Item3" }
            };
            
            int capacity = 50;
            double maxValue = SolveFractionalKnapsack(items, capacity);
            
            Console.WriteLine($"Maximum value in knapsack: {maxValue:F2}");
        }
        
        public static double SolveFractionalKnapsack(Item[] items, int capacity)
        {
            // Sort items by value per weight in descending order
            Array.Sort(items, (a, b) => b.ValuePerWeight.CompareTo(a.ValuePerWeight));
            
            double totalValue = 0;
            int currentWeight = 0;
            
            foreach (var item in items)
            {
                if (currentWeight + item.Weight <= capacity)
                {
                    // Take the whole item
                    totalValue += item.Value;
                    currentWeight += item.Weight;
                    Console.WriteLine($"Taking full {item.Name}: Value={item.Value}, Weight={item.Weight}");
                }
                else
                {
                    // Take fraction of the item
                    int remainingCapacity = capacity - currentWeight;
                    double fraction = (double)remainingCapacity / item.Weight;
                    totalValue += item.Value * fraction;
                    Console.WriteLine($"Taking {fraction:P} of {item.Name}: Value={item.Value * fraction:F2}, Weight={remainingCapacity}");
                    break;
                }
            }
            
            return totalValue;
        }
    }
    
    public class HuffmanCoding
    {
        public class Node
        {
            public char Character { get; set; }
            public int Frequency { get; set; }
            public Node? Left { get; set; }
            public Node? Right { get; set; }
            
            public bool IsLeaf => Left == null && Right == null;
        }
        
        public static void Run()
        {
            Console.WriteLine("Starting Huffman Coding...");
            
            var frequencies = new Dictionary<char, int>
            {
                { 'a', 5 },
                { 'b', 9 },
                { 'c', 12 },
                { 'd', 13 },
                { 'e', 16 },
                { 'f', 45 }
            };
            
            var codes = BuildHuffmanCodes(frequencies);
            
            Console.WriteLine("Huffman Codes:");
            foreach (var kvp in codes.OrderBy(x => x.Key))
            {
                Console.WriteLine($"'{kvp.Key}': {kvp.Value}");
            }
        }
        
        public static Dictionary<char, string> BuildHuffmanCodes(Dictionary<char, int> frequencies)
        {
            var priorityQueue = new List<Node>();
            
            // Create leaf nodes for each character
            foreach (var kvp in frequencies)
            {
                priorityQueue.Add(new Node 
                { 
                    Character = kvp.Key, 
                    Frequency = kvp.Value 
                });
            }
            
            // Build the Huffman tree
            while (priorityQueue.Count > 1)
            {
                // Sort by frequency
                priorityQueue.Sort((a, b) => a.Frequency.CompareTo(b.Frequency));
                
                // Take two nodes with minimum frequency
                var left = priorityQueue[0];
                var right = priorityQueue[1];
                priorityQueue.RemoveRange(0, 2);
                
                // Create internal node
                var merged = new Node
                {
                    Character = '\0', // Internal node
                    Frequency = left.Frequency + right.Frequency,
                    Left = left,
                    Right = right
                };
                
                priorityQueue.Add(merged);
            }
            
            // Generate codes
            var codes = new Dictionary<char, string>();
            if (priorityQueue.Count > 0)
            {
                GenerateCodes(priorityQueue[0], "", codes);
            }
            
            return codes;
        }
        
        private static void GenerateCodes(Node? node, string code, Dictionary<char, string> codes)
        {
            if (node == null)
                return;
                
            if (node.IsLeaf)
            {
                codes[node.Character] = code.Length > 0 ? code : "0";
                return;
            }
            
            GenerateCodes(node.Left, code + "0", codes);
            GenerateCodes(node.Right, code + "1", codes);
        }
    }
}
