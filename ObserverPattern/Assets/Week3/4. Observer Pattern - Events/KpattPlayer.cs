/*****************************************************************************
// File Name :         KpattPlayer.cs
// Author :            Kyle Grenier
// Creation Date :     #CREATIONDATE#
//
// Brief Description : ADD BRIEF DESCRIPTION OF THE FILE HERE
*****************************************************************************/
using UnityEngine;

namespace ObserverPatternEvents
{
    public class KpattPlayer : MonoBehaviour
    {
        private void Start()
        {
            SendEventOnClick.OnPlayerDeath += Die;
        }

        void Die()
        {

        }  
    }
}
