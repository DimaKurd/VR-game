﻿#pragma checksum "D:\studying\III курс\Нейроинтерфейсы\4lab\Windows-universal-samples-master\Windows-universal-samples-master\Samples\BluetoothLE\shared\Scenario3_ServerForeground.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E03D0DD5D7AF2BA341E17B8974E21846"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDKTemplate
{
    partial class Scenario3_ServerForeground : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Scenario3_ServerForeground_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IScenario3_ServerForeground_Bindings
        {
            private global::SDKTemplate.Scenario3_ServerForeground dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj4;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj4Click;

            // Static fields for each binding's enabled/disabled state

            public Scenario3_ServerForeground_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 36 && columnNumber == 72)
                {
                    this.obj4.Click -= obj4Click;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // Scenario3_ServerForeground.xaml line 36
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Button)target;
                        this.obj4Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.PublishButton_ClickAsync();
                        };
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += obj4Click;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IScenario3_ServerForeground_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::SDKTemplate.Scenario3_ServerForeground)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::SDKTemplate.Scenario3_ServerForeground obj, int phase)
            {
                if (obj != null)
                {
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Scenario3_ServerForeground.xaml line 32
                {
                    this.PeripheralWarning = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // Scenario3_ServerForeground.xaml line 35
                {
                    this.ServerPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // Scenario3_ServerForeground.xaml line 36
                {
                    this.PublishButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 5: // Scenario3_ServerForeground.xaml line 55
                {
                    this.ResultText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Scenario3_ServerForeground.xaml line 47
                {
                    this.Operand2Text = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Scenario3_ServerForeground.xaml line 43
                {
                    this.OperationText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Scenario3_ServerForeground.xaml line 44
                {
                    this.OperationLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Scenario3_ServerForeground.xaml line 39
                {
                    this.Operand1Text = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Scenario3_ServerForeground.xaml line 13
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Scenario3_ServerForeground_obj1_Bindings bindings = new Scenario3_ServerForeground_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

