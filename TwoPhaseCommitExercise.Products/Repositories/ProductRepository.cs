using TwoPhaseCommitExercise.Products.Interfaces;
using TwoPhaseCommitExercise.Products.Models;

namespace TwoPhaseCommitExercise.Products.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products = new();
        public bool IsLocked(int productId)
        {
            var product = products.Find(c => c.Id == productId);
            if (product is not null)
            {
                return product.Locked;
            }
            throw new ArgumentException("product not found!");
        }

        public bool Lock(int productId)
        {
            var product = products.Find(c => c.Id == productId);
            if (product is not null)
            {
                product.Locked = true;
                return product.Locked;
            }
            throw new ArgumentException("product not found!");
        }

        public decimal Spend(int productId, decimal expenditure)
        {
            var product = products.Find(c => c.Id == productId);
            if (product is null) throw new ArgumentException("product not found!");
            if (product.Funds < expenditure) throw new ArgumentException("Funds insufficient");

            product.Funds -= expenditure;
            return product.Funds;            
        }
    }
}
