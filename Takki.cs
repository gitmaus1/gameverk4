using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

using TMPro;


public class Takki : MonoBehaviour
{
    public TextMeshProUGUI textin;

    public void Start()
    {



       


                if (rememberMe.stig == 6)
                {
                    textin.text = textin.text + " �� wanst til hamingju ";
                }
                else
                {
                    textin.text = textin.text + " d�st ";
                }
            }





        

    
    private void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Byrja()
    {
        rememberMe.stig = 0;//n�ll stilli stigin 

        SceneManager.LoadScene(1);
    }


}

