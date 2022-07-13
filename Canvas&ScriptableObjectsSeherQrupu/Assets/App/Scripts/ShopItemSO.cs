using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewShopItem", menuName ="ScriptableObjects/NewShopItemData")]

public class ShopItemSO : ScriptableObject
{
   [Header("References")]

   [SerializeField] private Sprite itemSprite;

   [Header("Properties")]

   [SerializeField] private string itemName;

   [SerializeField] private int itemPrice;

   [SerializeField] private float itemSpeed;

   [SerializeField] private float itemHealth;

   public Sprite ReturnItemSprite()
	 {
      return itemSprite;
	 }

   public string ReturnItemName()
	 {
      return itemName;
	 }

   public int ReturnItemPrice()
	 {
      return itemPrice;
	 }
}
