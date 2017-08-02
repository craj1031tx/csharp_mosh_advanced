namespace csharp_mosh_advanced
{
    // where T : Product
    public class DiscountCalculator<TProduct> where TProduct : TProduct
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    public class Product
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    // where T : struct
    // where T : class
    // where T : new()
}