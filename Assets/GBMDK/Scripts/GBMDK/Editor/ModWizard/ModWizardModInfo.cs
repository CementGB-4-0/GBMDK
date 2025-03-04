using System;
using UnityEngine;
using UnityEngine.Events;

namespace GBMDK.Editor
{
    public class ModWizardModInfo : ScriptableObject
    {
        [HideInInspector]
        public bool CurrentlyActive 
        {
            get
            {
                return _currentlyActive;
            }
            set
            {
                if (_currentlyActive != value)
                {
                    ActiveStateChanged.Invoke(_currentlyActive);
                }
                _currentlyActive = value;
            }
        }
        private bool _currentlyActive;

        public UnityEvent<bool> ActiveStateChanged;

        public ModWizardModInfo_Refs refs;
    }
}