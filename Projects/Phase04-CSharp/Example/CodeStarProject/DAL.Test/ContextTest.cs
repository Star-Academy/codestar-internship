using Xunit;

namespace DAL.Test {
    public class ContextTest {
        [Fact]
        public void PrintTest () {
            var context = new Context ();

            var actual = context.Print ();

            var exepcted = 1;

            Assert.Equal (exepcted, actual);
        }
    }
}