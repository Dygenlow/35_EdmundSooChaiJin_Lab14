using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //Float Variables
    float speed = 6.0f;

    //Integer Variables
    int redCount = 0;
    int purpleCount = 0;
    int orangeCount = 0;
    int yellowCount = 0;

    //Text Component References
    public Text red;
    public Text purple;
    public Text orange;
    public Text yellow;

    //AudioSource Component References
    public AudioSource coin;
    public AudioSource explosion;
    public AudioSource jump;
    public AudioSource laser;

    // Start is called before the first frame update
    void Start()
    {
        coin.GetComponent<AudioSource>();
        explosion.GetComponent<AudioSource>();
        jump.GetComponent<AudioSource>();
        laser.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ForwardKey();
        BackKey();
        LeftKey();
        RightKey();

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Red"))
        {
            redCount++;

            red.GetComponent<Text>().text = "Red: " + redCount;

            coin.Play();
        }

        if (other.gameObject.CompareTag("Purple"))
        {
            purpleCount++;

            purple.GetComponent<Text>().text = "Purple: " + purpleCount;

            explosion.Play();
        }

        if (other.gameObject.CompareTag("Orange"))
        {
            orangeCount++;

            orange.GetComponent<Text>().text = "Orange: " + orangeCount;

            laser.Play();
        }

        if (other.gameObject.CompareTag("Yellow"))
        {
            yellowCount++;

            yellow.GetComponent<Text>().text = "Yellow: " + yellowCount;

            jump.Play();
        }
    }

    private void ForwardKey()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
    }

    private void BackKey()
    {
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }

    private void LeftKey()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }

    private void RightKey()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
