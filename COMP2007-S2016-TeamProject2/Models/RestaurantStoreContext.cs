/* File Name: COMP2007_S2016_TeamProject2
 * Author: Yandong Wang  200277628 Zhen Zhang 200257444
 * File Description: Create a website that allow customer to view the cuisines.
 * WebSite Name: Hai Di Lao Hot Pot
 */

namespace COMP2007_S2016_TeamProject2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantStoreContext : DbContext
    {
        public RestaurantStoreContext()
            : base("name=RestaurantStoreConnection")
        {
        }

        public virtual DbSet<FoodType> FoodTypes { get; set; }
        public virtual DbSet<FoodItem> FoodItems { get; set; }
    }
}
