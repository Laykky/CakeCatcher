using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator _animation;

    // Start is called before the first frame update
    void Start()
    {
        _animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _animation.SetBool("SpaceBarPressed", true);
        }

        if (Input.GetKeyUp("space"))
        {
            _animation.SetBool("SpaceBarPressed", false);
        }
    }
}
