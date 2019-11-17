using System;

namespace AlgoPrac.DataStructures.BST
{
    public class BST
    {
        public int value;

        public BST left;

        public BST right;

        public BST(int value)
        {
            this.value = value;
        }

        // Average: O(log(n)) time | O(1) space
        // Worse: O(n) time | O(1) space
        public BST Insert(int value)
        {
            var currentNode = this;
            while (true)
            {
                if (value < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = new BST(value);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                else
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = new BST(value);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            }

            return this;
        }

        // Average: O(log(n)) time | O(1) space
        // Worse: O(n) time | O(1) space
        public bool Contains(int value)
        {
            var currentNode = this;
            while (currentNode != null)
            {
                if (value < currentNode.value)
                {
                    currentNode = currentNode.left;
                }
                else if (value > currentNode.value)
                {
                    currentNode = currentNode.right;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        // 6/11 tests passing with v1, see v2 for proper implementation
        public int FindClosestValueV1(int target)
        {
            var currentNode = this;
            var closest = 0;
            while (currentNode != null)
            {
                if (currentNode.value > target)
                {
                    closest = currentNode.value;
                    currentNode = currentNode.left;
                }
                else
                {
                    closest = currentNode.value;
                    currentNode = currentNode.right;
                }
            }

            return closest;
        }

        // Average: O(log(n)) time | O(1) space
        // Worse: O(n) time | O(1) space
        public BST Remove(int value, BST parentNode = null)
        {
            var currentNode = this;
            while (currentNode != null)
            {
                if (value < currentNode.value)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.left;
                }
                else if (value > currentNode.value)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.right;
                }
                else
                {
                    if (currentNode.left != null && currentNode.right != null)
                    {
                        currentNode.value = currentNode.right.GetMinValue();

                        // currentNode.Value = smallest value of right subtree
                        currentNode.right.Remove(currentNode.value, currentNode);
                    }
                    else if (parentNode == null)
                    {
                        if (currentNode.left != null)
                        {
                            currentNode.value = currentNode.left.value;
                            currentNode.right = currentNode.left.right;
                            currentNode.left = currentNode.left.left;
                        }
                        else if (currentNode.right != null)
                        {
                            currentNode.value = currentNode.right.value;
                            currentNode.left = currentNode.right.left;
                            currentNode.right = currentNode.right.right;
                        }
                        else
                        {
                            currentNode = null;
                        }
                    }
                    else if (parentNode.left == currentNode)
                    {
                        parentNode.left = currentNode.left ?? currentNode.right;
                    }
                    else if (parentNode.right == currentNode)
                    {
                        parentNode.right = currentNode.left ?? currentNode.right;
                    }

                    break;
                }
            }

            return this;
        }

        private int GetMinValue()
        {
            var currentNode = this;
            while (currentNode.left != null)
            {
                currentNode = currentNode.left;
            }

            return currentNode.value;
        }
    }
}
