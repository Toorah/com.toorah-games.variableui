using System.Collections;
using System.Collections.Generic;
using Toorah.ScriptableVariables;
using UnityEngine;
using UnityEngine.UI;

namespace Toorah.VariableUI
{

    public class VarSlider : Slider
    {
        [SerializeField] FloatVariable m_variable;

        protected override void Awake()
        {
            value = m_variable.Value;

            m_variable.OnValueChanged.AddListener(SetValueWithoutNotify);
            onValueChanged.AddListener(v => m_variable.Value = v);
        }

    }

}