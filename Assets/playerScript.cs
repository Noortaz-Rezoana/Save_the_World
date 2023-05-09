using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textMeshProUGUI;
    //public TextMeshProUGUI ScoreGUI;
    public static int score;
    CharacterController characterController;
    public Transform cameraTransform;
    public int speed = 8;
    //bool move = false;
    Rigidbody move;

    //GameObject gun;
    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
        //gun = gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject;

        
        score = 0;
        textMeshProUGUI.text = "Score : " + score;
        //ScoreGUI.text = "Score: "+ score;
        move = GetComponent<Rigidbody>();
    }

    public int shoot()
    {
        Debug.Log("Started to Shoot");
        StartCoroutine("Shoot");
        score += 1;
        Debug.Log(score);
        return score - 1;
    }

    IEnumerator Shoot()
    {
       // gun.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(1f);
    }
    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = "Score : " + score;

        if (transform.eulerAngles.z > 90.0f && transform.eulerAngles.z < 270.0f)
        {
            move.velocity = -cameraTransform.forward * speed;
        }
        else
        {
            move.velocity = cameraTransform.forward * speed;
        }
        

    }
}
