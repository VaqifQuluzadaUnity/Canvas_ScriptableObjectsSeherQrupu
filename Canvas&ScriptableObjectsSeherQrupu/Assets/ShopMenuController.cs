using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenuController : MonoBehaviour
{
	 [SerializeField] private GameObject shopItemButtonPrefab;

	 [SerializeField] private Transform standartItemsContentParent;

	 [SerializeField] private ShopItemSO[] standartItemsArray;

	 [SerializeField] private ShopItemSO[] premiumItemsArray;

	 private void Start()
	 {
			SetStandartItems();
	 }

	 private void SetStandartItems()
	 {
			for (int i = 0; i < standartItemsArray.Length; i++)
			{
				 GameObject buttonInstance = Instantiate(shopItemButtonPrefab, standartItemsContentParent);

				 ShipButtonController buttonController = buttonInstance.GetComponent<ShipButtonController>();

				 buttonController.SetShipData(standartItemsArray[i]);

				 buttonController.SetupShipDataOnUI();

			}
	 }
}
