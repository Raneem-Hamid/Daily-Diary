using Daily_Diary;

namespace Daily_Diary_test
{
    public class UnitTest1
    {
        private string testFile = @"..\..\..\test.txt";
        [Fact]
        public void ReadALLTest()
        {
            //Arrange
            File.WriteAllText(testFile, "2002-11-20\n hii ");

            //Act
            var result = DailyDiary.ReadAllDairy(testFile);

            //Assert
            Assert.Equal("2002-11-20\n hii ", result);
        }

        [Fact]
        public void WriteTest()
        {
            //Arrange
            File.WriteAllText(testFile, "2002-11-20\n hii ");

            //Act
            
            var count = DailyDiary.CountDaily(testFile);

            //Assert
            Assert.Equal( count,1);
        }
    }
}