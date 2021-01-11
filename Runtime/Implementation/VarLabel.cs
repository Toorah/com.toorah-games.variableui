using System.Collections;
using System.Collections.Generic;
using TMPro;
using Toorah.ScriptableVariables;
using UnityEngine;
using UnityEngine.UI;

namespace Toorah.VariableUI
{

    public class VarLabel : VarUIDriver<TextMeshProUGUI, StringVariable>
    {
        void ApplyValue(string t)
        {
            m_ui.text = t;
        }

        protected override void BindUI()
        {
            m_ui.text = m_variable.Value;
            m_variable.OnValueChanged.AddListener(ApplyValue);
        }

        protected override void UnBindUI()
        {
            m_variable.OnValueChanged.RemoveListener(ApplyValue);
        }
    }

}