using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPrac.Algorithms.DepthFirstSearch
{
    // Average: O(v+e) time | O(v) space where v = vertices and e = edges
    public class DFS
    {
        public string name;
 
        public IList<DFS> children = new List<DFS>();

        public DFS(string name)
        {
            this.name = name;
        }

        public List<string> DepthFirstSearchV2(List<string> array)
        {
            array.Add(this.name);

            foreach (var c in children)
                c.DepthFirstSearchV2(array);

            return array;
        }

        public DFS AddChild(string name)
        {
            var child = new DFS(name);
            children.Add(child);
            return this;
        }
    }
}
