using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonInfo : MonoBehaviour
{

    public int ItemID;
    public TextMeshProUGUI PriceTxt;
    public TextMeshProUGUI QuantityTxt;
    public GameObject ShopManager;

    //
    void Update()
    {
        PriceTxt.text = "Price: $" + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
        QuantityTxt.text =  ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();

    }


}
