using System.Collections;
using System.Collections.Generic;
using Toorah.ScriptableVariables;
using UnityEngine;
using UnityEngine.UI;

namespace Toorah.VariableUI
{

    public class VarSlider : VarUIDriver<Slider, FloatVariable>
    {

        protected override void BindUI()
        {
            m_ui.value = m_variable.Value;

            m_variable.OnValueChanged.AddListener(m_ui.SetValueWithoutNotify);
            m_ui.onValueChanged.AddListener(m_variable.SetValue);
        }

        protected override void UnBindUI()
        {
            m_variable.OnValueChanged.RemoveListener(m_ui.SetValueWithoutNotify);
            m_ui.onValueChanged.RemoveListener(m_variable.SetValue);
        }
    }

}