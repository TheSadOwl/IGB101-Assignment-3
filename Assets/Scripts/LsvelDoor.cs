using UnityEngine;
using UnityEngine.SceneManagement;

public class LsvelDoor : MonoBehaviour
{
    VinhGameManager gameManager;

    public MeshRenderer mr;
    public GameObject lightgo;

    public string nextlevel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<VinhGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.levelComplete)
        {
            mr.enabled = true;
            lightgo.SetActive(true);
        }
        else
        {
            mr.enabled = false;
            lightgo.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            if (gameManager.levelComplete)
            {
                SceneManager.LoadScene(nextlevel);
            }
        }
    }

}
