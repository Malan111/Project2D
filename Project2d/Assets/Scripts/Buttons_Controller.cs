using UnityEngine;

public class Buttons_Controller : MonoBehaviour
{
    [SerializeField] private GameObject panel_Update;
    [SerializeField] private GameObject panel_Cards;
    [SerializeField] private GameObject panel_Locked;
    [SerializeField] private GameObject panel_Shop;

    void Start()
    {
        panel_Update.SetActive(false);
        panel_Cards.SetActive(false);
        panel_Locked.SetActive(false);
        panel_Shop.SetActive(false);
    }

    public void OnPanelBattle()
    {
        panel_Update.SetActive(false);
        panel_Cards.SetActive(false);
        panel_Locked.SetActive(false);
        panel_Shop.SetActive(false);
    }

    public void OnPanelUpdate()
    {
        panel_Update.SetActive(true);
        panel_Cards.SetActive(false);
        panel_Locked.SetActive(false);
        panel_Shop.SetActive(false);
    }
    public void OnPanelCards()
    {
        panel_Update.SetActive(false);
        panel_Cards.SetActive(true);
        panel_Locked.SetActive(false);
        panel_Shop.SetActive(false);
    }
    public void OnPanelLocked()
    {
        panel_Update.SetActive(false);
        panel_Cards.SetActive(false);
        panel_Locked.SetActive(true);
        panel_Shop.SetActive(false);
    }
    public void OnPanelShop()
    {
        panel_Update.SetActive(false);
        panel_Cards.SetActive(false);
        panel_Locked.SetActive(false);
        panel_Shop.SetActive(true);
    }

}
