using Classes_And_Objects.HR;

namespace C_FundamentalsAdvanced.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void PerformWork_Adds_NumberOfHours()
        {
            //Arrange
            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime
                (1979, 1, 16), 25);
            int numberOfHours = 3;
            //Act
            bethany.PerformWork(numberOfHours);

            //Assert
            Assert.Equal(numberOfHours, bethany.NumberOfHoursWorked);
        }

        [Fact]
        public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecified()
        {
            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime
                (1979, 1, 16), 25);
           
            bethany.PerformWork();

            Assert.Equal(1, bethany.NumberOfHoursWorked);
        }
    }
}
