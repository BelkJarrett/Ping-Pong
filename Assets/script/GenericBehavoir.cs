using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;
using System.Collections.Generic;
using System.IO;


namespace muninum
{
   [System.Serializable]
   public class Genericforces
    {
        public Vector3 force;
        public Vector3 impulse;
        public Vector3 acceleration;
        public Vector3 velocitychange;

        public Genericforces()
        {
            force = Vector3.zero;
            impulse = Vector3.zero;
            acceleration = Vector3.zero;
            velocitychange = Vector3.zero;
        }

        public void forceZero()
        {
            force = Vector3.zero;
        }

        public void forceSet(Vector3 t)
        {
            force = t;
        } 

         public void impulseZero()
        {
            impulse = Vector3.zero;
        }

        public void impulseSet(Vector3 t)
        {

        }
    }
}
