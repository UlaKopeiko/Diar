   M S B A M L   `   `   `  ����@  <Diary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Diary.UI.CasementsDiary.UI.Casements  5   	   +    %Diary.UI.Casements.WindowAutorization   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Diary.UI.Casements     5   	     � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$- 'Дневник самочувствия��5
   	   $	��450��6&   $	��450��66   $	��400��6C   $	��500��6R   $	��400��6b      WindowStyle#���   6q    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $3 -/Decoration/WindowDecoration/WindowStyle.xaml?�6%   %    5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��/Source/Logo.png��6   $��20q�6*   �� 5   
   $��1��6   $��Center=�6"   .+�5      �� $��
Логин��6    
 Header#��[ 6%   �� 5      -   5        $��tbLogin��5   $   $
��0 10q�6   6$   �� 5      $��Пароль��6   #��[ 6'   �� 5      -   5        $��tbPass��5   $   $
��0 10q�6   6$   �� 5      -   5        $��btnEnter��5   %   $��
Войти��6   $
��0 20q�65   6C   5       5!      5"      