﻿#pragma checksum "H:\WP\Lina.Anco.WP\Lina.Anco.WP\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "59FB936AE75A90432DB1796DA60549C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Lina.Anco.WP {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard myStoryboard;
        
        internal System.Windows.Media.Animation.Storyboard myStoryboard1;
        
        internal System.Windows.Media.Animation.Storyboard myStoryboard2;
        
        internal System.Windows.Media.Animation.Storyboard myStoryboard3;
        
        internal System.Windows.Media.Animation.Storyboard myStoryboard4;
        
        internal System.Windows.Media.Animation.Storyboard linaStorybord;
        
        internal System.Windows.Media.Animation.DoubleAnimation animationOpacity;
        
        internal System.Windows.Media.Animation.Storyboard showStart;
        
        internal System.Windows.Media.Animation.Storyboard hideStart;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.ProgressBar prgTime;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button result;
        
        internal System.Windows.Controls.TextBlock currentquestion;
        
        internal System.Windows.Controls.TextBlock maxQuestion;
        
        internal System.Windows.Controls.Button btnleftQuestion;
        
        internal System.Windows.Controls.Image btncalculation;
        
        internal System.Windows.Controls.Button btnrightQuestion;
        
        internal System.Windows.Controls.Button result1;
        
        internal System.Windows.Controls.Button result2;
        
        internal System.Windows.Controls.Button btnStart;
        
        internal System.Windows.Controls.Button btnSetting;
        
        internal System.Windows.Controls.Grid markGameover;
        
        internal System.Windows.Media.EllipseGeometry myCircle;
        
        internal System.Windows.Controls.Primitives.Popup my_popup_xaml1;
        
        internal System.Windows.Controls.Border FoldingPanel;
        
        internal System.Windows.Controls.StackPanel linaBangDime;
        
        internal System.Windows.Controls.TextBlock lnUserLevel;
        
        internal System.Windows.Controls.TextBlock lnNumberOfQS;
        
        internal System.Windows.Controls.Button btnTryAgain;
        
        internal System.Windows.Controls.Grid markPauseGame;
        
        internal System.Windows.Controls.Image sound;
        
        internal System.Windows.Controls.Image vibration;
        
        internal System.Windows.Controls.Grid markLavelUp;
        
        internal System.Windows.Controls.Image s1;
        
        internal System.Windows.Controls.TextBlock txtlvUp;
        
        internal System.Windows.Controls.Image s2;
        
        internal System.Windows.Controls.Button btnNextLevel;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Lina.Anco.WP;component/MainPage.xaml", System.UriKind.Relative));
            this.myStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("myStoryboard")));
            this.myStoryboard1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("myStoryboard1")));
            this.myStoryboard2 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("myStoryboard2")));
            this.myStoryboard3 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("myStoryboard3")));
            this.myStoryboard4 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("myStoryboard4")));
            this.linaStorybord = ((System.Windows.Media.Animation.Storyboard)(this.FindName("linaStorybord")));
            this.animationOpacity = ((System.Windows.Media.Animation.DoubleAnimation)(this.FindName("animationOpacity")));
            this.showStart = ((System.Windows.Media.Animation.Storyboard)(this.FindName("showStart")));
            this.hideStart = ((System.Windows.Media.Animation.Storyboard)(this.FindName("hideStart")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.prgTime = ((System.Windows.Controls.ProgressBar)(this.FindName("prgTime")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.result = ((System.Windows.Controls.Button)(this.FindName("result")));
            this.currentquestion = ((System.Windows.Controls.TextBlock)(this.FindName("currentquestion")));
            this.maxQuestion = ((System.Windows.Controls.TextBlock)(this.FindName("maxQuestion")));
            this.btnleftQuestion = ((System.Windows.Controls.Button)(this.FindName("btnleftQuestion")));
            this.btncalculation = ((System.Windows.Controls.Image)(this.FindName("btncalculation")));
            this.btnrightQuestion = ((System.Windows.Controls.Button)(this.FindName("btnrightQuestion")));
            this.result1 = ((System.Windows.Controls.Button)(this.FindName("result1")));
            this.result2 = ((System.Windows.Controls.Button)(this.FindName("result2")));
            this.btnStart = ((System.Windows.Controls.Button)(this.FindName("btnStart")));
            this.btnSetting = ((System.Windows.Controls.Button)(this.FindName("btnSetting")));
            this.markGameover = ((System.Windows.Controls.Grid)(this.FindName("markGameover")));
            this.myCircle = ((System.Windows.Media.EllipseGeometry)(this.FindName("myCircle")));
            this.my_popup_xaml1 = ((System.Windows.Controls.Primitives.Popup)(this.FindName("my_popup_xaml1")));
            this.FoldingPanel = ((System.Windows.Controls.Border)(this.FindName("FoldingPanel")));
            this.linaBangDime = ((System.Windows.Controls.StackPanel)(this.FindName("linaBangDime")));
            this.lnUserLevel = ((System.Windows.Controls.TextBlock)(this.FindName("lnUserLevel")));
            this.lnNumberOfQS = ((System.Windows.Controls.TextBlock)(this.FindName("lnNumberOfQS")));
            this.btnTryAgain = ((System.Windows.Controls.Button)(this.FindName("btnTryAgain")));
            this.markPauseGame = ((System.Windows.Controls.Grid)(this.FindName("markPauseGame")));
            this.sound = ((System.Windows.Controls.Image)(this.FindName("sound")));
            this.vibration = ((System.Windows.Controls.Image)(this.FindName("vibration")));
            this.markLavelUp = ((System.Windows.Controls.Grid)(this.FindName("markLavelUp")));
            this.s1 = ((System.Windows.Controls.Image)(this.FindName("s1")));
            this.txtlvUp = ((System.Windows.Controls.TextBlock)(this.FindName("txtlvUp")));
            this.s2 = ((System.Windows.Controls.Image)(this.FindName("s2")));
            this.btnNextLevel = ((System.Windows.Controls.Button)(this.FindName("btnNextLevel")));
        }
    }
}
