   M S B A M L   `   `   `  ����@  <Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Diary.UI.CasementsDiary.UI.Casements  5   	   &     Diary.UI.Casements.WindowInfTest   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Diary.UI.Casements     5   	     � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$- 'Дневник самочувствия��5
   	   $	��700��6&   $
��1300��66   $	��900��6F   $
��1400��6V      WindowStyle#���   6f    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/Decoration/WindowDecoration/WindowStyle.xaml?�6%   %    5      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   � -   5         �Name$ 	mainAreal��5      $��0��6    � RowDefinitions 5      �� 5      $	��160 �6    �� 5      $��* �6    .+�5      �� ���#406474	 �� CornerRadius$	 10��6*   $��10q�6<   ._�5       �� -   5        $��tbTitle��5    b   $��Название��6   $
��Left=�6,   $��Center=�6G     HeaderForDark#��[ 6q   $��50 0 0 0q�6�   5!      � 5"      $��1��6   
�������.+�5#      �� .+�5$      �� -   5        
 ��Name$
 ListQuestions��5$   -   $��0��6     %� 
ScrollUnit$ Pixel=�6D   $��Disabled=�6i   $��0q�6�   $	��400��6�   $��
10 10 10 0q�6�   ��5%      �� 5&      .R�5'      ��  �� Orientation$ 
Horizontal=�6%   $��40��6>   .+�5(   &   �� $	��Top=�6I   $��20��6a     NormalForLight#��[ 6l   ��61   �� *Factor+6l   �� 5)   &   $	��Top=�6F   $	��700��6^   $
��Wrap=�6j   #��[ 6~   ��60   �� *Text+6~   5*      5+      5-      5/      50      51      � 52   
   -   5        $ openFilters��52      $��1��6   $��Right=�6/   $	��400��6K   .+�53      �� $ 
Horizontal=�6   .+�54      �� -   5        $	��100��54      $��30��6'   ���#CF9A5F$	 	10 0 0 10��6G   $
��Left=�6a   $��Center=�6|   $��0 0 0 0q�6�   ._�55      �� $��Center=�6!   .+�56      �� -   5        $��btnOpenImage��56       $��20��64   $ ��/Source/NavigatingLeft.png��6@   �� 57      -   5        $��btnCloseImage��57   !   ���#CF9A5F$��	0 -20 0 0q�6K   ._�58      �� $��20��6%   $!��/Source/NavigatingRight.png��63   59      5:      5<      �� 5=      $��1��6   ���#406474$	 10��6?   $
��0 40q�6Q   ._�5>      �� $	��Top=�6!   $��0 60 0 0q�69   .+�5?      �� �� 5@      -   5        $��tbSearch��5@   %   $*��$Поиск по содержанию��65   $��-20 -27 0 0q�6P    J� Opacity$	 0.5Q�6e   $��Center=�6t   ���#508068#��[ 6�   6�   �� 5A      -	   5        $��	tbxSearch��5A   N   $��	0 -30 0 0q�6"   
������ 6�   �� 5B      -
   5        $��btnEditActivity��5B   T   $��	0 150 0 0q�6"   $-��'Настроить активность��65   6k   �� 5C      -   5        $��btnBackMenu��5C   F   $��20q�6!   $ ��В главное меню��6-   6Y   �� 5D      -   5        $��btnBack��5D   D   $��0 85 0 0q�6"   $��
Назад��64   6S   5E      5F      5G      5J      5L      5M      