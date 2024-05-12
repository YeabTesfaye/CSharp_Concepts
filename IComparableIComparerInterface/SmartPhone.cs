
namespace IComparableIComparerInterface;

    public class SmartPhone : IComparable
    {
        public string? Name {set; get;}
        public double Price {get; set;}
        public string? OS {get; set;}
        

    public int CompareTo(object? obj)
    {
        if (obj == null) return 1;
        SmartPhone? nextSmartPhone = obj as SmartPhone;

        if(nextSmartPhone != null){
            return this.Price.CompareTo(nextSmartPhone.Price);
        }
        else{
            throw new ArgumentException("Object doesn't have a proper price");
        }
    }

    public override string ToString()
    {
        return $"Name : {Name}  Price : {Price}  OS : {OS}";
    }
}
