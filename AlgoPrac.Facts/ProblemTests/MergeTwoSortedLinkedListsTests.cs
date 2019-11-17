using AlgoPrac.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AlgoPrac.Facts.ProblemTests
{
    public class MergeTwoSortedLinkedListsTests
    {
        [Fact]
        public void MergeTwoSortedLinkedListsTest()
        {
            var l1 = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(4)
                }
            };

            var l2 = new ListNode(1)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                }
            };

            var expected = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                            {
                                next = new ListNode(4)
                            }
                        }
                    }
                }
            };

            var actual = MergeTwoSortedLinkedLists.MergeSolution(l1, l2);
        }
    }
}
