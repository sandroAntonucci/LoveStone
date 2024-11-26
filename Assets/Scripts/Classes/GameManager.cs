using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Singleton for canvas update logic
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("GameManager is not initialized. Please ensure it exists in the scene.");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject); // Optional: Keep GameManager persistent across scenes
    }


    public void UpdateCharacterCanvas(GameObject character)
    {

        // Updates the image of the character
        GameObject.FindGameObjectWithTag("CardDesign").GetComponent<Image>().sprite = character.GetComponent<CharacterCard>().Character.Design;

        // Updates the canvas of the character
        foreach (Transform child in character.transform)
        {

            if (child.name == "Mana")
            {
                child.GetComponent<Text>().text = character.GetComponent<CharacterCard>().Mana.ToString();
            }
            else if (child.name == "Damage")
            {
                child.GetComponent<Text>().text = character.GetComponent<CharacterCard>().Character.Damage.ToString();
            }
            else if (child.name == "HP")
            {
                child.GetComponent<Text>().text = character.GetComponent<CharacterCard>().Character.HP.ToString();
            }
            else if (child.name == "Description")
            {
                child.GetComponent<Text>().text = character.GetComponent<CharacterCard>().Character.Description;
            }

        }
        

    }

    public void UpdateSpellCanvas(GameObject spell)
    {


        foreach (Transform child in spell.transform)
        {
            if (child.name == "Mana")
            {
                child.GetComponent<Text>().text = spell.GetComponent<SpellCard>().Mana.ToString();
            }
            else if (child.name == "Description")
            {
                child.GetComponent<Text>().text = spell.GetComponent<SpellCard>().Entity.Description;
            }
            else if (child.name == "SpellCardMask")
            {
                 child.GetChild(0).GetComponent<Image>().sprite = spell.GetComponent<SpellCard>().Entity.Design;
            }

        }

    }

    public void UpdateAvatarCanvas(GameObject avatar)
    {

        avatar.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = avatar.GetComponent<Avatar>().EntitySO.Design;

    }

    public void UpdatePowerCanvas(GameObject power)
    {

        power.transform.GetChild(1).GetChild(0).GetComponent<Image>().sprite = power.GetComponent<Power>().Entity.Design;
        power.transform.GetChild(0).GetComponent<Text>().text = power.GetComponent<Power>().Mana.ToString();
    }

    public void UpdateTokenCanvas(GameObject token)
    {
        token.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = token.GetComponent<Token>().Character.Design;
        token.transform.GetChild(1).GetComponent<Text>().text = token.GetComponent<Token>().Damage.ToString();
        token.transform.GetChild(2).GetComponent<Text>().text = token.GetComponent<Token>().HP.ToString();

    }
}
