   M S B A M L   `   `   `  ����F  BSortingDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SortingDemoSortingDemo  5   	       SortingDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SortingDemo     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         SortingDemo.SortFieldList   sortFieldList   SortingDemo.SortField   DisplayName   PropertyName��%�   &	          5
   
     5      $
 Name��6   $ ProcessName��61   6N     5      $ 	ProcessId��6   $ Id��66   6J     5      $ 	# Threads��6   $ Threads.Count��66   6U   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   $��2��6:   .+�5      �� $��Sort By:��6   $��Center=�6(   6E   �� 5      -   5         ��Name$ cmbSort��5      #��[  6(    �� DisplayMemberPath$ DisplayName��6a    �� SelectedValuePath$ PropertyName��6�   $��10,0,0,0q�6�   $	��100��6�   6�   �� 5      -   5        	 ��Name$	 chkDirection��5      $��	Ascending��6-   $��10,0,0,0q�6A   $��Center=�6S   6p   �� 5      -   5        $
��Sort��5      $��10,0,0,0q�6$   $��50��66   6R   �� 5      -   5        
 ��Name$
 	txtFilter��5   0   $	��150��6   $
��10,0q�6"   6E   �� 5      -   5        $��Filter��5      $��10,0,0,0q�6&   $��50��68   6V   5      �� 5   
   -   5         ��Name$ lstBox��5   R   $��0��6   $��1��6"   $��5q�6/   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6b   $��Stretch=�6�   ��6:   �� ��5      �� 5      .R�5       �� 
���   �$��2q�61   $��2q�6E   ._�5!      �� $ 
Horizontal=�6%   $��17(�6>   
�������.+�5"      �� $��5,5,5,0q�6$   $
��Bold"�6R   ��65   �� *ProcessName+6f   �� 5#      $��5,5,5,0q�6$   $��1��6c   
����  ���65   �� *Id+ �� StringFormat$  ({0}) ��6�   �� 5$      $��5,5,5,0q�6$   $��3��6t   
���  ����65   �� *Threads.Count+$ Threads : {0}��6�   5%      5&      5'      5)      5*      5+      