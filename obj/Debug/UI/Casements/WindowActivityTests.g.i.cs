﻿#pragma checksum "..\..\..\..\UI\Casements\WindowActivityTests.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D1145DD1A929FC93B06B92CA5253C60ECDD576F60E292061FCCB5AF9158125B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Diary.UI.Casements;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Diary.UI.Casements {
    
    
    /// <summary>
    /// WindowActivityTests
    /// </summary>
    public partial class WindowActivityTests : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\UI\Casements\WindowActivityTests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbTitle;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\UI\Casements\WindowActivityTests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnBack;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\UI\Casements\WindowActivityTests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListActivity;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\UI\Casements\WindowActivityTests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border DateSelection;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\UI\Casements\WindowActivityTests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar calendar;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\UI\Casements\WindowActivityTests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\UI\Casements\WindowActivityTests.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/Diary;component/ui/casements/windowactivitytests.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\Casements\WindowActivityTests.xaml"
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
            this.tbTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.btnBack = ((System.Windows.Controls.Image)(target));
            
            #line 28 "..\..\..\..\UI\Casements\WindowActivityTests.xaml"
            this.btnBack.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btnBack_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ListActivity = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.DateSelection = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.calendar = ((System.Windows.Controls.Calendar)(target));
            
            #line 64 "..\..\..\..\UI\Casements\WindowActivityTests.xaml"
            this.calendar.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Calendar_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\UI\Casements\WindowActivityTests.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\..\UI\Casements\WindowActivityTests.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

