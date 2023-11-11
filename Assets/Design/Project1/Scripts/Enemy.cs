using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameWorkProject
{
    public class Enemy : MonoBehaviour
    {
       private void OnMouseDown()
       {
        Destroy(gameObject);
       }
    }
}

