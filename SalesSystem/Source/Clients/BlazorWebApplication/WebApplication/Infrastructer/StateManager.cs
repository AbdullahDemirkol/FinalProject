using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Infrastructer
{
    public class StateManager
    {
        public event Action<ComponentBase, string> StateChanged;
        public void UpdateBody(ComponentBase componentBase, int upCategoryId, int downCategoryId, int brandId, int page)
        {
            var safas = "productList" + upCategoryId.ToString() + downCategoryId.ToString() + brandId.ToString() + page.ToString();
            StateChanged?.Invoke(componentBase, "productList" + upCategoryId.ToString() + downCategoryId.ToString() + brandId.ToString() + page.ToString());
        }
        public void UpdateContent(ComponentBase componentBase,string property)
        {
            StateChanged?.Invoke(componentBase, property);
        }
        public void UpdateComponentStop(ComponentBase componentBase)
        {
            StateChanged?.Invoke(componentBase, "componentStop");
        }

        public void UpdateCard(ComponentBase componentBase)
        {
            StateChanged?.Invoke(componentBase, "checkBasket");
        }
        public void IncraseProductCount(ComponentBase componentBase)
        {
            StateChanged?.Invoke(componentBase, "increase");

        }
        public void LoginChanged(ComponentBase componentBase)
        {
            StateChanged?.Invoke(componentBase, "login");
        }
    }
}
