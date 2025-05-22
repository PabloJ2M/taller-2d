using UnityEngine;

public class Backpack : MonoBehaviour
{
    [SerializeField] private InventorySO items;
    [SerializeField] private ItemSO item;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            items.AddItem(item);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            items.Save();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            items.Load();
        }
    }
}
