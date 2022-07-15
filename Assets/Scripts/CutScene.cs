using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{
    public GameObject thePlayer;
        public GameObject GameOverText;
    public GameObject cutSceneCam;

    void OnTriggerEnter(Collider other)
    {
        cutSceneCam.SetActive(true);
        GameOverText.SetActive(true);
        thePlayer.SetActive(false);
    }
}
