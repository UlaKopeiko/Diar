   M S B A M L   `   `   `  ����@  <Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Diary.UI.CasementsDiary.UI.Casements  5   	   &     Diary.UI.Casements.WindowAddTerm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Diary.UI.Casements     5   	     � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$- 'Дневник самочувствия��5
   	   $	��400��6&   $
��1000��66   $	��500��6F   $
��1000��6V      WindowStyle#���   6f    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/Decoration/WindowDecoration/WindowStyle.xaml?�6%   %    5      .��5      � ���#406474.+�5   
   �� $��Center=�6   $��Center=�60   .+�5      �� $��Термин:��6     HeaderForDark#��[ 6(   $��10q�6O   �� 5      -   5        $��tbxTerm��5   "   $	��250��6   
������� �� 	MaxLength$ 50��6D   $
��auto��6S   $��30��6a   $	��Top=�5       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6J   $
��Left=�6^   �� 5      $��Описание:��6   #��[ 6)   $��10q�6P   6^   �� 5      -   5        $��tbxText��5   "   $	��800��6   
�������$	 300��6D   $
��auto��6T   $��80��6b   $	��Top=�5       . $
 Wrap=�6J   �� 5      	 �� Orientation$	 
Horizontal=�6   $��Center=�62   .+�5      �� -   5        $��btnBack��5   8   $��Отменить��6   $��10q�6,   6G   �� 5      -   5        $��btnSave��5   C   $��Сохранить��6   $��200 10 10 10q�6-   6R   5      5       5!      5"      