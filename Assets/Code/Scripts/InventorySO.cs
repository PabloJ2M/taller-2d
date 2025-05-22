using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "inventory", menuName = "inventory/collection")]
public class InventorySO : ScriptableObject
{
    public InventoryContainer container;

    public void AddItem(ItemSO item)
    {
        container.Add(item);
    }
    public void Save()
    {
        string json = JsonUtility.ToJson(container, true);
        Debug.Log(json);
        PlayerPrefs.SetString("inventory", json);
    }
    public void Load()
    {
        string json = PlayerPrefs.GetString("inventory");
        container = JsonUtility.FromJson<InventoryContainer>(json);
    }
}

[Serializable] public class InventoryContainer
{
    public List<ItemSO> items;

    public void Add(ItemSO item)
    {
        items.Add(item);
    }
}
