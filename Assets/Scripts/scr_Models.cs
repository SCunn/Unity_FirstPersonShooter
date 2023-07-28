using System;
using System.Collections.Generic;
using UnityEngine;

public static class scr_Models
{
    #region - Player -

    [Serializable]

    public class PlayerSettingsMode1
    {
        [Header("View Settings")]
        public float ViewXSensitivity;
        public float ViewYSensitivity;

        public bool ViewXInverted;
        public bool ViewYInverted;
    }

    #endregion
    
}
