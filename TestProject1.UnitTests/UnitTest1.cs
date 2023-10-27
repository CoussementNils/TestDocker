namespace TestProject1.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            bool shouldPassTest = false;

            //Act
            shouldPassTest = !!shouldPassTest;

            //Assert
            Assert.True(shouldPassTest);
        }
    }
}