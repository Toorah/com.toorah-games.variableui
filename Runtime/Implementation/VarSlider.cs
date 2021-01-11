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

            m_variable.OnValueChanged.AddListener(SetValue);
            m_ui.onValueChanged.AddListener(m_variable.SetValue);
        }

        protected override void UnBindUI()
        {
            m_variable.OnValueChanged.RemoveListener(SetValue);
            m_ui.onValueChanged.RemoveListener(m_variable.SetValue);
        }


        void SetValue(float val)
        {
            val = Mathf.Clamp(val, m_ui.minValue, m_ui.maxValue);

            m_ui.SetValueWithoutNotify(val);
        }
    }

}