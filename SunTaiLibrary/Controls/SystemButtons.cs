﻿using System.Windows;
using System.Windows.Controls;

namespace SunTaiLibrary.Controls
{
    /// <summary>
    /// 自定义窗体右上角的功能按钮组
    /// </summary>
    public class SystemButtons : Control
    { 
        static SystemButtons()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SystemButtons), new FrameworkPropertyMetadata(typeof(SystemButtons)));
        }
    }
}
