   M S B A M L   `   `   `  ����R  NЗадания по WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Задания_по_WPFЗадания_по_WPF  5   	   (    "Задания_по_WPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Задания_по_WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��90 �6   6*   �� 5      6    � ColumnDefinitions 5   
   �� 5      $	��170 �6   6-   �� 5      6!   .+�5   
   �� $��1��6   .+�5      �� -   5        $��StudentsButton��5      $��Ученики��6+   6=   �� 5      -   5        $��
Класс��5      6%   �� 5      -   5        $��AddStudentButton��5      $'��!Добавить студента��6-   6I   5      �� 5   
   $��./Images/logo.jpg��6   $
��Fill=�6+   6<   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6%   $��Right=�6>   $��20��6Z   .+�5      �� -   5        $��
BackButton��5      $��
Назад��6'   $��0,0,10,0q�67   $��20��6I   $	��Top=�6U   6m   �� 5      -   5        $��ForwardButton��5      $��Вперёд��6*   $��0,0,10,0q�6;   6M   5       � 5   
   -   5        $��	MainFrame��5      $��1��6!   $��1��6.   
�������6W   5      5      