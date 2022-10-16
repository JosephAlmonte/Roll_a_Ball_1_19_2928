using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LlamarJuego : MonoBehaviour
{ 
    public Button BtnIniciar, BtnControles, BtnSalir;
    // Start is called before the first frame update
    void Start()
    {
        BtnIniciar.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Juego");
        });

        BtnControles.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Controles");
        });
        BtnSalir.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
