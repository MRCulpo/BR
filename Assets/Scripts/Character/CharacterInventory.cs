using Br.Weapon;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour, IInventory
{
    /// <summary>
    /// Referencia do CharacterController do Player
    /// </summary>
    [SerializeField]
    private CharacterController2D m_CharacterController2D;

    /// <summary>
    /// Lista dos itens para carregar ( MAXIMO 4 Item )
    /// </summary>
    private List<ItemBase> m_Inventory;
    /// <summary>
    /// Id do item que está sendo usado atualmente
    /// </summary>
    private int m_CurrentInventory;

    /// <summary>
    /// Quantidade total de item que pode estar dentro da Bag
    /// </summary>
    private int m_TotalInventory;

    private void Awake()
    {
        m_TotalInventory = 4;
        m_CurrentInventory = -1;
        m_Inventory = new List<ItemBase>();
    }

    public void AddInventory(GameObject _Item)
    {
        m_CharacterController2D.CurrentGun = _Item.GetComponent<IGun>();
        _Item.transform.parent = m_CharacterController2D.CharacterWeapon;
        _Item.transform.localPosition = Vector3.zero;
        _Item.SetActive(false);

        ItemBase _base = _Item.GetComponent<ItemBase>();

        if (m_Inventory.Count == 0)
        {
            m_Inventory.Add(_base);
            m_CurrentInventory = 0;
            _Item.SetActive(true);

            //Atribuir ao personagem ( dentro )
            //Ativar
        }
        else if(m_Inventory.Count < m_TotalInventory)
        {
            m_Inventory.Add(_base);
        }
        else if(m_Inventory.Count >= m_TotalInventory)
        {
            //Remove o item do Current Atual
            RemoveInventory();
            m_Inventory[m_CurrentInventory] = _base;
            _Item.SetActive(true);
            //Atribuir ao personagem ( dentro )
            //Ativar
        }
    }

    public void RemoveInventory()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Item"))
        {
            collision.enabled = false;
            AddInventory(collision.gameObject);
        }
    }
}
