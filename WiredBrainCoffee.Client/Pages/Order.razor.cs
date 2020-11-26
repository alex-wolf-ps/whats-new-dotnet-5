using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;
using WiredBrainCoffeeClient.Components;

namespace WiredBrainCoffee.Client.Pages
{
    public partial class Order
    {
        [Inject]
        public IMenuService MenuService { get; set; }

        [Inject]
        public NavigationManager NavManager { get; set; }
        
        [CascadingParameter] 
        public IModalService Modal { get; set; }

        public List<OrderItem> CurrentOrder { get; set; } = new List<OrderItem>();
        public List<MenuItem> FoodMenuItems { get; set; } = new List<MenuItem>();
        public List<MenuItem> CoffeeMenuItems { get; set; } = new List<MenuItem>();
        public decimal OrderTotal { get; set; } = 0;
        public decimal SalesTax { get; set; } = 0.06m;
        public string PromoCode { get; set; } = "";
        public bool IsValidPromoCode { get; set; } = true;
        public bool FoodTabHidden { get; set; } = true;
        public bool CoffeeTabHidden { get; set; } = false;

        public void ShowCoffee()
        {
            CoffeeTabHidden = false;
            FoodTabHidden = true;
        }

        public void ShowFood()
        {
            CoffeeTabHidden = true;
            FoodTabHidden = false;
        }

        async Task AddExtras(MenuItem item)
        {
            item.Extras = new Extras();
            var formModal = Modal.Show<CoffeeExtrasModal>("Enhance Your Coffee");
            var result = await formModal.Result;

            if (!result.Cancelled)
            {
                item.Extras = (Extras)result.Data;
                AddToOrder(item);
            }
        }

        public void AddToOrder(MenuItem item)
        {
            CurrentOrder.Add(new OrderItem()
            {
                Name = item.Name,
                Id = item.Id,
                Price = item.Price,
                Extras = item.Extras
            });

            OrderTotal += item.Price;
        }

        public void RemoveFromOrder(OrderItem item)
        {
            CurrentOrder.Remove(item);
            OrderTotal -= item.Price;
        }

        public async Task PlaceOrder()
        {
            NavManager.NavigateTo("order-confirmation");
        }

        protected async override Task OnInitializedAsync()
        {
            var menuItems = await MenuService.GetMenuItems();

            FoodMenuItems = menuItems.Where(x => x.Category == "Food").ToList();
            CoffeeMenuItems = menuItems.Where(x => x.Category == "Coffee").ToList();
        }
    }
}
