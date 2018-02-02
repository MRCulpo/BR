using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class ItemBase : MonoBehaviour {

    /// <summary>
    /// Nome do Item
    /// </summary>
    [SerializeField] private string m_NameItem;

    /// <summary>
    /// Tipo do Item
    /// </summary>
    [SerializeField] private Item m_Item;

    public string NameItem
    {
        get
        {
            return m_NameItem;
        }

        set
        {
            m_NameItem = value;
        }
    }

    public Item Item
    {
        get
        {
            return m_Item;
        }

        set
        {
            m_Item = value;
        }
    }
}
