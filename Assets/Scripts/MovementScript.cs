using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Animator anim1;
    public Animator anim2;
    public bool a=false,b=false;

    int j = 0, i = 0;


    /*
    int idlehash = Animator.StringToHash("idle");
    int lefthash = Animator.StringToHash("left");
    int righthash = Animator.StringToHash("right");
    int sweephash = Animator.StringToHash("sweep");
    int kickhash = Animator.StringToHash("kick");
    int elbowhash = Animator.StringToHash("elbow");
    int smashhash = Animator.StringToHash("smash");
    
    int victimhash = Animator.StringToHash("victim");
    */
    int fallhash = Animator.StringToHash("fall");
    int starthash = Animator.StringToHash("start");
   
    int idlestatehash = Animator.StringToHash("Base Layer.idle");
    int leftstatehash = Animator.StringToHash("Base Layer.left");
    int rightstatehash = Animator.StringToHash("Base Layer.right");
    int sweepstatehash = Animator.StringToHash("Base Layer.sweep");
    int kickstatehash = Animator.StringToHash("Base Layer.kick");
    int elbowstatehash = Animator.StringToHash("Base Layer.elbow");
    int smashstatehash = Animator.StringToHash("Base Layer.smash");
    
    // Use this for initialization
    void Start()
    {

       // anim1 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      //  AnimatorStateInfo stateInfo1 = anim1.GetCurrentAnimatorStateInfo(0);
      //  AnimatorStateInfo stateInfo2 = anim2.GetCurrentAnimatorStateInfo(0);
        /*      if (Input.GetKeyDown(KeyCode.W))
              {

                  anim1.SetTrigger(idlehash);

              }
              if (Input.GetKeyDown(KeyCode.Q))
              {

                  anim1.SetTrigger(lefthash);

              }
              if (Input.GetKeyDown(KeyCode.R))
              {
                  anim1.SetTrigger(righthash);
              }
              if (Input.GetKeyDown(KeyCode.K))
              {
                  anim1.SetTrigger(kickhash);
              }
              if (Input.GetKeyDown(KeyCode.S))
              {
                  anim1.SetTrigger(smashhash);
              }
              if (Input.GetKeyDown(KeyCode.J))
              {
                  anim1.SetTrigger(sweephash);
              }
              if (Input.GetKeyDown(KeyCode.R))
              {
                  anim1.SetTrigger(elbowhash);
              }
              */
        //smash kick  elbow sweep player1
        if (a == true && b == true)
        {

            anim1.SetTrigger(starthash);
            anim2.SetTrigger(starthash);

        }
        /*   if (stateInfo1.nameHash == smashstatehash)
           {
               if (stateInfo2.nameHash == kickstatehash)
               {

                   anim1.SetTrigger(fallhash);
                   b = false;
                   a = false;
               }
               else if (stateInfo2.nameHash == smashstatehash)
               {
                   anim1.SetTrigger(fallhash);
                   anim2.SetTrigger(fallhash);
                   b = false;
                   a = false;

               }
               else
               {

                   anim2.SetTrigger(fallhash);
                   b = false;
                   a = false;
               }
               anim1.ResetTrigger(starthash);
               anim2.ResetTrigger(starthash);
           }
           if (stateInfo1.nameHash == kickstatehash)
           {
               if (stateInfo2.nameHash == elbowstatehash)
               {
                   anim1.SetTrigger(fallhash);
                   b = false;
                   a = false;
               }
               else if (stateInfo2.nameHash == kickstatehash)
               {
                   anim1.SetTrigger(fallhash);
                   b = false;
                   a = false;
                   anim2.SetTrigger(fallhash);
               }
               else
               {
                   anim2.SetTrigger(fallhash);
                   b = false;
                   a = false;
               }
               anim1.ResetTrigger(starthash);
               anim2.ResetTrigger(starthash);
           }
           if (stateInfo1.nameHash == elbowstatehash)
           {
               if (stateInfo2.nameHash == sweepstatehash)
               {
                   anim1.SetTrigger(fallhash);
                   b = false;
                   a = false;
               }
               else if (stateInfo2.nameHash == elbowstatehash)
               {

                   anim1.SetTrigger(fallhash);
                   anim2.SetTrigger(fallhash);
                   b = false;
                   a = false;
               }
               else
               {
                   anim2.SetTrigger(fallhash);
                   b = false;
                   a = false;
               }
               anim1.ResetTrigger(starthash);
               anim2.ResetTrigger(starthash);
           }
           if (stateInfo1.nameHash == sweepstatehash)
           {
               if (stateInfo2.nameHash == smashstatehash)
               {
                   anim1.SetTrigger(fallhash);
                   b = false;
                   a = false;
               }
               else if (stateInfo2.nameHash == sweepstatehash)
               {
                   anim1.SetTrigger(fallhash);
                   anim2.SetTrigger(fallhash);
                   b = false;
                   a = false;
               }
               else
               {
                   anim2.SetTrigger(fallhash);
                   b = false;
                   a = false;
               }
               anim1.ResetTrigger(starthash);
               anim2.ResetTrigger(starthash);

           }*/



        // using i and j
        if (i == 1)
        {
            if (j == 1)
            { }
        }



    }

   public void player1()
    {
        a = true;
    }


    public void player2()
    {
        b = true;
    }
    //smash kick  elbow sweep player1
    public void p1sweep()
    {
        i = 4;
    }
    public void p1kick()
    {
        i = 2;
    }
    public void p1elbow()
    {
        i = 3;
    }
    public void p1smash()
    {
        j = 1;
    }
    public void p2sweep()
    {
        j = 4;
    }
    public void p2kick()
    {
        j = 2;
    }
    public void p2elbow()
    {
        j = 3;
    }
    public void p2smash()
    {
        j = 1;
    }

    
}


