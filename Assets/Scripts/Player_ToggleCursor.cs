﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class Player_ToggleCursor : NetworkBehaviour
{
    public FirstPersonController fpsController;
    
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;     // Get out this method if it isnt the local player
        }

        if (Input.GetButtonUp("Cancel"))
        {
            ToggleCursor();
        }
    }

    void ToggleCursor()
    {
        fpsController.enabled = !fpsController.enabled;  // Swap current active status
    }
}
