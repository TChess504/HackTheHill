using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventorySystem
{
    [SerializeField] private List<InventorySlot> inventorySlots;

    private int inventorySize;

    public List<InventorySlot> InventorySlots => inventorySlots;

}
