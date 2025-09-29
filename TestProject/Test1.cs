using Library;
namespace TestProject
{
    [TestClass]
    public sealed class Test1
    {

        [TestMethod]
        public void BorrowBook_ShouldMarkBookAsNotAvailable()
        {
            var book = new Book { Title = "Test Title", Author = "Test Author", IsAvailable = true };
            book.Borrow();
            Assert.IsFalse(book.IsAvailable, "The book should not be available after borrowing.");
        }
        [TestMethod]
        public void ReturnBook_ShouldThrowExceptionWhenAlreadyAvailable()
        {
            var book = new Book { Title = "Test Title", Author = "Test Author", IsAvailable = true };
            book.Return();
            Assert.IsTrue(book.IsAvailable, "The book should be available after returning.");
        }
        [TestMethod]
        public void CompareBooks_ShouldReturnTrueWhenBooksAreEqual()
        {
            var book1 = new Book { Title = "Test Title", Author = "Test Author" };
            var book2 = new Book { Title = "Test Title", Author = "Test Author" };
            var areEqual = book1 == book2;
            Assert.IsTrue(areEqual, "Books with the same title and author should be considered equal.");
        }
        [TestMethod]
        public void CheckBookAvailability_ShouldReturnCorrectAvailability()
        {
            var book = new Book { Title = "Test Title", Author = "Test Author", IsAvailable = true };
            var isAvailable = book.IsAvailable;
            Assert.IsTrue(isAvailable, "The book should be available initially.");
        }
    }
}
