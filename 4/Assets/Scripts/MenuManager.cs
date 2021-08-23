using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{



    public void ChangeScenes(int numberScenes)
    {
        StartCoroutine(Delay());
        SceneManager.LoadScene(numberScenes);
    }

    public void Quit()
    {

        Application.Quit();
    }

   private IEnumerator Delay()
    {
        yield return new WaitForSeconds(10f);
    }


}
