   M S B A M L   `   `   `  ����@  <Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Diary.UI.CasementsDiary.UI.Casements  5   	   )clr-namespace:Diary.UI.UCDiary.UI.UC  68   *    $Diary.UI.Casements.WindowTestPassing   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Diary.UI.Casements     5   	   ,local1clr-namespace:Diary.UI.UC     68   -   5          � WindowStyle$
  None=�5       � WindowStartupLocation$ CenterScreen=�5	   	   $	��700��5
   	   $
��1300��6   $	��700��6)   $
��1300��69      WindowStyle#���   6I    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/Decoration/WindowDecoration/WindowStyle.xaml?�6%   %    5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   ���#406474 �� CornerRadius$ 10��63   $��10q�6E   ._�5      �� $
��Left=�6   $��Center=�64   $
��10 0q�6O    �� Orientation$ 
Horizontal=�6]   .+�5      �� -   5        $��/Source/Back.png��5      $��60��62    � Cursor$
 Hand��6Z   �� 5      -   5        $��tbTest��5      $!��Название теста��6*     HeaderForDark#��[ 6@   $��Center=�6g   5      5      �� 5    
   -   5        $��tbTime��5       $��40 0 q�6#   #��[ 62   $��Center=�6Y   $��Right=�6t   �� 5!   
   $��1��6   $��10 30q�6$   	 %� 
ScrollUnit$	 Pixel=�63   .��5"   
   �� .+�5$      �� -   5        
 ��Name$
 ListQuestion��5$      $��0q�62   $	 Pixel=�6F   $��Disabled=�6k   $��Disabled=�6�   ��5%      �� 5&      .R�5'         Diary.UI.UC.UCQuestion  $��10q�60   $
��1200��6<   5(      5*      �� 5+      -   5        $��btnSave��5+   -   $��Завершить��6   $��Center=�6=   $
��40 0q�6Z   6h   5.      5/      50      51      