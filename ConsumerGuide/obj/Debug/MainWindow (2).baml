   M S B A M L   `   `   `  ����H  DConsumerGuide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ConsumerGuideConsumerGuide  5   	       ConsumerGuide.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ConsumerGuide     5   	     � Title$  
MainWindow��5   	    � WindowState$ Normal=�6   ��5
      �� 5   
    �� ImageSource$ 	photo.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      �� 5      $��70 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgService��5   0   $��1��6   $��1��6       AutoGenerateColumns .  $��28(�5         
IsReadOnly . 
���  ��$��5q�6H   ��5   _   �� *	Service+��5      �� 5      $ 	photo.jpg��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6%   
   
Visibility$
 Hidden=�6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *S_ID+6J     5       $	 Компания��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 67    6A   �� *S_Name+  5!      $	 Телефон��6%    66   �� *	S_Phone+4  .System.Windows.Controls.DataGridTemplateColumn  5"         CellTemplate 5#      �� 5$      .R�5%      �� -   5        $��Перейти��5%   %   67   5&      5(      5*      �� 5,   
   $��2��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Center=�6K   .+�5-      �� -   5        $��Инфо��5-      $��5q�6$   $��20(�6/   
���  ��
��� E��$��40��6i   $	��120��6u   5.      �� 5/      -   5        $��
Выход��5/      $��5q�6%   $��20(�60   
���  ��
���  ��$��40��6d   $	��120��6p   50      51      �� 53   
   $��1��6   $ 
Horizontal=�6%   $��Center=�6>   .+�54      �� -   5         ��Name$ txtFind��54      $��5q�6'   $��30��62   $	��300��6>   $��20(�6J   
�������
���  ��6p   �� 55      -   5        $��
Найти��55   +   $��5q�6;   $��20(�6F   
���  ��
���P��$��30��6|   $	��120��6�   56      58      59      