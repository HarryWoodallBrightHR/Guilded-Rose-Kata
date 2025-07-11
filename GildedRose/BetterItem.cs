﻿namespace GildedRoseKata;

public class BetterItem : Item
{
    public int DegradeWeight { get; set; } = -1;
    public ItemType Type { get; set; }
    
    public void Update()
    {
        if (SellIn <= 0)
        {
            DegradeWeight *= 2;
        }
        
        Quality += DegradeWeight;
        SellIn -= 1;
            
        if (Quality <= 0)
        {
            Quality = 0;
        }
    }
}

public enum ItemType
{
    Sulfuras,
    BackstagePasses,
    AgedBrie,
    Conjured,
    Normal,
}