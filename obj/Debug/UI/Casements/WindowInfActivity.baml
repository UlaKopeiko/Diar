   M S B A M L   `   `   `  ����@  <Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Diary.UI.CasementsDiary.UI.Casements  5   	   *    $Diary.UI.Casements.WindowInfActivity   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Diary.UI.Casements     5   	     � WindowStyle$
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
 Hand��6T   $��50��6b   $��30 10q�6n   6}   �� 5   
   -   5         ��Name$ ListActivity��5       $��1��6   	 %� 
ScrollUnit$	 Pixel=�66   $��Disabled=�6[   $��0q�6�   $��10 30 10 10q�6�   ��5      �� 5      .R�5       �� .+�5!      �� 
 �� Orientation$
 
Horizontal=�6%   $��40��6>   .+�5"      �� $��	Дата:��6(   $	��Top=�65   $��
10 10 10 0q�6M     NormalForLight#��[ 6a   �� 5#      $	��Top=�6\   $	��300��6t   #��[ 6�   ��6(   �� *	StartTime+ �� StringFormat$ 
dd.MM.yyyy��6�   �� 5$      $��Время работы:��6(   $	��Top=�6=   $��
10 10 10 0q�6U   #��[ 6i   �� 5%      $	��Top=�6Z   $��	10 10 0 0q�6r   #��[ 6�   ��6(   �� *	StartTime+$ HH:mm:ss��6�   �� 5&      $��-��6(   $	��Top=�61   $��
10 10 10 0q�6I   #��[ 6]   �� 5'      $	��Top=�6X   $��	10 10 0 0q�6p   #��[ 6�   ��6(   �� *	EndTime+$ HH:mm:ss��6�   5(      �� 5)      $��10q�6$   $	��0.8��60   ���#406474$
��1200��6R   5*      5,      5.      �� 5/   
   -   5        $��	btnDelete��5/      $��2��6   $��Удалить��6/   6A   50      51      