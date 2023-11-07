using MovieRental;

namespace MovieRentalTest
{
    public class Tests
    {
        private Customer _customer;
        
        private readonly Movie _regular1 = new Movie("Regular 1", Movie.Regular);
        private readonly Movie _regular2 = new Movie("Regular 2", Movie.Regular);
        private readonly Movie _regular3 = new Movie("Regular 3", Movie.Regular);

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMultipleRegularStatement()
        {
            _customer = new Customer("Customer Name");
            _customer.AddRental(new Rental(_regular1, 1));
            _customer.AddRental(new Rental(_regular2, 2));
            _customer.AddRental(new Rental(_regular3, 3));

            var statement = _customer.Statement();
            Assert.That(statement.Contains($"Amount owed is 7.5"));
            Assert.That(statement.Contains($"You earned 3 frequent renter points"));

        }




    }
}