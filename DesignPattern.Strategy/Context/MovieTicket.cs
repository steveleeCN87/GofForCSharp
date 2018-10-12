using DesignPattern.Strategy.Strategy;

namespace DesignPattern.Strategy.Context
{
    /// <summary>
    /// 环境类：电影票MovieTicket
    /// </summary>
    public class MovieTicket
    {
        private double _price;
        private IDiscount _discount;

        public double Price
        {
            get
            {
                return _discount.Calculate(_price);
            }
            set
            {
                _price = value;
            }
        }

        public IDiscount Discount
        {
            set
            {
                _discount = value;
            }
        }
    }
}
