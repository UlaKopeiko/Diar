   M S B A M L   `   `   `  ����@  <Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Diary.UI.CasementsDiary.UI.Casements  5   	   ,    &Diary.UI.Casements.WindowActivityTests   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Diary.UI.Casements     5   	     � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	   $	��700��5
   	   $
��1300��6   $	��700��6)   $
��1300��69      WindowStyle#���   6I    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/Decoration/WindowDecoration/WindowStyle.xaml?�6%   %    5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   ��  �� CornerRadius$ 10��6   ���#406474$��10q�68   �� 5   
   -   5        $��tbTitle��5   0   $��Right=�6   $��	0 30 40 0q�6?     HeaderForDark#��[ 6R   �� 5   
   -   5        $��btnBack��5      $��/Source/Back.png��6   $
��Left=�69    � Cursor$
 Hand��6T   $��50��6b   $��30 10q�6n   6}   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5       $	��420 �6#   .+�5"      �� -   5        	 ��Name$	 ListActivity��5"   '   $��0��6   
 %� 
ScrollUnit$
 Pixel=�6=   $��Disabled=�6b   $��0q�6�   $��10 30 10 10q�6�   ��5#      �� 5$      .R�5%      �� .+�5&      �� $��80��6)   .+�5'   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5(   &   �� $��Опрос:��60   $	��Top=�6>   $��
10 10 10 0q�6V     NormalForLight#��[ 6j   �� 5)   &   $	��Top=�6M   #��[ 6e   ��60   �� *Test1.Title+6e   5*   #   �� 5+   "   $ 
Horizontal=�6-   .+�5,   &   �� $��	Дата:��60   $	��Top=�6=   $��
10 10 10 0q�6U   #��[ 6i   �� 5-   &   $	��Top=�6d   #��[ 6|   ��60   �� *	StartTime+ �� StringFormat$ 
dd.MM.yyyy��6|   �� 5.   &   $��Время работы:��60   $	��Top=�6E   $��
10 10 10 0q�6]   #��[ 6q   �� 5/   &   $	��Top=�6b   $��	10 10 0 0q�6z   #��[ 6�   ��60   �� *	StartTime+$ HH:mm:ss��6�   �� 50   &   $��-��60   $	��Top=�69   $��
10 10 10 0q�6Q   #��[ 6e   �� 51   &   $	��Top=�6`   $��	10 10 0 0q�6x   #��[ 6�   ��60   �� *	EndTime+$ HH:mm:ss��6�   52   #   53      �� 54      $��10q�6(   $	��0.8��64   ���#406474$	��680��6V   55      57      59      �� 5:      $��1��6   $��Center=�6*   $��Center=�6G   .+�5;      �� -   5        $��DateSelection��5;      $��Center=�6/   
�������$��2q�6]   ���#406474$ 10��5<   +   $y�Visible=�6=   ._�5=      &   System.Windows.Controls.Calendar  -   5        $��calendar��5=   <   $��Center=�6   $��20q�6M   $	��300��6Y   $	��Top=�6f     CalendarStyle1#���  5>        CalendarButtonStyle1   CalendarButtonStyle# �  6D     CalendarDayButtonStyle1   CalendarDayButtonStyle# �  5?        CalendarItemStyle1   CalendarItemStyle# �  5@      ���	#FFAB9A9A6k   5A      �� 5B      -   5        $��	btnCancel��5B   %   $��20q�6   $��Отменить дату��66   6N   5C      5F      �� 5H   
   -   5        $��	btnDelete��5H      $��2��6   $��Удалить��6/   6A   5I      5J      