using TestGrading;

namespace TestGrading2.NUnit
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            int score = 80;
            string grade = Grading.GradeCalculator(score);

            Assert.AreEqual(grade, "A");
        }

        [Test]
        public void Test2()
        {
            int score = 74;
            string grade = Grading.GradeCalculator(score);

            Assert.AreEqual(grade, "B");
        }




    }
}