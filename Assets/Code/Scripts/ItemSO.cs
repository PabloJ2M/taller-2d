using UnityEngine;

[CreateAssetMenu(fileName = "item", menuName = "inventory/item")]
public class ItemSO : ScriptableObject
{
    public string name;
    public Sprite image;
    public Color color;

    public float weigth;
    public float cost;

    public int quallity;
    public bool rare;
}