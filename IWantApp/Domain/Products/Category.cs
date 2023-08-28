using Microsoft.AspNetCore.Components.Web;

namespace IWantApp.Domain.Products;

public class Category : Entity
{
    public bool Active { get; set; } = true;
}
