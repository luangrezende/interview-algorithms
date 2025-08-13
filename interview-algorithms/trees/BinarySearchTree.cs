namespace interview_algorithms.trees
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
        
        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    
    public class BinarySearchTree
    {
        private TreeNode? root;
        
        public static void Run()
        {
            Console.WriteLine("Starting Binary Search Tree operations...");
            
            BinarySearchTree bst = new BinarySearchTree();
            
            // Insert values
            int[] values = { 50, 30, 70, 20, 40, 60, 80 };
            foreach (int value in values)
            {
                bst.Insert(value);
            }
            
            Console.WriteLine("Tree traversals:");
            Console.Write("Inorder: ");
            bst.InorderTraversal();
            Console.WriteLine();
            
            Console.Write("Preorder: ");
            bst.PreorderTraversal();
            Console.WriteLine();
            
            Console.Write("Postorder: ");
            bst.PostorderTraversal();
            Console.WriteLine();
            
            Console.WriteLine($"Tree height: {bst.GetHeight()}");
            Console.WriteLine($"Search for 40: {bst.Search(40)}");
            Console.WriteLine($"Search for 90: {bst.Search(90)}");
        }
        
        public void Insert(int value)
        {
            root = InsertRec(root, value);
        }
        
        private TreeNode InsertRec(TreeNode? node, int value)
        {
            if (node == null)
                return new TreeNode(value);
                
            if (value < node.Value)
                node.Left = InsertRec(node.Left, value);
            else if (value > node.Value)
                node.Right = InsertRec(node.Right, value);
                
            return node;
        }
        
        public bool Search(int value)
        {
            return SearchRec(root, value);
        }
        
        private bool SearchRec(TreeNode? node, int value)
        {
            if (node == null)
                return false;
                
            if (value == node.Value)
                return true;
                
            if (value < node.Value)
                return SearchRec(node.Left, value);
            else
                return SearchRec(node.Right, value);
        }
        
        public void InorderTraversal()
        {
            InorderRec(root);
        }
        
        private void InorderRec(TreeNode? node)
        {
            if (node != null)
            {
                InorderRec(node.Left);
                Console.Write(node.Value + " ");
                InorderRec(node.Right);
            }
        }
        
        public void PreorderTraversal()
        {
            PreorderRec(root);
        }
        
        private void PreorderRec(TreeNode? node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " ");
                PreorderRec(node.Left);
                PreorderRec(node.Right);
            }
        }
        
        public void PostorderTraversal()
        {
            PostorderRec(root);
        }
        
        private void PostorderRec(TreeNode? node)
        {
            if (node != null)
            {
                PostorderRec(node.Left);
                PostorderRec(node.Right);
                Console.Write(node.Value + " ");
            }
        }
        
        public int GetHeight()
        {
            return GetHeightRec(root);
        }
        
        private int GetHeightRec(TreeNode? node)
        {
            if (node == null)
                return -1;
                
            return 1 + Math.Max(GetHeightRec(node.Left), GetHeightRec(node.Right));
        }
        
        public void Delete(int value)
        {
            root = DeleteRec(root, value);
        }
        
        private TreeNode? DeleteRec(TreeNode? node, int value)
        {
            if (node == null)
                return node;
                
            if (value < node.Value)
                node.Left = DeleteRec(node.Left, value);
            else if (value > node.Value)
                node.Right = DeleteRec(node.Right, value);
            else
            {
                // Node to be deleted found
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;
                    
                // Node with two children
                node.Value = MinValue(node.Right);
                node.Right = DeleteRec(node.Right, node.Value);
            }
            
            return node;
        }
        
        private int MinValue(TreeNode node)
        {
            int minValue = node.Value;
            while (node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }
            return minValue;
        }
    }
}
