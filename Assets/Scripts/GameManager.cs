using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
    public GameObject player ;
    public int currentPickups = 0;
    public int maxPickups = 4;
    public bool levelComplete = false;
    public Text pickupText;

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
    }
}
