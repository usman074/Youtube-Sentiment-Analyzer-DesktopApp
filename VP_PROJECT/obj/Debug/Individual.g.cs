﻿#pragma checksum "..\..\Individual.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4967942A777ACBB1F51A0413FEAA1DA2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace VP_PROJECT {
    
    
    /// <summary>
    /// Individual
    /// </summary>
    public partial class Individual : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button prevBtn;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button startBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label score;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label sadness;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label joy;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fear;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label disgust;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label anger;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VP_PROJECT;component/individual.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Individual.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.prevBtn = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Individual.xaml"
            this.prevBtn.Click += new System.Windows.RoutedEventHandler(this.prevBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.startBtn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Individual.xaml"
            this.startBtn.Click += new System.Windows.RoutedEventHandler(this.startBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nextBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Individual.xaml"
            this.nextBtn.Click += new System.Windows.RoutedEventHandler(this.nextBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Individual.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.score = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.sadness = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.joy = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.fear = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.disgust = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.anger = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

