﻿#pragma checksum "e:\Documents\Visual Studio 2017\Projects\TelerikChartTest\TelerikChartTest\Views\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "715E545F791D65EEBE50150332317546"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelerikChartTest.Views
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_TelerikChartTest_Controls_ChartUC_ChartItems(global::TelerikChartTest.Controls.ChartUC obj, global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartModel> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartModel>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartModel>), targetNullValue);
                }
                obj.ChartItems = value;
            }
            public static void Set_TelerikChartTest_Controls_ChartUC_ChartEventItems(global::TelerikChartTest.Controls.ChartUC obj, global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartEvent> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartEvent>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartEvent>), targetNullValue);
                }
                obj.ChartEventItems = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::TelerikChartTest.Views.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::TelerikChartTest.Controls.ChartUC obj3;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // Views\MainPage.xaml line 15
                        this.obj3 = (global::TelerikChartTest.Controls.ChartUC)target;
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

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
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::TelerikChartTest.Views.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TelerikChartTest.Views.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::TelerikChartTest.ViewModels.MainViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Data(obj.Data, phase);
                        this.Update_ViewModel_EventData(obj.EventData, phase);
                    }
                }
            }
            private void Update_ViewModel_Data(global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartModel> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_Data(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\MainPage.xaml line 15
                    XamlBindingSetters.Set_TelerikChartTest_Controls_ChartUC_ChartItems(this.obj3, obj, null);
                }
            }
            private void Update_ViewModel_EventData(global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartEvent> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_EventData(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\MainPage.xaml line 15
                    XamlBindingSetters.Set_TelerikChartTest_Controls_ChartUC_ChartEventItems(this.obj3, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MainPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MainPage_obj1_Bindings> weakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public MainPage_obj1_Bindings TryGetBindingObject()
                {
                    MainPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                    UpdateChildListeners_ViewModel_Data(null);
                    UpdateChildListeners_ViewModel_EventData(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::TelerikChartTest.ViewModels.MainViewModel obj = sender as global::TelerikChartTest.ViewModels.MainViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Data(obj.Data, DATA_CHANGED);
                                bindings.Update_ViewModel_EventData(obj.EventData, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Data":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Data(obj.Data, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "EventData":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_EventData(obj.EventData, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::TelerikChartTest.ViewModels.MainViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::TelerikChartTest.ViewModels.MainViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_Data(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartModel>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_ViewModel_Data(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartModel>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartModel> cache_ViewModel_Data = null;
                public void UpdateChildListeners_ViewModel_Data(global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartModel> obj)
                {
                    if (obj != cache_ViewModel_Data)
                    {
                        if (cache_ViewModel_Data != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_Data).PropertyChanged -= PropertyChanged_ViewModel_Data;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_ViewModel_Data).CollectionChanged -= CollectionChanged_ViewModel_Data;
                            cache_ViewModel_Data = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_Data = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_Data;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_ViewModel_Data;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_EventData(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartEvent> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartEvent>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_ViewModel_EventData(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartEvent> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartEvent>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartEvent> cache_ViewModel_EventData = null;
                public void UpdateChildListeners_ViewModel_EventData(global::System.Collections.ObjectModel.ObservableCollection<global::TelerikChartTest.Models.ChartEvent> obj)
                {
                    if (obj != cache_ViewModel_EventData)
                    {
                        if (cache_ViewModel_EventData != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_EventData).PropertyChanged -= PropertyChanged_ViewModel_EventData;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_ViewModel_EventData).CollectionChanged -= CollectionChanged_ViewModel_EventData;
                            cache_ViewModel_EventData = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_EventData = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_EventData;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_ViewModel_EventData;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MainPage.xaml line 10
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // Views\MainPage.xaml line 19
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.Button_Click;
                }
                break;
            case 5: // Views\MainPage.xaml line 20
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.Button_Click_1;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

