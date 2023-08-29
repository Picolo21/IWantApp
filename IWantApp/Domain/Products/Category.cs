using Flunt.Validations;

namespace IWantApp.Domain.Products;

public class Category : Entity
{
    public Category(string name, string createdBy, string editedBy)
    {
        Name = name;
        Active = true;
        CreatedBy = createdBy;
        CreatedOn = DateTime.Now;
        EditedBy = editedBy;
        EditedOn = DateTime.Now;

        Validate();
    }

    private void Validate()
    {
        var contract = new Contract<Category>()
                    .IsNullOrEmpty(Name, "Name")
                    .IsGreaterOrEqualsThan(Name, 3, "Name")
                    .IsNullOrEmpty(CreatedBy, "CreatedBy")
                    .IsNullOrEmpty(EditedBy, "EditedBy");
        AddNotifications(contract);
    }

    public bool Active { get; private set; }

    public void Editinfo(string name, bool active)
    {
        Name = name;
        Active = active;

        Validate();
    }
}
