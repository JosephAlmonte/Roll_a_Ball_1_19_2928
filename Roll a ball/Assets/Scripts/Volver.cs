using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Volver : MonoBehaviour
{
    public Button BtnVolver;
    // Start is called before the first frame update
    void Start()
    {
        BtnVolver.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Menu");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
