using UnityEngine;
using System.Collections;

public class ChangeSceneMenu : MonoBehaviour 
{


	void Start () 
    {
        StartCoroutine("WaitBeforeChange");
	}
    public IEnumerator WaitBeforeChange()
    {
        yield return new WaitForSeconds(2.0f);
        Application.LoadLevel(1);
    }

}
