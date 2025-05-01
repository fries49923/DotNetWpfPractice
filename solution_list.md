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

示範使用Behavior，此範例在label內滑鼠移動時(MouseMove)顯示xy座標，滑鼠按鍵點擊時(MouseDown)觸發相關Command，此範例將此Command與ViewModel連結

<br>

## [WpfFilterListBoxTest](./WpfFilterListBoxTest)

#ListBox #CollectionView #Filter

示範使用CollectionView，輸入字串到TextBox中，讓ListBox只顯示濾除後的結果

<br>

## [WpfListBoxDataTemplateDataTypeTest](./WpfListBoxDataTemplateDataTypeTest)

#ListBox #DataTemplate #DataType #Polymorphism

示範利用 DataTemplate 的 DataType 讓 ListBox 依據資料的子類別(型態)自動套用不同模板，並分別示範了三種實作方式：內嵌 XAML、UserControl、Control

<br>

## [WpfUserControlAnimationTest](./WpfUserControlAnimationTest)

#Storyboard #Anime #UserControl #DependencyProperty

建立一個具有動畫的UserControl，並且加入DependencyProperty讓外部元件可以在XAML Binding參數，來控制動畫的撥放與停止

<br>

