using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApplication
{
    public class AVLNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public AVLNode<T> Left { get; set; }
        public AVLNode<T> Right { get; set; }
        public int Height { get; set; }

        public AVLNode(T value)
        {
            Value = value;
            Height = 1;
        }
    }

    public class AVLTree<T> where T : IComparable<T>
    {
        private AVLNode<T> root;

        public void Insert(T value)
        {
            root = Insert(root, value);
        }

        private AVLNode<T> Insert(AVLNode<T> node, T value)
        {
            if (node == null)
            {
                return new AVLNode<T>(value);
            }

            if (value.CompareTo(node.Value) < 0)
            {
                node.Left = Insert(node.Left, value);
            }
            else if (value.CompareTo(node.Value) > 0)
            {
                node.Right = Insert(node.Right, value);
            }

            // Update height
            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            // Balance the node
            return Balance(node);
        }

        private AVLNode<T> Balance(AVLNode<T> node)
        {
            int balanceFactor = GetBalanceFactor(node);

            if (balanceFactor > 1) // Left-heavy
            {
                if (GetBalanceFactor(node.Left) < 0) // Left-Right case
                {
                    node.Left = RotateLeft(node.Left);
                }
                return RotateRight(node); // Left-Left case
            }
            if (balanceFactor < -1) // Right-heavy
            {
                if (GetBalanceFactor(node.Right) > 0) // Right-Left case
                {
                    node.Right = RotateRight(node.Right);
                }
                return RotateLeft(node); // Right-Right case
            }

            return node; // Balanced
        }

        private int GetHeight(AVLNode<T> node) => node?.Height ?? 0;

        private int GetBalanceFactor(AVLNode<T> node) => GetHeight(node.Left) - GetHeight(node.Right);

        private AVLNode<T> RotateRight(AVLNode<T> y)
        {
            AVLNode<T> x = y.Left;
            AVLNode<T> T = x.Right;

            x.Right = y;
            y.Left = T;

            y.Height = 1 + Math.Max(GetHeight(y.Left), GetHeight(y.Right));
            x.Height = 1 + Math.Max(GetHeight(x.Left), GetHeight(x.Right));

            return x;
        }

        private AVLNode<T> RotateLeft(AVLNode<T> x)
        {
            AVLNode<T> y = x.Right;
            AVLNode<T> T = y.Left;

            y.Left = x;
            x.Right = T;

            x.Height = 1 + Math.Max(GetHeight(x.Left), GetHeight(x.Right));
            y.Height = 1 + Math.Max(GetHeight(y.Left), GetHeight(y.Right));

            return y;
        }

        // In-order traversal to retrieve elements in sorted order
        public List<T> InOrder()
        {
            List<T> result = new List<T>();
            InOrder(root, result);
            return result;
        }

        private void InOrder(AVLNode<T> node, List<T> result)
        {
            if (node == null) return;

            InOrder(node.Left, result);
            result.Add(node.Value);
            InOrder(node.Right, result);
        }
    }


}
