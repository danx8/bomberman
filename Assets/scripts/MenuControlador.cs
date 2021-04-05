using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControlador : MonoBehaviour
{
    public void cambiarEscena(string nombreEscena){
        SceneManager.LoadScene(nombreEscena);
   }
}
