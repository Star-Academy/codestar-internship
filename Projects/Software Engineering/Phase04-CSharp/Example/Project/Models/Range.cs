using System;

namespace Project.Models {
    public class Range : IComparable {
        public int Start { get; set; }
        public int End { get; set; }

        public int CompareTo (object obj) {
            var otherObject = (Range) obj;

            var length = this.End - this.Start;
            var otherObjectLength = otherObject.End - otherObject.Start;

            return length - otherObjectLength;
        }

        // public override string ToString () {
        //     return this.Start + "," + this.End;
        // }
    }
}