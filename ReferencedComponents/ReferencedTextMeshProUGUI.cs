﻿using System;
using TMPro;
using UnityEngine;

namespace ReferenceSharing.ReferencedComponents
{
    public class ReferencedTextMeshProUGUI : ReferencedComponent<float>
    {
        [SerializeField] private string format, prefix, suffix;
        private TextMeshProUGUI _text;

        private void Awake()
        {
            _text = GetComponent<TextMeshProUGUI>();
        }

        protected override void OnValueChanged(object sender, float value)
        {
            _text.text = $"{prefix}{value.ToString(format)}{suffix}";
        }
    }
}