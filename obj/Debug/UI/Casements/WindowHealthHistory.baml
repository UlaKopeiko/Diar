   M S B A M L   `   `   `  ����@  <Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Diary.UI.CasementsDiary.UI.Casements  5   	   ,    &Diary.UI.Casements.WindowHealthHistory   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Diary.UI.Casements     5   	     � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$- 'Дневник самочувствия��5
   	   $	��800��6&   $
��1300��66   $	��900��6F   $
��1400��6V      WindowStyle#���   6f    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/Decoration/WindowDecoration/WindowStyle.xaml?�6%   %    5      .��5      � 
�������.+�5   
   �� -   5         � Cursor$
 Hand��5      $��/Source/BackForUser.png��6   $	��Top=�6?   $
��Left=�6W   $��	20 20 0 0q�6r   $��50��6�   $��50��6�    K� ZIndex$ 1��6�   6�   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6%   .+�5      �� $��
100 20 0 0q�6   .+�5      �� -   5        $��tbName��5       
 Header#��[ 6*   $��Right=�6J   �� 5      $��Личные жалобы��6   #��[ 61   $��20q�6Q   �� 5      -   5        $��tbCurrentDeviations��5   '   $	��250��6   $
��1100��6B   $
��Left=�6O   {�.  ���#406474	 �� 	MaxLength$		 300��6�   $	��Top=�6�   
 �� AcceptsReturn
 .  �� TextWrapping$
 Wrap=�6�   $��3q�6�   �� 5      $��Комментарии��6   #��[ 6/   $��20q�6O   �� 5       -   5        $��tbComplaints��5    '   $	��150��6   $
��1100��6;   $
��Left=�6H   ���#406474{�.  $		 300��6�   $	��Top=�6�   
 . $
 Wrap=�6�   $��3q�6�   �� 5!      $+��%Оценка самочувствия��6   #��[ 67   $��20q�6W   �� 5"      -   5        $��tbEvaluation��5"   &   $��40��6   $��50��6:   $
��Left=�6E   {�.  ���#406474$		 300��6�   $	��Top=�6�   
 . $
 Wrap=�6�   $��3q�6�   5#      5%      5(      5)      