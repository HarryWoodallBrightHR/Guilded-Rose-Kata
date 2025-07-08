using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void Foo()
    {
        List<Item> items = [ new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 10 } ];
        GildedRose app = new(items);
        app.UpdateQuality();
        Assert.Equal(8, items[0].Quality);
    }
}
