using System.Collections.Generic;
using System.Linq;
using Project.Models;

namespace Project {
    public class ProblemSovler {
        private readonly int[] array;
        private readonly HashSet<int> set;
        public ProblemSovler (int[] array) {
            this.array = array;
            this.set = new HashSet<int> (array);
        }

        public Range Solve () {
            return array
                .Where (i => !set.Contains (i - 1))
                .Select(i => new Range(){Start = i, End = FindEndOfRange(i)})
                .Max();
        }

        public int FindEndOfRange (int start) {
            int end = start;

            while(set.Contains(end + 1)){
                end++;
            }

            return end;
        }
    }
}