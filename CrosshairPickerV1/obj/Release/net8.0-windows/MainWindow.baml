   M S B A M L   `   `   `  ���� L  HCrosshairPickerV1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CrosshairPickerV1CrosshairPickerV1  "    CrosshairPickerV1.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:CrosshairPickerV1     -     � Title$  
MainWindow��$	��450��$	��400�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=����#24232B � 	Resources  �� 
TargetType   CustomSliderStyle �� Property �� Value �� 
TargetType � ColumnDefinitions	 ]�Name
 ]� DecreaseRepeatButton J� Opacity ]� Thumb n�Name ]� IncreaseRepeatButton  ComboBoxTest2 d� 	IsChecked �� Path �� Mode �� RelativeSource ��Name �� CornerRadius F�Name �� Triggers P� Property P� Value �� 
TargetName J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly �� 
IsReadOnly  �� IsDropDownOpen! � AllowsTransparency" J� SnapsToDevicePixels# � ActualWidth$ �� MaxDropDownHeight% K� IsItemsHost& �� Triggers��%R  &	        &	 �    �� " ��.���  � �� �� " ��.R��  �� $
��Auto ��� $��* ��� $
��Auto �.+��� ���#18171F$��10��$��Center=�$��1��._�]� $	 
PART_Track��$|�False��
 �� $��Slider.DecreaseLarge��$ 5Q�$��False�����#18171F$��0q� n� $ Thumb��$��25��$��25�����#A4FFAF
������ $��0q� �� $��Slider.IncreaseLarge��$ 0Q�$��False�����#18171F$��0q��� " ��.���  � �� �� " ��.R�� .+�d� $��2��$|�false�� �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+���� .R��  �� $��5* ��� $��* �.+��� $ Border��$��2��$ 5�����#A4FFAF
���   �$��1q��� $��0��$ 5,0,0,5��$��1q����#18171F
���   �$��0,0,1,0q�F� $ Arrow��$��1�����#18171F$��Center=�$��Center=�"����        � 	=  	= � z     	 P�  �@J�IsMouseOver$
 true��. ��� $ Border�� � �� �#A4FFAFP�  �@d�	IsChecked$
 trueY�. ��� $ Border�� � �� �#A4FFAF�� $��ContentSite��$ False��#��z #��z #��z��$��3q��� $ PART_EditableTextBox��$y�Hidden=�# z � $��Popup��$��Bottom=�#��z  $
! True��$|�False��$��Slide=�.��� $��DropDown��$
" True��#��z# #��z$ .+��� $ DropDownBorder�����#18171F�� $
" True��.���� $
% True��& .��� .+�� -   $��mainGrid��' � RowDefinitions' �� $��20 ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��20 � �� $��20 ��� $��* ��� $��20 �.+��� -   ( ��Name$( sliderCrosshairSize��$��1��$��1��$��1��) � Maximum$) 50Q�* � Minimum$* 2Q�+ � SmallChange$+ 1Q�#��[  , � Cursor$
, Hand���� $��	THICKNESS��$��2��
�������$��1��$��Center=��� -   $( sliderStrokeThickness��$��2��$��1��$��1��$) 10Q�$* 1Q�$+ 1Q�#��[  $
, Hand���� $	��GAP��$��3��
�������$��1��$��Center=��� -   $( sliderCrosshairGap��$��3��$��1��$��1��$	) 250Q�$	* -10Q�$+ 1Q�#��[  $
, Hand���� -   $��btnClose��$��X��$��20��$��20��$��0��$��2�����#A4FFAF
�������$
, Hand��$��Right=�$��Center=��� -   $��activateCrosshairButton��$��ActivateCrosshair��$	��150��$��50��$��6��$��1��$��2��$��2�����#A4FFAF$
, Hand��
�������$��Center=�$��Center=��� $
��SIZE��$��1��
�������$��1��$��Center=��� -   - ��Name$- cmbColor��$��1��$	��240��$��5��#��[ $
, Hand������ .R��� . �� Orientation$. 
Horizontal=�$��20��.+��� $��16��$��16��$��	50,0,20,0q����� *Brush+�� 
����������� *Name+