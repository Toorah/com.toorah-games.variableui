using System.Collections;
using System.Collections.Generic;
using Toorah.ScriptableVariables;
using UnityEngine;
using TMPro;

namespace Toorah.VariableUI
{
    public class VarTMPInputField : TMP_InputField
    {
        [SerializeField] StringVariable m_variable;

        protected override void Awake()
        {
            text = m_variable.Value;
            
            m_variable.OnValueChanged.AddListener(SetTextWithoutNotify);
            onValueChanged.AddListener(v => m_variable.Value = v);
        }
    }
}
