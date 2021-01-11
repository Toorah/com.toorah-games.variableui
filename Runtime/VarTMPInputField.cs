using System.Collections;
using System.Collections.Generic;
using Toorah.ScriptableVariables;
using UnityEngine;
using TMPro;

namespace Toorah.VariableUI
{
    public class VarTMPInputField : VarUIDriver<TMP_InputField, StringVariable>
    {
        protected override void BindUI()
        {
            m_ui.text = m_variable.Value;
            
            m_variable.OnValueChanged.AddListener(m_ui.SetTextWithoutNotify);
            m_ui.onValueChanged.AddListener(m_variable.SetValue);
        }

        protected override void UnBindUI()
        {
            m_variable.OnValueChanged.RemoveListener(m_ui.SetTextWithoutNotify);
            m_ui.onValueChanged.RemoveListener(m_variable.SetValue);
        }
    }
}
