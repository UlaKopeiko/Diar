   M S B A M L   `   `   `  ����@  <Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Diary.UI.CasementsDiary.UI.Casements  5   	   (    "Diary.UI.Casements.WindowListTests   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Diary.UI.Casements     5   	   -   5          � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$- 'Дневник самочувствия��5
   	   $	��700��6&   $
��1300��66   $	��900��6F   $
��1400��6V      WindowStyle#���   6�    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/Decoration/WindowDecoration/WindowStyle.xaml?�6%   %    5      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��400 �6   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $��* �6    �� 5      $	��100 �6    .+�5      �� -   5         ��Name$ ListTest��5   $   $��0��6   	 %� 
ScrollUnit$	 Pixel=�66   $��Disabled=�6[   $��0q�6�   $��	10 30 0 0q�6�   ��5      �� 5       .R�5!      �� 
 �� Orientation$
 
Horizontal=�6!   $��40��6:   .+�5"      ��  ��Name$ tbCode��6$     NormalForLight#��[ 65   $	��100��6]   �� 5#      $�#��6"    �� 5$       �Name$
 tbID��6"   �6.   �� *ID+5%      �� 5&      $	��Top=�6;   $	��500��6S   #��[ 6_   ��6$   �� *Title+6_   �� 5'      $	��Top=�6F   $��
100 10 0 0q�6^   #��[ 6r   ��6$   �� *TestStatu.Title+6r   5(      5)      5+      �� 5,      $��1��6   $
 
Horizontal=�6&   $��Center=�6?   .+�5-      �� -   5        $��btnNext��5-      $��Продолжить��6(   $��0 0 0 60q�6=   6O   5/      50      �� 51   
   $��1��6   ���#406474$��40q�66    �� CornerRadius$ 10��6B   ._�52      �� $	��Top=�6   $��	0 100 0 0q�61   .+�53      �� �� 54      -   5        $��tbSearch��54      $&�� Поиск по названию��6-   $��-40 -27 0 0q�6F    J� Opacity$	 0.5Q�6[   $��Center=�6i   ���#508068#��[ 6�   6�   �� 55      -   5        $��	tbxSearch��55   F   $��	0 -30 0 0q�6   
������ 6   �� 56      $��Статус:��6     NormalForDark#��[ 6+   $
��Left=�6S   $��	50 50 0 5q�6n   �� 57      ���#406474$��50 5 0 0q�61   $��0q�6C   .@�58      	� -   5        $��
rbActivity��58   5   $��Активный��6"   6G   	� 59      -   5        $��	rbExpects��59   4   $��Ожидает��6"   6E   	� 5:      -   5        $��
rbDisabled��5:   5   $��Отключен��6"   6G   	� 5;      -	   5        $��rbAll��5;   0   $��Все��6"   6=   5<      5=      5>      �� 5?   
   -
   5        $��btnBack��5?      $��1��6    $��Bottom=�60   $��10 10 10 65q�6L   $��
Назад��6a   6�   5@      5A      