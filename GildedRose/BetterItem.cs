namespace GildedRoseKata;

public class BetterItem : Item
{
    public int DegradeWeight { get; set; } = -1;
    public ItemType Type { get; set; }
}

public enum ItemType
{
    Sulfuras,
    BackstagePasses,
    AgedBrie,
    Conjured,
    Normal,
}