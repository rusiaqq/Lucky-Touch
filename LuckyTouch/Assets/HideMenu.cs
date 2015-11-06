using UnityEngine;
using System.Collections;

public class HideMenu : MonoBehaviour 
{

    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void HideAll()
    {
        if (_animator != null)
        {
            _animator.SetTrigger("Hide");
        }
    }
}
