   M S B A M L   `   `   `  ����L  HAssignment_10.3.2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Assignment_10._3._2Assignment_10._3._2  5   	   $    Assignment_10._3._2.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Assignment_10._3._2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Car Inventory��6    $
��Bold"�67   $��10q�6I   .��5      � .+�5      �  5      �� 5      $��* �6(   �� 5      $
��Auto �6(   5      &   System.Windows.Controls.DataGrid  5      -   5        $��CarsDataGrid��5   (   $��0��6      AutoGenerateColumns$ False��5         CanUserAddRows$
 True��5         CanUserDeleteRows$
 True��5         SelectionMode$ Single=�5      $��5q�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Year��6-      
IsReadOnly$
 True��6T   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6;   �� *Year+6T     5       $
 Make��6-   $
 True��6T   	 6;   �� *Make+6T     5!      $ Model��6-   $
 True��6V   	 6<   �� *Model+6V     5"      $ Price��6-   $
 True��6f   	 6<   �� *Price+
 �� StringFormat$
 C��6f     5#      $	 VIN��6-   $
 True��6R   	 6:   �� *VIN+6R   5%      �� 5(      $��1��6    �� Orientation$ 
Horizontal=�6*   $��Center=�6C   $��5q�6`   .+�5)      �� -   5        $��	AddCarBtn��5)      $��Add Vehicle��6.   $��30��6D   $��5q�6P   6[   �� 5*      -   5        $��UpdateCarBtn��5*      $��Update Vehicle��61   $��30��6J   $��5q�6V   6a   �� 5+      -   5        $��DeleteCarBtn��5+      $��Delete Vehicle��61   $��30��6J   $��5q�6V   6a   �� 5,      -   5        $��ReloadCarsBtn��5,      $��Refresh Inventory��62   $��30��6N   $��5q�6Z   6e   5.      5/      50      51      57      