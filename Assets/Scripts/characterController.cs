using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class characterController : MonoBehaviour
{
    public float speed = 10.0F;
    public camMouseLook camLook;
    static Animator anim;
    // USe this for initialization
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.lockState = CursorLockMode.Locked;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (translation != 0)
        {
            anim.SetBool("IsWalking", true);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }

        //Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKeyDown("escape"))
        {
            Pause();
        }
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("COMPLETE"))
            Loader();
    }
    void Loader()
    {
        SceneManager.LoadScene("Start");
    }
    void Pause()
    {
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
            camLook.enabled = false;
            //if (Input.GetKeyDown("escape"))
           // {
           //     UnPause();
           // }

        }
    }
    public void UnPause()
    {
        camLook.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
