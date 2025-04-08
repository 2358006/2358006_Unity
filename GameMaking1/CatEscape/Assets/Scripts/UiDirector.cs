using UnityEngine;

public class UiDirector : MonoBehaviour
{
    public GameObject Shop;
    bool isShopOpen = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickShop()
    {
        if (isShopOpen == false)
        {
            Shop.SetActive(true);
            isShopOpen = true;
        }
        else if (isShopOpen == true)
        {
            Shop.SetActive(false);
            isShopOpen = false;
        }
    }

}
