   M S B A M L   `   `   `  ����G  CTreeViewDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TreeViewDemoTreeViewDemo  5   	       TreeViewDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TreeViewDemo     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   R� $��5q�6+   ��6   �� ��5      �� 5       �� ItemsSource 6+   �� *	Modules+.R�5      ��  �� Orientation$ 
Horizontal=�6!   $��2q�6:   $��16(�6E   $
��Bold"�6]   .+�5      �� $��16(�6@   ��6#   �� *ProcessName+6P   �� 5      ��6#   �� *Id+ �� StringFormat$ ({0})��6P   5       �� ItemTemplate 5      �� 5      .R�5      �� $ 
Horizontal=�6)   .+�5   "   �� $��15(�6H   $
��Bold"�6`   ��6,   �� *
ModuleName+6~   �� 5   "   $��15(�6F   ��6,   �� *
FileName+6`   5      5      5      5      5      5      