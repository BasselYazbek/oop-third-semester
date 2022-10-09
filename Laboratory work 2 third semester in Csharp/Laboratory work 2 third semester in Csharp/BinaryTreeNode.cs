namespace lab2_3semester
{
    class BinaryTreeNode<T> where T : IComparable
    {
        private T data;
        private BinaryTreeNode<T> leftNode;
        private BinaryTreeNode<T> rightNode;

        public T Data { get => data; set => data = value; }
        public BinaryTreeNode<T> LeftNode { get => leftNode; set => leftNode = value; }
        public BinaryTreeNode<T> RightNode { get => rightNode; set => rightNode = value; }
        public BinaryTreeNode(T data)
        {
            Data = data;
            LeftNode = RightNode = null;
        }
    }
}