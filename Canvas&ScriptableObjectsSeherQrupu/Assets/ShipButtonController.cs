using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipButtonController : MonoBehaviour
{
   [SerializeField] Image shipIconImage;

   [SerializeField] private Text shipPriceText;

	 [SerializeField] ShopItemSO shipData;


	 public void SetupShipDataOnUI()
	 {
			shipIconImage.sprite = shipData.ReturnItemSprite();

			shipPriceText.text = shipData.ReturnItemPrice().ToString();
	 }

	 public void SetShipData(ShopItemSO _shipData)
	 {
			shipData = _shipData;
	 }
}
