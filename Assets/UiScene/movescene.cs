using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class movescene : MonoBehaviour
{
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
    public void level()
    {
        SceneManager.LoadScene(1);
    }

    public void opiton()
    {
        SceneManager.LoadScene(8);
    }

    public void search()
    {
        SceneManager.LoadScene(7);
    }
}
