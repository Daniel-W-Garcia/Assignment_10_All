   M S B A M L   `   `   `  ����L  HAssignment_10.3.2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Assignment_10._3._2Assignment_10._3._2  5   	   &     Assignment_10._3._2.AddCarDialog   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   3local!clr-namespace:Assignment_10._3._2     5   	     � Title$  Add Car��5   	   $	��320��6   $	��400��6&   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Make:��6-   $��	0,0,10,10q�6=   �� 5   
   -   5        $��MakeComboBox��5   0   $��0��6   $��1��6    $��0,0,0,10q�6D   �� 5   
   $��1��6   $��0��6   $��Model:��6-   $��	0,0,10,10q�6>   �� 5   
   -   5        $��ModelTextBox��5   /   $��1��6   $��1��6   $��0,0,0,10q�6C   �� 5   
   $��2��6   $��0��6   $��Year:��6-   $��	0,0,10,10q�6=   �� 5   
   -   5        $��YearTextBox��5   /   $��2��6   $��1��6   $��0,0,0,10q�6B   �� 5    
   $��3��6   $��0��6   $��Price:��6-   $��	0,0,10,10q�6>   �� 5!   
   -   5        $��PriceTextBox��5!   /   $��3��6   $��1��6   $��0,0,0,10q�6C   �� 5#   
   $��4��6   $��0��6   $
��VIN:��6-   $��	0,0,10,10q�6<   �� 5$   
   -   5        $��
VinTextBox��5$   /   $��4��6   $��1��6   $��0,0,0,10q�6A   �� 5&   
   $��6��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Right=�6O   $��0,20,0,0q�6k   .+�5'      �� -   5        $��OkButton��5'      $��OK��6%   $��75��62   $��30��6=   $	��5,0q�6I    �� 	IsDefault$
 True��6V   6g   �� 5(      -   5        $��CancelButton��5(      $��Cancel��6)   $��75��6:   $��30��6E   $	��5,0q�6Q    �� IsCancel$
 True��6^   5)      5*      5+      