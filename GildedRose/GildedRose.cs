namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            var betterItem = new ItemMapper().MapItem(Items[i]);
            
            betterItem.Update();
            
            Items[i].Quality = betterItem.Quality;
            Items[i].SellIn = betterItem.SellIn;
        }
    }

    public void FirstUpdateBackstagePass(BetterItem item)
    {
        
    }
    
    public void SecondUpdateBackstagePass(BetterItem item)
    {
        item.DegradeWeight += 1;
    }
}
