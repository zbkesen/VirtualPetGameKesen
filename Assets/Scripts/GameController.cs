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

    // Start is called before the first frame update
    void Start()
    {
        dogButton.interactable = false;
        catButton.interactable = false;
        pixelCat.gameObject.SetActive(false);
        pixelDog.gameObject.SetActive(false);
        playVP.gameObject.SetActive(false);
        feedVP.gameObject.SetActive(false);
        restVP.gameObject.SetActive(false);
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
        catButton.gameObject.SetActive(false);
        dogButton.gameObject.SetActive(false);
        nameInput.gameObject.SetActive(false);
        playVP.gameObject.SetActive(true);
        feedVP.gameObject.SetActive(true);
        restVP.gameObject.SetActive(true);
    }

    public void OnClickDogButton()
    {
        virtualPet = new Pet(nameInput.text);
        PetName();
        pixelDog.gameObject.SetActive(true);
        catButton.gameObject.SetActive(false);
        dogButton.gameObject.SetActive(false);
        nameInput.gameObject.SetActive(false);
        playVP.gameObject.SetActive(true);
        feedVP.gameObject.SetActive(true);
        restVP.gameObject.SetActive(true);
    }
}
