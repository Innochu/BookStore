using BookParadise.Application.Service.Interface;
using BookParadise.Persistence.DBContextFolder;
using Microsoft.EntityFrameworkCore;

namespace BookParadise.Application.Service.ConcreteClass
{
    public class Inventorymgt : IIInventorymgt
    {
        private readonly BookParadiseDb _dbContext;
      
        public Inventorymgt(BookParadiseDb dbContext)
        {
            _dbContext = dbContext;
          
        }


        public async Task UpdateInventoryLevelAsync(string orderId)
        {
           // await _rabbitMQSenderService.ReceiveMessage("orders");
            // 1. Get order details
            var order = await _dbContext.Orders.FindAsync(orderId);

            if (order == null)
            {
                throw new Exception($"Order with ID '{orderId}' not found");
            }

            // 2. Update book stock level
            var book = await _dbContext.Books.FirstOrDefaultAsync(item => item.Id == order.BookId);

            if (book == null)
            {
                throw new Exception($"Book with ID '{order.BookId}' not found");
            }

            // Log original and updated stock quantity
            var originalStock = book.StockQuantity;
            book.StockQuantity -= order.Quantity;
            var updatedStock = book.StockQuantity;

            Console.WriteLine($"Order ID: {orderId} - Book ID: {book.Id}");
            Console.WriteLine($"Original Stock: {originalStock}, Updated Stock: {updatedStock}");
            

            try
            {
                await _dbContext.SaveChangesAsync();
                Console.WriteLine("Inventory level updated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating inventory level: {ex.Message}");
            }
        }


    }

}
