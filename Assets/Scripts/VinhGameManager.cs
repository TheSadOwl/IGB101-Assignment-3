using TMPro;
using UnityEngine;

public class VinhGameManager : MonoBehaviour
{
    public GameObject player;
    public PlayerController playerController;
    public int currentPickups = 0;
    public int maxPickups = 4;
    public bool levelComplete = false;
    public TMP_Text pickupText;
    public TMP_Text interactionText;

    void Update()
    {
        levelcompletecheck();
        UpdateGUI();
    }
    private void levelcompletecheck()
    {
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
    }
    private void UpdateGUI()
    {
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;

        interactionText.text = playerController.InteractionStr;
    }
}
