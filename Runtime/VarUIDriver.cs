using System.Collections;
using System.Collections.Generic;
using Toorah.ScriptableVariables;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Toorah.VariableUI
{
    public abstract class VarUIDriver<T, U> : MonoBehaviour where T : UIBehaviour where U : BaseVariable
    {
        [SerializeField] protected T m_ui;
        [SerializeField] protected U m_variable;

        protected abstract void BindUI();
        protected abstract void UnBindUI();

        private void Reset()
        {
            m_ui = (T)GetComponent(typeof(T));
            if (m_ui == null)
            {
                m_ui = gameObject.AddComponent<T>();
            }
        }

        /// <summary>
        /// When overriding, make sure to call: <code>base.OnEnable();</code>
        /// </summary>
        protected virtual void OnEnable()
        {
            if(m_variable != null && m_ui != null)
                BindUI();
        }

        /// <summary>
        /// When overriding, make sure to call: <code>base.OnDisable();</code>
        /// </summary>
        protected virtual void OnDisable()
        {
            if (m_variable != null && m_ui != null)
                UnBindUI();
        }
    }
}
