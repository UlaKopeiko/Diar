   M S B A M L   `   `   `  ����@  <Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Diary.UI.CasementsDiary.UI.Casements  5   	   )clr-namespace:Diary.UI.UCDiary.UI.UC  68   $    Diary.UI.Casements.WindowUsers   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Diary.UI.Casements     5   	   ,local1clr-namespace:Diary.UI.UC     68     � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$- 'Дневник самочувствия��5
   	   $	��700��6&   $
��1300��66   $	��900��6F   $
��1800��6V      WindowStyle#���   5       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/Decoration/WindowDecoration/WindowStyle.xaml?�6%   %    5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� -   5        $��	ListUsers��5       %� 
ScrollUnit$ Pixel=�5      $��1��68   $��Disabled=�6E   $��Center=�6y   $��Stretch=�6�   $��Stretch=�5      $	��900��6/   $
��1400��6>   $��0q�6N   
�������$��0q�5   $   ��5      �� 5       .R�5!         Diary.UI.UC.UCUser  $��10q�6$   5"      ��5$      �� 5%       �� 
TargetType" ��6   .�5&      -   5        5'      5)      �� 5*   
   $��0��6   ���#406474$��10q�63   	 �� CornerRadius$	 10��6?   ._�5+      �� 
 �� Orientation$
 
Horizontal=�6   .+�5,      �� -   5        $��/Source/Back.png��5,      $��60��62    � Cursor$
 Hand��6>   $��20 10 10 10q�6L   6a   �� 5-      $��Center=�6   $��	680 0 0 0q�68   .+�50      �� $	��480��6   $��40��6*   �� 51      -   5        $��tbSearch��51       $��Поиск по ФИО��61   $��	0 -32 0 0q�6E    J� Opacity$	 0.5Q�6X   $��Center=�6f   ���#508068  NormalForLight#��[ 6�   6�   �� 52      $��/Source/Search.png��6   $��30��68   $��30��6D   $��10 -40 0 0 q�6O   $
��Left=�6d   �� 53      -   5        $��	tbxSearch��53   l   $��
50 -40 0 0q�6   $��0q�62   
������ $	��430��6`   $��40��6}   6�   55      56      57      �� 58   
   -   5        $��btnAdd��58      $��2��6   $��Создать��6,   6>   59      5:      