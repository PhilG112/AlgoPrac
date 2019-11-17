using AlgoPrac.DataStructures.BST;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgoPrac.Facts.DataStructureTests
{
    public class BinarySearchTreeTests
    {
        public static BST Test1;

        public BinarySearchTreeTests()
        {
            Test1 = new BST(10);
            Test1.Insert(5).Insert(15).Insert(5).Insert(2).Insert(1).Insert(22).Insert(1)
                .Insert(1).Insert(3).Insert(1).Insert(1).Insert(502).Insert(55000).Insert(204)
                .Insert(205).Insert(207).Insert(206).Insert(203).Insert(-51)
                .Insert(-403).Insert(1001).Insert(57).Insert(60).Insert(4500);
        }

        [Fact]
        public void TestCase1()
        {
            var ok = Test1.left.value == 5;

            Assert.True(ok);
        }

        [Fact]
        public void TestCase2()
        {
            var ok = FindClosestValueV2(Test1, -1);

            Assert.Equal(1, ok);
        }

        // Average: O(log(n)) time | O(1) space where n = number of nodes
        public int FindClosestValueV2(BST tree, int target)
        {
            var currentNode = tree;
            var closest = int.MaxValue / 2;

            while (currentNode != null)
            {
                // e.g (12 - 13) < (12 - 10) == true;
                // Therefore 13 is closer to 12 due to the fact that the absolute difference
                // of (12 - 13) is less than (12 - 10)
                if (Math.Abs(target - closest) > Math.Abs(target - currentNode.value))
                {
                    closest = currentNode.value;
                }

                if (target < currentNode.value)
                {
                     currentNode = currentNode.left;
                }
                else if (target > currentNode.value)
                {
                    currentNode = currentNode.right;
                }
                else
                {
                    break;
                }
            }

            return closest;
        }

        // Average: O(log(n)) time | O(log(n)) space where n = number of nodes
        private int FindClosestValueV2Recursive(BST tree, int target)
        {
            return FindClosestValueV2Helper(tree, target, int.MaxValue);
        }

        private int FindClosestValueV2Helper(BST tree, int target, int closest)
        {
            if (tree == null) return closest;

            if (Math.Abs(target - closest) > Math.Abs(target - tree.value))
            {
                closest = tree.value;
            }

            if (target < tree.value)
            {
                return FindClosestValueV2Helper(tree.left, target, closest);
            }
            else if (target > tree.value)
            {
                return FindClosestValueV2Helper(tree.right, target, closest);
            }
            else
            {
                return closest;
            }
        }

        private static void InOrderTraverse(BST tree, List<int> array)
        {
            if (tree.left != null)
            {
                InOrderTraverse(tree.left, array);
            }

            array.Add(tree.value);

            if (tree.right != null)
            {
                InOrderTraverse(tree.right, array);
            }
        }
    }
}
