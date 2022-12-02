using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{

    public Animator[] aniController;

    public int state = 0;
    public int oldState = 0;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(aniController != null)
        {
            if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.Alpha0))
            {
                state = 0;
            }
            if (Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.Alpha1))
            {
                foreach (Animator anim in aniController)
                {
                    if (anim.GetInteger("state") == 0)
                    {
                        //anim.SetInteger("state", 1);
                        state = 1;
                    }
                    else
                    {
                        //anim.SetInteger("state", 0);
                        state = 0;

                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.Alpha2))
            {
                foreach (Animator anim in aniController)
                {
                    if (anim.GetInteger("state") == 0)
                    {
                        //anim.SetInteger("state", 2);
                        state = 2;
                    }
                    else
                    {
                        //anim.SetInteger("state", 0);
                        state = 0;

                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.E) || Input.GetKeyUp(KeyCode.Alpha3))
            {
                foreach (Animator anim in aniController)
                {
                    if (anim.GetInteger("state") == 0)
                    {
                        //anim.SetInteger("state", 3);
                        state = 3;
                    }
                    else
                    {
                        //anim.SetInteger("state", 0);
                        state = 0;

                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.R) || Input.GetKeyUp(KeyCode.Alpha4))
            {
                foreach (Animator anim in aniController)
                {
                    if (anim.GetInteger("state") == 0)
                    {
                        //anim.SetInteger("state", 4);
                        state = 4;
                    }
                    else
                    {
                        //anim.SetInteger("state", 0);
                        state = 0;

                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.T) || Input.GetKeyUp(KeyCode.Alpha5))
            {
                foreach (Animator anim in aniController)
                {
                    if (anim.GetInteger("state") == 0)
                    {
                        //anim.SetInteger("state", 5);
                        state = 5;
                    }
                    else
                    {
                        //anim.SetInteger("state", 0);
                        state = 0;

                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.Y) || Input.GetKeyUp(KeyCode.Alpha6))
            {
                foreach (Animator anim in aniController)
                {
                    if (anim.GetInteger("state") == 0)
                    {
                        //anim.SetInteger("state", 6);
                        state = 6;
                    }
                    else
                    {
                        //anim.SetInteger("state", 0);
                        state = 0;

                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.U) || Input.GetKeyUp(KeyCode.Alpha7))
            {
                foreach (Animator anim in aniController)
                {
                    if (anim.GetInteger("state") == 0)
                    {
                        //anim.SetInteger("state", 7);
                        state = 7;
                    }
                    else
                    {
                        //anim.SetInteger("state", 0);
                        state = 0;

                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.I) || Input.GetKeyUp(KeyCode.Alpha8))
            {
                foreach (Animator anim in aniController)
                {
                    if (anim.GetInteger("state") == 0)
                    {
                        //anim.SetInteger("state", 8); 
                        state = 8;
                    }
                    else
                    {
                        //anim.SetInteger("state", 0);
                        state = 0;

                    }
                }
            }


            if (aniController[0].GetInteger("state") == 6)
            {
                if(aniController[0].GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f &&
                    aniController[0].GetCurrentAnimatorStateInfo(0).normalizedTime < 4.0f)
                {
                    Debug.Log(aniController[0].GetCurrentAnimatorStateInfo(0).normalizedTime);
                    state = 0;
                    //foreach (Animator anim in aniController)
                    //{
                    //    anim.SetInteger("state", 0); 
                    //    state = 0;

                    //}
                }
            }

            foreach (Animator anim in aniController)
            {
                anim.SetInteger("state", state);

            }

            //if(oldState != state)
            //{
            //    SetState(state);
            //}
            //oldState = state;

        }
    }

    public void SetState(int num)
    {
        //Debug.Log(num);
        //foreach (Animator anim in aniController)
        //{
        //    anim.SetInteger("state", num);

        //}
    }

}
