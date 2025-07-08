namespace GildedRoseKata;

public class ItemMapper
{
    public BetterItem MapItem(Item item)
    {
        var betterItem = new BetterItem()
        {
            Name = item.Name,
            Quality = item.Quality,
            SellIn = item.SellIn
        };

        if (item.Name.Contains("Sulfuras"))
        {
            betterItem.Type = ItemType.Sulfuras;
            betterItem.DegradeWeight = 0;
        }

        else if (item.Name.Contains("Backstage"))
        {
            betterItem.Type = ItemType.BackstagePasses;
            betterItem.DegradeWeight = 2;
        }
        
        else if (item.Name.Contains("Aged"))
        {
            betterItem.Type = ItemType.AgedBrie;
            betterItem.DegradeWeight = 1;
        }

        else if (item.Name.Contains("Conjured"))
        {
            betterItem.Type = ItemType.Conjured;
            betterItem.DegradeWeight = -2;
        }

        else
        {
            betterItem.Type = ItemType.Normal;
        }

        return betterItem;
    }
}