using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipButtonController : MonoBehaviour
{
   [SerializeField] Image shipIconImage;

   [SerializeField] private Text shipPriceText;

	 [SerializeField] private Button buyOrSelectButton;

	 [SerializeField] private Text buyOrSelectButtonText;

	 [SerializeField] ShopItemSO shipData;


	 public void SetupShipDataOnUI()
	 {
			shipIconImage.sprite = shipData.ReturnItemSprite();

			shipPriceText.text = shipData.ReturnItemPrice().ToString();

			if (shipData.shipState.isBuy)
			{
				 if (shipData.shipState.isSelect)
				 {
						SelectItem();
				 }
				 else
				 {
						DeselectItem();
				 }
			}
	 }

	 public void SetShipData(ShopItemSO _shipData)
	 {
			shipData = _shipData;
	 }
	 //
	 public void BuyOrSelectShip()
	 {

			if (shipData.GetIsBuy())
			{
				 if (!shipData.GetIsSelect())
				 {
						SelectItem();
				 }
			}
			else
			{
				 //Currency check

				 shipData.BuyItem();

				 SelectItem();

				 
			}
	 }

	 private void SelectItem()
	 {
			ShopMenuController.instance.SetCurrentSelectedShip(this);

			shipData.SelectItem();
			buyOrSelectButton.interactable = false;
			buyOrSelectButtonText.text = "Selected";
	 }

	 public void DeselectItem()
	 {
			shipData.DeselectItem();

			buyOrSelectButton.interactable = true;

			buyOrSelectButtonText.text = "Select";
	 }
}
