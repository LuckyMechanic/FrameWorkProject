using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Design.Project1
{
    public class GameStartPanel : MonoBehaviour
    {
        public GameObject Enemy;
        public GameObject BtnStart;

        // Start is called before the first frame update
        void Start()
        {
            BtnStart.GetComponent<Button>()
                .onClick.AddListener(() =>
                {
                    gameObject.SetActive(false);
                    Enemy.SetActive(true);
                }
                );
        }
    }

}
