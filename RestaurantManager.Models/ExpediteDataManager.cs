using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        protected override void OnDataLoaded()
        {
            this.OrderItems = base.Repository.Orders;
        }
        //public ExpediteDataManager()
        //{
        //    this._orderItems = new List<Order>
        //    {
        //        new Order { Items= new List<MenuItem> { new MenuItem() {Title="French Bread & Fondue Dip" } }, SpecialRequests="Extra" },
        //        new Order { Items=new List<MenuItem> { new MenuItem() { Title = "Mashed Peas" } }, SpecialRequests="" }
        //    };
        //}
        private List<Order> _orderItems;
        public List<Order> OrderItems
        {
            get { return _orderItems; }
            set
            {
                _orderItems = value;
                this.OnPropertyChanged();
            }
        }
    }
}
