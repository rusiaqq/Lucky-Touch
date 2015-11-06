using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	public void ChangeSceneToGame()
    {
        Hide();
        StartCoroutine("WaitBeforeChange");
    }

    public IEnumerator WaitBeforeChange()
    {
        yield return new WaitForSeconds(0.5f);
        Application.LoadLevel(2);
    }

    public void ChangeSceneToMenu()
    {
        Hide();
        StartCoroutine("WaitBeforeChangeMenu");
    }

    public IEnumerator WaitBeforeChangeMenu()
    {
        yield return new WaitForSeconds(0.5f);
        Application.LoadLevel(1);
    }

    public void ChangeSceneToHowTo()
    {
        Hide();
        StartCoroutine("WaitBeforeChangeHowTo");
    }

    public IEnumerator WaitBeforeChangeHowTo()
    {
        yield return new WaitForSeconds(0.5f);
        Application.LoadLevel(3);
    }

    private void Hide()
    {
        var menu = GameObject.FindGameObjectWithTag("HideMenu");
        if (menu != null)
        {
            var menuAnimator = menu.GetComponent<HideMenu>();
            menuAnimator.HideAll();
        }
    }
}
