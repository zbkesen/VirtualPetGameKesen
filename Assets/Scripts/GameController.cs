using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_Text petName;
    [SerializeField] private TMP_Text happyLevel;
    [SerializeField] private TMP_Text hungerLevel;
    [SerializeField] private TMP_Text energyLevel;
    [SerializeField] private Button dogButton;
    [SerializeField] private Button catButton;
    [SerializeField] private Button playVP;
    [SerializeField] private Button feedVP;
    [SerializeField] private Button restVP;
    [SerializeField] private Image pixelDog;
    [SerializeField] private Image pixelCat;
    private Pet virtualPet;
    private float timePassed = 0f;
    private bool gameStart;

    // Start is called before the first frame update
    void Start()
    {
        InitialHUD();
    }

    // Update is called once per frame
    void Update()
    {
        if (nameInput.text != "")
        {
            dogButton.interactable = true;
            catButton.interactable = true;
        }
    }

    void FixedUpdate()
    {
        VPStatDegrade();
    }

    void PetName()
    {
        virtualPet.Name = nameInput.text;
        if (virtualPet.Name != null)
        {
            petName.text = virtualPet.Name;
        }
    }

    public void OnClickCatButton()
    {
        virtualPet = new Pet(nameInput.text);
        PetName();
        pixelCat.gameObject.SetActive(true);
        SwitchHUD();
    }

    public void OnClickDogButton()
    {
        virtualPet = new Pet(nameInput.text);
        PetName();
        pixelDog.gameObject.SetActive(true);
        SwitchHUD();
    }

    public void OnClickPlayWithVP()
    {
        virtualPet.Play();
        happyLevel.text = ($"Happiness: {virtualPet.Happiness.ToString()}");
    }

    public void OnClickFeedVP()
    {
        virtualPet.Eat();
        hungerLevel.text = ($"Hunger: {virtualPet.Hunger.ToString()}");
    }

    public void OnClickLetRest()
    {
        virtualPet.Rest();
        energyLevel.text = ($"Energy: {virtualPet.Energy.ToString()}");
    }

    void VPStatDegrade()
    {
        if (gameStart == true)
        {
            timePassed += Time.deltaTime;
            if (timePassed > 5f)
            {
                virtualPet.GetHungry();
                hungerLevel.text = ($"Hunger: {virtualPet.Hunger.ToString()}");
                virtualPet.GetTired();
                energyLevel.text = ($"Energy: {virtualPet.Energy.ToString()}");
                virtualPet.GetBored();
                happyLevel.text = ($"Happiness: {virtualPet.Happiness.ToString()}");
                timePassed = 0;
            }
        }
    }

    void InitialHUD()
    {
        gameStart = false;
        dogButton.interactable = false;
        catButton.interactable = false;
        pixelCat.gameObject.SetActive(false);
        pixelDog.gameObject.SetActive(false);
        playVP.gameObject.SetActive(false);
        feedVP.gameObject.SetActive(false);
        restVP.gameObject.SetActive(false);
        happyLevel.gameObject.SetActive(false);
        hungerLevel.gameObject.SetActive(false);
        energyLevel.gameObject.SetActive(false);
    }

    void SwitchHUD()
    {
        gameStart = true;
        catButton.gameObject.SetActive(false);
        dogButton.gameObject.SetActive(false);
        nameInput.gameObject.SetActive(false);
        playVP.gameObject.SetActive(true);
        feedVP.gameObject.SetActive(true);
        restVP.gameObject.SetActive(true);
        happyLevel.gameObject.SetActive(true);
        energyLevel.gameObject.SetActive(true);
        hungerLevel.gameObject.SetActive(true);
    }
}
