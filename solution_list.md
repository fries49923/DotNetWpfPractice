# [.net WPF Tested Code]

## [WpfAncestorDataBindingTest](./WpfAncestorDataBindingTest)

#Ancestor #DataBinding

MVVM架構，示範DataBinding使用祖先目標(Ancestor)，通常DataBinding會找最近的DataContext，如果參雜需要較遠的話，則需要使用RelativeSource搭配Ancestor，告訴XAML另外的條件尋找Binding的目標

<br>

## [WpfAttachedPropAndCtTest](./WpfAttachedPropAndCtTest)

#AttachedProperty #附加屬性 #ControlTemplate

示範在ControlTemplate中使用附加屬性，達成不透過繼承也能彈性控制樣式的內容設定，亦即將 ControlTemplate 內部元件的屬性設定分離，讓樣式更加模組化與可重用。

<br>

## [WpfBehaviorWithCommandTest](./WpfBehaviorWithCommandTest)

#Behavior #Mouse event #Command

測試使用Behavior，此範例在label內滑鼠移動時(MouseMove)顯示xy座標，滑鼠按鍵點擊時(MouseDown)觸發相關Command，此範例將此Command與ViewModel連結

<br>

## [WpfCommandLineTest](./WpfCommandLineTest)

#CommandLine #arg #Startup

測試 WPF 應用程式啟動時使用命令列參數，例如根據不同參數開啟不同視窗；開發階段可在 IDE（如 Visual Studio）的「偵錯」頁籤中設定參數；實際使用時可以透過 .bat 檔傳入參數執行

<br>

## [WpfDictionaryBindingTest](./WpfDictionaryBindingTest)

#Command Pattern #DictionaryBinding #Dictionary

使用Command Pattern的Class放到Dictionary，並測試三種ListBox顯示方式，並且SelectionChanged時取得對應的Class

<br>

## [WpfDropFileTest](./WpfDropFileTest)

#Behavior #Drop

測試將 Behavior 用於 Drop 事件，透過將檔案拖曳到 UI 上來取得路徑字串或顯示圖片

<br>

## [WpfFilterListBoxTest](./WpfFilterListBoxTest)

#ListBox #CollectionView #Filter

示範使用CollectionView，輸入字串到TextBox中，讓ListBox只顯示濾除後的結果

<br>

## [WpfFontResourceTest](./WpfFontResourceTest)

#FontResource #FontFamily #ttf

測試在 WPF 中使用 TTF 字體檔案，並透過 Resource 字典來管理和使用字體

<br>

## [WpfKeyBindingTest](./WpfKeyBindingTest)

#KeyBinding #Hot Key #MVVM

測試在MVVM架構下撰寫快捷鍵(HotKey)，按下指定組合時，去觸發綁定的ViewModel的Command

<br>

## [WpfListBoxAlternationIndexTest](./WpfListBoxAlternationIndexTest)

#ListBox #AlternationIndex #AlternationCount

測試ListBox可以經過設定，來讓項目根據索引的值來使用不同的設定，例如背景顏色

<br>

## [WpfListBoxDataTemplateDataTypeTest](./WpfListBoxDataTemplateDataTypeTest)

#ListBox #DataTemplate #DataType #Polymorphism

示範利用 DataTemplate 的 DataType 讓 ListBox 依據資料的子類別(型態)自動套用不同模板，並分別示範了三種實作方式：內嵌 XAML、UserControl、Control

<br>

## [WpfListBoxSelectorTest](./WpfListBoxSelectorTest)

#ListBox #StyleSelector #ItemTemplateSelector #ItemContainerStyleSelector #Style #DataTemplate

測試繼承StyleSelector與DataTemplateSelector，並搭配ListBox的ItemTemplateSelector與ItemContainerStyleSelector，在item不同條件下使用不同的Style與DataTemplate

<br>

## [WpfMvvmEventTriggerTest](./WpfMvvmEventTriggerTest)

#i:Interaction.Triggers #i:EventTrigger #MVVM 

測試使用EventTrigger，讓路由事件經過此方式觸發ViewModel的Command

<br>

## [WpfOpenCvImprocTest](./WpfOpenCvImprocTest)

#OpenCvSharp4 #Image processing #MVVM #Nuget

測試 OpenCvSharp4 影像處理套件，並搭配其擴充功能，將影像轉換至 WPF UI 進行顯示。測試內容涵蓋影像讀取、灰階轉換、標記 (Labeling)、輪廓偵測 (Contours) 以及即時擷取攝影機畫面 (Capture frame from webcam)。

<br>

## [WpfToolKitMvvmAndDiTest](./WpfToolKitMvvmAndDiTest)

#CommunityToolkit.Mvvm #DI #Ioc #Microsoft.Extensions.DependencyInjection #MVVM #Nuget

測試同時使用 ToolKit.Mvvm 與 DI 套件，其中 Mvvm 部分透過繼承 ObservableObject 與使用對應的 Attribute 來實作 ViewModel；DI 部分則測試使用 Ioc.Default 取得 ViewModel，以及將其注入至 View 中的方式

<br>

## [WpfTriggerAnimeTest](./WpfTriggerAnimeTest)

#Storyboard #EventTrigger #RoutedEvent

測試 WPF 中 EventTrigger 與 Storyboard，例如，透過滑鼠左鍵點擊觸發元件動畫效果

<br>

## [WpfUserControlAnimationTest](./WpfUserControlAnimationTest)

#Storyboard #Anime #UserControl #DependencyProperty

建立一個具有動畫的UserControl，並且加入DependencyProperty讓外部元件可以在XAML Binding參數，來控制動畫的撥放與停止

<br>

