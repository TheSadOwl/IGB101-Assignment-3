using UnityEngine;

public class VinhPickup : MonoBehaviour
{
    VinhGameManager gameManager;


    public Animator anim;
    public AudioSource OnPickUpSound;
    public AudioSource PopSound;


    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<VinhGameManager>();
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            gameManager.currentPickups += 1;

            anim.SetTrigger("PickUp");
        }
    }

    public void PlaySound()
    {
        OnPickUpSound.Play();
    }

    public void PlayPopSound()
    {
        PopSound.Play();
    }

    public void HideObject()
    {
        gameObject.SetActive(false);
    }

}
