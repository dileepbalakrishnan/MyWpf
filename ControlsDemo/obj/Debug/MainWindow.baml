   M S B A M L   `   `   `  ����G  CControlsDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ControlsDemoControlsDemo  5   	       ControlsDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ControlsDemo     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         ControlsDemo.Person   person1   Name
   Age��%=   &	          5
   
   $ Dileep��6'   $ 35��65   6@   5      .��5      �� $��10q�6   .+�5   
   �� $	��250��6   $	��100��6   $��10q�6*   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��	12360.jpg��6   $��0,5,5,5q�6+   6>   �� 5      $��	Hi Dileep��6   $��Center=�6-   $��20,0,0,0q�6H   6\   5      5      �� 5   
   $	��250��6   $	��100��6   #��[  6*   6O   �� 5   
   $	��250��6   $	��100��6   #��[  6*   $��10q�6M   ��5      �� 5      .R�5      �  � RowDefinitions 5      �� 5      $
��Auto �6,   6<   �� 5      6.    � ColumnDefinitions 5      �� 5      $
��Auto �6/   6>   �� 5      61   .+�5       �� $
��Name��6$   $��10q�60   $��Center=�6<   $
��Left=�6W   6t   �� 5!      $��10q�6:   $��1��6F   ��6$   �� *Name+6X   �� 5"      $	��Age��6$   $��1��6/   $��10q�6<   $��Center=�6H   $
��Left=�6c   6�   �� 5#      $��1��69   $��1��6I   $��10q�6V   ��6$   �� *Age+6d   5$      5%      5'      5)      5*      