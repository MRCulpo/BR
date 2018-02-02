using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour, IInventory
{
    private List<ItemBase> m_Inventory;
    private int m_CurrentInventory;
    private int m_TotalInventory;

    private void Awake()
    {
        m_CurrentInventory = -1;
        m_Inventory = new List<ItemBase>();
    }

    public void AddInventory()
    {
        if(m_Inventory.Count < m_TotalInventory)
        {

        }
    }

    public void RemoveInventory()
    {

    }
}
