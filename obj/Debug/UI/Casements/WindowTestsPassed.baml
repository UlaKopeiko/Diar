   M S B A M L   `   `   `  ����@  <Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Diary.UI.CasementsDiary.UI.Casements  5   	   *    $Diary.UI.Casements.WindowTestsPassed   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Diary.UI.Casements     5   	     � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	   $	��700��5
   	   $
��1300��6   $	��900��6)   $
��1400��69      WindowStyle#���   6I    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/Decoration/WindowDecoration/WindowStyle.xaml?�6%   %    5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� $��0��6   ���#406474 �� CornerRadius$ 10��63   $��10q�6E   �� 5   
   $��Center=�6    �� Orientation$ 
Horizontal=�60   .+�5      �� -   5         � Cursor$
 Hand��5      $��/Source/Back.png��6"   $��40��6<   $��40��6H   $��30 0 0 0q�6S   6e   �� 5      $��Center=�6   $��	700 0 0 0q�64   .+�5!      �� $	��480��6   $��40��6&   �� 5"      -   5        $��tbSearch��5"      $&�� Поиск по названию��6-   $��-90 -32 0 0q�6F   	 J� Opacity$		 0.5Q�6[   $��Center=�6i   ���#508068  NormalForLight#��[ 6�   6�   �� 5#      $��/Source/Search.png��6   $��30��64   $��30��6@   $��10 -40 0 0 q�6K   $
��Left=�6`   �� 5$      -   5        $��	tbxSearch��5$   h   $��
50 -40 0 0q�6   $��0q�6.   
������ $	��430��6\   $��40��6y   6�   5&      5'      �� 5)   
   $��1��6   .+�5*      �� -   5        
 ��Name$
 ListFile��5*       %� 
ScrollUnit$ Pixel=�6)   $��Disabled=�6N   $��0q�6�   $��
10 30 10 0q�6�   ��5+      �� 5,      .R�5-      �� $ 
Horizontal=�6%   .+�5.      �� $	��Top=�6F   $
��1100��6^   #��[ 6l   ��6(   �� *DocumentName+6l   �� 5/      $��Download��6\   -   5        $��/Source/Download.png��5/   $   $��20��6B   $
 Hand��6N   6l   �� 50      $��Delete��6l   -   5        $��/Source/Delete.png��50   $   $��20��6@   $��40 0 0 0q�6L   $
 Hand��6^   6z   52      53      56      �� 57      -   5        $��tbNoResults��57      $&�� Ничего не найдено��6+    
 Header#��[ 6D   $��Center=�6d   $y�	Collapsed=�6�   58      �� 59   
   $ 
Horizontal=�6   $��2��6.   $��Center=�6;   .+�5:      �� -   5        $��btnContinue��5:      $��Добавить��6(   6;   5;      5<      5=      