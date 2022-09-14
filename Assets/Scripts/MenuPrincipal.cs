using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour {

public void Jogar ()
{

    SceneManager.LoadScene("cena 1");
}

public void Creditos ()
{

    SceneManager.LoadScene("creditos");
}


}